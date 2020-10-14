using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020._07._04_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int price = 0;

            listBox1.Items.Clear();
            listBox1.Items.Add("선택차종");

            if (radioButton1.Checked == true)
            {
                listBox1.Items.Add("승용차");
                price += 100;
                label5.Image = Properties.Resources.car_1;
            }
            else if (radioButton2.Checked == true)
            {
                listBox1.Items.Add("트럭");
                price += 80;
                label5.Image = Properties.Resources.car_2;
            }
            else
            {
                listBox1.Items.Add("봉고");
                price += 50;
                label5.Image = Properties.Resources.car_3;
            }

            listBox1.Items.Add("----------------");
            listBox1.Items.Add("선택옵션:");

            if (checkBox1.Checked == true)
            {
                listBox1.Items.Add("썬루프");
                price += 1;
            }
            if (checkBox2.Checked == true)
            {
                listBox1.Items.Add("자동온도조절장치");
                price += 2;
            }
            if (checkBox3.Checked == true)
            {
                listBox1.Items.Add("GPS");
                price += 3;
            }
            if (checkBox4.Checked == true)
            {
                listBox1.Items.Add("도난방지시스템");
                price += 2;
            }
            if (checkBox5.Checked == true)
            {
                listBox1.Items.Add("에어백");
                price += 10;
            }

            listBox1.Items.Add("---------------");
            listBox1.Items.Add("결제방법: ");

            if (comboBox1.SelectedIndex == 0) listBox1.Items.Add("일시불");
            else if (comboBox1.SelectedIndex == 1) listBox1.Items.Add("무통장입금");
            else listBox1.Items.Add("신용카드");

            listBox1.Items.Add("---------------");
            listBox1.Items.Add("견적금액: " + price + "만원");

            label6.Text = "견적가 : " + price + "만원";
        }
    }
}
