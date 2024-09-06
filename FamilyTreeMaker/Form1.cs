using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace FamilyTreeMaker
{
    public partial class MainForm : Form
    {
        //現時点で仕様上決める最大設定可能な世代数
        static readonly int MAX_GENERATION = 4;
        //列の最大数
        static readonly int MAX_COLUMN_NUMBER = 40;
        //PictureBox内のパディング
        static readonly int PADDING = 20;
        //家系図のセル内のパディング
        static int padding_famliytree;

        //デフォルトの列数
        static readonly int INITIAL_COLUMN_NUMBER = 10;
        //現在の列数
        static int column_number = INITIAL_COLUMN_NUMBER;

        //人物を表す記号のフォントサイズ(px) = セルの幅でもある
        static int cellWidth;
        //情報(死亡時年齢や発端者など)のフォントサイズ(pt)
        int infoSize = 10;

        //世代ごとのPicureBoxのなかでの基準位置
        static readonly int[] gen_centerY = new int[MAX_GENERATION];

        //情報表示用の文字フォント
        Font textFont;
        //世代表示の文字用フォント
        static readonly Font numFont = new Font(FontFamily.GenericMonospace, 20, FontStyle.Regular);

        //人物情報を格納するためのセル
        Person [,] cell = new Person[MAX_GENERATION, MAX_COLUMN_NUMBER];

        //選ばれているセル
        static int selectedGen, selectedCol;
        static int orgSelectedGen, orgSelectedCol;

        //家族関係を表現するインスタンス
        Family family;

        //動作モード
        //通常、配偶者関係設定、親子関係設定
        enum ActionMode 
        {
            Normal,
            SetMartial,
            SetFiliation
        }
        //現在の動作モードを保持する変数
        ActionMode actionMode;

        public MainForm()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //セル幅の計算
            colSizeNumeric.Value  = column_number;
            cellWidth = calcCellWidth();

            //初期状態として左上セルを選択状態にしておく
            selectedCol = 0;
            selectedGen = 0;
            orgSelectedCol = 0;
            orgSelectedGen = 0;

            family = new Family();
            actionMode = ActionMode.Normal;
            infoLabel.Text = "";

            //グループボック内のオブジェクトを使用可不能に
            foreach (Control c in groupBox1.Controls)
            {
                c.Enabled = false;
            }

            //情報表示用のテキストのフォントのサイズ設定
            infoTextFontSizeNumeric.Value = infoSize;
            textFont = new Font(FontFamily.GenericMonospace, infoSize, FontStyle.Regular);

            //最大列数の設定
            colSizeNumeric.Maximum = MAX_COLUMN_NUMBER;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //家系図をファイルに保存
            //新しいイメージにバックグラウンドで家系図作成
            Image image = new Bitmap(mainPictureBox.ClientRectangle.Width, mainPictureBox.ClientRectangle.Height);
            Graphics g = Graphics.FromImage(image);
            g.FillRectangle(Brushes.White, 0, 0, image.Width, image.Height);  

           //作成した画像ファイル用のインスタンスのグラフィックコンテキストに家計図を描画
            drawFamilyGraphics(Graphics.FromImage(image));

            //SaveFileDialogを使用してファイル選択
            if (saveFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                image.Save(saveFileDialog1.FileName);
            }
        }

        private void mainPictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            //世代別の基準となるY座標を計算
            setGenerationCenterY(e.ClipRectangle.Height);
            //セル幅計算
            cellWidth = calcCellWidth();

            for (int gen = 0; gen < MAX_GENERATION; gen++)
            {            
                //世代の文字表示
                g.DrawString((gen + 1).ToString(), numFont, Brushes.Black, 0, gen_centerY[gen] - numFont.Height / 2);

                //セル表示
                for (int c = 0; c < column_number; c++)
                {
                    g.DrawRectangle(Pens.LightGray, PADDING * 2 + cellWidth * c, gen_centerY[gen] - cellWidth / 2, cellWidth, cellWidth);
                }
            }

            //選択されているセルなら赤枠
            if (selectedGen > -1 && selectedCol > -1)
            {
                g.DrawRectangle(Pens.Red, PADDING * 2 + cellWidth * selectedCol, gen_centerY[selectedGen] - cellWidth / 2, cellWidth, cellWidth);
            }

            //家系図を描画
            drawFamilyGraphics(g);
        }

         private void mainPictureBox_Resize(object sender, EventArgs e)
        {
            mainPictureBox.Refresh();
        }

        private void charSizeNumeric_ValueChanged(object sender, EventArgs e)
        {
            //表示サイズの変更
            column_number = (int)colSizeNumeric.Value;
            cellWidth = calcCellWidth();

            //表示リフレッシュ
            mainPictureBox.Refresh();
        }

        private void オブジェクトの削除DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //人物の削除
            Person p = cell[selectedGen, selectedCol];

            if (p == null)
            {
                //対象セルが空ならば当然何もしない
                return;
            }
            else
            {
                //婚姻関係あるいは親子関係がある場合には削除不可
                if (family.GetChildNum(p) > 0 || p.getSpouseID() != -1)
                {
                    MessageBox.Show("配偶者関係あるいは子が存在する場合削除できません", "エラー", MessageBoxButtons.OK);
                    return;

                }

                //削除を確認した上でエラー
                DialogResult res = MessageBox.Show("削除してよいですか？", "確認", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    //Yesなので削除
                    family.Remove(cell[selectedGen, selectedCol]);
                    cell[selectedGen, selectedCol] = null;
                    mainPictureBox.Refresh();
                }
            }
        }

        private void 男性を追加FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //人物追加のメニューは性別共通でTagで性を管理
            int sex = int.Parse((string)(sender as ToolStripMenuItem).Tag);
            addPerson(sex);
        }

        private void mainPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            //最も近いセルを選ぶ
            if (e.X > PADDING * 2)
            {
                selectedCol = (e.X - PADDING * 2) / cellWidth;
                selectedGen = e.Y / (mainPictureBox.Height / MAX_GENERATION);
            }
            if (selectedCol >= column_number)
            {
                selectedCol = column_number - 1;
            }

            //動作モードがノーマルの時にのみ選択したセルを保存
            if (actionMode == ActionMode.Normal)
            {
                orgSelectedGen = selectedGen;
                orgSelectedCol = selectedCol;
            }

            //対象者の情報を表示
            showTargetPersonInfo(selectedGen, selectedCol);

            if (e.Button == MouseButtons.Left)
            {
                //動作モードがノーマル: 何もしない(選択しただけ)
                if (actionMode == ActionMode.Normal) { }

                //動作モードが配偶者関係設定: 配偶者関係設定処理
                if (actionMode == ActionMode.SetMartial)
                {
                    createSpouse();
                }

                //動作モードが親子関係設定: 親子関係設定処理
                if (actionMode == ActionMode.SetFiliation)
                {
                    createFiliation();
                }
            }

            //選択セルも変わっている可能性があるので再描画
            mainPictureBox.Refresh();
        }

        //対象者の名前を設定
        private void nameText_TextChanged(object sender, EventArgs e)
        {
            cell[selectedGen, selectedCol].setName(nameText.Text);
        }

        private void isDeadCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (cell[selectedGen, selectedCol] != null)
            {
                cell[selectedGen, selectedCol].setIsDead(isDeadCheck.Checked);
                mainPictureBox.Refresh();
            }
        }

        private void maleRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (cell[selectedGen, selectedCol] != null)
            {
                int sex = int.Parse((string)(sender as RadioButton).Tag);
                cell[selectedGen, selectedCol].setSex(sex);
                mainPictureBox.Refresh();
            }
        }

        private void isSufferedCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (cell[selectedGen, selectedCol] != null)
            {
                cell[selectedGen, selectedCol].setIsSuffered(isSufferedCheck.Checked);
                mainPictureBox.Refresh();
            }
        }

        private void infoTextFontSizeNumeric_ValueChanged(object sender, EventArgs e)
        {
            infoSize = (int)infoTextFontSizeNumeric.Value;
            textFont = new Font(FontFamily.GenericMonospace, infoSize, FontStyle.Regular);
            mainPictureBox.Refresh();
        }

        private void mainPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }

            Person tp = cell[selectedGen, selectedCol];
            Person sp = cell[orgSelectedGen, orgSelectedCol];

            if (actionMode == ActionMode.Normal)
            {
                //動作モードがノーマルの場合
                //もしボタンアップしたときのセル位置が異なっていたら移動モード
                //移動対象が空セルだったら移動、そうでなければ移動処理しない

                if (e.X > PADDING * 2)
                {
                    selectedCol = (e.X - PADDING * 2) / cellWidth;
                    selectedGen = e.Y / (mainPictureBox.Height / MAX_GENERATION);
                }
                if (selectedCol >= column_number)
                {
                    selectedCol = column_number - 1;
                }

                if (e.Button == MouseButtons.Left && (selectedCol != orgSelectedCol || selectedGen != orgSelectedGen))
                {
                    if (sp == null)
                    {
                        return;
                    }

                    //世代が異なっていたら移動しないが、親子関係が設定できるようならばする
                    if (selectedGen != orgSelectedGen)
                    {
                        if (Math.Abs(selectedGen - orgSelectedGen) == 1)
                        { 
                            //親子関係が設定できるようならばする
                            if (sp != null)
                            {
                                createFiliation();
                                mainPictureBox.Refresh();
                            }

                        } 
                        else 
                        {
                            MessageBox.Show("世代が異なる移動はできません", "エラー", MessageBoxButtons.OK);
                            selectedCol = orgSelectedCol;
                            selectedGen = orgSelectedGen;
                        }
                    } 
                    else if (cell[selectedGen, selectedCol] != null)
                    {
                        //お互いに配偶者設定されていなければ、配偶者設定できるならば行う
                        if (!sp.getIsMarried() && !tp.getIsMarried())
                        {
                            createSpouse();
                            mainPictureBox.Refresh();
                        } else
                        {
                            //空いていなければ移動しない
                            MessageBox.Show("移動対象セルが空ではありません", "エラー", MessageBoxButtons.OK);
                            selectedCol = orgSelectedCol;
                            selectedGen = orgSelectedGen;
                        }
                    } 
                    else
                    {
                        //条件が整っているので移動処理
                        cell[selectedGen, selectedCol] = sp;
                        cell[orgSelectedGen, orgSelectedCol] = null;
                        mainPictureBox.Refresh();
                    }
                }
            }
            else if (actionMode == ActionMode.SetMartial || actionMode == ActionMode.SetFiliation)
            {
                //動作モードをノーマルに戻す
                actionMode = ActionMode.Normal;
                infoLabel.Text = "";
            }
        }

        private void 婚姻関係を設定MToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //配偶者関係設定モード

            //もし選択しているセルが空だったらメッセージ表示して何もしない
            if (cell[selectedGen, selectedCol] == null)
            {
                MessageBox.Show("選択したセルは空です", "エラー", MessageBoxButtons.OK);
                return;
            }
            else if (cell[selectedGen, selectedCol].getIsMarried())
            {
                //既に配偶者関係が存在している人物 = エラー
                MessageBox.Show("既に配偶者関係が設定されています", "エラー", MessageBoxButtons.OK);
                return;
            }
            else
            {
                //現在選択セルの人物を保存
                actionMode = ActionMode.SetMartial;
                orgSelectedGen = selectedGen;
                orgSelectedCol = selectedCol;
                infoLabel.Text = "配偶者関係を設定中・・・";
            }
        }

        private void ageOfDeathNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (cell[selectedGen, selectedCol] != null)
            {
                cell[selectedGen, selectedCol].setAge((int)ageNumeric.Value);
            }

            mainPictureBox.Refresh();
        }

        private void 親子関係を設定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //親子関係の設定
            //もし選択しているセルが空だったらメッセージ表示して何もしない
            if (cell[selectedGen, selectedCol] == null)
            {
                MessageBox.Show("選択したセルは空です", "エラー", MessageBoxButtons.OK);
                return;
            }

            actionMode = ActionMode.SetFiliation;
            //現在選択セルの人物を保存
            orgSelectedGen = selectedGen;
            orgSelectedCol = selectedCol;
            infoLabel.Text = "親子関係を設定中・・・";
        }

        private void 婚姻関係を削除IToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Person p = cell[selectedGen, selectedCol];

            //もし選択しているセルが空か、配偶者関係がなければ何もしない
            if (p == null || !p.getIsMarried())
            {
                return;
            }

            //子供がいる場合には削除不可
            if (family.GetChildNum(p) > 0)
            {
                MessageBox.Show("配偶者関係を削除する前に全ての親子関係を削除してください", "エラー", MessageBoxButtons.OK);
                return;
            }

            //婚姻関係を削除
            Person tp = family.GetFromId(p.getSpouseID());
            p.setIsMarried(false, -1);
            tp.setIsMarried(false, -1);

            mainPictureBox.Refresh();
        }

        private void isProbandCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (cell[selectedGen, selectedCol] != null)
            {
                cell[selectedGen, selectedCol].setIsProband(isProbandCheck.Checked);
                mainPictureBox.Refresh();
            }
        }
    
        private void isConsanguineousCheck_CheckedChanged(object sender, EventArgs e)
        {
            //近親婚の有無
            if (cell[selectedGen, selectedCol] != null)
            {
                cell[selectedGen, selectedCol].setIsConsanguineous(isConsanguineousCheck.Checked);
                mainPictureBox.Refresh();
            }
        }

        private void 親子関係を削除EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //近親婚の有無
            if (cell[selectedGen, selectedCol] != null)
            {
                cell[selectedGen, selectedCol].setParentID(-1);
                mainPictureBox.Refresh();
            }
        }


        private void 保存SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //保存ボタンと動作は同じ
            button1_Click(sender, e);
        }

        private void addPerson(int sex = 0)
        {
            //選択していなければ通知
            if (selectedGen < 0 || selectedCol < 0)
            {
                MessageBox.Show("対象セルを選んでください", "エラー", MessageBoxButtons.OK);
                return;
            }

            //選択セルに人物がいなければ追加
            if (cell[selectedGen, selectedCol] == null)
            {
                //対象セルに人はいない
                Person p = new Person(sex);
                p.setGeranation(selectedGen);

                cell[selectedGen, selectedCol] = p;
                family.Add(p);

                showTargetPersonInfo(selectedGen, selectedCol);

                mainPictureBox.Refresh();
            }
            else
            {
                MessageBox.Show("対象セルには既に人がいます", "エラー", MessageBoxButtons.OK);
            }
        }

        private void mainPictureBox_DoubleClick(object sender, EventArgs e)
        {
            //ダブルクリックで男性の人物追加
            addPerson();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            //ショートカットキーの動作
            Person p = cell[selectedGen, selectedCol];
            if (p == null)
            {
                //対象セルが空ならば何もしない
                return;
            }

            switch (e.KeyCode)
            {
                case Keys.S:
                    //罹患者の入れ替え
                    isSufferedCheck.Checked = !isSufferedCheck.Checked;
                    break;
                case Keys.D:
                    //死亡かどうかの入れ替え
                    isDeadCheck.Checked = !isDeadCheck.Checked;
                    break;
                case Keys.F:
                    //女性にする
                    femaleRadio.Checked = true;
                    break;
                case Keys.M:
                    //男性にする
                    maleRadio.Checked = true;
                    break;
                default:
                    showTargetPersonInfo(selectedGen, selectedCol);
                    break;
            }
        }

        //対象者の情報を表示
        private void showTargetPersonInfo(int gen, int col)
        {
            Person p = cell[gen, col];
            if (p == null)
            {
                //情報を初期化
                nameText.Text = "";
                isDeadCheck.Checked = false;
                ageNumeric.Enabled = isDeadCheck.Checked;
                ageNumeric.Value = 0;
                isProbandCheck.Checked = false;
                isSufferedCheck.Checked = false;
                isConsanguineousCheck.Checked = false;
                maleRadio.Checked = false;
                femaleRadio.Checked = false;
                unknownRadio.Checked = false;

                //さらにグループボック内のオブジェクトを使用不能に
                foreach (Control c in groupBox1.Controls)
                {
                    c.Enabled = false;
                }

                return;
            }

            nameText.Text = p.getName();
            switch (p.getSex())
            {
                case 0:
                    //男性
                    maleRadio.Checked = true;
                    break;
                case 1:
                    //女性
                    femaleRadio.Checked = true;
                    break;
                case 2:
                    //判別不能
                    unknownRadio.Checked = true;
                    break;
            }

            nameText.Text = p.getName();
            isDeadCheck.Checked = p.getIsDead();
            ageNumeric.Enabled = isDeadCheck.Checked;
            ageNumeric.Value = p.getAge();
            isProbandCheck.Checked = p.getIsProband();
            isSufferedCheck.Checked = p.getIsSuffered();
            isConsanguineousCheck.Checked = p.getIsConsanguineous();

            //さらにグループボック内のオブジェクトを使用可能に
            foreach (Control c in groupBox1.Controls)
            {
                c.Enabled = true;
            }
        }

        //親子関係の設定
        private void createFiliation()
        {
            bool isError = false;

            //親子関係設定
            //対象のセルが空 = ノーマルモードに戻す
            if (cell[selectedGen, selectedCol] != null)
            {
                Person child, parent;
                if (selectedGen > orgSelectedGen)
                {
                    //親側が先に選ばれて、子側が次に選ばれた場合
                    child = cell[selectedGen, selectedCol];
                    parent = cell[orgSelectedGen, orgSelectedCol];
                }
                else
                {
                    //子側が先に選ばれて、親側が次に選ばれた
                    child = cell[orgSelectedGen, orgSelectedCol];
                    parent = cell[selectedGen, selectedCol];
                }

                if (Math.Abs(orgSelectedGen - selectedGen) > 1 || orgSelectedGen == selectedGen)
                {
                    //世代が1世代の差で無いとエラー
                    MessageBox.Show("2世代以上離れているか同世代の人物とは親子関係を設定できません", "エラー", MessageBoxButtons.OK);
                    isError = true;
                }
                else if (!parent.getIsMarried())
                {
                    //親に配偶者がいない場合 = エラー
                    MessageBox.Show("親世代に配偶者がいません", "エラー", MessageBoxButtons.OK);
                    isError = true;
                }
                else
                {
                    //条件が整ったので親子関係を設定
                    //親のIDを設定
                    child.setParentID(parent.getId());
                }

                if (isError)
                {
                    //エラーの場合は共通のエラー処理
                    selectedGen = orgSelectedGen;
                    selectedCol = orgSelectedCol;
                    //動作モードをノーマルに戻す
                    actionMode = ActionMode.Normal;
                    infoLabel.Text = "";
                }
            }
        }

        private void 男性に変更CMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int sex = int.Parse((string)(sender as ToolStripMenuItem).Tag);
            changeSex(sex);
        }

        //配偶者関係の設定
        private void createSpouse()
        {
            bool isError = false;

            //対象のセルが空 = ノーマルモードに戻す
            if (cell[selectedGen, selectedCol] != null)
            {
                Person p = cell[orgSelectedGen, orgSelectedCol];
                Person tp = cell[selectedGen, selectedCol];
                if (orgSelectedGen != selectedGen)
                {
                    //対象のセルが世代違い
                    MessageBox.Show("世代が異なる人物間で配偶者関係は設定できません", "エラー", MessageBoxButtons.OK);
                    isError = true;
                }
                else if (tp.getIsMarried())
                {
                    //既に配偶者関係が存在している人物 = エラー
                    MessageBox.Show("既に配偶者関係が設定されています", "エラー", MessageBoxButtons.OK);
                    isError = true;
                }
                else if ((p.getSex() == 1 && tp.getSex() == 1) || (p.getSex() == 0 && tp.getSex() == 0))
                {
                    //どちらかが性別判別不能ではなく男性同士あるいは女性同士であれば配偶者関係は設定できない
                    MessageBox.Show("男性同士あるいは女性同士になっています", "エラー", MessageBoxButtons.OK);
                    isError = true;
                }
                else
                {
                    //条件が整ったので配偶者関係を設定
                    //自分と配偶者関係相手のID
                    int tid = cell[selectedGen, selectedCol].getId();
                    int id = cell[orgSelectedGen, orgSelectedCol].getId();

                    //配偶者関係を設定(双方向にidを設定し、isMarriedをtrueに
                    cell[selectedGen, selectedCol].setIsMarried(true, id);
                    cell[orgSelectedGen, orgSelectedCol].setIsMarried(true, tid);
                }

                if (isError)
                {
                    //エラーの場合は共通のエラー処理
                    selectedGen = orgSelectedGen;
                    selectedCol = orgSelectedCol;
                    //動作モードをノーマルに戻す
                    actionMode = ActionMode.Normal;
                    infoLabel.Text = "";
                }
            }
        }

        //性別変更
        private void changeSex(int sex)
        {
            //性別変更
            if (cell[selectedGen, selectedCol] != null)
            {
                cell[selectedGen, selectedCol].setSex(sex);
            }

            showTargetPersonInfo(selectedGen, selectedCol);
            mainPictureBox.Refresh();
        }

        //家系図描画メソッド
        private void drawFamilyGraphics(Graphics g)
        {
            //パディング
            padding_famliytree = cellWidth / 6;
            //図形描画サイズ(幅)
            int ds = cellWidth - padding_famliytree * 2;

            for (int gen = 0; gen < MAX_GENERATION; gen++)
            {
                for (int col = 0; col < column_number; col++)
                {
                    Person p = cell[gen, col];
                    if (p != null)
                    {
                        //人物がいれば描画
                        int x = getTargetPoint(gen, col).X;
                        int y = getTargetPoint(gen, col).Y;
                        int xx = getTargetPoint(gen, col + 1).X;

                        switch (p.getSex())
                        {
                            //男性
                            case 0:
                                if (p.getIsSuffered())
                                {
                                    //罹患者ならば塗りつぶし
                                    g.FillRectangle(Brushes.Black, x + padding_famliytree, y + padding_famliytree, ds, ds);
                                }
                                else
                                {
                                    //非罹患者ならば□
                                    g.DrawRectangle(Pens.Black, x + padding_famliytree, y + padding_famliytree, ds, ds);
                                }

                                break;

                            //女性
                            case 1:
                                if (p.getIsSuffered())
                                {
                                    //罹患者ならば塗りつぶし
                                    g.FillEllipse(Brushes.Black, x + padding_famliytree, y + padding_famliytree, ds, ds);
                                }
                                else
                                {
                                    //非罹患者ならば□
                                    g.DrawEllipse(Pens.Black, x + padding_famliytree, y + padding_famliytree, ds, ds);
                                }
                                break;

                            //性別判別不能: ◇
                            case 2:
                                //◇描画のための基準点を計算
                                int x1 = x + cellWidth / 2;
                                int y1 = y + cellWidth / 2;

                                Point[] points = new Point[5];
                                points[0] = new Point(x1, y + padding_famliytree);
                                points[1] = new Point(x + padding_famliytree, y1);
                                points[2] = new Point(x1, y + cellWidth - padding_famliytree);
                                points[3] = new Point(xx - padding_famliytree, y1);
                                points[4] = points[0];

                                if (p.getIsSuffered())
                                {
                                    g.FillPolygon(Brushes.Black, points);
                                }
                                else
                                {
                                    //非罹患ならば普通に◇
                                    g.DrawLines(Pens.Black, points);
                                }
                                break;
                        }

                        if (p.getIsDead())
                        {
                            //死亡していれば斜め線追加
                            g.DrawLine(Pens.Black, xx, y, x, y + cellWidth);
                        }

                        //年齢表示
                        if (p.getAge() != -1)
                        {
                            if (p.getIsDead())
                            {
                                g.DrawString(String.Format("d.{0}y", p.getAge()), textFont, Brushes.Black, x + padding_famliytree / 3, y + cellWidth);
                            }
                            else
                            {
                                g.DrawString(String.Format("{0}y", p.getAge()), textFont, Brushes.Black, x + padding_famliytree / 2, y + cellWidth);
                            }
                        }

                        if (p.getIsProband())
                        {
                            //発端者ならばP↑追加
                            g.DrawString("P", textFont, Brushes.Black, x - padding_famliytree * 3, y + cellWidth + padding_famliytree);
                            //↑のポイント作成
                            int al = padding_famliytree / 2;
                            int tx = x - padding_famliytree / 3;
                            int ty = y + cellWidth + padding_famliytree / 3;
                            g.DrawLine(Pens.Black, x - padding_famliytree, y + cellWidth + padding_famliytree, tx, ty);
                            g.DrawLine(Pens.Black, tx - al, ty, tx, ty);
                            g.DrawLine(Pens.Black, tx, ty + al, tx, ty);
                        }

                        //婚姻関係あれば関係線を描画
                        if (p.getIsMarried())
                        {
                            //結婚相手
                            Person tp = family.GetFromId(p.getSpouseID());

                            //近親婚かどうか
                            if (p.getIsConsanguineous())
                            {
                                //近親婚だったので二重線
                                g.DrawLines(Pens.Black, calcLinePointOfRelatedPersons(p, tp, true, false, false));
                                g.DrawLines(Pens.Black, calcLinePointOfRelatedPersons(p, tp, true, false, true));

                            }
                            else
                            {
                                //近親婚ではないので通常の線
                                g.DrawLines(Pens.Black, calcLinePointOfRelatedPersons(p, tp, true, false, false));
                            }
                        }

                        //親子関係があれば関係線を描画
                        if (p.getParentID() != -1)
                        {
                            g.DrawLines(Pens.Black, calcLinePointOfRelatedPersons(p, family.GetFromId(p.getParentID()), false, true, false));
                        }
                    }
                }
            }
        }

        //各世代のPictureBox内での基準位置計算
        private void setGenerationCenterY(int height)
        {
            for (int i = 0; i < MAX_GENERATION; i++)
            {
                gen_centerY[i] = height / 2 / MAX_GENERATION * (2 * i + 1);
            }
        }

        //セル幅の計算メソッド
        private int calcCellWidth()
        {
            return (int)((float)(mainPictureBox.ClientRectangle.Width - PADDING * 3) / column_number);
        }

        //人物同士の関係線を引くための座標計算メソッド
        private Point[] calcLinePointOfRelatedPersons(Person p1, Person p2, Boolean isMartial, Boolean isFiliation, Boolean isConsanguineous)
        {
            Point[] ret = new Point[0];
            int margin_consanguineous;

            if (isMartial)
            {
                //婚姻関係ならば2点計算
                ret = new Point[2];

                //p1とp2の位置で左側(colの位置)の位置を求める
                int p1_col = 0, p2_col = 0;
                int gen = p1.getGeneration();

                for (int c = 0; c < MAX_COLUMN_NUMBER; c++)
                {
                    if (cell[gen, c] == p1)
                    {
                        p1_col = c;
                    }
                    if (cell[gen, c] == p2)
                    {
                        p2_col = c;
                    }
                }

                //世代の基準線のy座標
                int ry = gen_centerY[gen];
                int rx1 = getTargetPoint(gen, Math.Min(p1_col, p2_col) + 1).X - padding_famliytree;
                int rx2 = getTargetPoint(gen, Math.Max(p1_col, p2_col)).X + padding_famliytree;

                if (isConsanguineous)
                {
                    margin_consanguineous = -cellWidth / 18;
                }
                else
                {
                    margin_consanguineous = 0;
                }
                ret[0] = new Point(rx1, ry + margin_consanguineous);
                ret[1] = new Point(rx2, ry + margin_consanguineous);
            }
            else if (isFiliation)
            {
                //親子関係ならば4点
                ret = new Point[4];

                //親の配偶者のインスタンス
                //p1が子供、p2が親という前提
                Person p3 = family.GetFromId(p2.getSpouseID());
                int p1_col = 0, p2_col = 0, p3_col = 0;
                int gen = p2.getGeneration();
                int cgen = p1.getGeneration();

                //親のセルの位置を同定
                for (int c = 0; c < MAX_COLUMN_NUMBER; c++)
                {
                    if (cell[gen, c] == p2)
                    {
                        p2_col = c;
                    }
                    if (cell[gen, c] == p3)
                    {
                        p3_col = c;
                    }
                }
                //子のセルの位置を同定
                for (int c = 0; c < MAX_COLUMN_NUMBER; c++)
                {
                    if (cell[cgen, c] == p1)
                    {
                        p1_col = c;
                        break;
                    }
                }

                //親世代の関係線の中点座標
                int ry = gen_centerY[gen];
                int rx = (getTargetPoint(gen, Math.Min(p2_col, p3_col)).X + getTargetPoint(gen, Math.Max(p2_col, p3_col)).X) / 2 + cellWidth / 2;
                //次に上記中点のx座標は同じで、世代間の中点のy座標の
                int ry1 = (gen_centerY[gen] + gen_centerY[gen + 1]) / 2;
                //次に上記の点のy座標は同じで、子のセルのx座標
                int rx1 = getTargetPoint(cgen, p1_col).X + cellWidth / 2;
                //最後に上記の点とx座標は同じで、子のセルのy座標
                int ry2 = getTargetPoint(cgen, p1_col).Y + padding_famliytree;

                //線の座標を設定
                ret[0] = new Point(rx, ry);
                ret[1] = new Point(rx, ry1);
                ret[2] = new Point(rx1, ry1);
                ret[3] = new Point(rx1, ry2);
            }

            return ret;
        }

        private Point getTargetPoint(int gen, int col)
        {
            return new Point(PADDING * 2 + cellWidth * col, gen_centerY[gen] - cellWidth / 2);
        }
    }
}
