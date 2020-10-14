using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020._07._04_03
{
    public partial class Form1 : Form
    {
        CheckBox[] Menu;
        const int count = 7;

        public Form1()
        {
            InitializeComponent();
            Menu = new CheckBox[count];
            Menu[0] = checkBox1;
            Menu[1] = checkBox2;
            Menu[2] = checkBox3;
            Menu[3] = checkBox4;
            Menu[4] = checkBox5;
            Menu[5] = checkBox6;
            Menu[6] = checkBox7;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for(int i = 0; i < count; i++)
            {
                if (Menu[i].Checked == true)
                    listBox1.Items.Add(Menu[i].Text);
            }

            /*listBox1.Items.Clear();
            if (checkBox1.Checked == true)
                listBox1.Items.Add("짜장면");
            if (checkBox2.Checked == true)
                listBox1.Items.Add("쟁반짜장");
            if (checkBox3.Checked == true)
                listBox1.Items.Add("삼선짜장");
            if (checkBox4.Checked == true)
                listBox1.Items.Add("사천짜장");
            if (checkBox5.Checked == true)
                listBox1.Items.Add("간짜장");
            if (checkBox6.Checked == true)
                listBox1.Items.Add("짜장밥");
            if (checkBox7.Checked == true)
                listBox1.Items.Add("짜장라면");*/
        }
    }
}
