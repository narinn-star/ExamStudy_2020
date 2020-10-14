using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020._07._04_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] Array01 = new int[10];

            System.Random ranNum = new System.Random();
            double average = 0;

            for (int i = 0; i < Array01.Length; i++)
            {
                Array01[i] = ranNum.Next(1, 101);
                average += Array01[i];
            }
            label2.Text = "";

            for (int i = 0; i < Array01.Length; i++)
            {
                if (i % 2 == 0)
                    label2.Text += "\niarray [" + i + "] = " + Array01[i] + "     ";
                else
                    label2.Text += "iarray [" + i + "] = " + Array01[i];
            }

            int Max = Array01[0];
            int Min = Array01[0];
            for (int i = 0; i < Array01.Length; i++)
            {
                if (Max < Array01[i]) Max = Array01[i];
                if (Min > Array01[i]) Min = Array01[i];
            }
            average = average / Array01.Length;

            label2.Text += "\n\n\n배열값의 최대는 " + Max;
            label2.Text += "\n\n배열값의 최소는 " + Min;
            label2.Text += "\n\n10 개 원소 배열값의 평균은 " + average; 
            
        }
    }
}
