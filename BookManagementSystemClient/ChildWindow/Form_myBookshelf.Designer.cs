namespace BookManagementSystemClient.ChildWindow
{
    partial class Form_myBookshelf
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
            this.label_bookshelfList = new System.Windows.Forms.Label();
            this.listView_bookshelfList = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.columnHeader_title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_publisher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_publishDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_TN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_operation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_manageMyBookshelf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_bookshelfList
            // 
            this.label_bookshelfList.AutoSize = true;
            this.label_bookshelfList.Location = new System.Drawing.Point(12, 9);
            this.label_bookshelfList.Name = "label_bookshelfList";
            this.label_bookshelfList.Size = new System.Drawing.Size(53, 12);
            this.label_bookshelfList.TabIndex = 0;
            this.label_bookshelfList.Text = "书架列表";
            // 
            // listView_bookshelfList
            // 
            this.listView_bookshelfList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_title,
            this.columnHeader_author,
            this.columnHeader_publisher,
            this.columnHeader_publishDate,
            this.columnHeader_TN,
            this.columnHeader_operation});
            this.listView_bookshelfList.Location = new System.Drawing.Point(15, 66);
            this.listView_bookshelfList.Name = "listView_bookshelfList";
            this.listView_bookshelfList.Size = new System.Drawing.Size(710, 340);
            this.listView_bookshelfList.TabIndex = 1;
            this.listView_bookshelfList.UseCompatibleStateImageBehavior = false;
            this.listView_bookshelfList.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "当前选择共【】项记录";
            // 
            // columnHeader_title
            // 
            this.columnHeader_title.Text = "题名";
            this.columnHeader_title.Width = 176;
            // 
            // columnHeader_author
            // 
            this.columnHeader_author.Text = "责任者";
            this.columnHeader_author.Width = 113;
            // 
            // columnHeader_publisher
            // 
            this.columnHeader_publisher.Text = "出版社";
            this.columnHeader_publisher.Width = 80;
            // 
            // columnHeader_publishDate
            // 
            this.columnHeader_publishDate.Text = "出版日期";
            this.columnHeader_publishDate.Width = 123;
            // 
            // columnHeader_TN
            // 
            this.columnHeader_TN.Text = "索书号/TN";
            this.columnHeader_TN.Width = 103;
            // 
            // columnHeader_operation
            // 
            this.columnHeader_operation.Text = "操作";
            this.columnHeader_operation.Width = 97;
            // 
            // button_manageMyBookshelf
            // 
            this.button_manageMyBookshelf.Location = new System.Drawing.Point(73, 4);
            this.button_manageMyBookshelf.Name = "button_manageMyBookshelf";
            this.button_manageMyBookshelf.Size = new System.Drawing.Size(88, 23);
            this.button_manageMyBookshelf.TabIndex = 3;
            this.button_manageMyBookshelf.Text = "管理我的书架";
            this.button_manageMyBookshelf.UseVisualStyleBackColor = true;
            // 
            // Form_myBookshelf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 418);
            this.Controls.Add(this.button_manageMyBookshelf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView_bookshelfList);
            this.Controls.Add(this.label_bookshelfList);
            this.Name = "Form_myBookshelf";
            this.Text = "我的书架";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_bookshelfList;
        private System.Windows.Forms.ListView listView_bookshelfList;
        private System.Windows.Forms.ColumnHeader columnHeader_title;
        private System.Windows.Forms.ColumnHeader columnHeader_author;
        private System.Windows.Forms.ColumnHeader columnHeader_publisher;
        private System.Windows.Forms.ColumnHeader columnHeader_publishDate;
        private System.Windows.Forms.ColumnHeader columnHeader_TN;
        private System.Windows.Forms.ColumnHeader columnHeader_operation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_manageMyBookshelf;
    }
}