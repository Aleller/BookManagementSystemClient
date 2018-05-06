namespace BookManagementSystemClient.ChildWindow
{
    partial class Form_reportLoss
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
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button_confirmReport = new System.Windows.Forms.Button();
            this.label_inputPassword = new System.Windows.Forms.Label();
            this.label_warning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(196, 137);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(381, 21);
            this.textBox_password.TabIndex = 1;
            // 
            // button_confirmReport
            // 
            this.button_confirmReport.Location = new System.Drawing.Point(605, 135);
            this.button_confirmReport.Name = "button_confirmReport";
            this.button_confirmReport.Size = new System.Drawing.Size(75, 23);
            this.button_confirmReport.TabIndex = 0;
            this.button_confirmReport.Text = "确认挂失";
            this.button_confirmReport.UseVisualStyleBackColor = true;
            // 
            // label_inputPassword
            // 
            this.label_inputPassword.AutoSize = true;
            this.label_inputPassword.Location = new System.Drawing.Point(120, 140);
            this.label_inputPassword.Name = "label_inputPassword";
            this.label_inputPassword.Size = new System.Drawing.Size(65, 12);
            this.label_inputPassword.TabIndex = 2;
            this.label_inputPassword.Text = "输入密码：";
            // 
            // label_warning
            // 
            this.label_warning.AutoSize = true;
            this.label_warning.Location = new System.Drawing.Point(253, 200);
            this.label_warning.Name = "label_warning";
            this.label_warning.Size = new System.Drawing.Size(233, 24);
            this.label_warning.TabIndex = 3;
            this.label_warning.Text = "挂失后图书证将无法使用！\r\n挂失后自己不能解除，需要工作人员处理！";
            // 
            // Form_reportLoss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 405);
            this.Controls.Add(this.label_warning);
            this.Controls.Add(this.label_inputPassword);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.button_confirmReport);
            this.Name = "Form_reportLoss";
            this.Text = "读者挂失";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button_confirmReport;
        private System.Windows.Forms.Label label_inputPassword;
        private System.Windows.Forms.Label label_warning;
    }
}