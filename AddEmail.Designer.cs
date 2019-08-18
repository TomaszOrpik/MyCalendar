namespace MyCalendar
{
    partial class AddEmail
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.yearBox = new System.Windows.Forms.TextBox();
            this.MonthBox = new System.Windows.Forms.ComboBox();
            this.DayBox = new System.Windows.Forms.ComboBox();
            this.MinBox = new System.Windows.Forms.ComboBox();
            this.HourBox = new System.Windows.Forms.ComboBox();
            this.Passwordlabel = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxMyPassword = new System.Windows.Forms.TextBox();
            this.textBoxMyMail = new System.Windows.Forms.TextBox();
            this.Datelabel = new System.Windows.Forms.Label();
            this.checkBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.checkBoxNow = new System.Windows.Forms.CheckBox();
            this.Subjectlabel = new System.Windows.Forms.Label();
            this.Bodylabel = new System.Windows.Forms.Label();
            this.Recipientlabel = new System.Windows.Forms.Label();
            this.textBoxRecipent = new System.Windows.Forms.TextBox();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.textBoxBody = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // yearBox
            // 
            this.yearBox.BackColor = System.Drawing.Color.Firebrick;
            this.yearBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.yearBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.yearBox.Location = new System.Drawing.Point(383, 113);
            this.yearBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.yearBox.Multiline = true;
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(79, 26);
            this.yearBox.TabIndex = 19;
            this.yearBox.Text = "2019";
            this.yearBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.yearBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yearBox_KeyPress);
            // 
            // MonthBox
            // 
            this.MonthBox.BackColor = System.Drawing.Color.Firebrick;
            this.MonthBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MonthBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MonthBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MonthBox.FormattingEnabled = true;
            this.MonthBox.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.MonthBox.Location = new System.Drawing.Point(253, 110);
            this.MonthBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MonthBox.Name = "MonthBox";
            this.MonthBox.Size = new System.Drawing.Size(120, 25);
            this.MonthBox.TabIndex = 18;
            this.MonthBox.SelectedIndexChanged += new System.EventHandler(this.MonthBox_SelectedIndexChanged);
            // 
            // DayBox
            // 
            this.DayBox.BackColor = System.Drawing.Color.Firebrick;
            this.DayBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DayBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DayBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DayBox.FormattingEnabled = true;
            this.DayBox.Location = new System.Drawing.Point(148, 110);
            this.DayBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DayBox.Name = "DayBox";
            this.DayBox.Size = new System.Drawing.Size(96, 25);
            this.DayBox.TabIndex = 17;
            // 
            // MinBox
            // 
            this.MinBox.BackColor = System.Drawing.Color.Firebrick;
            this.MinBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MinBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MinBox.FormattingEnabled = true;
            this.MinBox.Location = new System.Drawing.Point(72, 110);
            this.MinBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinBox.Name = "MinBox";
            this.MinBox.Size = new System.Drawing.Size(67, 25);
            this.MinBox.TabIndex = 16;
            // 
            // HourBox
            // 
            this.HourBox.BackColor = System.Drawing.Color.Firebrick;
            this.HourBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HourBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HourBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HourBox.FormattingEnabled = true;
            this.HourBox.Location = new System.Drawing.Point(4, 110);
            this.HourBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HourBox.Name = "HourBox";
            this.HourBox.Size = new System.Drawing.Size(59, 25);
            this.HourBox.TabIndex = 15;
            // 
            // Passwordlabel
            // 
            this.Passwordlabel.AutoSize = true;
            this.Passwordlabel.Font = new System.Drawing.Font("Segoe Print", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Passwordlabel.Location = new System.Drawing.Point(-1, 43);
            this.Passwordlabel.Name = "Passwordlabel";
            this.Passwordlabel.Size = new System.Drawing.Size(80, 24);
            this.Passwordlabel.TabIndex = 21;
            this.Passwordlabel.Text = "Password:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe Print", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelName.Location = new System.Drawing.Point(3, 11);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(63, 24);
            this.labelName.TabIndex = 20;
            this.labelName.Text = "E-mail:";
            // 
            // textBoxMyPassword
            // 
            this.textBoxMyPassword.BackColor = System.Drawing.Color.Firebrick;
            this.textBoxMyPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMyPassword.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxMyPassword.Location = new System.Drawing.Point(96, 41);
            this.textBoxMyPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxMyPassword.Name = "textBoxMyPassword";
            this.textBoxMyPassword.PasswordChar = '*';
            this.textBoxMyPassword.Size = new System.Drawing.Size(349, 31);
            this.textBoxMyPassword.TabIndex = 27;
            // 
            // textBoxMyMail
            // 
            this.textBoxMyMail.BackColor = System.Drawing.Color.Firebrick;
            this.textBoxMyMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMyMail.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxMyMail.Location = new System.Drawing.Point(96, 4);
            this.textBoxMyMail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxMyMail.Name = "textBoxMyMail";
            this.textBoxMyMail.Size = new System.Drawing.Size(349, 31);
            this.textBoxMyMail.TabIndex = 26;
            // 
            // Datelabel
            // 
            this.Datelabel.AutoSize = true;
            this.Datelabel.Font = new System.Drawing.Font("Segoe Print", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Datelabel.Location = new System.Drawing.Point(3, 82);
            this.Datelabel.Name = "Datelabel";
            this.Datelabel.Size = new System.Drawing.Size(47, 24);
            this.Datelabel.TabIndex = 28;
            this.Datelabel.Text = "Date:";
            // 
            // checkBoxShowPassword
            // 
            this.checkBoxShowPassword.AutoSize = true;
            this.checkBoxShowPassword.Font = new System.Drawing.Font("Segoe Print", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxShowPassword.Location = new System.Drawing.Point(96, 75);
            this.checkBoxShowPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxShowPassword.Name = "checkBoxShowPassword";
            this.checkBoxShowPassword.Size = new System.Drawing.Size(146, 28);
            this.checkBoxShowPassword.TabIndex = 37;
            this.checkBoxShowPassword.Text = "Show password!";
            this.checkBoxShowPassword.UseVisualStyleBackColor = true;
            this.checkBoxShowPassword.CheckedChanged += new System.EventHandler(this.checkBoxShowPassword_CheckedChanged);
            // 
            // checkBoxNow
            // 
            this.checkBoxNow.AutoSize = true;
            this.checkBoxNow.Font = new System.Drawing.Font("Segoe Print", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxNow.Location = new System.Drawing.Point(309, 78);
            this.checkBoxNow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxNow.Name = "checkBoxNow";
            this.checkBoxNow.Size = new System.Drawing.Size(143, 28);
            this.checkBoxNow.TabIndex = 36;
            this.checkBoxNow.Text = "Send Mail Now!";
            this.checkBoxNow.UseVisualStyleBackColor = true;
            // 
            // Subjectlabel
            // 
            this.Subjectlabel.AutoSize = true;
            this.Subjectlabel.Font = new System.Drawing.Font("Segoe Print", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Subjectlabel.Location = new System.Drawing.Point(3, 202);
            this.Subjectlabel.Name = "Subjectlabel";
            this.Subjectlabel.Size = new System.Drawing.Size(65, 24);
            this.Subjectlabel.TabIndex = 40;
            this.Subjectlabel.Text = "Subject:";
            // 
            // Bodylabel
            // 
            this.Bodylabel.AutoSize = true;
            this.Bodylabel.Font = new System.Drawing.Font("Segoe Print", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Bodylabel.Location = new System.Drawing.Point(1, 265);
            this.Bodylabel.Name = "Bodylabel";
            this.Bodylabel.Size = new System.Drawing.Size(49, 24);
            this.Bodylabel.TabIndex = 39;
            this.Bodylabel.Text = "Body:";
            // 
            // Recipientlabel
            // 
            this.Recipientlabel.AutoSize = true;
            this.Recipientlabel.Font = new System.Drawing.Font("Segoe Print", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Recipientlabel.Location = new System.Drawing.Point(3, 139);
            this.Recipientlabel.Name = "Recipientlabel";
            this.Recipientlabel.Size = new System.Drawing.Size(78, 24);
            this.Recipientlabel.TabIndex = 38;
            this.Recipientlabel.Text = "Recipient:";
            // 
            // textBoxRecipent
            // 
            this.textBoxRecipent.BackColor = System.Drawing.Color.Firebrick;
            this.textBoxRecipent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRecipent.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxRecipent.Location = new System.Drawing.Point(8, 166);
            this.textBoxRecipent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxRecipent.Name = "textBoxRecipent";
            this.textBoxRecipent.Size = new System.Drawing.Size(437, 31);
            this.textBoxRecipent.TabIndex = 41;
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.BackColor = System.Drawing.Color.Firebrick;
            this.textBoxSubject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSubject.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSubject.Location = new System.Drawing.Point(8, 229);
            this.textBoxSubject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(437, 31);
            this.textBoxSubject.TabIndex = 42;
            // 
            // textBoxBody
            // 
            this.textBoxBody.BackColor = System.Drawing.Color.Firebrick;
            this.textBoxBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBody.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxBody.Location = new System.Drawing.Point(7, 292);
            this.textBoxBody.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxBody.Multiline = true;
            this.textBoxBody.Name = "textBoxBody";
            this.textBoxBody.Size = new System.Drawing.Size(438, 132);
            this.textBoxBody.TabIndex = 43;
            // 
            // SendButton
            // 
            this.SendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SendButton.Location = new System.Drawing.Point(96, 431);
            this.SendButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(273, 42);
            this.SendButton.TabIndex = 44;
            this.SendButton.Text = "SEND";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // AddEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.textBoxBody);
            this.Controls.Add(this.textBoxSubject);
            this.Controls.Add(this.textBoxRecipent);
            this.Controls.Add(this.Subjectlabel);
            this.Controls.Add(this.Bodylabel);
            this.Controls.Add(this.Recipientlabel);
            this.Controls.Add(this.checkBoxShowPassword);
            this.Controls.Add(this.checkBoxNow);
            this.Controls.Add(this.Datelabel);
            this.Controls.Add(this.textBoxMyPassword);
            this.Controls.Add(this.textBoxMyMail);
            this.Controls.Add(this.Passwordlabel);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.MonthBox);
            this.Controls.Add(this.DayBox);
            this.Controls.Add(this.MinBox);
            this.Controls.Add(this.HourBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddEmail";
            this.Size = new System.Drawing.Size(468, 487);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox yearBox;
        private System.Windows.Forms.ComboBox MonthBox;
        private System.Windows.Forms.ComboBox DayBox;
        private System.Windows.Forms.ComboBox MinBox;
        private System.Windows.Forms.ComboBox HourBox;
        private System.Windows.Forms.Label Passwordlabel;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxMyPassword;
        private System.Windows.Forms.TextBox textBoxMyMail;
        private System.Windows.Forms.Label Datelabel;
        private System.Windows.Forms.CheckBox checkBoxShowPassword;
        private System.Windows.Forms.CheckBox checkBoxNow;
        private System.Windows.Forms.Label Subjectlabel;
        private System.Windows.Forms.Label Bodylabel;
        private System.Windows.Forms.Label Recipientlabel;
        private System.Windows.Forms.TextBox textBoxRecipent;
        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.TextBox textBoxBody;
        private System.Windows.Forms.Button SendButton;
    }
}
