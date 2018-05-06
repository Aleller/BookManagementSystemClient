namespace BookManagementSystemClient.ChildWindow
{
    partial class Form_personalInformation
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
            this.label_booksWillOverdueIn5Days = new System.Windows.Forms.Label();
            this.label_booksOverdue = new System.Windows.Forms.Label();
            this.label_booksOrdered = new System.Windows.Forms.Label();
            this.label_userName = new System.Windows.Forms.Label();
            this.label_booksBorrowedAccumulated = new System.Windows.Forms.Label();
            this.label_debt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_booksWillOverdueIn5Days
            // 
            this.label_booksWillOverdueIn5Days.AutoSize = true;
            this.label_booksWillOverdueIn5Days.Location = new System.Drawing.Point(29, 51);
            this.label_booksWillOverdueIn5Days.Name = "label_booksWillOverdueIn5Days";
            this.label_booksWillOverdueIn5Days.Size = new System.Drawing.Size(131, 12);
            this.label_booksWillOverdueIn5Days.TabIndex = 0;
            this.label_booksWillOverdueIn5Days.Text = "五天内即将过期图书：0";
            // 
            // label_booksOverdue
            // 
            this.label_booksOverdue.AutoSize = true;
            this.label_booksOverdue.Location = new System.Drawing.Point(29, 78);
            this.label_booksOverdue.Name = "label_booksOverdue";
            this.label_booksOverdue.Size = new System.Drawing.Size(83, 12);
            this.label_booksOverdue.TabIndex = 1;
            this.label_booksOverdue.Text = "已超期图书：0";
            // 
            // label_booksOrdered
            // 
            this.label_booksOrdered.AutoSize = true;
            this.label_booksOrdered.Location = new System.Drawing.Point(29, 105);
            this.label_booksOrdered.Name = "label_booksOrdered";
            this.label_booksOrdered.Size = new System.Drawing.Size(71, 12);
            this.label_booksOrdered.TabIndex = 2;
            this.label_booksOrdered.Text = "预约到书：0";
            // 
            // label_userName
            // 
            this.label_userName.AutoSize = true;
            this.label_userName.Location = new System.Drawing.Point(29, 27);
            this.label_userName.Name = "label_userName";
            this.label_userName.Size = new System.Drawing.Size(101, 12);
            this.label_userName.TabIndex = 3;
            this.label_userName.Text = "用户：2015210793";
            // 
            // label_booksBorrowedAccumulated
            // 
            this.label_booksBorrowedAccumulated.AutoSize = true;
            this.label_booksBorrowedAccumulated.Location = new System.Drawing.Point(29, 132);
            this.label_booksBorrowedAccumulated.Name = "label_booksBorrowedAccumulated";
            this.label_booksBorrowedAccumulated.Size = new System.Drawing.Size(77, 12);
            this.label_booksBorrowedAccumulated.TabIndex = 4;
            this.label_booksBorrowedAccumulated.Text = "累计借书：14";
            // 
            // label_debt
            // 
            this.label_debt.AutoSize = true;
            this.label_debt.Location = new System.Drawing.Point(29, 163);
            this.label_debt.Name = "label_debt";
            this.label_debt.Size = new System.Drawing.Size(71, 12);
            this.label_debt.TabIndex = 5;
            this.label_debt.Text = "欠款金额：0";
            // 
            // Form_personalInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 215);
            this.Controls.Add(this.label_debt);
            this.Controls.Add(this.label_booksBorrowedAccumulated);
            this.Controls.Add(this.label_userName);
            this.Controls.Add(this.label_booksOrdered);
            this.Controls.Add(this.label_booksOverdue);
            this.Controls.Add(this.label_booksWillOverdueIn5Days);
            this.Name = "Form_personalInformation";
            this.Text = "证件信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_booksWillOverdueIn5Days;
        private System.Windows.Forms.Label label_booksOverdue;
        private System.Windows.Forms.Label label_booksOrdered;
        private System.Windows.Forms.Label label_userName;
        private System.Windows.Forms.Label label_booksBorrowedAccumulated;
        private System.Windows.Forms.Label label_debt;
    }
}