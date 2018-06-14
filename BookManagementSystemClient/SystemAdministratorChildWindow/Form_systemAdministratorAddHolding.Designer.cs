namespace BookManagementSystemClient.SystemAdministratorChildWindow
{
    partial class Form_systemAdministratorAddHolding
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
            this.label_barcode = new System.Windows.Forms.Label();
            this.label_callNumber = new System.Windows.Forms.Label();
            this.textBox_barcode = new System.Windows.Forms.TextBox();
            this.textBox_callNumber = new System.Windows.Forms.TextBox();
            this.button_confirm = new System.Windows.Forms.Button();
            this.label_marcNo = new System.Windows.Forms.Label();
            this.textBox_marcNo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_barcode
            // 
            this.label_barcode.AutoSize = true;
            this.label_barcode.Location = new System.Drawing.Point(21, 91);
            this.label_barcode.Name = "label_barcode";
            this.label_barcode.Size = new System.Drawing.Size(53, 12);
            this.label_barcode.TabIndex = 26;
            this.label_barcode.Text = "条形码：";
            // 
            // label_callNumber
            // 
            this.label_callNumber.AutoSize = true;
            this.label_callNumber.Location = new System.Drawing.Point(21, 63);
            this.label_callNumber.Name = "label_callNumber";
            this.label_callNumber.Size = new System.Drawing.Size(53, 12);
            this.label_callNumber.TabIndex = 25;
            this.label_callNumber.Text = "索书号：";
            // 
            // textBox_barcode
            // 
            this.textBox_barcode.Location = new System.Drawing.Point(114, 88);
            this.textBox_barcode.Name = "textBox_barcode";
            this.textBox_barcode.Size = new System.Drawing.Size(464, 21);
            this.textBox_barcode.TabIndex = 24;
            // 
            // textBox_callNumber
            // 
            this.textBox_callNumber.Location = new System.Drawing.Point(114, 60);
            this.textBox_callNumber.Name = "textBox_callNumber";
            this.textBox_callNumber.Size = new System.Drawing.Size(464, 21);
            this.textBox_callNumber.TabIndex = 23;
            // 
            // button_confirm
            // 
            this.button_confirm.Location = new System.Drawing.Point(503, 144);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(75, 23);
            this.button_confirm.TabIndex = 27;
            this.button_confirm.Text = "确定";
            this.button_confirm.UseVisualStyleBackColor = true;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // label_marcNo
            // 
            this.label_marcNo.AutoSize = true;
            this.label_marcNo.Location = new System.Drawing.Point(21, 36);
            this.label_marcNo.Name = "label_marcNo";
            this.label_marcNo.Size = new System.Drawing.Size(77, 12);
            this.label_marcNo.TabIndex = 28;
            this.label_marcNo.Text = "唯一标识码：";
            // 
            // textBox_marcNo
            // 
            this.textBox_marcNo.Location = new System.Drawing.Point(114, 33);
            this.textBox_marcNo.Name = "textBox_marcNo";
            this.textBox_marcNo.Size = new System.Drawing.Size(464, 21);
            this.textBox_marcNo.TabIndex = 29;
            // 
            // Form_systemAdministratorAddHolding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 186);
            this.Controls.Add(this.textBox_marcNo);
            this.Controls.Add(this.label_marcNo);
            this.Controls.Add(this.button_confirm);
            this.Controls.Add(this.label_barcode);
            this.Controls.Add(this.label_callNumber);
            this.Controls.Add(this.textBox_barcode);
            this.Controls.Add(this.textBox_callNumber);
            this.Name = "Form_systemAdministratorAddHolding";
            this.Text = "添加馆藏信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_barcode;
        private System.Windows.Forms.Label label_callNumber;
        private System.Windows.Forms.TextBox textBox_barcode;
        private System.Windows.Forms.TextBox textBox_callNumber;
        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.Label label_marcNo;
        private System.Windows.Forms.TextBox textBox_marcNo;
    }
}