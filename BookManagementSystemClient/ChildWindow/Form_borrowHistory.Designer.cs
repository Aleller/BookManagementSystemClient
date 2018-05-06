namespace BookManagementSystemClient.ChildWindow
{
    partial class Form_borrowHistory
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
            this.radioButton_displayAll = new System.Windows.Forms.RadioButton();
            this.radioButton_displayByPage = new System.Windows.Forms.RadioButton();
            this.listView_borrowedBooks = new System.Windows.Forms.ListView();
            this.columnHeader_number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_TN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_dateOfReturn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_dateOfBorrow = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_position = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // radioButton_displayAll
            // 
            this.radioButton_displayAll.AutoSize = true;
            this.radioButton_displayAll.Location = new System.Drawing.Point(12, 12);
            this.radioButton_displayAll.Name = "radioButton_displayAll";
            this.radioButton_displayAll.Size = new System.Drawing.Size(71, 16);
            this.radioButton_displayAll.TabIndex = 2;
            this.radioButton_displayAll.TabStop = true;
            this.radioButton_displayAll.Text = "显示全部";
            this.radioButton_displayAll.UseVisualStyleBackColor = true;
            // 
            // radioButton_displayByPage
            // 
            this.radioButton_displayByPage.AutoSize = true;
            this.radioButton_displayByPage.Location = new System.Drawing.Point(113, 12);
            this.radioButton_displayByPage.Name = "radioButton_displayByPage";
            this.radioButton_displayByPage.Size = new System.Drawing.Size(71, 16);
            this.radioButton_displayByPage.TabIndex = 3;
            this.radioButton_displayByPage.TabStop = true;
            this.radioButton_displayByPage.Text = "分页显示";
            this.radioButton_displayByPage.UseVisualStyleBackColor = true;
            // 
            // listView_borrowedBooks
            // 
            this.listView_borrowedBooks.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView_borrowedBooks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_number,
            this.columnHeader_TN,
            this.columnHeader_title,
            this.columnHeader_author,
            this.columnHeader_dateOfBorrow,
            this.columnHeader_dateOfReturn,
            this.columnHeader_position});
            this.listView_borrowedBooks.HoverSelection = true;
            this.listView_borrowedBooks.Location = new System.Drawing.Point(12, 34);
            this.listView_borrowedBooks.Name = "listView_borrowedBooks";
            this.listView_borrowedBooks.Size = new System.Drawing.Size(704, 365);
            this.listView_borrowedBooks.TabIndex = 4;
            this.listView_borrowedBooks.UseCompatibleStateImageBehavior = false;
            this.listView_borrowedBooks.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_number
            // 
            this.columnHeader_number.Text = "序号";
            // 
            // columnHeader_title
            // 
            this.columnHeader_title.Text = "书名";
            this.columnHeader_title.Width = 118;
            // 
            // columnHeader_author
            // 
            this.columnHeader_author.Text = "作者简介";
            this.columnHeader_author.Width = 84;
            // 
            // columnHeader_TN
            // 
            this.columnHeader_TN.Text = "TN";
            this.columnHeader_TN.Width = 89;
            // 
            // columnHeader_dateOfReturn
            // 
            this.columnHeader_dateOfReturn.Text = "归还日期";
            this.columnHeader_dateOfReturn.Width = 106;
            // 
            // columnHeader_dateOfBorrow
            // 
            this.columnHeader_dateOfBorrow.Text = "借阅日期";
            this.columnHeader_dateOfBorrow.Width = 105;
            // 
            // columnHeader_position
            // 
            this.columnHeader_position.Text = "馆藏地";
            this.columnHeader_position.Width = 108;
            // 
            // Form_borrowHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 411);
            this.Controls.Add(this.listView_borrowedBooks);
            this.Controls.Add(this.radioButton_displayByPage);
            this.Controls.Add(this.radioButton_displayAll);
            this.Name = "Form_borrowHistory";
            this.Text = "借阅历史";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton_displayAll;
        private System.Windows.Forms.RadioButton radioButton_displayByPage;
        private System.Windows.Forms.ListView listView_borrowedBooks;
        private System.Windows.Forms.ColumnHeader columnHeader_number;
        private System.Windows.Forms.ColumnHeader columnHeader_title;
        private System.Windows.Forms.ColumnHeader columnHeader_author;
        private System.Windows.Forms.ColumnHeader columnHeader_TN;
        private System.Windows.Forms.ColumnHeader columnHeader_dateOfReturn;
        private System.Windows.Forms.ColumnHeader columnHeader_dateOfBorrow;
        private System.Windows.Forms.ColumnHeader columnHeader_position;
    }
}