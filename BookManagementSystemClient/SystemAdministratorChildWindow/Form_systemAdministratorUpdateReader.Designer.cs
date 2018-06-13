namespace BookManagementSystemClient.SystemAdministratorChildWindow
{
    partial class Form_systemAdministratorUpdateReader
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
            this.label_please = new System.Windows.Forms.Label();
            this.textBox_searchStudentID = new System.Windows.Forms.TextBox();
            this.button_searchConfirm = new System.Windows.Forms.Button();
            this.label_Password = new System.Windows.Forms.Label();
            this.label_MaxBorrow = new System.Windows.Forms.Label();
            this.label_MaxReserve = new System.Windows.Forms.Label();
            this.label_HasBorrowed = new System.Windows.Forms.Label();
            this.label_HasReserved = new System.Windows.Forms.Label();
            this.label_OverDue = new System.Windows.Forms.Label();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.textBox_MaxBorrow = new System.Windows.Forms.TextBox();
            this.textBox_MaxReserve = new System.Windows.Forms.TextBox();
            this.textBox_HasBorrowed = new System.Windows.Forms.TextBox();
            this.textBox_HasReserved = new System.Windows.Forms.TextBox();
            this.textBox_OverDue = new System.Windows.Forms.TextBox();
            this.button_confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_please
            // 
            this.label_please.AutoSize = true;
            this.label_please.Location = new System.Drawing.Point(166, 18);
            this.label_please.Name = "label_please";
            this.label_please.Size = new System.Drawing.Size(185, 12);
            this.label_please.TabIndex = 0;
            this.label_please.Text = "请先输入需要修改的读者的学号：";
            // 
            // textBox_searchStudentID
            // 
            this.textBox_searchStudentID.Location = new System.Drawing.Point(66, 43);
            this.textBox_searchStudentID.Name = "textBox_searchStudentID";
            this.textBox_searchStudentID.Size = new System.Drawing.Size(285, 21);
            this.textBox_searchStudentID.TabIndex = 1;
            // 
            // button_searchConfirm
            // 
            this.button_searchConfirm.Location = new System.Drawing.Point(391, 41);
            this.button_searchConfirm.Name = "button_searchConfirm";
            this.button_searchConfirm.Size = new System.Drawing.Size(75, 23);
            this.button_searchConfirm.TabIndex = 2;
            this.button_searchConfirm.Text = "查询";
            this.button_searchConfirm.UseVisualStyleBackColor = true;
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Location = new System.Drawing.Point(64, 97);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(41, 12);
            this.label_Password.TabIndex = 3;
            this.label_Password.Text = "密码：";
            // 
            // label_MaxBorrow
            // 
            this.label_MaxBorrow.AutoSize = true;
            this.label_MaxBorrow.Location = new System.Drawing.Point(64, 124);
            this.label_MaxBorrow.Name = "label_MaxBorrow";
            this.label_MaxBorrow.Size = new System.Drawing.Size(65, 12);
            this.label_MaxBorrow.TabIndex = 4;
            this.label_MaxBorrow.Text = "最多可借：";
            // 
            // label_MaxReserve
            // 
            this.label_MaxReserve.AutoSize = true;
            this.label_MaxReserve.Location = new System.Drawing.Point(64, 151);
            this.label_MaxReserve.Name = "label_MaxReserve";
            this.label_MaxReserve.Size = new System.Drawing.Size(77, 12);
            this.label_MaxReserve.TabIndex = 5;
            this.label_MaxReserve.Text = "最多可预约：";
            // 
            // label_HasBorrowed
            // 
            this.label_HasBorrowed.AutoSize = true;
            this.label_HasBorrowed.Location = new System.Drawing.Point(64, 178);
            this.label_HasBorrowed.Name = "label_HasBorrowed";
            this.label_HasBorrowed.Size = new System.Drawing.Size(41, 12);
            this.label_HasBorrowed.TabIndex = 6;
            this.label_HasBorrowed.Text = "已借：";
            // 
            // label_HasReserved
            // 
            this.label_HasReserved.AutoSize = true;
            this.label_HasReserved.Location = new System.Drawing.Point(64, 205);
            this.label_HasReserved.Name = "label_HasReserved";
            this.label_HasReserved.Size = new System.Drawing.Size(53, 12);
            this.label_HasReserved.TabIndex = 7;
            this.label_HasReserved.Text = "已预约：";
            // 
            // label_OverDue
            // 
            this.label_OverDue.AutoSize = true;
            this.label_OverDue.Location = new System.Drawing.Point(64, 232);
            this.label_OverDue.Name = "label_OverDue";
            this.label_OverDue.Size = new System.Drawing.Size(41, 12);
            this.label_OverDue.TabIndex = 8;
            this.label_OverDue.Text = "过期：";
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(151, 94);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(315, 21);
            this.textBox_Password.TabIndex = 9;
            // 
            // textBox_MaxBorrow
            // 
            this.textBox_MaxBorrow.Location = new System.Drawing.Point(151, 121);
            this.textBox_MaxBorrow.Name = "textBox_MaxBorrow";
            this.textBox_MaxBorrow.Size = new System.Drawing.Size(315, 21);
            this.textBox_MaxBorrow.TabIndex = 10;
            // 
            // textBox_MaxReserve
            // 
            this.textBox_MaxReserve.Location = new System.Drawing.Point(151, 148);
            this.textBox_MaxReserve.Name = "textBox_MaxReserve";
            this.textBox_MaxReserve.Size = new System.Drawing.Size(315, 21);
            this.textBox_MaxReserve.TabIndex = 11;
            // 
            // textBox_HasBorrowed
            // 
            this.textBox_HasBorrowed.Location = new System.Drawing.Point(151, 175);
            this.textBox_HasBorrowed.Name = "textBox_HasBorrowed";
            this.textBox_HasBorrowed.Size = new System.Drawing.Size(315, 21);
            this.textBox_HasBorrowed.TabIndex = 12;
            // 
            // textBox_HasReserved
            // 
            this.textBox_HasReserved.Location = new System.Drawing.Point(151, 202);
            this.textBox_HasReserved.Name = "textBox_HasReserved";
            this.textBox_HasReserved.Size = new System.Drawing.Size(315, 21);
            this.textBox_HasReserved.TabIndex = 13;
            // 
            // textBox_OverDue
            // 
            this.textBox_OverDue.Location = new System.Drawing.Point(151, 229);
            this.textBox_OverDue.Name = "textBox_OverDue";
            this.textBox_OverDue.Size = new System.Drawing.Size(315, 21);
            this.textBox_OverDue.TabIndex = 14;
            // 
            // button_confirm
            // 
            this.button_confirm.Location = new System.Drawing.Point(391, 278);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(75, 23);
            this.button_confirm.TabIndex = 15;
            this.button_confirm.Text = "确定";
            this.button_confirm.UseVisualStyleBackColor = true;
            // 
            // Form_systemAdministratorUpdateReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 313);
            this.Controls.Add(this.button_confirm);
            this.Controls.Add(this.textBox_OverDue);
            this.Controls.Add(this.textBox_HasReserved);
            this.Controls.Add(this.textBox_HasBorrowed);
            this.Controls.Add(this.textBox_MaxReserve);
            this.Controls.Add(this.textBox_MaxBorrow);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.label_OverDue);
            this.Controls.Add(this.label_HasReserved);
            this.Controls.Add(this.label_HasBorrowed);
            this.Controls.Add(this.label_MaxReserve);
            this.Controls.Add(this.label_MaxBorrow);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.button_searchConfirm);
            this.Controls.Add(this.textBox_searchStudentID);
            this.Controls.Add(this.label_please);
            this.Name = "Form_systemAdministratorUpdateReader";
            this.Text = "系统管理员-修改读者";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_please;
        private System.Windows.Forms.TextBox textBox_searchStudentID;
        private System.Windows.Forms.Button button_searchConfirm;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Label label_MaxBorrow;
        private System.Windows.Forms.Label label_MaxReserve;
        private System.Windows.Forms.Label label_HasBorrowed;
        private System.Windows.Forms.Label label_HasReserved;
        private System.Windows.Forms.Label label_OverDue;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.TextBox textBox_MaxBorrow;
        private System.Windows.Forms.TextBox textBox_MaxReserve;
        private System.Windows.Forms.TextBox textBox_HasBorrowed;
        private System.Windows.Forms.TextBox textBox_HasReserved;
        private System.Windows.Forms.TextBox textBox_OverDue;
        private System.Windows.Forms.Button button_confirm;
    }
}