namespace BookManagementSystemClient.SystemAdministratorChildWindow
{
    partial class Form_systemAdministratorDeleteBook
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
            this.label_MarcNo = new System.Windows.Forms.Label();
            this.label_ISBN = new System.Windows.Forms.Label();
            this.textBox_MarcNo = new System.Windows.Forms.TextBox();
            this.textBox_ISBN = new System.Windows.Forms.TextBox();
            this.button_delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_MarcNo
            // 
            this.label_MarcNo.AutoSize = true;
            this.label_MarcNo.Location = new System.Drawing.Point(53, 47);
            this.label_MarcNo.Name = "label_MarcNo";
            this.label_MarcNo.Size = new System.Drawing.Size(77, 12);
            this.label_MarcNo.TabIndex = 0;
            this.label_MarcNo.Text = "唯一标识符：";
            // 
            // label_ISBN
            // 
            this.label_ISBN.AutoSize = true;
            this.label_ISBN.Location = new System.Drawing.Point(53, 99);
            this.label_ISBN.Name = "label_ISBN";
            this.label_ISBN.Size = new System.Drawing.Size(41, 12);
            this.label_ISBN.TabIndex = 1;
            this.label_ISBN.Text = "ISBN：";
            // 
            // textBox_MarcNo
            // 
            this.textBox_MarcNo.Location = new System.Drawing.Point(129, 44);
            this.textBox_MarcNo.Name = "textBox_MarcNo";
            this.textBox_MarcNo.Size = new System.Drawing.Size(228, 21);
            this.textBox_MarcNo.TabIndex = 2;
            // 
            // textBox_ISBN
            // 
            this.textBox_ISBN.Location = new System.Drawing.Point(129, 96);
            this.textBox_ISBN.Name = "textBox_ISBN";
            this.textBox_ISBN.Size = new System.Drawing.Size(228, 21);
            this.textBox_ISBN.TabIndex = 3;
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(282, 150);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 4;
            this.button_delete.Text = "删除";
            this.button_delete.UseVisualStyleBackColor = true;
            // 
            // Form_deleteBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 246);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.textBox_ISBN);
            this.Controls.Add(this.textBox_MarcNo);
            this.Controls.Add(this.label_ISBN);
            this.Controls.Add(this.label_MarcNo);
            this.Name = "Form_deleteBook";
            this.Text = "系统管理员-删除图书";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_MarcNo;
        private System.Windows.Forms.Label label_ISBN;
        private System.Windows.Forms.TextBox textBox_MarcNo;
        private System.Windows.Forms.TextBox textBox_ISBN;
        private System.Windows.Forms.Button button_delete;
    }
}