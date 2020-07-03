using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020._07._02_02
{
    public partial class Form1 : Form
    {
        bool file_name = false;
        bool modified = false;
        string name = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void 새로만들기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (modified == true)
                {
                    DialogResult answer = MessageBox.Show("변경된 내용을 저장하시겠습니까?", "저장", MessageBoxButtons.YesNo);
                    if (answer == DialogResult.Yes)
                    {
                        if (file_name == true)
                        {
                            System.IO.StreamWriter fs = new System.IO.StreamWriter(name, false, System.Text.Encoding.Default);
                            fs.WriteLine(textBox1.Text);
                            fs.Close();
                            modified = false;
                        }
                        else
                        {
                            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                            {
                                name = saveFileDialog1.FileName;
                                System.IO.StreamWriter fs = new System.IO.StreamWriter(name, false, System.Text.Encoding.Default);
                                fs.WriteLine(textBox1.Text);
                                fs.Close();
                                modified = false;
                                file_name = true;
                            }
                        }
                    }
                    textBox1.Text = "";
                    name = "";
                    file_name = false;
                    modified = false;
                }
            }
            catch
            {
                MessageBox.Show("새로만들기를 하는 도중 이상이 발생하였습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void 열기OCtrlOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (modified == true)
                {
                    DialogResult answer = MessageBox.Show("변경된 내용을 저장하시겠습니까?", "저장", MessageBoxButtons.YesNo);
                    if (answer == DialogResult.Yes)
                    {
                        if (file_name == true)
                        {
                            System.IO.StreamWriter fs = new System.IO.StreamWriter(name, false, Encoding.Default);
                            fs.WriteLine(textBox1.Text);
                            fs.Close();
                            modified = false;
                        }
                        else
                        {
                            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                            {
                                name = saveFileDialog1.FileName;
                                System.IO.StreamWriter fs = new System.IO.StreamWriter(name, false, Encoding.Default);
                                fs.WriteLine(textBox1.Text);
                                fs.Close();
                                modified = false;
                                file_name = true;
                            }
                        }
                    }
                }
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    name = openFileDialog1.FileName;
                    System.IO.StreamReader fs = new System.IO.StreamReader(name, Encoding.Default);
                    textBox1.Text = fs.ReadToEnd();
                    fs.Close();
                    modified = true;
                    file_name = false;
                }
            }
            catch
            {
                MessageBox.Show("열기를 하는 도중 이상이 발생하였습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void 저장SCtrlSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (modified == true)
                {
                    DialogResult answer = MessageBox.Show("Text 내용을 저장하시겠습니까?", "저장", MessageBoxButtons.YesNo);
                    if (answer == DialogResult.Yes)
                    {
                        if (file_name == true)
                        {
                            System.IO.StreamWriter fs = new System.IO.StreamWriter(name, false, Encoding.Default);
                            fs.WriteLine(textBox1.Text);
                            fs.Close();
                            modified = false;
                        }
                        else
                        {
                            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                            {
                                name = saveFileDialog1.FileName;
                                System.IO.StreamWriter fs = new System.IO.StreamWriter(name, false, Encoding.Default);
                                fs.WriteLine(textBox1.Text);
                                fs.Close();
                                modified = false;
                                file_name = true;
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("저장을 하는 도중 이상이 발생하였습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void 끝내기ECttrlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (modified == true)
                {
                    DialogResult answer = MessageBox.Show("변경된 내용을 저장하고 종료하시겠습니까?", "메모장", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (answer == DialogResult.Yes)
                    {
                        if (file_name == true)
                        {
                            System.IO.StreamWriter fs = new StreamWriter(name, false, Encoding.Default);
                            fs.WriteLine(textBox1.Text);
                            fs.Close();
                            modified = false;
                        }
                        else
                        {
                            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                            {
                                name = saveFileDialog1.FileName;
                                StreamWriter fs = new StreamWriter(name, false, Encoding.Default);
                                fs.WriteLine(textBox1.Text);
                                fs.Close();
                                modified = false;
                                file_name = true;
                            }
                        }
                    }
                }
                Application.Exit();
            }
            catch
            {
                MessageBox.Show("끝내기를 하는 도중 이상이 발생하였습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }   
        }

        private void 잘라내ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void 복사ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void 붙여넣ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void 삭ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste("");
        }

        private void 모두선택AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void 글꼴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.Yes)
                textBox1.Font = fontDialog1.Font;
        }

        private void 색깔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Yes)
                textBox1.ForeColor = colorDialog1.Color;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (modified == true)
                {
                    DialogResult answer = MessageBox.Show("변경된 내용을 저장하고 종료 하시겠습니까?", "메모장", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (answer == DialogResult.Yes)
                    {
                        if (file_name == true)
                        {
                            StreamWriter fs = new StreamWriter(name, false, Encoding.Default);
                            fs.WriteLine(textBox1.Text);
                            fs.Close();
                            modified = false;
                        }
                        else
                        {
                            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                            {
                                name = saveFileDialog1.FileName;
                                StreamWriter fs = new StreamWriter(name, false, Encoding.Default);
                                fs.WriteLine(textBox1.Text);
                                fs.Close();
                                modified = false;
                                file_name = true;
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("종료를 하는 도중 이상이 발생하였습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
