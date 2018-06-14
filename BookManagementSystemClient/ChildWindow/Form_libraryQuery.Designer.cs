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
            this.columnHeader_reserveButton = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_MarcNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Publisher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_ISBN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Carrier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Subject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_CLS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label_currentQuery = new System.Windows.Forms.Label();
            this.comboBox_sortordProperty = new System.Windows.Forms.ComboBox();
            this.label_sortord = new System.Windows.Forms.Label();
            this.comboBox_sortordUpDown = new System.Windows.Forms.ComboBox();
            this.label_queryInformation = new System.Windows.Forms.Label();
            this.button_previousPage = new System.Windows.Forms.Button();
            this.button_nextPage = new System.Windows.Forms.Button();
            this.button_subQuery = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_queryType
            // 
            this.comboBox_queryType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_queryType.FormattingEnabled = true;
            this.comboBox_queryType.Items.AddRange(new object[] {
            "唯一标识符",
            "题名",
            "作者",
            "出版社",
            "ISBN",
            "价格",
            "馆藏地",
            "科目",
            "中图法分类号"});
            this.comboBox_queryType.Location = new System.Drawing.Point(84, 16);
            this.comboBox_queryType.Name = "comboBox_queryType";
            this.comboBox_queryType.Size = new System.Drawing.Size(127, 20);
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
            this.textBox_inputQuery.Location = new System.Drawing.Point(217, 16);
            this.textBox_inputQuery.Name = "textBox_inputQuery";
            this.textBox_inputQuery.Size = new System.Drawing.Size(459, 21);
            this.textBox_inputQuery.TabIndex = 2;
            // 
            // button_query
            // 
            this.button_query.Location = new System.Drawing.Point(682, 14);
            this.button_query.Name = "button_query";
            this.button_query.Size = new System.Drawing.Size(44, 23);
            this.button_query.TabIndex = 3;
            this.button_query.Text = "查询";
            this.button_query.UseVisualStyleBackColor = true;
            this.button_query.Click += new System.EventHandler(this.button_query_Click);
            // 
            // listView_borrowedBooks
            // 
            this.listView_borrowedBooks.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView_borrowedBooks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_reserveButton,
            this.columnHeader_MarcNo,
            this.columnHeader_Title,
            this.columnHeader_Author,
            this.columnHeader_Publisher,
            this.columnHeader_ISBN,
            this.columnHeader_Price,
            this.columnHeader_Carrier,
            this.columnHeader_Subject,
            this.columnHeader_CLS});
            this.listView_borrowedBooks.GridLines = true;
            this.listView_borrowedBooks.HoverSelection = true;
            this.listView_borrowedBooks.Location = new System.Drawing.Point(15, 76);
            this.listView_borrowedBooks.Name = "listView_borrowedBooks";
            this.listView_borrowedBooks.Size = new System.Drawing.Size(792, 470);
            this.listView_borrowedBooks.TabIndex = 4;
            this.listView_borrowedBooks.UseCompatibleStateImageBehavior = false;
            this.listView_borrowedBooks.View = System.Windows.Forms.View.Details;
            this.listView_borrowedBooks.ItemActivate += new System.EventHandler(this.listView_borrowedBooks_ItemActivate);
            // 
            // columnHeader_reserveButton
            // 
            this.columnHeader_reserveButton.Text = "";
            // 
            // columnHeader_MarcNo
            // 
            this.columnHeader_MarcNo.Text = "唯一标识符";
            this.columnHeader_MarcNo.Width = 102;
            // 
            // columnHeader_Title
            // 
            this.columnHeader_Title.Text = "书名";
            this.columnHeader_Title.Width = 162;
            // 
            // columnHeader_Author
            // 
            this.columnHeader_Author.Text = "作者";
            this.columnHeader_Author.Width = 75;
            // 
            // columnHeader_Publisher
            // 
            this.columnHeader_Publisher.Text = "出版社";
            // 
            // columnHeader_ISBN
            // 
            this.columnHeader_ISBN.Text = "ISBN";
            // 
            // columnHeader_Price
            // 
            this.columnHeader_Price.Text = "价格";
            // 
            // columnHeader_Carrier
            // 
            this.columnHeader_Carrier.Text = "馆藏地";
            // 
            // columnHeader_Subject
            // 
            this.columnHeader_Subject.Text = "科目";
            // 
            // columnHeader_CLS
            // 
            this.columnHeader_CLS.Text = "中图法分类号";
            this.columnHeader_CLS.Width = 84;
            // 
            // label_currentQuery
            // 
            this.label_currentQuery.AutoSize = true;
            this.label_currentQuery.Location = new System.Drawing.Point(13, 50);
            this.label_currentQuery.Name = "label_currentQuery";
            this.label_currentQuery.Size = new System.Drawing.Size(101, 12);
            this.label_currentQuery.TabIndex = 6;
            this.label_currentQuery.Text = "当前检索词语：无";
            // 
            // comboBox_sortordProperty
            // 
            this.comboBox_sortordProperty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_sortordProperty.FormattingEnabled = true;
            this.comboBox_sortordProperty.Items.AddRange(new object[] {
            "相关度",
            "入藏日期",
            "题名",
            "责任者",
            "索书号/TN",
            "出版社",
            "出版日期"});
            this.comboBox_sortordProperty.Location = new System.Drawing.Point(288, 47);
            this.comboBox_sortordProperty.Name = "comboBox_sortordProperty";
            this.comboBox_sortordProperty.Size = new System.Drawing.Size(94, 20);
            this.comboBox_sortordProperty.TabIndex = 9;
            // 
            // label_sortord
            // 
            this.label_sortord.AutoSize = true;
            this.label_sortord.Location = new System.Drawing.Point(217, 50);
            this.label_sortord.Name = "label_sortord";
            this.label_sortord.Size = new System.Drawing.Size(65, 12);
            this.label_sortord.TabIndex = 10;
            this.label_sortord.Text = "排序方式：";
            // 
            // comboBox_sortordUpDown
            // 
            this.comboBox_sortordUpDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_sortordUpDown.FormattingEnabled = true;
            this.comboBox_sortordUpDown.Items.AddRange(new object[] {
            "升序排列",
            "降序排列"});
            this.comboBox_sortordUpDown.Location = new System.Drawing.Point(388, 47);
            this.comboBox_sortordUpDown.Name = "comboBox_sortordUpDown";
            this.comboBox_sortordUpDown.Size = new System.Drawing.Size(92, 20);
            this.comboBox_sortordUpDown.TabIndex = 11;
            // 
            // label_queryInformation
            // 
            this.label_queryInformation.AutoSize = true;
            this.label_queryInformation.Location = new System.Drawing.Point(514, 52);
            this.label_queryInformation.Name = "label_queryInformation";
            this.label_queryInformation.Size = new System.Drawing.Size(113, 12);
            this.label_queryInformation.TabIndex = 12;
            this.label_queryInformation.Text = "共命中0条，0页结果";
            // 
            // button_previousPage
            // 
            this.button_previousPage.Location = new System.Drawing.Point(651, 47);
            this.button_previousPage.Name = "button_previousPage";
            this.button_previousPage.Size = new System.Drawing.Size(75, 23);
            this.button_previousPage.TabIndex = 13;
            this.button_previousPage.Text = "上一页";
            this.button_previousPage.UseVisualStyleBackColor = true;
            // 
            // button_nextPage
            // 
            this.button_nextPage.Location = new System.Drawing.Point(732, 47);
            this.button_nextPage.Name = "button_nextPage";
            this.button_nextPage.Size = new System.Drawing.Size(75, 23);
            this.button_nextPage.TabIndex = 14;
            this.button_nextPage.Text = "下一页";
            this.button_nextPage.UseVisualStyleBackColor = true;
            // 
            // button_subQuery
            // 
            this.button_subQuery.Location = new System.Drawing.Point(732, 14);
            this.button_subQuery.Name = "button_subQuery";
            this.button_subQuery.Size = new System.Drawing.Size(75, 23);
            this.button_subQuery.TabIndex = 15;
            this.button_subQuery.Text = "二次查询";
            this.button_subQuery.UseVisualStyleBackColor = true;
            // 
            // Form_libraryQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 558);
            this.Controls.Add(this.button_subQuery);
            this.Controls.Add(this.button_nextPage);
            this.Controls.Add(this.button_previousPage);
            this.Controls.Add(this.label_queryInformation);
            this.Controls.Add(this.comboBox_sortordUpDown);
            this.Controls.Add(this.label_sortord);
            this.Controls.Add(this.comboBox_sortordProperty);
            this.Controls.Add(this.label_currentQuery);
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
        private System.Windows.Forms.Label label_currentQuery;
        private System.Windows.Forms.ComboBox comboBox_sortordProperty;
        private System.Windows.Forms.Label label_sortord;
        private System.Windows.Forms.ComboBox comboBox_sortordUpDown;
        private System.Windows.Forms.Label label_queryInformation;
        private System.Windows.Forms.Button button_previousPage;
        private System.Windows.Forms.Button button_nextPage;
        private System.Windows.Forms.Button button_subQuery;
        private System.Windows.Forms.ColumnHeader columnHeader_MarcNo;
        private System.Windows.Forms.ColumnHeader columnHeader_Title;
        private System.Windows.Forms.ColumnHeader columnHeader_Author;
        private System.Windows.Forms.ColumnHeader columnHeader_Publisher;
        private System.Windows.Forms.ColumnHeader columnHeader_ISBN;
        private System.Windows.Forms.ColumnHeader columnHeader_Price;
        private System.Windows.Forms.ColumnHeader columnHeader_Carrier;
        private System.Windows.Forms.ColumnHeader columnHeader_Subject;
        private System.Windows.Forms.ColumnHeader columnHeader_CLS;
        private System.Windows.Forms.ColumnHeader columnHeader_reserveButton;
    }
}