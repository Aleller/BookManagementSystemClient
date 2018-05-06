namespace BookManagementSystemClient.ChildWindow
{
    partial class Form_review
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
            this.label_warning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_warning
            // 
            this.label_warning.AutoSize = true;
            this.label_warning.Location = new System.Drawing.Point(214, 175);
            this.label_warning.Name = "label_warning";
            this.label_warning.Size = new System.Drawing.Size(113, 12);
            this.label_warning.TabIndex = 0;
            this.label_warning.Text = "您的该项记录为空！";
            // 
            // Form_review
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 380);
            this.Controls.Add(this.label_warning);
            this.Name = "Form_review";
            this.Text = "我的书评";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_warning;
    }
}