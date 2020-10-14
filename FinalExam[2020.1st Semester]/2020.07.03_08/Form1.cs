using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020._07._03_08
{
    public partial class Form1 : Form
    {
        int win = 0;
        int draw = 0;
        int lose = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "가위";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "바위";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "보";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string system = "";
            string result = "";
            textBox1.Text = "";

            if (user == "가위" || user == "바위" || user == "보")
            {
                System.Random battle = new System.Random();
                int what = battle.Next(1, 4);
                if (what == 1) system = "가위";
                else if (what == 2) system = "바위";
                else system = "보";

                if (user == system)
                {
                    result = "무승부";
                    draw += 1;
                }
                else
                {
                    if ((user == "가위" && system == "보") || (user == "바위" && system == "가위") || (user == "보" && system == "바위"))
                    {
                        result = "User 승";
                        win += 1;
                    }
                    else
                    {
                        result = "User 패";
                        lose += 1;
                    }
                }
                label2.Text = "User 는 ->" + user + "\n\nSystem 은 -> " + system + "\n\n결과는 -> " + result;
                label3.Text = "총전적 : " + win + "승 " + draw + "무 " + lose + "패";
            }
            else
            {
                label2.Text = "입력값이 '가위, 바위, 보'\n중 하나가 아니어서 패 처리합니다.";
                lose += 1;
                label3.Text = "총전적 : " + win + "승 " + draw + "무 " + lose + "패";
            }
        }
    }
}
