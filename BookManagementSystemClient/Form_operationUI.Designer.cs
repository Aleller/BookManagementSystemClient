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
            this.label_overdue = new System.Windows.Forms.Label();
            this.label_maxOrder = new System.Windows.Forms.Label();
            this.label_maxBorrow = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.我的图书馆ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.我的首页ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.证件信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.借阅历史ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.预约信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.我的书架ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.书刊遗失ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.读者挂失ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.账目清单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.违章缴款ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.我的书评ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.检索历史ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.书目检索ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.馆藏检索ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.简单检索ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.多字段检索ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.分类浏览ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_borrowedBooks = new System.Windows.Forms.GroupBox();
            this.listView_borrowedBooks = new System.Windows.Forms.ListView();
            this.columnHeader_number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_publisher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_ISBN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_subject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_TN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_dateOfReturn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label_borrowedBookAmount = new System.Windows.Forms.Label();
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
            this.groupBox_myHomePage.Controls.Add(this.label_overdue);
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
            // label_overdue
            // 
            this.label_overdue.AutoSize = true;
            this.label_overdue.ForeColor = System.Drawing.Color.Red;
            this.label_overdue.Location = new System.Drawing.Point(344, 29);
            this.label_overdue.Name = "label_overdue";
            this.label_overdue.Size = new System.Drawing.Size(71, 12);
            this.label_overdue.TabIndex = 3;
            this.label_overdue.Text = "超期图书：0";
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
            this.证件信息ToolStripMenuItem,
            this.借阅历史ToolStripMenuItem,
            this.预约信息ToolStripMenuItem,
            this.我的书架ToolStripMenuItem,
            this.书刊遗失ToolStripMenuItem,
            this.读者挂失ToolStripMenuItem,
            this.账目清单ToolStripMenuItem,
            this.违章缴款ToolStripMenuItem,
            this.我的书评ToolStripMenuItem,
            this.检索历史ToolStripMenuItem});
            this.我的图书馆ToolStripMenuItem.Name = "我的图书馆ToolStripMenuItem";
            this.我的图书馆ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.我的图书馆ToolStripMenuItem.Text = "我的图书馆";
            // 
            // 我的首页ToolStripMenuItem
            // 
            this.我的首页ToolStripMenuItem.Name = "我的首页ToolStripMenuItem";
            this.我的首页ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.我的首页ToolStripMenuItem.Text = "我的首页";
            // 
            // 证件信息ToolStripMenuItem
            // 
            this.证件信息ToolStripMenuItem.Name = "证件信息ToolStripMenuItem";
            this.证件信息ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.证件信息ToolStripMenuItem.Text = "证件信息";
            this.证件信息ToolStripMenuItem.Click += new System.EventHandler(this.证件信息ToolStripMenuItem_Click);
            // 
            // 借阅历史ToolStripMenuItem
            // 
            this.借阅历史ToolStripMenuItem.Name = "借阅历史ToolStripMenuItem";
            this.借阅历史ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.借阅历史ToolStripMenuItem.Text = "借阅历史";
            this.借阅历史ToolStripMenuItem.Click += new System.EventHandler(this.借阅历史ToolStripMenuItem_Click);
            // 
            // 预约信息ToolStripMenuItem
            // 
            this.预约信息ToolStripMenuItem.Name = "预约信息ToolStripMenuItem";
            this.预约信息ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.预约信息ToolStripMenuItem.Text = "预约信息";
            this.预约信息ToolStripMenuItem.Click += new System.EventHandler(this.预约信息ToolStripMenuItem_Click);
            // 
            // 我的书架ToolStripMenuItem
            // 
            this.我的书架ToolStripMenuItem.Name = "我的书架ToolStripMenuItem";
            this.我的书架ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.我的书架ToolStripMenuItem.Text = "我的书架";
            this.我的书架ToolStripMenuItem.Click += new System.EventHandler(this.我的书架ToolStripMenuItem_Click);
            // 
            // 书刊遗失ToolStripMenuItem
            // 
            this.书刊遗失ToolStripMenuItem.Name = "书刊遗失ToolStripMenuItem";
            this.书刊遗失ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.书刊遗失ToolStripMenuItem.Text = "书刊遗失";
            this.书刊遗失ToolStripMenuItem.Click += new System.EventHandler(this.书刊遗失ToolStripMenuItem_Click);
            // 
            // 读者挂失ToolStripMenuItem
            // 
            this.读者挂失ToolStripMenuItem.Name = "读者挂失ToolStripMenuItem";
            this.读者挂失ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.读者挂失ToolStripMenuItem.Text = "读者挂失";
            this.读者挂失ToolStripMenuItem.Click += new System.EventHandler(this.读者挂失ToolStripMenuItem_Click);
            // 
            // 账目清单ToolStripMenuItem
            // 
            this.账目清单ToolStripMenuItem.Name = "账目清单ToolStripMenuItem";
            this.账目清单ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.账目清单ToolStripMenuItem.Text = "账目清单";
            this.账目清单ToolStripMenuItem.Click += new System.EventHandler(this.账目清单ToolStripMenuItem_Click);
            // 
            // 违章缴款ToolStripMenuItem
            // 
            this.违章缴款ToolStripMenuItem.Name = "违章缴款ToolStripMenuItem";
            this.违章缴款ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.违章缴款ToolStripMenuItem.Text = "违章缴款";
            this.违章缴款ToolStripMenuItem.Click += new System.EventHandler(this.违章缴款ToolStripMenuItem_Click);
            // 
            // 我的书评ToolStripMenuItem
            // 
            this.我的书评ToolStripMenuItem.Name = "我的书评ToolStripMenuItem";
            this.我的书评ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.我的书评ToolStripMenuItem.Text = "我的书评";
            this.我的书评ToolStripMenuItem.Click += new System.EventHandler(this.我的书评ToolStripMenuItem_Click);
            // 
            // 检索历史ToolStripMenuItem
            // 
            this.检索历史ToolStripMenuItem.Name = "检索历史ToolStripMenuItem";
            this.检索历史ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.检索历史ToolStripMenuItem.Text = "检索历史";
            this.检索历史ToolStripMenuItem.Click += new System.EventHandler(this.检索历史ToolStripMenuItem_Click);
            // 
            // 书目检索ToolStripMenuItem
            // 
            this.书目检索ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.馆藏检索ToolStripMenuItem,
            this.简单检索ToolStripMenuItem,
            this.多字段检索ToolStripMenuItem});
            this.书目检索ToolStripMenuItem.Name = "书目检索ToolStripMenuItem";
            this.书目检索ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.书目检索ToolStripMenuItem.Text = "书目检索";
            // 
            // 馆藏检索ToolStripMenuItem
            // 
            this.馆藏检索ToolStripMenuItem.Name = "馆藏检索ToolStripMenuItem";
            this.馆藏检索ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.馆藏检索ToolStripMenuItem.Text = "馆藏检索";
            this.馆藏检索ToolStripMenuItem.Click += new System.EventHandler(this.馆藏检索ToolStripMenuItem_Click);
            // 
            // 简单检索ToolStripMenuItem
            // 
            this.简单检索ToolStripMenuItem.Name = "简单检索ToolStripMenuItem";
            this.简单检索ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.简单检索ToolStripMenuItem.Text = "简单检索";
            // 
            // 多字段检索ToolStripMenuItem
            // 
            this.多字段检索ToolStripMenuItem.Name = "多字段检索ToolStripMenuItem";
            this.多字段检索ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.多字段检索ToolStripMenuItem.Text = "多字段检索";
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
            this.groupBox_borrowedBooks.Controls.Add(this.label_borrowedBookAmount);
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
            this.columnHeader_number,
            this.columnHeader_title,
            this.columnHeader_author,
            this.columnHeader_publisher,
            this.columnHeader_ISBN,
            this.columnHeader_price,
            this.columnHeader_subject,
            this.columnHeader_TN,
            this.columnHeader_dateOfReturn});
            this.listView_borrowedBooks.HoverSelection = true;
            this.listView_borrowedBooks.Location = new System.Drawing.Point(13, 48);
            this.listView_borrowedBooks.Name = "listView_borrowedBooks";
            this.listView_borrowedBooks.Size = new System.Drawing.Size(752, 256);
            this.listView_borrowedBooks.TabIndex = 1;
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
            // 
            // columnHeader_author
            // 
            this.columnHeader_author.Text = "责任人";
            // 
            // columnHeader_publisher
            // 
            this.columnHeader_publisher.Text = "发行商";
            // 
            // columnHeader_ISBN
            // 
            this.columnHeader_ISBN.Text = "ISBN";
            // 
            // columnHeader_price
            // 
            this.columnHeader_price.Text = "定价";
            // 
            // columnHeader_subject
            // 
            this.columnHeader_subject.Text = "学科主题";
            // 
            // columnHeader_TN
            // 
            this.columnHeader_TN.Text = "中图法分类号";
            this.columnHeader_TN.Width = 89;
            // 
            // columnHeader_dateOfReturn
            // 
            this.columnHeader_dateOfReturn.Text = "归还日期";
            // 
            // label_borrowedBookAmount
            // 
            this.label_borrowedBookAmount.AutoSize = true;
            this.label_borrowedBookAmount.Location = new System.Drawing.Point(11, 21);
            this.label_borrowedBookAmount.Name = "label_borrowedBookAmount";
            this.label_borrowedBookAmount.Size = new System.Drawing.Size(71, 12);
            this.label_borrowedBookAmount.TabIndex = 0;
            this.label_borrowedBookAmount.Text = "已借数量：0";
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
            this.groupBox_borrowedBooks.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem 证件信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 借阅历史ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 预约信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 我的书架ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 书刊遗失ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 读者挂失ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 账目清单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 违章缴款ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 我的书评ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 检索历史ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 书目检索ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 分类浏览ToolStripMenuItem;
        private System.Windows.Forms.Label label_ordered;
        private System.Windows.Forms.Label label_overdue;
        private System.Windows.Forms.Label label_maxOrder;
        private System.Windows.Forms.Label label_maxBorrow;
        private System.Windows.Forms.GroupBox groupBox_borrowedBooks;
        private System.Windows.Forms.ListView listView_borrowedBooks;
        private System.Windows.Forms.ColumnHeader columnHeader_title;
        private System.Windows.Forms.ColumnHeader columnHeader_publisher;
        private System.Windows.Forms.ColumnHeader columnHeader_ISBN;
        private System.Windows.Forms.ColumnHeader columnHeader_price;
        private System.Windows.Forms.ColumnHeader columnHeader_author;
        private System.Windows.Forms.ColumnHeader columnHeader_subject;
        private System.Windows.Forms.ColumnHeader columnHeader_TN;
        private System.Windows.Forms.Label label_borrowedBookAmount;
        private System.Windows.Forms.ToolStripMenuItem 馆藏检索ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 简单检索ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 多字段检索ToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader_number;
        private System.Windows.Forms.ColumnHeader columnHeader_dateOfReturn;
    }
}