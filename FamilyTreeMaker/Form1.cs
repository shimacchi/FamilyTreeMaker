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
        static readonly Font genFont = new Font(FontFamily.GenericMonospace, 20, FontStyle.Regular);
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
            pl.Text = "TestLabel";
            pl.Show();
            mainPictureBox.Controls.Add(pl);
        }
    }
}
