namespace BookManagementSystemClient
{
    partial class Form_login
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
            this.button_login = new System.Windows.Forms.Button();
            this.button_register = new System.Windows.Forms.Button();
            this.label_userName = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.textBox_userName = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.groupBox_reader = new System.Windows.Forms.GroupBox();
            this.groupBox_reader.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(124, 133);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(75, 23);
            this.button_login.TabIndex = 0;
            this.button_login.Text = "登录";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // button_register
            // 
            this.button_register.Location = new System.Drawing.Point(43, 133);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(75, 23);
            this.button_register.TabIndex = 1;
            this.button_register.Text = "注册";
            this.button_register.UseVisualStyleBackColor = true;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // label_userName
            // 
            this.label_userName.AutoSize = true;
            this.label_userName.Location = new System.Drawing.Point(40, 41);
            this.label_userName.Name = "label_userName";
            this.label_userName.Size = new System.Drawing.Size(53, 12);
            this.label_userName.TabIndex = 2;
            this.label_userName.Text = "用户名：";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(40, 85);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(41, 12);
            this.label_password.TabIndex = 3;
            this.label_password.Text = "密码：";
            // 
            // textBox_userName
            // 
            this.textBox_userName.Location = new System.Drawing.Point(99, 38);
            this.textBox_userName.Name = "textBox_userName";
            this.textBox_userName.Size = new System.Drawing.Size(100, 21);
            this.textBox_userName.TabIndex = 4;
            this.textBox_userName.Text = "2015210793";
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(99, 82);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(100, 21);
            this.textBox_password.TabIndex = 5;
            this.textBox_password.Text = "123456";
            // 
            // groupBox_reader
            // 
            this.groupBox_reader.Controls.Add(this.label_password);
            this.groupBox_reader.Controls.Add(this.textBox_password);
            this.groupBox_reader.Controls.Add(this.button_login);
            this.groupBox_reader.Controls.Add(this.textBox_userName);
            this.groupBox_reader.Controls.Add(this.button_register);
            this.groupBox_reader.Controls.Add(this.label_userName);
            this.groupBox_reader.Location = new System.Drawing.Point(13, 13);
            this.groupBox_reader.Name = "groupBox_reader";
            this.groupBox_reader.Size = new System.Drawing.Size(247, 210);
            this.groupBox_reader.TabIndex = 6;
            this.groupBox_reader.TabStop = false;
            this.groupBox_reader.Text = "读者入口";
            // 
            // Form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 235);
            this.Controls.Add(this.groupBox_reader);
            this.Name = "Form_login";
            this.Text = "图书管理系统-客户端";
            this.groupBox_reader.ResumeLayout(false);
            this.groupBox_reader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.Label label_userName;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox textBox_userName;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.GroupBox groupBox_reader;
    }
}

