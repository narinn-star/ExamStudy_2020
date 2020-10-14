using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020._07._03_01
{
    public partial class Form1 : Form
    {
        double total = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "0";
            total = 0;
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double num = double.Parse(textBox1.Text);
                total += num;
                label1.Text = total.ToString();
            }
            catch (Exception ee)
            {
                label1.Text = ee.Message;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double num = double.Parse(textBox1.Text);
                total -= num;
                label1.Text = total.ToString();
            }
            catch (Exception ee)
            {
                label1.Text = ee.Message;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double num = double.Parse(textBox1.Text);
                total = total * num;
                label1.Text = total.ToString();
            }
            catch (Exception ee)
            {
                label1.Text = ee.Message;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "0")
                {
                    double num = double.Parse(textBox1.Text);
                    total = total / num;
                    label1.Text = total.ToString();
                }
            }
            catch (Exception ee)
            {
                label1.Text = ee.Message;
            }
        }
    }
}
