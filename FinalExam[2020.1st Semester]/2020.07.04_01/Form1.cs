using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020._07._04_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string number = textBox1.Text;

            if (number.IndexOf("-") >= 0) label3.Text = "-빼고 입력해주세요";
            else if (number.Length != 13) label3.Text = "정확히 입력해주세요";
            else
            {
                int[] eachnum = new int[13];
                for (int i = 0; i <= number.Length; i++) 
                    eachnum[i] = int.Parse(number.Substring(i, 1));
                int Y = 0;
                for (int i = 0; i < 8; i++)
                    Y = Y + eachnum[i] * (i + 2);
                for (int i = 8; i < 12; i++)
                    Y = Y + eachnum[i] * (i - 6);
                int Z = (11 - (Y % 11)) % 10;

                if (Z == eachnum[12]) label3.Text = "올바른 주민번호 입니다.";
                else label3.Text = "올바르지 않은 주민번호 입니다.";
            }
        }
    }
}
