namespace BookManagementSystemClient.ChildWindow
{
    partial class Form_queryHistory
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
            this.button_delete = new System.Windows.Forms.Button();
            this.listView_queryHistory = new System.Windows.Forms.ListView();
            this.columnHeader_content = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(13, 13);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(99, 23);
            this.button_delete.TabIndex = 0;
            this.button_delete.Text = "删除选中记录";
            this.button_delete.UseVisualStyleBackColor = true;
            // 
            // listView_queryHistory
            // 
            this.listView_queryHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_content,
            this.columnHeader_date});
            this.listView_queryHistory.Location = new System.Drawing.Point(13, 43);
            this.listView_queryHistory.Name = "listView_queryHistory";
            this.listView_queryHistory.Size = new System.Drawing.Size(686, 339);
            this.listView_queryHistory.TabIndex = 1;
            this.listView_queryHistory.UseCompatibleStateImageBehavior = false;
            this.listView_queryHistory.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_content
            // 
            this.columnHeader_content.Text = "检索内容";
            this.columnHeader_content.Width = 444;
            // 
            // columnHeader_date
            // 
            this.columnHeader_date.Text = "检索时间";
            this.columnHeader_date.Width = 227;
            // 
            // Form_queryHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 394);
            this.Controls.Add(this.listView_queryHistory);
            this.Controls.Add(this.button_delete);
            this.Name = "Form_queryHistory";
            this.Text = "查询历史";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.ListView listView_queryHistory;
        private System.Windows.Forms.ColumnHeader columnHeader_content;
        private System.Windows.Forms.ColumnHeader columnHeader_date;
    }
}