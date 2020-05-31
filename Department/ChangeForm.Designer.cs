namespace Department
{
    partial class ChangeForm
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
            this.buttonOK = new System.Windows.Forms.Button();
            this.textBoxOldHead = new System.Windows.Forms.TextBox();
            this.textBoxNewHead = new System.Windows.Forms.TextBox();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.textBoxOldPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(168, 196);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // textBoxOldHead
            // 
            this.textBoxOldHead.Location = new System.Drawing.Point(12, 101);
            this.textBoxOldHead.Name = "textBoxOldHead";
            this.textBoxOldHead.Size = new System.Drawing.Size(182, 20);
            this.textBoxOldHead.TabIndex = 1;
            this.textBoxOldHead.Text = "Previous head...";
            // 
            // textBoxNewHead
            // 
            this.textBoxNewHead.Location = new System.Drawing.Point(225, 101);
            this.textBoxNewHead.Name = "textBoxNewHead";
            this.textBoxNewHead.Size = new System.Drawing.Size(182, 20);
            this.textBoxNewHead.TabIndex = 1;
            this.textBoxNewHead.Text = "New head...";
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Location = new System.Drawing.Point(225, 141);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.Size = new System.Drawing.Size(182, 20);
            this.textBoxNewPassword.TabIndex = 1;
            this.textBoxNewPassword.Text = "New password...";
            // 
            // textBoxOldPassword
            // 
            this.textBoxOldPassword.Location = new System.Drawing.Point(12, 141);
            this.textBoxOldPassword.Name = "textBoxOldPassword";
            this.textBoxOldPassword.Size = new System.Drawing.Size(182, 20);
            this.textBoxOldPassword.TabIndex = 1;
            this.textBoxOldPassword.Text = "Old password...";
            // 
            // ChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 236);
            this.Controls.Add(this.textBoxNewPassword);
            this.Controls.Add(this.textBoxNewHead);
            this.Controls.Add(this.textBoxOldPassword);
            this.Controls.Add(this.textBoxOldHead);
            this.Controls.Add(this.buttonOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ChangeForm";
            this.Text = "ChangeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        public System.Windows.Forms.TextBox textBoxOldHead;
        public System.Windows.Forms.TextBox textBoxNewHead;
        public System.Windows.Forms.TextBox textBoxNewPassword;
        public System.Windows.Forms.TextBox textBoxOldPassword;
    }
}