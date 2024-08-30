using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace FamilyTreeMaker
{
    public partial class MainForm : Form
    {
        //現時点で仕様上決める最大設定可能な世代数
        static readonly int MAX_GENERATION = 3;
        //列の最大数
        static readonly int MAX_COLUMN_NUMBER = 30;

        static readonly int PADDING = 10;
        //デフォルトの列数
        static readonly int INITIAL_COLUMN_NUMBER = 20;
        //現在の列数
        static int column_number = INITIAL_COLUMN_NUMBER;

        //人物を表す記号のフォントサイズ(px) = セルの幅でもある
        static int cellWidth;
        //情報(死亡時年齢や発端者など)のフォントサイズ(pt)
        static int infoSize = 12;

        //世代ごとのPicureBoxのなかでの基準位置
        static readonly int[] gen_centerY = new int[MAX_GENERATION];

        //情報表示用の文字フォント
        static Font textFont = new Font(FontFamily.GenericMonospace, infoSize, FontStyle.Regular);
        //世代表示の文字用フォント
        static readonly Font numFont = new Font(FontFamily.GenericMonospace, 20, FontStyle.Regular);

        //人物情報を格納するためのセル
        Person [,] cell = new Person[MAX_GENERATION, MAX_COLUMN_NUMBER];

        //選ばれているセル
        static int selectedGen, selectedCol;

        //家族関係を表現するインスタンス
        Family family;


        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            colSizeNumeric.Value  = column_number;
            cellWidth = calcCellWidth(false);

            selectedCol = -1;
            selectedGen = -1;

            family = new Family();

            //グループボック内のオブジェクトを使用可不能に
            foreach (Control c in groupBox1.Controls)
            {
                c.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //家系図をファイルに保存
            //新しいイメージボックスにバックグラウンドで家系図作成
            Image image = new Bitmap(mainPictureBox.Width, mainPictureBox.Height);
            Graphics g = Graphics.FromImage(image);
            g.FillRectangle(Brushes.White, 0, 0, image.Width, image.Height);  

            drawFamilyGraphics(Graphics.FromImage(image));

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
            int c_width = calcCellWidth(false);

            //世代など表示
            for (int gen = 0; gen < MAX_GENERATION; gen++)
            {
                g.DrawString((gen + 1).ToString(), numFont, Brushes.Black, 0, gen_centerY[gen] - numFont.Height / 2);

                //セル表示
                for (int c = 0; c < column_number; c++)
                {
                    g.DrawRectangle(Pens.LightGray, PADDING * 2 + c_width * c, gen_centerY[gen] - c_width / 2, c_width, c_width);
                }
            }

            //選択されているセルなら赤枠
            if (selectedGen > -1 && selectedCol > -1)
            {
                g.DrawRectangle(Pens.Red, PADDING * 2 + c_width * selectedCol, gen_centerY[selectedGen] - c_width / 2, c_width, c_width);
            }

            //家系図を描画
            drawFamilyGraphics(g);
        }

        //家系図描画メソッド
        private void drawFamilyGraphics(Graphics g)
        {
            //パディングは2px
            int pad = 5;
            //図形描画サイズ(幅)
            int ds = calcCellWidth(false) - pad * 2;

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
                                    g.FillRectangle(Brushes.Black, x + pad, y + pad, ds, ds);
                                } else
                                {
                                    //非罹患者ならば□
                                    g.DrawRectangle(Pens.Black, x + pad, y + pad, ds, ds);
                                }

                                if (p.getIsDead())
                                {
                                    //死亡していれば斜め線追加
                                    g.DrawLine(Pens.Black, xx, y, x, y + calcCellWidth(false));
                                }
                                break;

                            //女性
                            case 1:
                                if (p.getIsSuffered())
                                {
                                    //罹患者ならば塗りつぶし
                                    g.FillEllipse(Brushes.Black, x + pad, y + pad, ds, ds);
                                }
                                else
                                {
                                    //非罹患者ならば□
                                    g.DrawEllipse(Pens.Black, x + pad, y + pad, ds, ds);
                                }

                                if (p.getIsDead())
                                {
                                    //死亡していれば斜め線追加
                                    g.DrawLine(Pens.Black, xx, y, x, y + calcCellWidth(false));
                                }
                                break;
                        }
                    }
                }
            }
        }

        private void mainPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void setGenerationCenterY(int height)
        {
            for (int i = 0; i < MAX_GENERATION; i++)
            {
                gen_centerY[i] = height / 2 / MAX_GENERATION * (2 * i + 1);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
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
                Person p = new Person();
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

         private void mainPictureBox_Resize(object sender, EventArgs e)
        {
            cellWidth = calcCellWidth(false);
            mainPictureBox.Refresh();
        }

        private void charSizeNumeric_ValueChanged(object sender, EventArgs e)
        {
            //表示サイズの変更
            column_number = (int)colSizeNumeric.Value;
            cellWidth = calcCellWidth(false);

            //表示リフレッシュ
            mainPictureBox.Refresh();
        }

        //セル幅の計算メソッド
        private int calcCellWidth(Boolean isPt)
        {
            float factor;
            if (isPt)
            {
                factor = 1.33f;
            }
            else
            {
                factor = 1.0f;
            }

            return (int)((float)(mainPictureBox.Width - PADDING * 3) / factor / column_number);
        }

        private void オブジェクトの削除DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ボタンの機能と同等
            deleteButton_Click(sender, e);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //人物の削除
            //選択セルに人物がいなければ追加
            if (cell[selectedGen, selectedCol] == null)
            {
                //対象セルに人はいないのでエラー
                MessageBox.Show("対象セルには人がいません", "エラー", MessageBoxButtons.OK);
                return;
            }
            else
            {
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

        private void オブジェクトの追加AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //追加ボタンと動作は同じ
            addButton_Click(sender, e);
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

            //対象者の情報を表示
            showTargetPersonInfo(selectedGen, selectedCol);

            //再描画
            mainPictureBox.Refresh();
        }

        private Point getTargetPoint(int gen, int col)
        {
            int width = calcCellWidth(false);
            return new Point(PADDING * 2 + width * col, gen_centerY[gen] - width / 2);
        }

        //対象者の名前を設定
        private void nameText_TextChanged(object sender, EventArgs e)
        {
            if (cell[selectedGen, selectedCol] != null)
            {
                cell[selectedGen, selectedCol].setName(nameText.Text);
            }

        }

        private void isDeadCheck_CheckedChanged(object sender, EventArgs e)
        {
            //死亡チェックがあれば下の表示は有効
            ageOfDeathNumeric.Enabled = isDeadCheck.Checked;

            //対象がnullでなければ情報更新
            if (cell[selectedGen, selectedCol] != null)
            {
                cell[selectedGen, selectedCol].setIsDead(isDeadCheck.Checked);
            }

            mainPictureBox.Refresh();
        }

        private void maleRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (cell[selectedGen, selectedCol] != null)
            {
                int sex = int.Parse((string)(sender as RadioButton).Tag);

                cell[selectedGen, selectedCol].setSex(sex);
            }

            mainPictureBox.Refresh();
        }

        private void isSufferedCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (cell[selectedGen, selectedCol] != null)
            {
                cell[selectedGen, selectedCol].setIsSuffered(isSufferedCheck.Checked);
            }

            mainPictureBox.Refresh();
        }

        //対象者の情報を表示
        private void showTargetPersonInfo(int gen, int col)
        {
            Person p = cell[gen, col];
            if (p == null)
            {
                //情報を初期化
                nameText.Text = "";
                childNumLabel.Text = "0";
                isDeadCheck.Checked = false;
                ageOfDeathNumeric.Enabled = isDeadCheck.Checked;
                ageOfDeathNumeric.Value = 0;
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
                default:
                    break;
            }

            nameText.Text = p.getName();
            childNumLabel.Text = family.GetChildNum(p.getId()).ToString();
            isDeadCheck.Checked = p.getIsDead();
            ageOfDeathNumeric.Enabled = isDeadCheck.Checked;
            ageOfDeathNumeric.Value = p.getAgeOfDeath();
            isProbandCheck.Checked = p.getIsProband();
            isSufferedCheck.Checked = p.getIsSuffered();
            isConsanguineousCheck.Checked = p.getIsConsanguineous();

            //さらにグループボック内のオブジェクトを使用可能に
            foreach (Control c in groupBox1.Controls)
            {
                c.Enabled = true;
            }
        }
    }
}
