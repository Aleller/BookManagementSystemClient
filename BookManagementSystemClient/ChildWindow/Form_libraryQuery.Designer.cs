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
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label_currentQuery = new System.Windows.Forms.Label();
            this.groupBox_publishYear = new System.Windows.Forms.GroupBox();
            this.textBox_startYear = new System.Windows.Forms.TextBox();
            this.textBox_endYear = new System.Windows.Forms.TextBox();
            this.label_to = new System.Windows.Forms.Label();
            this.groupBox_keywords = new System.Windows.Forms.GroupBox();
            this.listView_keywords = new System.Windows.Forms.ListView();
            this.columnHeader_enable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_keywords = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.checkBox_enable = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox_publishYear.SuspendLayout();
            this.groupBox_keywords.SuspendLayout();
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
            this.listView_borrowedBooks.Location = new System.Drawing.Point(217, 43);
            this.listView_borrowedBooks.Name = "listView_borrowedBooks";
            this.listView_borrowedBooks.Size = new System.Drawing.Size(590, 503);
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
            this.columnHeader_coverAndTitle.Width = 156;
            // 
            // columnHeader_author
            // 
            this.columnHeader_author.Text = "责任人";
            this.columnHeader_author.Width = 112;
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
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(6, 49);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(188, 45);
            this.trackBar1.TabIndex = 5;
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
            // groupBox_publishYear
            // 
            this.groupBox_publishYear.Controls.Add(this.checkBox_enable);
            this.groupBox_publishYear.Controls.Add(this.label_to);
            this.groupBox_publishYear.Controls.Add(this.textBox_endYear);
            this.groupBox_publishYear.Controls.Add(this.textBox_startYear);
            this.groupBox_publishYear.Controls.Add(this.trackBar1);
            this.groupBox_publishYear.Location = new System.Drawing.Point(12, 83);
            this.groupBox_publishYear.Name = "groupBox_publishYear";
            this.groupBox_publishYear.Size = new System.Drawing.Size(200, 100);
            this.groupBox_publishYear.TabIndex = 7;
            this.groupBox_publishYear.TabStop = false;
            this.groupBox_publishYear.Text = "出版年份";
            // 
            // textBox_startYear
            // 
            this.textBox_startYear.Location = new System.Drawing.Point(60, 20);
            this.textBox_startYear.Name = "textBox_startYear";
            this.textBox_startYear.Size = new System.Drawing.Size(52, 21);
            this.textBox_startYear.TabIndex = 7;
            // 
            // textBox_endYear
            // 
            this.textBox_endYear.Location = new System.Drawing.Point(144, 20);
            this.textBox_endYear.Name = "textBox_endYear";
            this.textBox_endYear.Size = new System.Drawing.Size(50, 21);
            this.textBox_endYear.TabIndex = 8;
            // 
            // label_to
            // 
            this.label_to.AutoSize = true;
            this.label_to.Location = new System.Drawing.Point(118, 25);
            this.label_to.Name = "label_to";
            this.label_to.Size = new System.Drawing.Size(17, 12);
            this.label_to.TabIndex = 9;
            this.label_to.Text = "到";
            // 
            // groupBox_keywords
            // 
            this.groupBox_keywords.Controls.Add(this.listView_keywords);
            this.groupBox_keywords.Location = new System.Drawing.Point(12, 190);
            this.groupBox_keywords.Name = "groupBox_keywords";
            this.groupBox_keywords.Size = new System.Drawing.Size(200, 356);
            this.groupBox_keywords.TabIndex = 8;
            this.groupBox_keywords.TabStop = false;
            this.groupBox_keywords.Text = "主题词";
            // 
            // listView_keywords
            // 
            this.listView_keywords.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_enable,
            this.columnHeader_keywords});
            this.listView_keywords.Location = new System.Drawing.Point(7, 21);
            this.listView_keywords.Name = "listView_keywords";
            this.listView_keywords.Size = new System.Drawing.Size(187, 329);
            this.listView_keywords.TabIndex = 0;
            this.listView_keywords.UseCompatibleStateImageBehavior = false;
            this.listView_keywords.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_enable
            // 
            this.columnHeader_enable.Text = "启用";
            // 
            // columnHeader_keywords
            // 
            this.columnHeader_keywords.Text = "主题词";
            this.columnHeader_keywords.Width = 122;
            // 
            // checkBox_enable
            // 
            this.checkBox_enable.AutoSize = true;
            this.checkBox_enable.Location = new System.Drawing.Point(7, 24);
            this.checkBox_enable.Name = "checkBox_enable";
            this.checkBox_enable.Size = new System.Drawing.Size(48, 16);
            this.checkBox_enable.TabIndex = 10;
            this.checkBox_enable.Text = "启用";
            this.checkBox_enable.UseVisualStyleBackColor = true;
            // 
            // Form_libraryQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 558);
            this.Controls.Add(this.groupBox_keywords);
            this.Controls.Add(this.groupBox_publishYear);
            this.Controls.Add(this.label_currentQuery);
            this.Controls.Add(this.listView_borrowedBooks);
            this.Controls.Add(this.button_query);
            this.Controls.Add(this.textBox_inputQuery);
            this.Controls.Add(this.label_queryType);
            this.Controls.Add(this.comboBox_queryType);
            this.Name = "Form_libraryQuery";
            this.Text = "馆藏检索";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox_publishYear.ResumeLayout(false);
            this.groupBox_publishYear.PerformLayout();
            this.groupBox_keywords.ResumeLayout(false);
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
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label_currentQuery;
        private System.Windows.Forms.GroupBox groupBox_publishYear;
        private System.Windows.Forms.Label label_to;
        private System.Windows.Forms.TextBox textBox_endYear;
        private System.Windows.Forms.TextBox textBox_startYear;
        private System.Windows.Forms.GroupBox groupBox_keywords;
        private System.Windows.Forms.ListView listView_keywords;
        private System.Windows.Forms.ColumnHeader columnHeader_enable;
        private System.Windows.Forms.ColumnHeader columnHeader_keywords;
        private System.Windows.Forms.CheckBox checkBox_enable;
    }
}