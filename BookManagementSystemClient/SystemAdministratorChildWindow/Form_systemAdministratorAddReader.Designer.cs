namespace BookManagementSystemClient.SystemAdministratorChildWindow
{
    partial class Form_systemAdministratorAddReader
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
            this.label_userName = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.textBox_userName = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button_confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_userName
            // 
            this.label_userName.AutoSize = true;
            this.label_userName.Location = new System.Drawing.Point(98, 48);
            this.label_userName.Name = "label_userName";
            this.label_userName.Size = new System.Drawing.Size(89, 12);
            this.label_userName.TabIndex = 0;
            this.label_userName.Text = "读者的用户名：";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(98, 99);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(77, 12);
            this.label_password.TabIndex = 1;
            this.label_password.Text = "读者的密码：";
            // 
            // textBox_userName
            // 
            this.textBox_userName.Location = new System.Drawing.Point(194, 45);
            this.textBox_userName.Name = "textBox_userName";
            this.textBox_userName.Size = new System.Drawing.Size(150, 21);
            this.textBox_userName.TabIndex = 2;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(194, 96);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(150, 21);
            this.textBox_password.TabIndex = 3;
            // 
            // button_confirm
            // 
            this.button_confirm.Location = new System.Drawing.Point(269, 155);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(75, 23);
            this.button_confirm.TabIndex = 4;
            this.button_confirm.Text = "确定";
            this.button_confirm.UseVisualStyleBackColor = true;
            // 
            // Form_systemAdministratorAddReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 233);
            this.Controls.Add(this.button_confirm);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_userName);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_userName);
            this.Name = "Form_systemAdministratorAddReader";
            this.Text = "系统管理员-添加读者";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_userName;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox textBox_userName;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button_confirm;
    }
}