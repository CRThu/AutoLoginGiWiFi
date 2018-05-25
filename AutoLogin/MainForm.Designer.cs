namespace AutoLogin
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.loginWebBrowser = new System.Windows.Forms.WebBrowser();
            this.loginButton = new System.Windows.Forms.Button();
            this.connectionStatusLabel = new System.Windows.Forms.Label();
            this.externalIPLabel = new System.Windows.Forms.Label();
            this.internalIPLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.setLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setAPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginWebBrowser
            // 
            this.loginWebBrowser.Location = new System.Drawing.Point(12, 43);
            this.loginWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.loginWebBrowser.Name = "loginWebBrowser";
            this.loginWebBrowser.Size = new System.Drawing.Size(400, 540);
            this.loginWebBrowser.TabIndex = 0;
            this.loginWebBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.loginWebBrowser_DocumentCompleted);
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.loginButton.Location = new System.Drawing.Point(438, 279);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(273, 127);
            this.loginButton.TabIndex = 1;
            this.loginButton.Text = "连接GIWIFI";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // connectionStatusLabel
            // 
            this.connectionStatusLabel.AutoSize = true;
            this.connectionStatusLabel.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.connectionStatusLabel.Location = new System.Drawing.Point(448, 51);
            this.connectionStatusLabel.Name = "connectionStatusLabel";
            this.connectionStatusLabel.Size = new System.Drawing.Size(137, 39);
            this.connectionStatusLabel.TabIndex = 2;
            this.connectionStatusLabel.Text = "连接状态";
            // 
            // externalIPLabel
            // 
            this.externalIPLabel.AutoSize = true;
            this.externalIPLabel.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.externalIPLabel.Location = new System.Drawing.Point(449, 153);
            this.externalIPLabel.Name = "externalIPLabel";
            this.externalIPLabel.Size = new System.Drawing.Size(114, 31);
            this.externalIPLabel.TabIndex = 4;
            this.externalIPLabel.Text = "外网IP:无";
            // 
            // internalIPLabel
            // 
            this.internalIPLabel.AutoSize = true;
            this.internalIPLabel.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.internalIPLabel.Location = new System.Drawing.Point(449, 109);
            this.internalIPLabel.Name = "internalIPLabel";
            this.internalIPLabel.Size = new System.Drawing.Size(192, 31);
            this.internalIPLabel.TabIndex = 5;
            this.internalIPLabel.Text = "内网IP:127.0.0.1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setLoginToolStripMenuItem,
            this.setAPToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(740, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // setLoginToolStripMenuItem
            // 
            this.setLoginToolStripMenuItem.Name = "setLoginToolStripMenuItem";
            this.setLoginToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.setLoginToolStripMenuItem.Text = "设置登陆信息";
            this.setLoginToolStripMenuItem.Click += new System.EventHandler(this.setLoginToolStripMenuItem_Click);
            // 
            // setAPToolStripMenuItem
            // 
            this.setAPToolStripMenuItem.Enabled = false;
            this.setAPToolStripMenuItem.Name = "setAPToolStripMenuItem";
            this.setAPToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.setAPToolStripMenuItem.Text = "设置热点信息";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.aboutToolStripMenuItem.Text = "关于";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 595);
            this.Controls.Add(this.internalIPLabel);
            this.Controls.Add(this.externalIPLabel);
            this.Controls.Add(this.connectionStatusLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.loginWebBrowser);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoLogin GiWiFi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser loginWebBrowser;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label connectionStatusLabel;
        private System.Windows.Forms.Label externalIPLabel;
        private System.Windows.Forms.Label internalIPLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem setLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setAPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

