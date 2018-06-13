namespace BookManagementSystemClient
{
    partial class Form_operationUI
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
            this.label_userName = new System.Windows.Forms.Label();
            this.groupBox_myHomePage = new System.Windows.Forms.GroupBox();
            this.label_ordered = new System.Windows.Forms.Label();
            this.label_maxOrder = new System.Windows.Forms.Label();
            this.label_maxBorrow = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.我的图书馆ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.我的首页ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.借阅历史ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.当前预约ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.检索历史ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.预约历史toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.书目检索ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.馆藏检索ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.分类浏览ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_borrowedBooks = new System.Windows.Forms.GroupBox();
            this.listView_borrowedBooks = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label_borrowedBookAmount = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox_myHomePage.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox_borrowedBooks.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_userName
            // 
            this.label_userName.AutoSize = true;
            this.label_userName.Location = new System.Drawing.Point(10, 29);
            this.label_userName.Name = "label_userName";
            this.label_userName.Size = new System.Drawing.Size(101, 12);
            this.label_userName.TabIndex = 0;
            this.label_userName.Text = "用户：2015210793";
            // 
            // groupBox_myHomePage
            // 
            this.groupBox_myHomePage.Controls.Add(this.label_ordered);
            this.groupBox_myHomePage.Controls.Add(this.label_borrowedBookAmount);
            this.groupBox_myHomePage.Controls.Add(this.label_maxOrder);
            this.groupBox_myHomePage.Controls.Add(this.label_maxBorrow);
            this.groupBox_myHomePage.Controls.Add(this.label_userName);
            this.groupBox_myHomePage.Location = new System.Drawing.Point(11, 28);
            this.groupBox_myHomePage.Name = "groupBox_myHomePage";
            this.groupBox_myHomePage.Size = new System.Drawing.Size(772, 59);
            this.groupBox_myHomePage.TabIndex = 1;
            this.groupBox_myHomePage.TabStop = false;
            this.groupBox_myHomePage.Text = "我的首页";
            // 
            // label_ordered
            // 
            this.label_ordered.AutoSize = true;
            this.label_ordered.Location = new System.Drawing.Point(446, 29);
            this.label_ordered.Name = "label_ordered";
            this.label_ordered.Size = new System.Drawing.Size(71, 12);
            this.label_ordered.TabIndex = 4;
            this.label_ordered.Text = "预约到书：0";
            // 
            // label_maxOrder
            // 
            this.label_maxOrder.AutoSize = true;
            this.label_maxOrder.Location = new System.Drawing.Point(233, 29);
            this.label_maxOrder.Name = "label_maxOrder";
            this.label_maxOrder.Size = new System.Drawing.Size(83, 12);
            this.label_maxOrder.TabIndex = 2;
            this.label_maxOrder.Text = "最多可预约：1";
            // 
            // label_maxBorrow
            // 
            this.label_maxBorrow.AutoSize = true;
            this.label_maxBorrow.Location = new System.Drawing.Point(136, 29);
            this.label_maxBorrow.Name = "label_maxBorrow";
            this.label_maxBorrow.Size = new System.Drawing.Size(77, 12);
            this.label_maxBorrow.TabIndex = 1;
            this.label_maxBorrow.Text = "最多可借：17";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.我的图书馆ToolStripMenuItem,
            this.书目检索ToolStripMenuItem,
            this.分类浏览ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(796, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 21);
            // 
            // 我的图书馆ToolStripMenuItem
            // 
            this.我的图书馆ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.我的首页ToolStripMenuItem,
            this.借阅历史ToolStripMenuItem,
            this.当前预约ToolStripMenuItem,
            this.检索历史ToolStripMenuItem,
            this.预约历史toolStripMenuItem});
            this.我的图书馆ToolStripMenuItem.Name = "我的图书馆ToolStripMenuItem";
            this.我的图书馆ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.我的图书馆ToolStripMenuItem.Text = "我的图书馆";
            // 
            // 我的首页ToolStripMenuItem
            // 
            this.我的首页ToolStripMenuItem.Name = "我的首页ToolStripMenuItem";
            this.我的首页ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.我的首页ToolStripMenuItem.Text = "我的首页";
            // 
            // 借阅历史ToolStripMenuItem
            // 
            this.借阅历史ToolStripMenuItem.Name = "借阅历史ToolStripMenuItem";
            this.借阅历史ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.借阅历史ToolStripMenuItem.Text = "借阅历史";
            this.借阅历史ToolStripMenuItem.Click += new System.EventHandler(this.借阅历史ToolStripMenuItem_Click);
            // 
            // 当前预约ToolStripMenuItem
            // 
            this.当前预约ToolStripMenuItem.Name = "当前预约ToolStripMenuItem";
            this.当前预约ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.当前预约ToolStripMenuItem.Text = "当前预约";
            this.当前预约ToolStripMenuItem.Click += new System.EventHandler(this.预约信息ToolStripMenuItem_Click);
            // 
            // 检索历史ToolStripMenuItem
            // 
            this.检索历史ToolStripMenuItem.Name = "检索历史ToolStripMenuItem";
            this.检索历史ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.检索历史ToolStripMenuItem.Text = "检索历史";
            this.检索历史ToolStripMenuItem.Click += new System.EventHandler(this.检索历史ToolStripMenuItem_Click);
            // 
            // 预约历史toolStripMenuItem
            // 
            this.预约历史toolStripMenuItem.Name = "预约历史toolStripMenuItem";
            this.预约历史toolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.预约历史toolStripMenuItem.Text = "预约历史";
            this.预约历史toolStripMenuItem.Click += new System.EventHandler(this.预约历史toolStripMenuItem_Click);
            // 
            // 书目检索ToolStripMenuItem
            // 
            this.书目检索ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.馆藏检索ToolStripMenuItem});
            this.书目检索ToolStripMenuItem.Name = "书目检索ToolStripMenuItem";
            this.书目检索ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.书目检索ToolStripMenuItem.Text = "书目检索";
            // 
            // 馆藏检索ToolStripMenuItem
            // 
            this.馆藏检索ToolStripMenuItem.Name = "馆藏检索ToolStripMenuItem";
            this.馆藏检索ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.馆藏检索ToolStripMenuItem.Text = "馆藏检索";
            this.馆藏检索ToolStripMenuItem.Click += new System.EventHandler(this.馆藏检索ToolStripMenuItem_Click);
            // 
            // 分类浏览ToolStripMenuItem
            // 
            this.分类浏览ToolStripMenuItem.Name = "分类浏览ToolStripMenuItem";
            this.分类浏览ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.分类浏览ToolStripMenuItem.Text = "分类浏览";
            // 
            // groupBox_borrowedBooks
            // 
            this.groupBox_borrowedBooks.Controls.Add(this.listView_borrowedBooks);
            this.groupBox_borrowedBooks.Location = new System.Drawing.Point(12, 110);
            this.groupBox_borrowedBooks.Name = "groupBox_borrowedBooks";
            this.groupBox_borrowedBooks.Size = new System.Drawing.Size(771, 329);
            this.groupBox_borrowedBooks.TabIndex = 3;
            this.groupBox_borrowedBooks.TabStop = false;
            this.groupBox_borrowedBooks.Text = "当前借阅";
            // 
            // listView_borrowedBooks
            // 
            this.listView_borrowedBooks.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView_borrowedBooks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView_borrowedBooks.HoverSelection = true;
            this.listView_borrowedBooks.Location = new System.Drawing.Point(13, 20);
            this.listView_borrowedBooks.Name = "listView_borrowedBooks";
            this.listView_borrowedBooks.Size = new System.Drawing.Size(752, 284);
            this.listView_borrowedBooks.TabIndex = 1;
            this.listView_borrowedBooks.UseCompatibleStateImageBehavior = false;
            this.listView_borrowedBooks.View = System.Windows.Forms.View.Details;
            this.listView_borrowedBooks.ItemActivate += new System.EventHandler(this.listView_borrowedBooks_ItemActivate);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "条形码";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "书名";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "作者";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "借阅日期";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "应还日期";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "馆藏地";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "是否续借";
            // 
            // label_borrowedBookAmount
            // 
            this.label_borrowedBookAmount.AutoSize = true;
            this.label_borrowedBookAmount.Location = new System.Drawing.Point(344, 29);
            this.label_borrowedBookAmount.Name = "label_borrowedBookAmount";
            this.label_borrowedBookAmount.Size = new System.Drawing.Size(71, 12);
            this.label_borrowedBookAmount.TabIndex = 0;
            this.label_borrowedBookAmount.Text = "已借数量：0";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "续借";
            // 
            // Form_operationUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 451);
            this.Controls.Add(this.groupBox_borrowedBooks);
            this.Controls.Add(this.groupBox_myHomePage);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_operationUI";
            this.Text = "图书馆信息系统客户端";
            this.groupBox_myHomePage.ResumeLayout(false);
            this.groupBox_myHomePage.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox_borrowedBooks.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_userName;
        private System.Windows.Forms.GroupBox groupBox_myHomePage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 我的图书馆ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 我的首页ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 借阅历史ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 当前预约ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 书目检索ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 分类浏览ToolStripMenuItem;
        private System.Windows.Forms.Label label_ordered;
        private System.Windows.Forms.Label label_maxOrder;
        private System.Windows.Forms.Label label_maxBorrow;
        private System.Windows.Forms.GroupBox groupBox_borrowedBooks;
        private System.Windows.Forms.ListView listView_borrowedBooks;
        private System.Windows.Forms.Label label_borrowedBookAmount;
        private System.Windows.Forms.ToolStripMenuItem 馆藏检索ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 检索历史ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 预约历史toolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}