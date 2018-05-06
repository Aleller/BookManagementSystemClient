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
            this.trackBar_publishYear = new System.Windows.Forms.TrackBar();
            this.label_currentQuery = new System.Windows.Forms.Label();
            this.groupBox_publishYear = new System.Windows.Forms.GroupBox();
            this.checkBox_enable = new System.Windows.Forms.CheckBox();
            this.label_to = new System.Windows.Forms.Label();
            this.textBox_endYear = new System.Windows.Forms.TextBox();
            this.textBox_startYear = new System.Windows.Forms.TextBox();
            this.comboBox_sortordProperty = new System.Windows.Forms.ComboBox();
            this.label_sortord = new System.Windows.Forms.Label();
            this.comboBox_sortordUpDown = new System.Windows.Forms.ComboBox();
            this.label_queryInformation = new System.Windows.Forms.Label();
            this.button_previousPage = new System.Windows.Forms.Button();
            this.button_nextPage = new System.Windows.Forms.Button();
            this.button_subQuery = new System.Windows.Forms.Button();
            this.tabControl_queryProperty = new System.Windows.Forms.TabControl();
            this.tabPage_keywords = new System.Windows.Forms.TabPage();
            this.tabPage_position = new System.Windows.Forms.TabPage();
            this.listView_keywords = new System.Windows.Forms.ListView();
            this.columnHeader_enableKeywords = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_keywords = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage_author = new System.Windows.Forms.TabPage();
            this.tabPage_type = new System.Windows.Forms.TabPage();
            this.tabPage_classicification = new System.Windows.Forms.TabPage();
            this.tabPage_language = new System.Windows.Forms.TabPage();
            this.tabPage_publisher = new System.Windows.Forms.TabPage();
            this.tabPage_publishYear = new System.Windows.Forms.TabPage();
            this.listView_position = new System.Windows.Forms.ListView();
            this.columnHeader_enablePosition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_position = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_author = new System.Windows.Forms.ListView();
            this.columnHeader_enableAuthor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_publisher = new System.Windows.Forms.ListView();
            this.columnHeader_enablePublisher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_publishYear = new System.Windows.Forms.ListView();
            this.columnHeader_enablePublishYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_publishYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_type = new System.Windows.Forms.ListView();
            this.columnHeader_enableType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_classicification = new System.Windows.Forms.ListView();
            this.columnHeader_enableClassicification = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_classicification = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_language = new System.Windows.Forms.ListView();
            this.columnHeader_enableLanguage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_language = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_publishYear)).BeginInit();
            this.groupBox_publishYear.SuspendLayout();
            this.tabControl_queryProperty.SuspendLayout();
            this.tabPage_keywords.SuspendLayout();
            this.tabPage_position.SuspendLayout();
            this.tabPage_author.SuspendLayout();
            this.tabPage_type.SuspendLayout();
            this.tabPage_classicification.SuspendLayout();
            this.tabPage_language.SuspendLayout();
            this.tabPage_publisher.SuspendLayout();
            this.tabPage_publishYear.SuspendLayout();
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
            this.button_query.Size = new System.Drawing.Size(44, 23);
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
            this.listView_borrowedBooks.Location = new System.Drawing.Point(217, 76);
            this.listView_borrowedBooks.Name = "listView_borrowedBooks";
            this.listView_borrowedBooks.Size = new System.Drawing.Size(590, 470);
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
            // trackBar_publishYear
            // 
            this.trackBar_publishYear.Location = new System.Drawing.Point(6, 49);
            this.trackBar_publishYear.Name = "trackBar_publishYear";
            this.trackBar_publishYear.Size = new System.Drawing.Size(188, 45);
            this.trackBar_publishYear.TabIndex = 5;
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
            this.groupBox_publishYear.Controls.Add(this.trackBar_publishYear);
            this.groupBox_publishYear.Location = new System.Drawing.Point(12, 83);
            this.groupBox_publishYear.Name = "groupBox_publishYear";
            this.groupBox_publishYear.Size = new System.Drawing.Size(200, 100);
            this.groupBox_publishYear.TabIndex = 7;
            this.groupBox_publishYear.TabStop = false;
            this.groupBox_publishYear.Text = "出版年份";
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
            // label_to
            // 
            this.label_to.AutoSize = true;
            this.label_to.Location = new System.Drawing.Point(118, 25);
            this.label_to.Name = "label_to";
            this.label_to.Size = new System.Drawing.Size(17, 12);
            this.label_to.TabIndex = 9;
            this.label_to.Text = "到";
            // 
            // textBox_endYear
            // 
            this.textBox_endYear.Location = new System.Drawing.Point(144, 20);
            this.textBox_endYear.Name = "textBox_endYear";
            this.textBox_endYear.Size = new System.Drawing.Size(50, 21);
            this.textBox_endYear.TabIndex = 8;
            // 
            // textBox_startYear
            // 
            this.textBox_startYear.Location = new System.Drawing.Point(60, 20);
            this.textBox_startYear.Name = "textBox_startYear";
            this.textBox_startYear.Size = new System.Drawing.Size(52, 21);
            this.textBox_startYear.TabIndex = 7;
            // 
            // comboBox_sortordProperty
            // 
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
            // tabControl_queryProperty
            // 
            this.tabControl_queryProperty.Controls.Add(this.tabPage_keywords);
            this.tabControl_queryProperty.Controls.Add(this.tabPage_position);
            this.tabControl_queryProperty.Controls.Add(this.tabPage_author);
            this.tabControl_queryProperty.Controls.Add(this.tabPage_type);
            this.tabControl_queryProperty.Controls.Add(this.tabPage_classicification);
            this.tabControl_queryProperty.Controls.Add(this.tabPage_language);
            this.tabControl_queryProperty.Controls.Add(this.tabPage_publisher);
            this.tabControl_queryProperty.Controls.Add(this.tabPage_publishYear);
            this.tabControl_queryProperty.Location = new System.Drawing.Point(12, 189);
            this.tabControl_queryProperty.Multiline = true;
            this.tabControl_queryProperty.Name = "tabControl_queryProperty";
            this.tabControl_queryProperty.SelectedIndex = 0;
            this.tabControl_queryProperty.Size = new System.Drawing.Size(200, 357);
            this.tabControl_queryProperty.TabIndex = 16;
            // 
            // tabPage_keywords
            // 
            this.tabPage_keywords.Controls.Add(this.listView_keywords);
            this.tabPage_keywords.Location = new System.Drawing.Point(4, 58);
            this.tabPage_keywords.Name = "tabPage_keywords";
            this.tabPage_keywords.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_keywords.Size = new System.Drawing.Size(192, 295);
            this.tabPage_keywords.TabIndex = 0;
            this.tabPage_keywords.Text = "主题词";
            this.tabPage_keywords.UseVisualStyleBackColor = true;
            // 
            // tabPage_position
            // 
            this.tabPage_position.Controls.Add(this.listView_position);
            this.tabPage_position.Location = new System.Drawing.Point(4, 58);
            this.tabPage_position.Name = "tabPage_position";
            this.tabPage_position.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_position.Size = new System.Drawing.Size(192, 295);
            this.tabPage_position.TabIndex = 1;
            this.tabPage_position.Text = "馆藏地";
            this.tabPage_position.UseVisualStyleBackColor = true;
            // 
            // listView_keywords
            // 
            this.listView_keywords.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_enableKeywords,
            this.columnHeader_keywords});
            this.listView_keywords.Location = new System.Drawing.Point(6, 6);
            this.listView_keywords.Name = "listView_keywords";
            this.listView_keywords.Size = new System.Drawing.Size(180, 283);
            this.listView_keywords.TabIndex = 1;
            this.listView_keywords.UseCompatibleStateImageBehavior = false;
            this.listView_keywords.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_enableKeywords
            // 
            this.columnHeader_enableKeywords.Text = "启用";
            this.columnHeader_enableKeywords.Width = 53;
            // 
            // columnHeader_keywords
            // 
            this.columnHeader_keywords.Text = "主题词";
            this.columnHeader_keywords.Width = 122;
            // 
            // tabPage_author
            // 
            this.tabPage_author.Controls.Add(this.listView_author);
            this.tabPage_author.Location = new System.Drawing.Point(4, 58);
            this.tabPage_author.Name = "tabPage_author";
            this.tabPage_author.Size = new System.Drawing.Size(192, 295);
            this.tabPage_author.TabIndex = 2;
            this.tabPage_author.Text = "作者";
            this.tabPage_author.UseVisualStyleBackColor = true;
            // 
            // tabPage_type
            // 
            this.tabPage_type.Controls.Add(this.listView_type);
            this.tabPage_type.Location = new System.Drawing.Point(4, 58);
            this.tabPage_type.Name = "tabPage_type";
            this.tabPage_type.Size = new System.Drawing.Size(192, 295);
            this.tabPage_type.TabIndex = 3;
            this.tabPage_type.Text = "文献类型";
            this.tabPage_type.UseVisualStyleBackColor = true;
            // 
            // tabPage_classicification
            // 
            this.tabPage_classicification.Controls.Add(this.listView_classicification);
            this.tabPage_classicification.Location = new System.Drawing.Point(4, 58);
            this.tabPage_classicification.Name = "tabPage_classicification";
            this.tabPage_classicification.Size = new System.Drawing.Size(192, 295);
            this.tabPage_classicification.TabIndex = 4;
            this.tabPage_classicification.Text = "分类";
            this.tabPage_classicification.UseVisualStyleBackColor = true;
            // 
            // tabPage_language
            // 
            this.tabPage_language.Controls.Add(this.listView_language);
            this.tabPage_language.Location = new System.Drawing.Point(4, 58);
            this.tabPage_language.Name = "tabPage_language";
            this.tabPage_language.Size = new System.Drawing.Size(192, 295);
            this.tabPage_language.TabIndex = 5;
            this.tabPage_language.Text = "语言";
            this.tabPage_language.UseVisualStyleBackColor = true;
            // 
            // tabPage_publisher
            // 
            this.tabPage_publisher.Controls.Add(this.listView_publisher);
            this.tabPage_publisher.Location = new System.Drawing.Point(4, 58);
            this.tabPage_publisher.Name = "tabPage_publisher";
            this.tabPage_publisher.Size = new System.Drawing.Size(192, 295);
            this.tabPage_publisher.TabIndex = 6;
            this.tabPage_publisher.Text = "出版社";
            this.tabPage_publisher.UseVisualStyleBackColor = true;
            // 
            // tabPage_publishYear
            // 
            this.tabPage_publishYear.Controls.Add(this.listView_publishYear);
            this.tabPage_publishYear.Location = new System.Drawing.Point(4, 58);
            this.tabPage_publishYear.Name = "tabPage_publishYear";
            this.tabPage_publishYear.Size = new System.Drawing.Size(192, 295);
            this.tabPage_publishYear.TabIndex = 7;
            this.tabPage_publishYear.Text = "出版年份";
            this.tabPage_publishYear.UseVisualStyleBackColor = true;
            // 
            // listView_position
            // 
            this.listView_position.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_enablePosition,
            this.columnHeader_position});
            this.listView_position.Location = new System.Drawing.Point(6, 6);
            this.listView_position.Name = "listView_position";
            this.listView_position.Size = new System.Drawing.Size(180, 283);
            this.listView_position.TabIndex = 2;
            this.listView_position.UseCompatibleStateImageBehavior = false;
            this.listView_position.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_enablePosition
            // 
            this.columnHeader_enablePosition.Text = "启用";
            // 
            // columnHeader_position
            // 
            this.columnHeader_position.Text = "馆藏地";
            this.columnHeader_position.Width = 122;
            // 
            // listView_author
            // 
            this.listView_author.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_enableAuthor,
            this.columnHeader4});
            this.listView_author.Location = new System.Drawing.Point(6, 6);
            this.listView_author.Name = "listView_author";
            this.listView_author.Size = new System.Drawing.Size(180, 283);
            this.listView_author.TabIndex = 2;
            this.listView_author.UseCompatibleStateImageBehavior = false;
            this.listView_author.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_enableAuthor
            // 
            this.columnHeader_enableAuthor.Text = "启用";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "作者";
            this.columnHeader4.Width = 122;
            // 
            // listView_publisher
            // 
            this.listView_publisher.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_enablePublisher,
            this.columnHeader12});
            this.listView_publisher.Location = new System.Drawing.Point(6, 6);
            this.listView_publisher.Name = "listView_publisher";
            this.listView_publisher.Size = new System.Drawing.Size(180, 283);
            this.listView_publisher.TabIndex = 2;
            this.listView_publisher.UseCompatibleStateImageBehavior = false;
            this.listView_publisher.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_enablePublisher
            // 
            this.columnHeader_enablePublisher.Text = "启用";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "出版社";
            this.columnHeader12.Width = 122;
            // 
            // listView_publishYear
            // 
            this.listView_publishYear.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_enablePublishYear,
            this.columnHeader_publishYear});
            this.listView_publishYear.Location = new System.Drawing.Point(6, 6);
            this.listView_publishYear.Name = "listView_publishYear";
            this.listView_publishYear.Size = new System.Drawing.Size(180, 283);
            this.listView_publishYear.TabIndex = 2;
            this.listView_publishYear.UseCompatibleStateImageBehavior = false;
            this.listView_publishYear.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_enablePublishYear
            // 
            this.columnHeader_enablePublishYear.Text = "启用";
            // 
            // columnHeader_publishYear
            // 
            this.columnHeader_publishYear.Text = "出版年份";
            this.columnHeader_publishYear.Width = 122;
            // 
            // listView_type
            // 
            this.listView_type.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_enableType,
            this.columnHeader_type});
            this.listView_type.Location = new System.Drawing.Point(6, 6);
            this.listView_type.Name = "listView_type";
            this.listView_type.Size = new System.Drawing.Size(180, 283);
            this.listView_type.TabIndex = 2;
            this.listView_type.UseCompatibleStateImageBehavior = false;
            this.listView_type.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_enableType
            // 
            this.columnHeader_enableType.Text = "启用";
            // 
            // columnHeader_type
            // 
            this.columnHeader_type.Text = "文献类型";
            this.columnHeader_type.Width = 122;
            // 
            // listView_classicification
            // 
            this.listView_classicification.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_enableClassicification,
            this.columnHeader_classicification});
            this.listView_classicification.Location = new System.Drawing.Point(6, 6);
            this.listView_classicification.Name = "listView_classicification";
            this.listView_classicification.Size = new System.Drawing.Size(180, 283);
            this.listView_classicification.TabIndex = 2;
            this.listView_classicification.UseCompatibleStateImageBehavior = false;
            this.listView_classicification.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_enableClassicification
            // 
            this.columnHeader_enableClassicification.Text = "启用";
            // 
            // columnHeader_classicification
            // 
            this.columnHeader_classicification.Text = "分类";
            this.columnHeader_classicification.Width = 122;
            // 
            // listView_language
            // 
            this.listView_language.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_enableLanguage,
            this.columnHeader_language});
            this.listView_language.Location = new System.Drawing.Point(6, 6);
            this.listView_language.Name = "listView_language";
            this.listView_language.Size = new System.Drawing.Size(180, 283);
            this.listView_language.TabIndex = 2;
            this.listView_language.UseCompatibleStateImageBehavior = false;
            this.listView_language.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_enableLanguage
            // 
            this.columnHeader_enableLanguage.Text = "启用";
            // 
            // columnHeader_language
            // 
            this.columnHeader_language.Text = "语言";
            this.columnHeader_language.Width = 122;
            // 
            // Form_libraryQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 558);
            this.Controls.Add(this.tabControl_queryProperty);
            this.Controls.Add(this.button_subQuery);
            this.Controls.Add(this.button_nextPage);
            this.Controls.Add(this.button_previousPage);
            this.Controls.Add(this.label_queryInformation);
            this.Controls.Add(this.comboBox_sortordUpDown);
            this.Controls.Add(this.label_sortord);
            this.Controls.Add(this.comboBox_sortordProperty);
            this.Controls.Add(this.groupBox_publishYear);
            this.Controls.Add(this.label_currentQuery);
            this.Controls.Add(this.listView_borrowedBooks);
            this.Controls.Add(this.button_query);
            this.Controls.Add(this.textBox_inputQuery);
            this.Controls.Add(this.label_queryType);
            this.Controls.Add(this.comboBox_queryType);
            this.Name = "Form_libraryQuery";
            this.Text = "馆藏检索";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_publishYear)).EndInit();
            this.groupBox_publishYear.ResumeLayout(false);
            this.groupBox_publishYear.PerformLayout();
            this.tabControl_queryProperty.ResumeLayout(false);
            this.tabPage_keywords.ResumeLayout(false);
            this.tabPage_position.ResumeLayout(false);
            this.tabPage_author.ResumeLayout(false);
            this.tabPage_type.ResumeLayout(false);
            this.tabPage_classicification.ResumeLayout(false);
            this.tabPage_language.ResumeLayout(false);
            this.tabPage_publisher.ResumeLayout(false);
            this.tabPage_publishYear.ResumeLayout(false);
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
        private System.Windows.Forms.TrackBar trackBar_publishYear;
        private System.Windows.Forms.Label label_currentQuery;
        private System.Windows.Forms.GroupBox groupBox_publishYear;
        private System.Windows.Forms.Label label_to;
        private System.Windows.Forms.TextBox textBox_endYear;
        private System.Windows.Forms.TextBox textBox_startYear;
        private System.Windows.Forms.CheckBox checkBox_enable;
        private System.Windows.Forms.ComboBox comboBox_sortordProperty;
        private System.Windows.Forms.Label label_sortord;
        private System.Windows.Forms.ComboBox comboBox_sortordUpDown;
        private System.Windows.Forms.Label label_queryInformation;
        private System.Windows.Forms.Button button_previousPage;
        private System.Windows.Forms.Button button_nextPage;
        private System.Windows.Forms.Button button_subQuery;
        private System.Windows.Forms.TabControl tabControl_queryProperty;
        private System.Windows.Forms.TabPage tabPage_keywords;
        private System.Windows.Forms.ListView listView_keywords;
        private System.Windows.Forms.ColumnHeader columnHeader_enableKeywords;
        private System.Windows.Forms.ColumnHeader columnHeader_keywords;
        private System.Windows.Forms.TabPage tabPage_position;
        private System.Windows.Forms.ListView listView_position;
        private System.Windows.Forms.ColumnHeader columnHeader_enablePosition;
        private System.Windows.Forms.ColumnHeader columnHeader_position;
        private System.Windows.Forms.TabPage tabPage_author;
        private System.Windows.Forms.ListView listView_author;
        private System.Windows.Forms.ColumnHeader columnHeader_enableAuthor;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TabPage tabPage_type;
        private System.Windows.Forms.ListView listView_type;
        private System.Windows.Forms.ColumnHeader columnHeader_enableType;
        private System.Windows.Forms.ColumnHeader columnHeader_type;
        private System.Windows.Forms.TabPage tabPage_classicification;
        private System.Windows.Forms.ListView listView_classicification;
        private System.Windows.Forms.ColumnHeader columnHeader_enableClassicification;
        private System.Windows.Forms.ColumnHeader columnHeader_classicification;
        private System.Windows.Forms.TabPage tabPage_language;
        private System.Windows.Forms.ListView listView_language;
        private System.Windows.Forms.ColumnHeader columnHeader_enableLanguage;
        private System.Windows.Forms.ColumnHeader columnHeader_language;
        private System.Windows.Forms.TabPage tabPage_publisher;
        private System.Windows.Forms.ListView listView_publisher;
        private System.Windows.Forms.ColumnHeader columnHeader_enablePublisher;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.TabPage tabPage_publishYear;
        private System.Windows.Forms.ListView listView_publishYear;
        private System.Windows.Forms.ColumnHeader columnHeader_enablePublishYear;
        private System.Windows.Forms.ColumnHeader columnHeader_publishYear;
    }
}