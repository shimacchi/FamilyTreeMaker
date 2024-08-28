using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FamilyTreeMaker
{
    public partial class MainForm : Form
    {
        //現時点で仕様上決める最大設定可能な世代数
        static readonly int MAX_GENERATION = 3;
        static readonly int PADDING = 10;
        static readonly int[] gen_centerY = new int[MAX_GENERATION];
        static readonly Font genFont = new Font(FontFamily.GenericMonospace, 22, FontStyle.Regular);
        static readonly Font textFont = new Font(FontFamily.GenericMonospace, 12, FontStyle.Regular);
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void mainPictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int height = e.ClipRectangle.Height;
            int width = e.ClipRectangle.Width;
            //世代別の基準となるY座標を計算
            setGenerationCenterY(height);

            //世代など表示
            for(int gen = 0; gen < MAX_GENERATION; gen++)
            {
                g.DrawLine(Pens.LightGray, PADDING * 2, gen_centerY[gen], width - PADDING, gen_centerY[gen]);
                g.DrawString((gen + 1).ToString(), genFont, Brushes.Black, 0, gen_centerY[gen] - genFont.Height / 2);
            }
            //家系図を描画
            DrawFamilyGraphics.setGrahicContext(e.Graphics);
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
            Label pl = new PersonLabel(new Person());
            //ラベルコントロールの基本設定
            pl.Font = genFont;
            pl.MouseDown += new MouseEventHandler(personLabel_MouseDown);
            pl.MouseUp += new MouseEventHandler(personLabel_MouseUp);
            pl.MouseMove += new MouseEventHandler(personLabel_MouseMove);
            pl.Text = "○";
            
            mainPictureBox.Controls.Add(pl);
        }

        private void personLabel_MouseDown(object sender, MouseEventArgs e)
        {
            PersonLabel pl = (sender as PersonLabel);
            //移動可能にする
            pl.isMoveable = true;
            pl.Width = 30;
            pl.Height = 30;
            pl.pX = e.X;
            pl.pY = e.Y;

        }

        private void personLabel_MouseUp(object sender, MouseEventArgs e)
        {
            //移動不能にする
            (sender as PersonLabel).isMoveable = false;
        }
        private void personLabel_MouseMove(object sender, MouseEventArgs e)
        {
            //移動可能なら移動する
            PersonLabel pl = (sender as PersonLabel);
            if (pl.isMoveable)
            {
                pl.Left = pl.Left + e.X - pl.pX;
                pl.Top = pl.Top + e.Y - pl.pY;

                mainPictureBox.Refresh();
            }
        }
    }
}
