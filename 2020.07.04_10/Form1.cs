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

namespace _2020._07._04_10
{
    public partial class Form1 : Form
    {
        bool modified = false;
        bool file_name = false;
        string name = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            modified = true;
        }

        private void 파일ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 새로만들기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (modified == true)
                {
                    DialogResult answer = MessageBox.Show("변경된 내용을 저장하시겠습니까?", "저장", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
                            if (saveFileDialog1.ShowDialog() == DialogResult.Yes)
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
                }
                textBox1.Text = "";
                modified = false;
                file_name = false;
                name = "";
            }
            catch
            {
                MessageBox.Show("새로만들기를 하는 도중 이상이 발생하였습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (modified == true)
                {
                    DialogResult answer = MessageBox.Show("변경된 내용을 저장하시겠습니까?", "저장", MessageBoxButtons.YesNo);
                    if(answer == DialogResult.Yes)
                    {
                        if(file_name == true)
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
                }
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    name = openFileDialog1.FileName;
                    System.IO.StreamReader fs = new System.IO.StreamReader(name, System.Text.Encoding.Default);
                    textBox1.Text = fs.ReadToEnd();
                    fs.Close();
                    modified = false;
                    file_name = true;
                }
            }
            catch
            {
                MessageBox.Show("열기를 하는 도중 이상이 발생하였습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (modified)
                {
                    DialogResult answer = MessageBox.Show("변경된 내용을 저장하시겠습니까?", "저장", MessageBoxButtons.YesNo);
                    if (answer == DialogResult.Yes)
                    {
                        if (file_name)
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
                }
            }
            catch
            {
                MessageBox.Show("저장을 하는 도중 이상이 발생하였습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (modified)
                {
                    DialogResult answer = MessageBox.Show("변경된 내용을 저장하시겠습니까?", "저장", MessageBoxButtons.YesNoCancel);
                    if (answer == DialogResult.Yes)
                    {
                        if (file_name)
                        {
                            System.IO.StreamWriter fs = new System.IO.StreamWriter(name, false, System.Text.Encoding.Default);
                            fs.WriteLine(textBox1.Text);
                            fs.Close();
                            modified = false;
                        }
                        else
                        {
                            if (saveFileDialog1.ShowDialog () == DialogResult.OK)
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
                }
                Application.Exit();
            }
            catch
            {
                MessageBox.Show("끝내기를 하는 도중 이상이 발생하였습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (modified)
                {
                    DialogResult answer = MessageBox.Show("변경된 내용을 저장하시겠습니까?", "저장", MessageBoxButtons.YesNoCancel);
                    if (answer == DialogResult.Yes)
                    {
                        if (file_name)
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
                    else if(answer == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                    }
                }
            }
            catch
            {
                MessageBox.Show("종료를 하는 도중 이상이 발생하였습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void 잘라내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void 복사ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void 붙여넣기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void 삭제ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste("");
        }

        private void 모두선택ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void 글꼴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                textBox1.Font = fontDialog1.Font;
        }

        private void 색깔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                textBox1.ForeColor = colorDialog1.Color;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
