using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020._07._02_01
{
    public partial class Form1 : Form
    {
        bool drawing = false;
        Point spoint;
        Pen mypen = new Pen(Color.Black);

        public Form1()
        {
            InitializeComponent();
        }

        private void 종료XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            drawing = true;
            spoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing == true)
            {
                Point fpoint = new Point(e.X, e.Y);
                Graphics G = panel1.CreateGraphics();
                G.DrawLine(mypen, spoint, fpoint);
                spoint = fpoint;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            drawing = false;
        }

        private void colorLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                mypen.Color = colorDialog1.Color;
        }

        private void dotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mypen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
        }

        private void dashdotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mypen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
        }

        private void solidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mypen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
        }

        private void 굵기10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mypen.Width = 10;
        }

        private void 굵기5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mypen.Width = 5;
        }

        private void 굵기3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mypen.Width = 3;
        }

        private void 굵기1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mypen.Width = 1;
        }
    }
}
