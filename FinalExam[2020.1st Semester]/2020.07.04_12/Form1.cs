using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020._07._04_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string num = textBox1.Text;

            if (num.IndexOf("-") >= 0) label2.Text = "-빼고 입력해주세요";
            else if (num.Length != 13) label2.Text = "정확히 입력해주세요";
            else
            {
                int[] eachnum = new int[13];
                for (int i = 0; i < num.Length; i++)
                    eachnum[i] = int.Parse(num.Substring(i, 1));

                int Y = 0;
                for (int i = 0; i < 8; i++)
                    Y = Y + eachnum[i] * (i + 2);
                for (int i = 8; i < 12; i++)
                    Y = Y + eachnum[i] * (i - 6);

                int Z = (11 - (Y % 11)) % 10;

                if (Z == eachnum[12]) label2.Text = "올바른 주민번호입니다.";
                else label2.Text = "올바르지 않은 주민번호입니다.";
            }
        }
    }
}
