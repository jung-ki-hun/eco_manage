namespace WindowsFormsApp3
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.코드실행VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.폴더열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.종료XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.깃ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.깃연동ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.깃로그ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.깃푸쉬ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.깃풀ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.깃커밋CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.사용법AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Desktop;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("나눔손글씨 붓", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.깃ToolStripMenuItem,
            this.도움말HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(114, 233);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.코드실행VToolStripMenuItem,
            this.폴더열기ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.종료XToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(101, 35);
            this.파일ToolStripMenuItem.Text = "파일(&F)";
            // 
            // 코드실행VToolStripMenuItem
            // 
            this.코드실행VToolStripMenuItem.Name = "코드실행VToolStripMenuItem";
            this.코드실행VToolStripMenuItem.Size = new System.Drawing.Size(204, 36);
            this.코드실행VToolStripMenuItem.Text = "코드 실행(&V)";
            this.코드실행VToolStripMenuItem.Click += new System.EventHandler(this.코드실행VToolStripMenuItem_Click);
            // 
            // 폴더열기ToolStripMenuItem
            // 
            this.폴더열기ToolStripMenuItem.Name = "폴더열기ToolStripMenuItem";
            this.폴더열기ToolStripMenuItem.Size = new System.Drawing.Size(204, 36);
            this.폴더열기ToolStripMenuItem.Text = "폴더 열기(&O)";
            this.폴더열기ToolStripMenuItem.Click += new System.EventHandler(this.폴더열기ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(201, 6);
            // 
            // 종료XToolStripMenuItem
            // 
            this.종료XToolStripMenuItem.Name = "종료XToolStripMenuItem";
            this.종료XToolStripMenuItem.Size = new System.Drawing.Size(204, 36);
            this.종료XToolStripMenuItem.Text = "종료(&X)";
            this.종료XToolStripMenuItem.Click += new System.EventHandler(this.종료XToolStripMenuItem_Click);
            // 
            // 깃ToolStripMenuItem
            // 
            this.깃ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.깃연동ToolStripMenuItem,
            this.깃로그ToolStripMenuItem,
            this.toolStripMenuItem2,
            this.깃푸쉬ToolStripMenuItem,
            this.깃풀ToolStripMenuItem,
            this.toolStripMenuItem3,
            this.깃커밋CToolStripMenuItem});
            this.깃ToolStripMenuItem.Name = "깃ToolStripMenuItem";
            this.깃ToolStripMenuItem.Size = new System.Drawing.Size(101, 35);
            this.깃ToolStripMenuItem.Text = "깃(&G)";
            // 
            // 깃연동ToolStripMenuItem
            // 
            this.깃연동ToolStripMenuItem.Name = "깃연동ToolStripMenuItem";
            this.깃연동ToolStripMenuItem.Size = new System.Drawing.Size(191, 36);
            this.깃연동ToolStripMenuItem.Text = "깃 연동(&R)";
            // 
            // 깃로그ToolStripMenuItem
            // 
            this.깃로그ToolStripMenuItem.Name = "깃로그ToolStripMenuItem";
            this.깃로그ToolStripMenuItem.Size = new System.Drawing.Size(191, 36);
            this.깃로그ToolStripMenuItem.Text = "깃 로그(&L)";
            this.깃로그ToolStripMenuItem.Click += new System.EventHandler(this.깃로그ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(188, 6);
            // 
            // 깃푸쉬ToolStripMenuItem
            // 
            this.깃푸쉬ToolStripMenuItem.Name = "깃푸쉬ToolStripMenuItem";
            this.깃푸쉬ToolStripMenuItem.Size = new System.Drawing.Size(191, 36);
            this.깃푸쉬ToolStripMenuItem.Text = "깃 푸쉬(&S)";
            // 
            // 깃풀ToolStripMenuItem
            // 
            this.깃풀ToolStripMenuItem.Name = "깃풀ToolStripMenuItem";
            this.깃풀ToolStripMenuItem.Size = new System.Drawing.Size(191, 36);
            this.깃풀ToolStripMenuItem.Text = "깃 풀(&U)";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(188, 6);
            // 
            // 깃커밋CToolStripMenuItem
            // 
            this.깃커밋CToolStripMenuItem.Name = "깃커밋CToolStripMenuItem";
            this.깃커밋CToolStripMenuItem.Size = new System.Drawing.Size(191, 36);
            this.깃커밋CToolStripMenuItem.Text = "깃 커밋(&C)";
            // 
            // 도움말HToolStripMenuItem
            // 
            this.도움말HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.사용법AToolStripMenuItem});
            this.도움말HToolStripMenuItem.Name = "도움말HToolStripMenuItem";
            this.도움말HToolStripMenuItem.Size = new System.Drawing.Size(101, 35);
            this.도움말HToolStripMenuItem.Text = "도움말(&H)";
            // 
            // 사용법AToolStripMenuItem
            // 
            this.사용법AToolStripMenuItem.Name = "사용법AToolStripMenuItem";
            this.사용법AToolStripMenuItem.Size = new System.Drawing.Size(182, 36);
            this.사용법AToolStripMenuItem.Text = "사용법(&A)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(416, 233);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "eco";
            this.TransparencyKey = System.Drawing.Color.White;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 폴더열기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 깃ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 깃연동ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 깃푸쉬ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 깃풀ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 깃로그ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 종료XToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem 깃커밋CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 사용법AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 코드실행VToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

