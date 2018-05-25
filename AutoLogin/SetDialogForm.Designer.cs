namespace AutoLogin
{
    partial class setDialogForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.userLabel = new System.Windows.Forms.Label();
            this.passowrdLabel = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.setButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.userLabel.Location = new System.Drawing.Point(24, 66);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(92, 31);
            this.userLabel.TabIndex = 6;
            this.userLabel.Text = "用户名:";
            // 
            // passowrdLabel
            // 
            this.passowrdLabel.AutoSize = true;
            this.passowrdLabel.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.passowrdLabel.Location = new System.Drawing.Point(24, 126);
            this.passowrdLabel.Name = "passowrdLabel";
            this.passowrdLabel.Size = new System.Drawing.Size(68, 31);
            this.passowrdLabel.TabIndex = 7;
            this.passowrdLabel.Text = "密码:";
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.username.Location = new System.Drawing.Point(122, 66);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(178, 38);
            this.username.TabIndex = 8;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.password.Location = new System.Drawing.Point(122, 123);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(178, 38);
            this.password.TabIndex = 9;
            // 
            // setButton
            // 
            this.setButton.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.setButton.Location = new System.Drawing.Point(105, 206);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(122, 57);
            this.setButton.TabIndex = 10;
            this.setButton.Text = "确认";
            this.setButton.UseVisualStyleBackColor = true;
            this.setButton.Click += new System.EventHandler(this.setButton_Click);
            // 
            // setDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 306);
            this.Controls.Add(this.setButton);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.passowrdLabel);
            this.Controls.Add(this.userLabel);
            this.DoubleBuffered = true;
            this.Name = "setDialogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "设置登录信息";
            this.Load += new System.EventHandler(this.setDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label passowrdLabel;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button setButton;
    }
}