namespace BookManagementSystemClient.ChildWindow
{
    partial class Form_bill
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
            this.listView_bill = new System.Windows.Forms.ListView();
            this.columnHeader_billingDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_billingBusiness = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_refund = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_pay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_paymentMode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_proformaInvoiceNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView_bill
            // 
            this.listView_bill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_billingDate,
            this.columnHeader_billingBusiness,
            this.columnHeader_refund,
            this.columnHeader_pay,
            this.columnHeader_paymentMode,
            this.columnHeader_proformaInvoiceNumber});
            this.listView_bill.Location = new System.Drawing.Point(13, 13);
            this.listView_bill.Name = "listView_bill";
            this.listView_bill.Size = new System.Drawing.Size(743, 389);
            this.listView_bill.TabIndex = 0;
            this.listView_bill.UseCompatibleStateImageBehavior = false;
            this.listView_bill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_billingDate
            // 
            this.columnHeader_billingDate.Text = "结算时间";
            this.columnHeader_billingDate.Width = 150;
            // 
            // columnHeader_billingBusiness
            // 
            this.columnHeader_billingBusiness.Text = "结算项目";
            this.columnHeader_billingBusiness.Width = 165;
            // 
            // columnHeader_refund
            // 
            this.columnHeader_refund.Text = "退款";
            this.columnHeader_refund.Width = 91;
            // 
            // columnHeader_pay
            // 
            this.columnHeader_pay.Text = "缴款";
            this.columnHeader_pay.Width = 85;
            // 
            // columnHeader_paymentMode
            // 
            this.columnHeader_paymentMode.Text = "结算方式";
            this.columnHeader_paymentMode.Width = 86;
            // 
            // columnHeader_proformaInvoiceNumber
            // 
            this.columnHeader_proformaInvoiceNumber.Text = "票据号";
            this.columnHeader_proformaInvoiceNumber.Width = 154;
            // 
            // Form_bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 414);
            this.Controls.Add(this.listView_bill);
            this.Name = "Form_bill";
            this.Text = "账目清单";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_bill;
        private System.Windows.Forms.ColumnHeader columnHeader_billingDate;
        private System.Windows.Forms.ColumnHeader columnHeader_billingBusiness;
        private System.Windows.Forms.ColumnHeader columnHeader_refund;
        private System.Windows.Forms.ColumnHeader columnHeader_pay;
        private System.Windows.Forms.ColumnHeader columnHeader_paymentMode;
        private System.Windows.Forms.ColumnHeader columnHeader_proformaInvoiceNumber;
    }
}