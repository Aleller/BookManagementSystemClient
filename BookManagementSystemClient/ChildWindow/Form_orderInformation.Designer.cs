namespace BookManagementSystemClient.ChildWindow
{
    partial class Form_orderInformation
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
            this.listView_orderInformation = new System.Windows.Forms.ListView();
            this.columnHeader_TN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_titleAndAuthor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_position = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_orderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_expirationDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_takeBookPosition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_cancel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label_pleaseInput = new System.Windows.Forms.Label();
            this.textBox_CallNumber = new System.Windows.Forms.TextBox();
            this.button_reserve = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView_orderInformation
            // 
            this.listView_orderInformation.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_TN,
            this.columnHeader_titleAndAuthor,
            this.columnHeader_position,
            this.columnHeader_orderDate,
            this.columnHeader_expirationDate,
            this.columnHeader_takeBookPosition,
            this.columnHeader_status,
            this.columnHeader_cancel});
            this.listView_orderInformation.Location = new System.Drawing.Point(13, 85);
            this.listView_orderInformation.Name = "listView_orderInformation";
            this.listView_orderInformation.Size = new System.Drawing.Size(781, 307);
            this.listView_orderInformation.TabIndex = 0;
            this.listView_orderInformation.UseCompatibleStateImageBehavior = false;
            this.listView_orderInformation.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_TN
            // 
            this.columnHeader_TN.Text = "TN/索书号";
            this.columnHeader_TN.Width = 88;
            // 
            // columnHeader_titleAndAuthor
            // 
            this.columnHeader_titleAndAuthor.Text = "题名/责任者";
            this.columnHeader_titleAndAuthor.Width = 128;
            // 
            // columnHeader_position
            // 
            this.columnHeader_position.Text = "馆藏地";
            this.columnHeader_position.Width = 97;
            // 
            // columnHeader_orderDate
            // 
            this.columnHeader_orderDate.Text = "预约(到)书日";
            this.columnHeader_orderDate.Width = 105;
            // 
            // columnHeader_expirationDate
            // 
            this.columnHeader_expirationDate.Text = "截止日期";
            this.columnHeader_expirationDate.Width = 89;
            // 
            // columnHeader_takeBookPosition
            // 
            this.columnHeader_takeBookPosition.Text = "取书地";
            this.columnHeader_takeBookPosition.Width = 87;
            // 
            // columnHeader_status
            // 
            this.columnHeader_status.Text = "状态";
            this.columnHeader_status.Width = 113;
            // 
            // columnHeader_cancel
            // 
            this.columnHeader_cancel.Text = "取消预约";
            // 
            // label_pleaseInput
            // 
            this.label_pleaseInput.AutoSize = true;
            this.label_pleaseInput.Location = new System.Drawing.Point(78, 27);
            this.label_pleaseInput.Name = "label_pleaseInput";
            this.label_pleaseInput.Size = new System.Drawing.Size(173, 12);
            this.label_pleaseInput.TabIndex = 1;
            this.label_pleaseInput.Text = "请输入要预约的图书的索书号：";
            // 
            // textBox_CallNumber
            // 
            this.textBox_CallNumber.Location = new System.Drawing.Point(292, 24);
            this.textBox_CallNumber.Name = "textBox_CallNumber";
            this.textBox_CallNumber.Size = new System.Drawing.Size(179, 21);
            this.textBox_CallNumber.TabIndex = 2;
            // 
            // button_reserve
            // 
            this.button_reserve.Location = new System.Drawing.Point(530, 21);
            this.button_reserve.Name = "button_reserve";
            this.button_reserve.Size = new System.Drawing.Size(75, 23);
            this.button_reserve.TabIndex = 3;
            this.button_reserve.Text = "预约";
            this.button_reserve.UseVisualStyleBackColor = true;
            this.button_reserve.Click += new System.EventHandler(this.button_reserve_Click);
            // 
            // Form_orderInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 404);
            this.Controls.Add(this.button_reserve);
            this.Controls.Add(this.textBox_CallNumber);
            this.Controls.Add(this.label_pleaseInput);
            this.Controls.Add(this.listView_orderInformation);
            this.Name = "Form_orderInformation";
            this.Text = "预约信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_orderInformation;
        private System.Windows.Forms.ColumnHeader columnHeader_TN;
        private System.Windows.Forms.ColumnHeader columnHeader_titleAndAuthor;
        private System.Windows.Forms.ColumnHeader columnHeader_position;
        private System.Windows.Forms.ColumnHeader columnHeader_orderDate;
        private System.Windows.Forms.ColumnHeader columnHeader_expirationDate;
        private System.Windows.Forms.ColumnHeader columnHeader_takeBookPosition;
        private System.Windows.Forms.ColumnHeader columnHeader_status;
        private System.Windows.Forms.ColumnHeader columnHeader_cancel;
        private System.Windows.Forms.Label label_pleaseInput;
        private System.Windows.Forms.TextBox textBox_CallNumber;
        private System.Windows.Forms.Button button_reserve;
    }
}