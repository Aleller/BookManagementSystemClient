namespace BookManagementSystemClient.SystemAdministratorChildWindow
{
    partial class Form_systemAdministratorRetrieveReader
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
            this.label_retrieveStudentID = new System.Windows.Forms.Label();
            this.textBox_studentID = new System.Windows.Forms.TextBox();
            this.button_confirm = new System.Windows.Forms.Button();
            this.listView_reader = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label_retrieveStudentID
            // 
            this.label_retrieveStudentID.AutoSize = true;
            this.label_retrieveStudentID.Location = new System.Drawing.Point(105, 22);
            this.label_retrieveStudentID.Name = "label_retrieveStudentID";
            this.label_retrieveStudentID.Size = new System.Drawing.Size(65, 12);
            this.label_retrieveStudentID.TabIndex = 0;
            this.label_retrieveStudentID.Text = "读者学号：";
            // 
            // textBox_studentID
            // 
            this.textBox_studentID.Location = new System.Drawing.Point(184, 19);
            this.textBox_studentID.Name = "textBox_studentID";
            this.textBox_studentID.Size = new System.Drawing.Size(150, 21);
            this.textBox_studentID.TabIndex = 1;
            // 
            // button_confirm
            // 
            this.button_confirm.Location = new System.Drawing.Point(363, 17);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(75, 23);
            this.button_confirm.TabIndex = 2;
            this.button_confirm.Text = "查询";
            this.button_confirm.UseVisualStyleBackColor = true;
            // 
            // listView_reader
            // 
            this.listView_reader.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView_reader.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView_reader.HoverSelection = true;
            this.listView_reader.Location = new System.Drawing.Point(12, 53);
            this.listView_reader.Name = "listView_reader";
            this.listView_reader.Size = new System.Drawing.Size(511, 244);
            this.listView_reader.TabIndex = 5;
            this.listView_reader.UseCompatibleStateImageBehavior = false;
            this.listView_reader.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "学号";
            this.columnHeader1.Width = 91;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "最多可借数量";
            this.columnHeader2.Width = 81;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "最多可预约数量";
            this.columnHeader3.Width = 91;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "已借阅数量";
            this.columnHeader4.Width = 91;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "已预约数量";
            this.columnHeader5.Width = 79;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "超期数量";
            // 
            // Form_retrieveReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 309);
            this.Controls.Add(this.listView_reader);
            this.Controls.Add(this.button_confirm);
            this.Controls.Add(this.textBox_studentID);
            this.Controls.Add(this.label_retrieveStudentID);
            this.Name = "Form_retrieveReader";
            this.Text = "系统管理员-查询读者";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_retrieveStudentID;
        private System.Windows.Forms.TextBox textBox_studentID;
        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.ListView listView_reader;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}