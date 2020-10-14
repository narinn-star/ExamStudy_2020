using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020._07._04_08
{
    public partial class Form1 : Form
    {
        bool drawing = false;
        Pen Mypen = new Pen(Color.Black, 2);
        Point spoint;

        public Form1()
        {
            InitializeComponent();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                Mypen.Color = colorDialog1.Color;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            drawing = true;
            spoint = new Point(e.X, e.Y);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            drawing = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                Point fpoint = new Point(e.X, e.Y);
                Graphics G = pictureBox1.CreateGraphics();
                G.DrawLine(Mypen, spoint, fpoint);
                spoint = fpoint;
            }
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 굵기10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mypen.Width = 10;
        }

        private void 굵기7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mypen.Width = 5;
        }

        private void 굵기5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mypen.Width = 3;
        }

        private void 굵기1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mypen.Width = 1;
        }

        private void dotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mypen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
        }

        private void dashDotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mypen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
        }

        private void solidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mypen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
        }
    }
}
