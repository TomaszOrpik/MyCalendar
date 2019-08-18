namespace MyCalendar
{
    partial class SettingsDefaultEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsDefaultEmail));
            this.textBoxMyPassword = new System.Windows.Forms.TextBox();
            this.textBoxMyMail = new System.Windows.Forms.TextBox();
            this.Passwordlabel = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.checkBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxMyPassword
            // 
            this.textBoxMyPassword.BackColor = System.Drawing.Color.SteelBlue;
            this.textBoxMyPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMyPassword.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxMyPassword.Location = new System.Drawing.Point(157, 64);
            this.textBoxMyPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMyPassword.Name = "textBoxMyPassword";
            this.textBoxMyPassword.PasswordChar = '*';
            this.textBoxMyPassword.Size = new System.Drawing.Size(422, 43);
            this.textBoxMyPassword.TabIndex = 29;
            // 
            // textBoxMyMail
            // 
            this.textBoxMyMail.BackColor = System.Drawing.Color.SteelBlue;
            this.textBoxMyMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMyMail.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxMyMail.Location = new System.Drawing.Point(157, 13);
            this.textBoxMyMail.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMyMail.Name = "textBoxMyMail";
            this.textBoxMyMail.Size = new System.Drawing.Size(422, 43);
            this.textBoxMyMail.TabIndex = 28;
            // 
            // Passwordlabel
            // 
            this.Passwordlabel.AutoSize = true;
            this.Passwordlabel.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Passwordlabel.Location = new System.Drawing.Point(15, 72);
            this.Passwordlabel.Name = "Passwordlabel";
            this.Passwordlabel.Size = new System.Drawing.Size(115, 35);
            this.Passwordlabel.TabIndex = 27;
            this.Passwordlabel.Text = "Password:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelName.Location = new System.Drawing.Point(21, 21);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(92, 35);
            this.labelName.TabIndex = 26;
            this.labelName.Text = "E-mail:";
            // 
            // checkBoxShowPassword
            // 
            this.checkBoxShowPassword.AutoSize = true;
            this.checkBoxShowPassword.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxShowPassword.Location = new System.Drawing.Point(381, 114);
            this.checkBoxShowPassword.Name = "checkBoxShowPassword";
            this.checkBoxShowPassword.Size = new System.Drawing.Size(198, 39);
            this.checkBoxShowPassword.TabIndex = 36;
            this.checkBoxShowPassword.Text = "Show password!";
            this.checkBoxShowPassword.UseVisualStyleBackColor = true;
            this.checkBoxShowPassword.CheckedChanged += new System.EventHandler(this.checkBoxShowPassword_CheckedChanged);
            // 
            // SendButton
            // 
            this.SendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SendButton.Location = new System.Drawing.Point(21, 160);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(273, 42);
            this.SendButton.TabIndex = 38;
            this.SendButton.Text = "SEND";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CloseButton.Location = new System.Drawing.Point(310, 160);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(273, 42);
            this.CloseButton.TabIndex = 37;
            this.CloseButton.Text = "CLOSE";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SettingsDefaultEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(621, 220);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.checkBoxShowPassword);
            this.Controls.Add(this.textBoxMyPassword);
            this.Controls.Add(this.textBoxMyMail);
            this.Controls.Add(this.Passwordlabel);
            this.Controls.Add(this.labelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsDefaultEmail";
            this.Text = "SettingsDefaultEmail";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SettingDefaultEmail_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SettingDefaultEmail_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMyPassword;
        private System.Windows.Forms.TextBox textBoxMyMail;
        private System.Windows.Forms.Label Passwordlabel;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.CheckBox checkBoxShowPassword;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Button CloseButton;
    }
}