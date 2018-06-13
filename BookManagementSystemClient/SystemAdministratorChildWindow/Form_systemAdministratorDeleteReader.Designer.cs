namespace BookManagementSystemClient.SystemAdministratorChildWindow
{
    partial class Form_systemAdministratorDeleteReader
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
            this.label_studentID = new System.Windows.Forms.Label();
            this.textBox_studentID = new System.Windows.Forms.TextBox();
            this.button_confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_studentID
            // 
            this.label_studentID.AutoSize = true;
            this.label_studentID.Location = new System.Drawing.Point(89, 50);
            this.label_studentID.Name = "label_studentID";
            this.label_studentID.Size = new System.Drawing.Size(125, 12);
            this.label_studentID.TabIndex = 0;
            this.label_studentID.Text = "要删除的读者的学号：";
            // 
            // textBox_studentID
            // 
            this.textBox_studentID.Location = new System.Drawing.Point(84, 93);
            this.textBox_studentID.Name = "textBox_studentID";
            this.textBox_studentID.Size = new System.Drawing.Size(123, 21);
            this.textBox_studentID.TabIndex = 1;
            // 
            // button_confirm
            // 
            this.button_confirm.Location = new System.Drawing.Point(107, 152);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(75, 23);
            this.button_confirm.TabIndex = 2;
            this.button_confirm.Text = "确定";
            this.button_confirm.UseVisualStyleBackColor = true;
            // 
            // Form_deleteReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button_confirm);
            this.Controls.Add(this.textBox_studentID);
            this.Controls.Add(this.label_studentID);
            this.Name = "Form_deleteReader";
            this.Text = "系统管理员-删除读者";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_studentID;
        private System.Windows.Forms.TextBox textBox_studentID;
        private System.Windows.Forms.Button button_confirm;
    }
}