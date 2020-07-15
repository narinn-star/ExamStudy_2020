using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020._07._04_06
{
    public partial class Form1 : Form
    {
        CheckBox[] num;
        const int count = 20;
        public Form1()
        {
            InitializeComponent();
            num = new CheckBox[count];
            num[0] = checkBox1;
            num[1] = checkBox2;
            num[2] = checkBox3;
            num[3] = checkBox4;
            num[4] = checkBox5;
            num[5] = checkBox6;
            num[6] = checkBox7;
            num[7] = checkBox8;
            num[8] = checkBox9;
            num[9] = checkBox10;
            num[10] = checkBox11;
            num[11] = checkBox12;
            num[12] = checkBox13;
            num[13] = checkBox14;
            num[14] = checkBox15;
            num[15] = checkBox16;
            num[16] = checkBox17;
            num[17] = checkBox18;
            num[18] = checkBox19;
            num[19] = checkBox20;
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Random Rnum = new System.Random();
            for (int i = 0; i < count; i++)
                num[i].Text = Rnum.Next(1, 99).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            checkBox1.Text = "checkBox1";
            checkBox1.Checked = false;
            checkBox2.Text = "checkBox2";
            checkBox2.Checked = false;
            checkBox3.Text = "checkBox3";
            checkBox3.Checked = false;
            checkBox4.Text = "checkBox4";
            checkBox4.Checked = false;
            checkBox5.Text = "checkBox5";
            checkBox5.Checked = false;
            checkBox6.Text = "checkBox6";
            checkBox6.Checked = false;
            checkBox7.Text = "checkBox7";
            checkBox7.Checked = false;
            checkBox8.Text = "checkBox8";
            checkBox8.Checked = false;
            checkBox9.Text = "checkBox9";
            checkBox9.Checked = false;
            checkBox10.Text = "checkBox10";
            checkBox10.Checked = false;
            checkBox11.Text = "checkBox11";
            checkBox11.Checked = false;
            checkBox12.Text = "checkBox12";
            checkBox12.Checked = false;
            checkBox13.Text = "checkBox13";
            checkBox13.Checked = false;
            checkBox14.Text = "checkBox14";
            checkBox14.Checked = false;
            checkBox15.Text = "checkBox15";
            checkBox15.Checked = false;
            checkBox16.Text = "checkBox16";
            checkBox16.Checked = false;
            checkBox17.Text = "checkBox17";
            checkBox17.Checked = false;
            checkBox18.Text = "checkBox18";
            checkBox18.Checked = false;
            checkBox19.Text = "checkBox19";
            checkBox19.Checked = false;
            checkBox20.Text = "checkBox20";
            checkBox20.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("각 체크박스의 숫자들");
                listBox1.Items.Add("--------------------");

                for (int i = 1; i < count; i++)
                    listBox1.Items.Add("checkBox" + i + " = " + num[i].Text);

                listBox2.Items.Clear();
                listBox2.Items.Add("선택된 체크박스의 숫자들");
                listBox2.Items.Add("------------------------");

                for (int i = 0; i < count; i++)
                    if (num[i].Checked == true) listBox2.Items.Add("checkBox" + i + " = " + num[i].Text);

                listBox2.Items.Add("------------------------");
                listBox2.Items.Add("선택된 체크박스의 숫자합계");
                listBox2.Items.Add("------------------------");

                int sum = 0;
                double average = 0;
                int count02 = 0;

                for (int i = 0; i < count; i++)
                {
                    if(num[i].Checked == true)
                    {
                        sum += int.Parse(num[i].Text);
                        count02++;
                    }
                }
                listBox2.Items.Add("숫자합계 -> " + sum);
                listBox2.Items.Add("------------------------");
                listBox2.Items.Add("선택된 체크박스의 숫자평균");

                average = sum / (double)count02;
                listBox2.Items.Add("------------------------");
                listBox2.Items.Add("숫자평균 -> " + average);
            }
            catch
            {
                MessageBox.Show("숫자바꾸기를 먼저 하세요");
            }
        }
    }
}
