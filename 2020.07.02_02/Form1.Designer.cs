namespace _2020._07._02_02
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.편집EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.서식JToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.새로만들기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.열기OCtrlOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장SCtrlSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.끝내기ECttrlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.잘라내ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.복사ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.붙여넣ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.삭ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.모두선택AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.글꼴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.색깔ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oNOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.oFFFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일FToolStripMenuItem,
            this.편집EToolStripMenuItem,
            this.서식JToolStripMenuItem,
            this.도움말HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1035, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일FToolStripMenuItem
            // 
            this.파일FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.새로만들기ToolStripMenuItem,
            this.열기OCtrlOToolStripMenuItem,
            this.저장SCtrlSToolStripMenuItem,
            this.toolStripMenuItem2,
            this.끝내기ECttrlToolStripMenuItem});
            this.파일FToolStripMenuItem.Name = "파일FToolStripMenuItem";
            this.파일FToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.파일FToolStripMenuItem.Text = "파일(F)";
            // 
            // 편집EToolStripMenuItem
            // 
            this.편집EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.잘라내ToolStripMenuItem,
            this.복사ToolStripMenuItem,
            this.붙여넣ToolStripMenuItem,
            this.삭ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.모두선택AToolStripMenuItem});
            this.편집EToolStripMenuItem.Name = "편집EToolStripMenuItem";
            this.편집EToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.편집EToolStripMenuItem.Text = "편집(E)";
            // 
            // 서식JToolStripMenuItem
            // 
            this.서식JToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.글꼴ToolStripMenuItem,
            this.toolStripMenuItem3,
            this.색깔ToolStripMenuItem});
            this.서식JToolStripMenuItem.Name = "서식JToolStripMenuItem";
            this.서식JToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.서식JToolStripMenuItem.Text = "서식(J)";
            // 
            // 도움말HToolStripMenuItem
            // 
            this.도움말HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oNOToolStripMenuItem,
            this.toolStripMenuItem4,
            this.oFFFToolStripMenuItem});
            this.도움말HToolStripMenuItem.Name = "도움말HToolStripMenuItem";
            this.도움말HToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.도움말HToolStripMenuItem.Text = "도움말(H)";
            // 
            // 새로만들기ToolStripMenuItem
            // 
            this.새로만들기ToolStripMenuItem.Name = "새로만들기ToolStripMenuItem";
            this.새로만들기ToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.새로만들기ToolStripMenuItem.Text = "새로 만들기(N)   Ctrl+N";
            this.새로만들기ToolStripMenuItem.Click += new System.EventHandler(this.새로만들기ToolStripMenuItem_Click);
            // 
            // 열기OCtrlOToolStripMenuItem
            // 
            this.열기OCtrlOToolStripMenuItem.Name = "열기OCtrlOToolStripMenuItem";
            this.열기OCtrlOToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.열기OCtrlOToolStripMenuItem.Text = "열기(O)             Ctrl+O";
            this.열기OCtrlOToolStripMenuItem.Click += new System.EventHandler(this.열기OCtrlOToolStripMenuItem_Click);
            // 
            // 저장SCtrlSToolStripMenuItem
            // 
            this.저장SCtrlSToolStripMenuItem.Name = "저장SCtrlSToolStripMenuItem";
            this.저장SCtrlSToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.저장SCtrlSToolStripMenuItem.Text = "저장(S)              Ctrl+S";
            this.저장SCtrlSToolStripMenuItem.Click += new System.EventHandler(this.저장SCtrlSToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(253, 6);
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // 끝내기ECttrlToolStripMenuItem
            // 
            this.끝내기ECttrlToolStripMenuItem.Name = "끝내기ECttrlToolStripMenuItem";
            this.끝내기ECttrlToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.끝내기ECttrlToolStripMenuItem.Text = "끝내기(E)            Cttrl";
            this.끝내기ECttrlToolStripMenuItem.Click += new System.EventHandler(this.끝내기ECttrlToolStripMenuItem_Click);
            // 
            // 잘라내ToolStripMenuItem
            // 
            this.잘라내ToolStripMenuItem.Name = "잘라내ToolStripMenuItem";
            this.잘라내ToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.잘라내ToolStripMenuItem.Text = "잘라내기(T)        Ctrl+T";
            this.잘라내ToolStripMenuItem.Click += new System.EventHandler(this.잘라내ToolStripMenuItem_Click);
            // 
            // 복사ToolStripMenuItem
            // 
            this.복사ToolStripMenuItem.Name = "복사ToolStripMenuItem";
            this.복사ToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.복사ToolStripMenuItem.Text = "복사(C)             Ctrl+C";
            this.복사ToolStripMenuItem.Click += new System.EventHandler(this.복사ToolStripMenuItem_Click);
            // 
            // 붙여넣ToolStripMenuItem
            // 
            this.붙여넣ToolStripMenuItem.Name = "붙여넣ToolStripMenuItem";
            this.붙여넣ToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.붙여넣ToolStripMenuItem.Text = "붙여넣기(P)        Ctrl+P";
            this.붙여넣ToolStripMenuItem.Click += new System.EventHandler(this.붙여넣ToolStripMenuItem_Click);
            // 
            // 삭ToolStripMenuItem
            // 
            this.삭ToolStripMenuItem.Name = "삭ToolStripMenuItem";
            this.삭ToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.삭ToolStripMenuItem.Text = "삭제(D)              Ctrl+D";
            this.삭ToolStripMenuItem.Click += new System.EventHandler(this.삭ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(256, 6);
            // 
            // 모두선택AToolStripMenuItem
            // 
            this.모두선택AToolStripMenuItem.Name = "모두선택AToolStripMenuItem";
            this.모두선택AToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.모두선택AToolStripMenuItem.Text = "모두선택(A)        Ctrl+A";
            this.모두선택AToolStripMenuItem.Click += new System.EventHandler(this.모두선택AToolStripMenuItem_Click);
            // 
            // 글꼴ToolStripMenuItem
            // 
            this.글꼴ToolStripMenuItem.Name = "글꼴ToolStripMenuItem";
            this.글꼴ToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.글꼴ToolStripMenuItem.Text = "글꼴(F)          Ctrl+F";
            this.글꼴ToolStripMenuItem.Click += new System.EventHandler(this.글꼴ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(276, 6);
            // 
            // 색깔ToolStripMenuItem
            // 
            this.색깔ToolStripMenuItem.Name = "색깔ToolStripMenuItem";
            this.색깔ToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.색깔ToolStripMenuItem.Text = "색깔(C)          Ctrl+Shift+C";
            this.색깔ToolStripMenuItem.Click += new System.EventHandler(this.색깔ToolStripMenuItem_Click);
            // 
            // oNOToolStripMenuItem
            // 
            this.oNOToolStripMenuItem.Name = "oNOToolStripMenuItem";
            this.oNOToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.oNOToolStripMenuItem.Text = "ON(O)         Ctrl+Shift+O";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(268, 6);
            // 
            // oFFFToolStripMenuItem
            // 
            this.oFFFToolStripMenuItem.Name = "oFFFToolStripMenuItem";
            this.oFFFToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.oFFFToolStripMenuItem.Text = "OFF(F)         Ctrl+Shift+F";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(0, 31);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(1035, 595);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "텍스트 파일 (*.txt)|*.txt|모든 파일 (*.*)|*.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 626);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "메모장";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 새로만들기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 편집EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 서식JToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 열기OCtrlOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저장SCtrlSToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 끝내기ECttrlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 잘라내ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 복사ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 붙여넣ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 삭ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 모두선택AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 글꼴ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem 색깔ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oNOToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem oFFFToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

