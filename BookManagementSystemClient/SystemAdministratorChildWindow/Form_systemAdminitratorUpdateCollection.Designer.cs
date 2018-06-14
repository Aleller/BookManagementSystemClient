namespace BookManagementSystemClient.SystemAdministratorChildWindow
{
    partial class Form_systemAdminitratorUpdateCollection
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBox_status = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_returning = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_holding = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_volume = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_confirm = new System.Windows.Forms.Button();
            this.textBox_barcode = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_callNumberDelete = new System.Windows.Forms.TextBox();
            this.textBox_barcodeDelete = new System.Windows.Forms.TextBox();
            this.button_confirmDelete = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(583, 327);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBox_status);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.textBox_returning);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBox_holding);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBox_volume);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button_confirm);
            this.tabPage1.Controls.Add(this.textBox_barcode);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(575, 301);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "修改馆藏信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBox_status
            // 
            this.comboBox_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_status.FormattingEnabled = true;
            this.comboBox_status.Items.AddRange(new object[] {
            "保留本",
            "可借"});
            this.comboBox_status.Location = new System.Drawing.Point(227, 139);
            this.comboBox_status.Name = "comboBox_status";
            this.comboBox_status.Size = new System.Drawing.Size(286, 20);
            this.comboBox_status.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "还书地：";
            // 
            // textBox_returning
            // 
            this.textBox_returning.Location = new System.Drawing.Point(227, 163);
            this.textBox_returning.Name = "textBox_returning";
            this.textBox_returning.Size = new System.Drawing.Size(286, 21);
            this.textBox_returning.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "状态：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "馆藏地：";
            // 
            // textBox_holding
            // 
            this.textBox_holding.Location = new System.Drawing.Point(227, 109);
            this.textBox_holding.Name = "textBox_holding";
            this.textBox_holding.Size = new System.Drawing.Size(286, 21);
            this.textBox_holding.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "年卷数：";
            // 
            // textBox_volume
            // 
            this.textBox_volume.Location = new System.Drawing.Point(227, 82);
            this.textBox_volume.Name = "textBox_volume";
            this.textBox_volume.Size = new System.Drawing.Size(286, 21);
            this.textBox_volume.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "要修改的图书的条形码：";
            // 
            // button_confirm
            // 
            this.button_confirm.Location = new System.Drawing.Point(438, 199);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(75, 23);
            this.button_confirm.TabIndex = 1;
            this.button_confirm.Text = "确定";
            this.button_confirm.UseVisualStyleBackColor = true;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // textBox_barcode
            // 
            this.textBox_barcode.Location = new System.Drawing.Point(227, 55);
            this.textBox_barcode.Name = "textBox_barcode";
            this.textBox_barcode.Size = new System.Drawing.Size(286, 21);
            this.textBox_barcode.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button_confirmDelete);
            this.tabPage2.Controls.Add(this.textBox_barcodeDelete);
            this.tabPage2.Controls.Add(this.textBox_callNumberDelete);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(575, 301);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "删除馆藏信息";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(90, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "请输入要删除的书本的索书号：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(90, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "条形码：";
            // 
            // textBox_callNumberDelete
            // 
            this.textBox_callNumberDelete.Location = new System.Drawing.Point(270, 40);
            this.textBox_callNumberDelete.Name = "textBox_callNumberDelete";
            this.textBox_callNumberDelete.Size = new System.Drawing.Size(201, 21);
            this.textBox_callNumberDelete.TabIndex = 2;
            // 
            // textBox_barcodeDelete
            // 
            this.textBox_barcodeDelete.Location = new System.Drawing.Point(270, 70);
            this.textBox_barcodeDelete.Name = "textBox_barcodeDelete";
            this.textBox_barcodeDelete.Size = new System.Drawing.Size(201, 21);
            this.textBox_barcodeDelete.TabIndex = 3;
            // 
            // button_confirmDelete
            // 
            this.button_confirmDelete.Location = new System.Drawing.Point(396, 127);
            this.button_confirmDelete.Name = "button_confirmDelete";
            this.button_confirmDelete.Size = new System.Drawing.Size(75, 23);
            this.button_confirmDelete.TabIndex = 4;
            this.button_confirmDelete.Text = "删除";
            this.button_confirmDelete.UseVisualStyleBackColor = true;
            this.button_confirmDelete.Click += new System.EventHandler(this.button_confirmDelete_Click);
            // 
            // Form_systemAdminitratorUpdateCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 352);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form_systemAdminitratorUpdateCollection";
            this.Text = "系统管理员-修改馆藏信息";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.TextBox textBox_barcode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_returning;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_holding;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_volume;
        private System.Windows.Forms.ComboBox comboBox_status;
        private System.Windows.Forms.Button button_confirmDelete;
        private System.Windows.Forms.TextBox textBox_barcodeDelete;
        private System.Windows.Forms.TextBox textBox_callNumberDelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}