using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020._07._03_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Random ranNum = new System.Random();
            int who = ranNum.Next(1, 5);
            int what = ranNum.Next(1, 4);

            string result = "";

            if (who == 1) result += "쏠 사람 : 김태희, ";
            else if (who == 2) result += "쏠 사람 : 한가인, ";
            else if (who == 3) result += "쏠 사람 : 성유리, ";
            else result += "쏠 사람 : 한예슬, ";

            if (what == 1) result += "쏠 메뉴 : 짜장면";
            else if (what == 2) result += "쏠 메뉴 : 간짜장";
            else result += "쏠 메뉴 : 짜장라면";

            label3.Text = result;
        }
    }
}
