namespace BookManagementSystemClient
{
    partial class Form_register
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
            this.label_UserName = new System.Windows.Forms.Label();
            this.label_inputPassword1 = new System.Windows.Forms.Label();
            this.label_inputPassword2 = new System.Windows.Forms.Label();
            this.textBox_inputUserName = new System.Windows.Forms.TextBox();
            this.textBox_inputPassword1 = new System.Windows.Forms.TextBox();
            this.textBox_inputPassword2 = new System.Windows.Forms.TextBox();
            this.button_register = new System.Windows.Forms.Button();
            this.comboBox_userGroup = new System.Windows.Forms.ComboBox();
            this.label_userGroup = new System.Windows.Forms.Label();
            this.textBox_key = new System.Windows.Forms.TextBox();
            this.label_key = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_UserName
            // 
            this.label_UserName.AutoSize = true;
            this.label_UserName.Location = new System.Drawing.Point(44, 50);
            this.label_UserName.Name = "label_UserName";
            this.label_UserName.Size = new System.Drawing.Size(89, 12);
            this.label_UserName.TabIndex = 0;
            this.label_UserName.Text = "请输入用户名：";
            // 
            // label_inputPassword1
            // 
            this.label_inputPassword1.AutoSize = true;
            this.label_inputPassword1.Location = new System.Drawing.Point(44, 86);
            this.label_inputPassword1.Name = "label_inputPassword1";
            this.label_inputPassword1.Size = new System.Drawing.Size(77, 12);
            this.label_inputPassword1.TabIndex = 1;
            this.label_inputPassword1.Text = "请输入密码：";
            // 
            // label_inputPassword2
            // 
            this.label_inputPassword2.AutoSize = true;
            this.label_inputPassword2.Location = new System.Drawing.Point(44, 127);
            this.label_inputPassword2.Name = "label_inputPassword2";
            this.label_inputPassword2.Size = new System.Drawing.Size(65, 12);
            this.label_inputPassword2.TabIndex = 2;
            this.label_inputPassword2.Text = "重复密码：";
            // 
            // textBox_inputUserName
            // 
            this.textBox_inputUserName.Location = new System.Drawing.Point(137, 47);
            this.textBox_inputUserName.Name = "textBox_inputUserName";
            this.textBox_inputUserName.Size = new System.Drawing.Size(100, 21);
            this.textBox_inputUserName.TabIndex = 3;
            this.textBox_inputUserName.Text = "2015210793";
            // 
            // textBox_inputPassword1
            // 
            this.textBox_inputPassword1.Location = new System.Drawing.Point(137, 83);
            this.textBox_inputPassword1.Name = "textBox_inputPassword1";
            this.textBox_inputPassword1.PasswordChar = '*';
            this.textBox_inputPassword1.Size = new System.Drawing.Size(100, 21);
            this.textBox_inputPassword1.TabIndex = 4;
            this.textBox_inputPassword1.Text = "123456";
            // 
            // textBox_inputPassword2
            // 
            this.textBox_inputPassword2.Location = new System.Drawing.Point(137, 124);
            this.textBox_inputPassword2.Name = "textBox_inputPassword2";
            this.textBox_inputPassword2.PasswordChar = '*';
            this.textBox_inputPassword2.Size = new System.Drawing.Size(100, 21);
            this.textBox_inputPassword2.TabIndex = 5;
            this.textBox_inputPassword2.Text = "123456";
            // 
            // button_register
            // 
            this.button_register.Location = new System.Drawing.Point(162, 241);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(75, 23);
            this.button_register.TabIndex = 6;
            this.button_register.Text = "注册";
            this.button_register.UseVisualStyleBackColor = true;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // comboBox_userGroup
            // 
            this.comboBox_userGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_userGroup.FormattingEnabled = true;
            this.comboBox_userGroup.Items.AddRange(new object[] {
            "读者",
            "系统管理员"});
            this.comboBox_userGroup.Location = new System.Drawing.Point(137, 165);
            this.comboBox_userGroup.Name = "comboBox_userGroup";
            this.comboBox_userGroup.Size = new System.Drawing.Size(100, 20);
            this.comboBox_userGroup.TabIndex = 7;
            this.comboBox_userGroup.SelectedIndexChanged += new System.EventHandler(this.comboBox_userGroup_SelectedIndexChanged);
            // 
            // label_userGroup
            // 
            this.label_userGroup.AutoSize = true;
            this.label_userGroup.Location = new System.Drawing.Point(44, 168);
            this.label_userGroup.Name = "label_userGroup";
            this.label_userGroup.Size = new System.Drawing.Size(89, 12);
            this.label_userGroup.TabIndex = 8;
            this.label_userGroup.Text = "请选择用户组：";
            // 
            // textBox_key
            // 
            this.textBox_key.Location = new System.Drawing.Point(137, 202);
            this.textBox_key.Name = "textBox_key";
            this.textBox_key.Size = new System.Drawing.Size(100, 21);
            this.textBox_key.TabIndex = 9;
            // 
            // label_key
            // 
            this.label_key.AutoSize = true;
            this.label_key.Location = new System.Drawing.Point(44, 205);
            this.label_key.Name = "label_key";
            this.label_key.Size = new System.Drawing.Size(89, 12);
            this.label_key.TabIndex = 10;
            this.label_key.Text = "管理员验证码：";
            // 
            // Form_register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 276);
            this.Controls.Add(this.label_key);
            this.Controls.Add(this.textBox_key);
            this.Controls.Add(this.label_userGroup);
            this.Controls.Add(this.comboBox_userGroup);
            this.Controls.Add(this.button_register);
            this.Controls.Add(this.textBox_inputPassword2);
            this.Controls.Add(this.textBox_inputPassword1);
            this.Controls.Add(this.textBox_inputUserName);
            this.Controls.Add(this.label_inputPassword2);
            this.Controls.Add(this.label_inputPassword1);
            this.Controls.Add(this.label_UserName);
            this.Name = "Form_register";
            this.Text = "注册账户";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_UserName;
        private System.Windows.Forms.Label label_inputPassword1;
        private System.Windows.Forms.Label label_inputPassword2;
        private System.Windows.Forms.TextBox textBox_inputUserName;
        private System.Windows.Forms.TextBox textBox_inputPassword1;
        private System.Windows.Forms.TextBox textBox_inputPassword2;
        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.ComboBox comboBox_userGroup;
        private System.Windows.Forms.Label label_userGroup;
        private System.Windows.Forms.TextBox textBox_key;
        private System.Windows.Forms.Label label_key;
    }
}