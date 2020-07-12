using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020._07._04_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] Xword = new string[4];
            Xword[0] = "바보";
            Xword[1] = "메롱";
            Xword[2] = "님아";
            Xword[3] = "8억";

            string contents = textBox1.Text;
            foreach (string word in Xword)
            {
                string First = "";
                string Second = "";
                int Position = contents.IndexOf(word);
                while (Position >= 0)
                {
                    First = contents.Substring(0, Position);
                    Second = contents.Substring(Position + word.Length);

                    contents = First + "금지어" + Second;
                    Position = contents.IndexOf(word);
                }
            }
            textBox1.Text = contents;
        }
    }
}
