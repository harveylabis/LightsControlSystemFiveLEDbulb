namespace LightsControlSystemFiveLED
{
    partial class Form2
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
            this.lbl_login_Password = new System.Windows.Forms.Label();
            this.txtbox_login_PasswordField = new System.Windows.Forms.TextBox();
            this.btn_login_Enter = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // lbl_login_Password
            // 
            this.lbl_login_Password.AutoSize = true;
            this.lbl_login_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login_Password.Location = new System.Drawing.Point(12, 26);
            this.lbl_login_Password.Name = "lbl_login_Password";
            this.lbl_login_Password.Size = new System.Drawing.Size(77, 17);
            this.lbl_login_Password.TabIndex = 0;
            this.lbl_login_Password.Text = "Password: ";
            // 
            // txtbox_login_PasswordField
            // 
            this.txtbox_login_PasswordField.Location = new System.Drawing.Point(96, 26);
            this.txtbox_login_PasswordField.Name = "txtbox_login_PasswordField";
            this.txtbox_login_PasswordField.PasswordChar = '*';
            this.txtbox_login_PasswordField.Size = new System.Drawing.Size(137, 20);
            this.txtbox_login_PasswordField.TabIndex = 1;
            this.txtbox_login_PasswordField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbox_login_PasswordField_KeyDown);
            // 
            // btn_login_Enter
            // 
            this.btn_login_Enter.Location = new System.Drawing.Point(158, 64);
            this.btn_login_Enter.Name = "btn_login_Enter";
            this.btn_login_Enter.Size = new System.Drawing.Size(75, 23);
            this.btn_login_Enter.TabIndex = 2;
            this.btn_login_Enter.Text = "Enter";
            this.btn_login_Enter.UseVisualStyleBackColor = true;
            this.btn_login_Enter.Click += new System.EventHandler(this.btn_login_Enter_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 115);
            this.Controls.Add(this.btn_login_Enter);
            this.Controls.Add(this.txtbox_login_PasswordField);
            this.Controls.Add(this.lbl_login_Password);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_login_Password;
        private System.Windows.Forms.TextBox txtbox_login_PasswordField;
        private System.Windows.Forms.Button btn_login_Enter;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}