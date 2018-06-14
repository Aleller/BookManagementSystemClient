namespace BookManagementSystemClient.ChildWindow
{
    partial class Form_reserveBooks
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
            this.listView_holdingInformation = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView_holdingInformation
            // 
            this.listView_holdingInformation.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView_holdingInformation.GridLines = true;
            this.listView_holdingInformation.Location = new System.Drawing.Point(13, 13);
            this.listView_holdingInformation.Name = "listView_holdingInformation";
            this.listView_holdingInformation.Size = new System.Drawing.Size(596, 309);
            this.listView_holdingInformation.TabIndex = 0;
            this.listView_holdingInformation.UseCompatibleStateImageBehavior = false;
            this.listView_holdingInformation.View = System.Windows.Forms.View.Details;
            this.listView_holdingInformation.ItemActivate += new System.EventHandler(this.listView_holdingInformation_ItemActivate);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "点击预约";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "唯一标识码";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "索书号";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "条形码";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "卷";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "馆藏地";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "状态";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "归还地点";
            // 
            // Form_reserveBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 334);
            this.Controls.Add(this.listView_holdingInformation);
            this.Name = "Form_reserveBooks";
            this.Text = "预订图书";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_holdingInformation;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}