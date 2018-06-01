namespace BookManagementSystemClient
{
    partial class Form_register
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
            this.label_UserName = new System.Windows.Forms.Label();
            this.label_inputPassword1 = new System.Windows.Forms.Label();
            this.label_inputPassword2 = new System.Windows.Forms.Label();
            this.textBox_inputUserName = new System.Windows.Forms.TextBox();
            this.textBox_inputPassword1 = new System.Windows.Forms.TextBox();
            this.textBox_inputPassword2 = new System.Windows.Forms.TextBox();
            this.button_register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_UserName
            // 
            this.label_UserName.AutoSize = true;
            this.label_UserName.Location = new System.Drawing.Point(44, 50);
            this.label_UserName.Name = "label_UserName";
            this.label_UserName.Size = new System.Drawing.Size(89, 12);
            this.label_UserName.TabIndex = 0;
            this.label_UserName.Text = "请输入用户名：";
            // 
            // label_inputPassword1
            // 
            this.label_inputPassword1.AutoSize = true;
            this.label_inputPassword1.Location = new System.Drawing.Point(44, 86);
            this.label_inputPassword1.Name = "label_inputPassword1";
            this.label_inputPassword1.Size = new System.Drawing.Size(77, 12);
            this.label_inputPassword1.TabIndex = 1;
            this.label_inputPassword1.Text = "请输入密码：";
            // 
            // label_inputPassword2
            // 
            this.label_inputPassword2.AutoSize = true;
            this.label_inputPassword2.Location = new System.Drawing.Point(44, 130);
            this.label_inputPassword2.Name = "label_inputPassword2";
            this.label_inputPassword2.Size = new System.Drawing.Size(65, 12);
            this.label_inputPassword2.TabIndex = 2;
            this.label_inputPassword2.Text = "重复密码：";
            // 
            // textBox_inputUserName
            // 
            this.textBox_inputUserName.Location = new System.Drawing.Point(137, 47);
            this.textBox_inputUserName.Name = "textBox_inputUserName";
            this.textBox_inputUserName.Size = new System.Drawing.Size(100, 21);
            this.textBox_inputUserName.TabIndex = 3;
            // 
            // textBox_inputPassword1
            // 
            this.textBox_inputPassword1.Location = new System.Drawing.Point(137, 83);
            this.textBox_inputPassword1.Name = "textBox_inputPassword1";
            this.textBox_inputPassword1.Size = new System.Drawing.Size(100, 21);
            this.textBox_inputPassword1.TabIndex = 4;
            // 
            // textBox_inputPassword2
            // 
            this.textBox_inputPassword2.Location = new System.Drawing.Point(137, 127);
            this.textBox_inputPassword2.Name = "textBox_inputPassword2";
            this.textBox_inputPassword2.Size = new System.Drawing.Size(100, 21);
            this.textBox_inputPassword2.TabIndex = 5;
            // 
            // button_register
            // 
            this.button_register.Location = new System.Drawing.Point(162, 182);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(75, 23);
            this.button_register.TabIndex = 6;
            this.button_register.Text = "注册";
            this.button_register.UseVisualStyleBackColor = true;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // Form_register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button_register);
            this.Controls.Add(this.textBox_inputPassword2);
            this.Controls.Add(this.textBox_inputPassword1);
            this.Controls.Add(this.textBox_inputUserName);
            this.Controls.Add(this.label_inputPassword2);
            this.Controls.Add(this.label_inputPassword1);
            this.Controls.Add(this.label_UserName);
            this.Name = "Form_register";
            this.Text = "注册账户";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_UserName;
        private System.Windows.Forms.Label label_inputPassword1;
        private System.Windows.Forms.Label label_inputPassword2;
        private System.Windows.Forms.TextBox textBox_inputUserName;
        private System.Windows.Forms.TextBox textBox_inputPassword1;
        private System.Windows.Forms.TextBox textBox_inputPassword2;
        private System.Windows.Forms.Button button_register;
    }
}