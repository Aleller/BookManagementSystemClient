namespace BookManagementSystemClient.ChildWindow
{
    partial class Form_libraryQuery
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
            this.comboBox_queryType = new System.Windows.Forms.ComboBox();
            this.label_queryType = new System.Windows.Forms.Label();
            this.textBox_inputQuery = new System.Windows.Forms.TextBox();
            this.button_query = new System.Windows.Forms.Button();
            this.listView_borrowedBooks = new System.Windows.Forms.ListView();
            this.columnHeader_number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_coverAndTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_publisher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_detailButton = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // comboBox_queryType
            // 
            this.comboBox_queryType.FormattingEnabled = true;
            this.comboBox_queryType.Items.AddRange(new object[] {
            "任意词",
            "题名",
            "责任者",
            "主题词",
            "ISBN",
            "分类号",
            "出版社"});
            this.comboBox_queryType.Location = new System.Drawing.Point(84, 16);
            this.comboBox_queryType.Name = "comboBox_queryType";
            this.comboBox_queryType.Size = new System.Drawing.Size(96, 20);
            this.comboBox_queryType.TabIndex = 0;
            // 
            // label_queryType
            // 
            this.label_queryType.AutoSize = true;
            this.label_queryType.Location = new System.Drawing.Point(13, 19);
            this.label_queryType.Name = "label_queryType";
            this.label_queryType.Size = new System.Drawing.Size(65, 12);
            this.label_queryType.TabIndex = 1;
            this.label_queryType.Text = "查询字段：";
            // 
            // textBox_inputQuery
            // 
            this.textBox_inputQuery.Location = new System.Drawing.Point(196, 16);
            this.textBox_inputQuery.Name = "textBox_inputQuery";
            this.textBox_inputQuery.Size = new System.Drawing.Size(480, 21);
            this.textBox_inputQuery.TabIndex = 2;
            // 
            // button_query
            // 
            this.button_query.Location = new System.Drawing.Point(682, 14);
            this.button_query.Name = "button_query";
            this.button_query.Size = new System.Drawing.Size(125, 23);
            this.button_query.TabIndex = 3;
            this.button_query.Text = "查询";
            this.button_query.UseVisualStyleBackColor = true;
            // 
            // listView_borrowedBooks
            // 
            this.listView_borrowedBooks.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView_borrowedBooks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_number,
            this.columnHeader_coverAndTitle,
            this.columnHeader_author,
            this.columnHeader_publisher,
            this.columnHeader_detailButton});
            this.listView_borrowedBooks.HoverSelection = true;
            this.listView_borrowedBooks.Location = new System.Drawing.Point(15, 43);
            this.listView_borrowedBooks.Name = "listView_borrowedBooks";
            this.listView_borrowedBooks.Size = new System.Drawing.Size(792, 503);
            this.listView_borrowedBooks.TabIndex = 4;
            this.listView_borrowedBooks.UseCompatibleStateImageBehavior = false;
            this.listView_borrowedBooks.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_number
            // 
            this.columnHeader_number.Text = "序号";
            this.columnHeader_number.Width = 68;
            // 
            // columnHeader_coverAndTitle
            // 
            this.columnHeader_coverAndTitle.Text = "封面/书名";
            this.columnHeader_coverAndTitle.Width = 305;
            // 
            // columnHeader_author
            // 
            this.columnHeader_author.Text = "责任人";
            this.columnHeader_author.Width = 163;
            // 
            // columnHeader_publisher
            // 
            this.columnHeader_publisher.Text = "出版社";
            this.columnHeader_publisher.Width = 122;
            // 
            // columnHeader_detailButton
            // 
            this.columnHeader_detailButton.Text = "查看馆藏";
            this.columnHeader_detailButton.Width = 97;
            // 
            // Form_libraryQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 558);
            this.Controls.Add(this.listView_borrowedBooks);
            this.Controls.Add(this.button_query);
            this.Controls.Add(this.textBox_inputQuery);
            this.Controls.Add(this.label_queryType);
            this.Controls.Add(this.comboBox_queryType);
            this.Name = "Form_libraryQuery";
            this.Text = "馆藏检索";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_queryType;
        private System.Windows.Forms.Label label_queryType;
        private System.Windows.Forms.TextBox textBox_inputQuery;
        private System.Windows.Forms.Button button_query;
        private System.Windows.Forms.ListView listView_borrowedBooks;
        private System.Windows.Forms.ColumnHeader columnHeader_number;
        private System.Windows.Forms.ColumnHeader columnHeader_coverAndTitle;
        private System.Windows.Forms.ColumnHeader columnHeader_author;
        private System.Windows.Forms.ColumnHeader columnHeader_publisher;
        private System.Windows.Forms.ColumnHeader columnHeader_detailButton;
    }
}