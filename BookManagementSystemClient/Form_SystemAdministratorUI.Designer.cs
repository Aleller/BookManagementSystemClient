namespace BookManagementSystemClient
{
    partial class Form_SystemAdministratorUI
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
            this.tabControl_systemAdministratorUI = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button_updateCollection = new System.Windows.Forms.Button();
            this.button_updateBook = new System.Windows.Forms.Button();
            this.button_deleteBook = new System.Windows.Forms.Button();
            this.button_addBook = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_release = new System.Windows.Forms.Button();
            this.textBox_announcement = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button_confirm = new System.Windows.Forms.Button();
            this.textBox_newKey2 = new System.Windows.Forms.TextBox();
            this.textBox_newKey1 = new System.Windows.Forms.TextBox();
            this.textBox_oldKey = new System.Windows.Forms.TextBox();
            this.label_newKey2 = new System.Windows.Forms.Label();
            this.label_newKey1 = new System.Windows.Forms.Label();
            this.label_oldKey = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label_marcNo = new System.Windows.Forms.Label();
            this.textBox_marcNo = new System.Windows.Forms.TextBox();
            this.button_confirmLend = new System.Windows.Forms.Button();
            this.textBox_barcode = new System.Windows.Forms.TextBox();
            this.textBox_studentID = new System.Windows.Forms.TextBox();
            this.label_barcode = new System.Windows.Forms.Label();
            this.label_studentID = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label_marcNoReturn = new System.Windows.Forms.Label();
            this.textBox_marcNoReturn = new System.Windows.Forms.TextBox();
            this.button_confirmReturn = new System.Windows.Forms.Button();
            this.textBox_barcodeReturn = new System.Windows.Forms.TextBox();
            this.textBox_studendIDReturn = new System.Windows.Forms.TextBox();
            this.label_barcodeReturn = new System.Windows.Forms.Label();
            this.label_studentIDReturn = new System.Windows.Forms.Label();
            this.tabControl_systemAdministratorUI.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_systemAdministratorUI
            // 
            this.tabControl_systemAdministratorUI.Controls.Add(this.tabPage1);
            this.tabControl_systemAdministratorUI.Controls.Add(this.tabPage2);
            this.tabControl_systemAdministratorUI.Controls.Add(this.tabPage3);
            this.tabControl_systemAdministratorUI.Controls.Add(this.tabPage4);
            this.tabControl_systemAdministratorUI.Controls.Add(this.tabPage5);
            this.tabControl_systemAdministratorUI.Location = new System.Drawing.Point(13, 13);
            this.tabControl_systemAdministratorUI.Name = "tabControl_systemAdministratorUI";
            this.tabControl_systemAdministratorUI.SelectedIndex = 0;
            this.tabControl_systemAdministratorUI.Size = new System.Drawing.Size(689, 440);
            this.tabControl_systemAdministratorUI.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button_updateCollection);
            this.tabPage1.Controls.Add(this.button_updateBook);
            this.tabPage1.Controls.Add(this.button_deleteBook);
            this.tabPage1.Controls.Add(this.button_addBook);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(681, 414);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "图书管理";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button_updateCollection
            // 
            this.button_updateCollection.Location = new System.Drawing.Point(79, 224);
            this.button_updateCollection.Name = "button_updateCollection";
            this.button_updateCollection.Size = new System.Drawing.Size(223, 90);
            this.button_updateCollection.TabIndex = 4;
            this.button_updateCollection.Text = "编辑馆藏信息";
            this.button_updateCollection.UseVisualStyleBackColor = true;
            this.button_updateCollection.Click += new System.EventHandler(this.button_updateCollection_Click);
            // 
            // button_updateBook
            // 
            this.button_updateBook.Location = new System.Drawing.Point(378, 224);
            this.button_updateBook.Name = "button_updateBook";
            this.button_updateBook.Size = new System.Drawing.Size(223, 90);
            this.button_updateBook.TabIndex = 3;
            this.button_updateBook.Text = "修改图书";
            this.button_updateBook.UseVisualStyleBackColor = true;
            this.button_updateBook.Click += new System.EventHandler(this.button_updateBook_Click);
            // 
            // button_deleteBook
            // 
            this.button_deleteBook.Location = new System.Drawing.Point(378, 98);
            this.button_deleteBook.Name = "button_deleteBook";
            this.button_deleteBook.Size = new System.Drawing.Size(223, 90);
            this.button_deleteBook.TabIndex = 1;
            this.button_deleteBook.Text = "删除图书";
            this.button_deleteBook.UseVisualStyleBackColor = true;
            this.button_deleteBook.Click += new System.EventHandler(this.button_deleteBook_Click);
            // 
            // button_addBook
            // 
            this.button_addBook.Location = new System.Drawing.Point(79, 98);
            this.button_addBook.Name = "button_addBook";
            this.button_addBook.Size = new System.Drawing.Size(223, 90);
            this.button_addBook.TabIndex = 0;
            this.button_addBook.Text = "添加图书";
            this.button_addBook.UseVisualStyleBackColor = true;
            this.button_addBook.Click += new System.EventHandler(this.button_addBook_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button_release);
            this.tabPage2.Controls.Add(this.textBox_announcement);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(681, 414);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "发布公告";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button_release
            // 
            this.button_release.Location = new System.Drawing.Point(548, 315);
            this.button_release.Name = "button_release";
            this.button_release.Size = new System.Drawing.Size(75, 23);
            this.button_release.TabIndex = 1;
            this.button_release.Text = "发布";
            this.button_release.UseVisualStyleBackColor = true;
            this.button_release.Click += new System.EventHandler(this.button_release_Click);
            // 
            // textBox_announcement
            // 
            this.textBox_announcement.Location = new System.Drawing.Point(50, 32);
            this.textBox_announcement.Multiline = true;
            this.textBox_announcement.Name = "textBox_announcement";
            this.textBox_announcement.Size = new System.Drawing.Size(573, 254);
            this.textBox_announcement.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button_confirm);
            this.tabPage3.Controls.Add(this.textBox_newKey2);
            this.tabPage3.Controls.Add(this.textBox_newKey1);
            this.tabPage3.Controls.Add(this.textBox_oldKey);
            this.tabPage3.Controls.Add(this.label_newKey2);
            this.tabPage3.Controls.Add(this.label_newKey1);
            this.tabPage3.Controls.Add(this.label_oldKey);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(681, 414);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "修改管理员验证码";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button_confirm
            // 
            this.button_confirm.Location = new System.Drawing.Point(458, 129);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(75, 23);
            this.button_confirm.TabIndex = 6;
            this.button_confirm.Text = "确定";
            this.button_confirm.UseVisualStyleBackColor = true;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // textBox_newKey2
            // 
            this.textBox_newKey2.Location = new System.Drawing.Point(241, 86);
            this.textBox_newKey2.Name = "textBox_newKey2";
            this.textBox_newKey2.Size = new System.Drawing.Size(292, 21);
            this.textBox_newKey2.TabIndex = 5;
            // 
            // textBox_newKey1
            // 
            this.textBox_newKey1.Location = new System.Drawing.Point(241, 59);
            this.textBox_newKey1.Name = "textBox_newKey1";
            this.textBox_newKey1.Size = new System.Drawing.Size(292, 21);
            this.textBox_newKey1.TabIndex = 4;
            // 
            // textBox_oldKey
            // 
            this.textBox_oldKey.Location = new System.Drawing.Point(241, 32);
            this.textBox_oldKey.Name = "textBox_oldKey";
            this.textBox_oldKey.Size = new System.Drawing.Size(292, 21);
            this.textBox_oldKey.TabIndex = 3;
            // 
            // label_newKey2
            // 
            this.label_newKey2.AutoSize = true;
            this.label_newKey2.Location = new System.Drawing.Point(145, 89);
            this.label_newKey2.Name = "label_newKey2";
            this.label_newKey2.Size = new System.Drawing.Size(89, 12);
            this.label_newKey2.TabIndex = 2;
            this.label_newKey2.Text = "重复新验证码：";
            // 
            // label_newKey1
            // 
            this.label_newKey1.AutoSize = true;
            this.label_newKey1.Location = new System.Drawing.Point(145, 62);
            this.label_newKey1.Name = "label_newKey1";
            this.label_newKey1.Size = new System.Drawing.Size(89, 12);
            this.label_newKey1.TabIndex = 1;
            this.label_newKey1.Text = "输入新验证码：";
            // 
            // label_oldKey
            // 
            this.label_oldKey.AutoSize = true;
            this.label_oldKey.Location = new System.Drawing.Point(145, 35);
            this.label_oldKey.Name = "label_oldKey";
            this.label_oldKey.Size = new System.Drawing.Size(89, 12);
            this.label_oldKey.TabIndex = 0;
            this.label_oldKey.Text = "输入原验证码：";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label_marcNo);
            this.tabPage4.Controls.Add(this.textBox_marcNo);
            this.tabPage4.Controls.Add(this.button_confirmLend);
            this.tabPage4.Controls.Add(this.textBox_barcode);
            this.tabPage4.Controls.Add(this.textBox_studentID);
            this.tabPage4.Controls.Add(this.label_barcode);
            this.tabPage4.Controls.Add(this.label_studentID);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(681, 414);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "借书";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label_marcNo
            // 
            this.label_marcNo.AutoSize = true;
            this.label_marcNo.Location = new System.Drawing.Point(134, 73);
            this.label_marcNo.Name = "label_marcNo";
            this.label_marcNo.Size = new System.Drawing.Size(101, 12);
            this.label_marcNo.TabIndex = 6;
            this.label_marcNo.Text = "书本唯一标识码：";
            // 
            // textBox_marcNo
            // 
            this.textBox_marcNo.Location = new System.Drawing.Point(243, 70);
            this.textBox_marcNo.Name = "textBox_marcNo";
            this.textBox_marcNo.Size = new System.Drawing.Size(283, 21);
            this.textBox_marcNo.TabIndex = 5;
            // 
            // button_confirmLend
            // 
            this.button_confirmLend.Location = new System.Drawing.Point(451, 149);
            this.button_confirmLend.Name = "button_confirmLend";
            this.button_confirmLend.Size = new System.Drawing.Size(75, 23);
            this.button_confirmLend.TabIndex = 4;
            this.button_confirmLend.Text = "借出";
            this.button_confirmLend.UseVisualStyleBackColor = true;
            this.button_confirmLend.Click += new System.EventHandler(this.button_confirmLend_Click);
            // 
            // textBox_barcode
            // 
            this.textBox_barcode.Location = new System.Drawing.Point(243, 97);
            this.textBox_barcode.Name = "textBox_barcode";
            this.textBox_barcode.Size = new System.Drawing.Size(283, 21);
            this.textBox_barcode.TabIndex = 3;
            // 
            // textBox_studentID
            // 
            this.textBox_studentID.Location = new System.Drawing.Point(243, 42);
            this.textBox_studentID.Name = "textBox_studentID";
            this.textBox_studentID.Size = new System.Drawing.Size(283, 21);
            this.textBox_studentID.TabIndex = 2;
            // 
            // label_barcode
            // 
            this.label_barcode.AutoSize = true;
            this.label_barcode.Location = new System.Drawing.Point(134, 100);
            this.label_barcode.Name = "label_barcode";
            this.label_barcode.Size = new System.Drawing.Size(77, 12);
            this.label_barcode.TabIndex = 1;
            this.label_barcode.Text = "书本条形码：";
            // 
            // label_studentID
            // 
            this.label_studentID.AutoSize = true;
            this.label_studentID.Location = new System.Drawing.Point(134, 45);
            this.label_studentID.Name = "label_studentID";
            this.label_studentID.Size = new System.Drawing.Size(65, 12);
            this.label_studentID.TabIndex = 0;
            this.label_studentID.Text = "学生学号：";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label_marcNoReturn);
            this.tabPage5.Controls.Add(this.textBox_marcNoReturn);
            this.tabPage5.Controls.Add(this.button_confirmReturn);
            this.tabPage5.Controls.Add(this.textBox_barcodeReturn);
            this.tabPage5.Controls.Add(this.textBox_studendIDReturn);
            this.tabPage5.Controls.Add(this.label_barcodeReturn);
            this.tabPage5.Controls.Add(this.label_studentIDReturn);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(681, 414);
            this.tabPage5.TabIndex = 5;
            this.tabPage5.Text = "还书";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label_marcNoReturn
            // 
            this.label_marcNoReturn.AutoSize = true;
            this.label_marcNoReturn.Location = new System.Drawing.Point(123, 81);
            this.label_marcNoReturn.Name = "label_marcNoReturn";
            this.label_marcNoReturn.Size = new System.Drawing.Size(101, 12);
            this.label_marcNoReturn.TabIndex = 13;
            this.label_marcNoReturn.Text = "书本唯一标识码：";
            // 
            // textBox_marcNoReturn
            // 
            this.textBox_marcNoReturn.Location = new System.Drawing.Point(232, 78);
            this.textBox_marcNoReturn.Name = "textBox_marcNoReturn";
            this.textBox_marcNoReturn.Size = new System.Drawing.Size(283, 21);
            this.textBox_marcNoReturn.TabIndex = 12;
            // 
            // button_confirmReturn
            // 
            this.button_confirmReturn.Location = new System.Drawing.Point(440, 157);
            this.button_confirmReturn.Name = "button_confirmReturn";
            this.button_confirmReturn.Size = new System.Drawing.Size(75, 23);
            this.button_confirmReturn.TabIndex = 11;
            this.button_confirmReturn.Text = "还书";
            this.button_confirmReturn.UseVisualStyleBackColor = true;
            // 
            // textBox_barcodeReturn
            // 
            this.textBox_barcodeReturn.Location = new System.Drawing.Point(232, 105);
            this.textBox_barcodeReturn.Name = "textBox_barcodeReturn";
            this.textBox_barcodeReturn.Size = new System.Drawing.Size(283, 21);
            this.textBox_barcodeReturn.TabIndex = 10;
            // 
            // textBox_studendIDReturn
            // 
            this.textBox_studendIDReturn.Location = new System.Drawing.Point(232, 50);
            this.textBox_studendIDReturn.Name = "textBox_studendIDReturn";
            this.textBox_studendIDReturn.Size = new System.Drawing.Size(283, 21);
            this.textBox_studendIDReturn.TabIndex = 9;
            // 
            // label_barcodeReturn
            // 
            this.label_barcodeReturn.AutoSize = true;
            this.label_barcodeReturn.Location = new System.Drawing.Point(123, 108);
            this.label_barcodeReturn.Name = "label_barcodeReturn";
            this.label_barcodeReturn.Size = new System.Drawing.Size(77, 12);
            this.label_barcodeReturn.TabIndex = 8;
            this.label_barcodeReturn.Text = "书本条形码：";
            // 
            // label_studentIDReturn
            // 
            this.label_studentIDReturn.AutoSize = true;
            this.label_studentIDReturn.Location = new System.Drawing.Point(123, 53);
            this.label_studentIDReturn.Name = "label_studentIDReturn";
            this.label_studentIDReturn.Size = new System.Drawing.Size(65, 12);
            this.label_studentIDReturn.TabIndex = 7;
            this.label_studentIDReturn.Text = "学生学号：";
            // 
            // Form_SystemAdministratorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 465);
            this.Controls.Add(this.tabControl_systemAdministratorUI);
            this.Name = "Form_SystemAdministratorUI";
            this.Text = "图书管理系统-系统管理员";
            this.tabControl_systemAdministratorUI.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_systemAdministratorUI;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button_updateBook;
        private System.Windows.Forms.Button button_deleteBook;
        private System.Windows.Forms.Button button_addBook;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.TextBox textBox_newKey2;
        private System.Windows.Forms.TextBox textBox_newKey1;
        private System.Windows.Forms.TextBox textBox_oldKey;
        private System.Windows.Forms.Label label_newKey2;
        private System.Windows.Forms.Label label_newKey1;
        private System.Windows.Forms.Label label_oldKey;
        private System.Windows.Forms.TextBox textBox_announcement;
        private System.Windows.Forms.Button button_release;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button_confirmLend;
        private System.Windows.Forms.TextBox textBox_barcode;
        private System.Windows.Forms.TextBox textBox_studentID;
        private System.Windows.Forms.Label label_barcode;
        private System.Windows.Forms.Label label_studentID;
        private System.Windows.Forms.Label label_marcNo;
        private System.Windows.Forms.TextBox textBox_marcNo;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label_marcNoReturn;
        private System.Windows.Forms.TextBox textBox_marcNoReturn;
        private System.Windows.Forms.Button button_confirmReturn;
        private System.Windows.Forms.TextBox textBox_barcodeReturn;
        private System.Windows.Forms.TextBox textBox_studendIDReturn;
        private System.Windows.Forms.Label label_barcodeReturn;
        private System.Windows.Forms.Label label_studentIDReturn;
        private System.Windows.Forms.Button button_updateCollection;
    }
}