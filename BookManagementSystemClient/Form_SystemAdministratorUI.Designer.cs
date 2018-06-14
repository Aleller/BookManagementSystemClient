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
            this.button_updateBook = new System.Windows.Forms.Button();
            this.button_retrieveBook = new System.Windows.Forms.Button();
            this.button_deleteBook = new System.Windows.Forms.Button();
            this.button_addBook = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl_systemAdministratorUI.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_systemAdministratorUI
            // 
            this.tabControl_systemAdministratorUI.Controls.Add(this.tabPage1);
            this.tabControl_systemAdministratorUI.Controls.Add(this.tabPage3);
            this.tabControl_systemAdministratorUI.Location = new System.Drawing.Point(13, 13);
            this.tabControl_systemAdministratorUI.Name = "tabControl_systemAdministratorUI";
            this.tabControl_systemAdministratorUI.SelectedIndex = 0;
            this.tabControl_systemAdministratorUI.Size = new System.Drawing.Size(689, 440);
            this.tabControl_systemAdministratorUI.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button_updateBook);
            this.tabPage1.Controls.Add(this.button_retrieveBook);
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
            // button_retrieveBook
            // 
            this.button_retrieveBook.Location = new System.Drawing.Point(79, 224);
            this.button_retrieveBook.Name = "button_retrieveBook";
            this.button_retrieveBook.Size = new System.Drawing.Size(223, 90);
            this.button_retrieveBook.TabIndex = 2;
            this.button_retrieveBook.Text = "查询图书";
            this.button_retrieveBook.UseVisualStyleBackColor = true;
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
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(681, 414);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "图书管理员信息管理";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_systemAdministratorUI;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button_updateBook;
        private System.Windows.Forms.Button button_retrieveBook;
        private System.Windows.Forms.Button button_deleteBook;
        private System.Windows.Forms.Button button_addBook;
        private System.Windows.Forms.TabPage tabPage3;
    }
}