using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020._07._03_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] Array01 = new int[100];
            label2.Text = "";

            for (int i = 0; i < Array01.Length; i++)
            {
                Array01[i] = i + 1;
            }

            foreach (int output in Array01)
            { 
                if (output % 10 == 1)
                {
                    label2.Text += "\n";
                    label2.Text += output + " ";
                }
                else
                {
                    label2.Text += output + " ";
                }
                
            }
        }
    }
}
