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
            this.columnHeader_Barcode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_BorrowDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_ReturnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Holding = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_IsRenewed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_reflash = new System.Windows.Forms.Button();
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
            this.columnHeader_Barcode,
            this.columnHeader_Title,
            this.columnHeader_Author,
            this.columnHeader_BorrowDate,
            this.columnHeader_ReturnDate,
            this.columnHeader_Holding,
            this.columnHeader_IsRenewed});
            this.listView_borrowedBooks.HoverSelection = true;
            this.listView_borrowedBooks.Location = new System.Drawing.Point(12, 34);
            this.listView_borrowedBooks.Name = "listView_borrowedBooks";
            this.listView_borrowedBooks.Size = new System.Drawing.Size(704, 365);
            this.listView_borrowedBooks.TabIndex = 4;
            this.listView_borrowedBooks.UseCompatibleStateImageBehavior = false;
            this.listView_borrowedBooks.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_Barcode
            // 
            this.columnHeader_Barcode.Text = "条形码";
            this.columnHeader_Barcode.Width = 136;
            // 
            // columnHeader_Title
            // 
            this.columnHeader_Title.Text = "书名";
            this.columnHeader_Title.Width = 123;
            // 
            // columnHeader_Author
            // 
            this.columnHeader_Author.Text = "作者";
            this.columnHeader_Author.Width = 97;
            // 
            // columnHeader_BorrowDate
            // 
            this.columnHeader_BorrowDate.Text = "借阅日期";
            this.columnHeader_BorrowDate.Width = 83;
            // 
            // columnHeader_ReturnDate
            // 
            this.columnHeader_ReturnDate.Text = "归还日期";
            this.columnHeader_ReturnDate.Width = 84;
            // 
            // columnHeader_Holding
            // 
            this.columnHeader_Holding.Text = "馆藏地";
            this.columnHeader_Holding.Width = 119;
            // 
            // columnHeader_IsRenewed
            // 
            this.columnHeader_IsRenewed.Text = "是否续借";
            // 
            // button_reflash
            // 
            this.button_reflash.Location = new System.Drawing.Point(641, 9);
            this.button_reflash.Name = "button_reflash";
            this.button_reflash.Size = new System.Drawing.Size(75, 23);
            this.button_reflash.TabIndex = 5;
            this.button_reflash.Text = "刷新";
            this.button_reflash.UseVisualStyleBackColor = true;
            this.button_reflash.Click += new System.EventHandler(this.button_reflash_Click);
            // 
            // Form_borrowHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 411);
            this.Controls.Add(this.button_reflash);
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
        private System.Windows.Forms.ColumnHeader columnHeader_Barcode;
        private System.Windows.Forms.ColumnHeader columnHeader_Title;
        private System.Windows.Forms.ColumnHeader columnHeader_Author;
        private System.Windows.Forms.ColumnHeader columnHeader_BorrowDate;
        private System.Windows.Forms.ColumnHeader columnHeader_ReturnDate;
        private System.Windows.Forms.ColumnHeader columnHeader_Holding;
        private System.Windows.Forms.ColumnHeader columnHeader_IsRenewed;
        private System.Windows.Forms.Button button_reflash;
    }
}