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
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label_pleaseInput = new System.Windows.Forms.Label();
            this.textBox_CallNumber = new System.Windows.Forms.TextBox();
            this.button_reserve = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView_orderInformation
            // 
            this.listView_orderInformation.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView_orderInformation.Location = new System.Drawing.Point(13, 71);
            this.listView_orderInformation.Name = "listView_orderInformation";
            this.listView_orderInformation.Size = new System.Drawing.Size(781, 321);
            this.listView_orderInformation.TabIndex = 0;
            this.listView_orderInformation.UseCompatibleStateImageBehavior = false;
            this.listView_orderInformation.View = System.Windows.Forms.View.Details;
            this.listView_orderInformation.ItemActivate += new System.EventHandler(this.listView_orderInformation_ItemActivate);
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "取消预约";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "索书号";
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
            this.columnHeader5.Text = "预订日期";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "预订失效日期";
            this.columnHeader6.Width = 85;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "馆藏地";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "状态";
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
        private System.Windows.Forms.Label label_pleaseInput;
        private System.Windows.Forms.TextBox textBox_CallNumber;
        private System.Windows.Forms.Button button_reserve;
        private System.Windows.Forms.ColumnHeader columnHeader9;
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