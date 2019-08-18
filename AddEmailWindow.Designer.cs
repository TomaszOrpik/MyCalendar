namespace MyCalendar
{
    partial class AddEmailWindow
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
            this.SendButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.Passwordlabel = new System.Windows.Forms.Label();
            this.Datelabel = new System.Windows.Forms.Label();
            this.Recipientlabel = new System.Windows.Forms.Label();
            this.Bodylabel = new System.Windows.Forms.Label();
            this.Subjectlabel = new System.Windows.Forms.Label();
            this.textBoxMyMail = new System.Windows.Forms.TextBox();
            this.textBoxMyPassword = new System.Windows.Forms.TextBox();
            this.textBoxRecipent = new System.Windows.Forms.TextBox();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.textBoxBody = new System.Windows.Forms.TextBox();
            this.yearBox = new System.Windows.Forms.TextBox();
            this.MonthBox = new System.Windows.Forms.ComboBox();
            this.DayBox = new System.Windows.Forms.ComboBox();
            this.MinBox = new System.Windows.Forms.ComboBox();
            this.HourBox = new System.Windows.Forms.ComboBox();
            this.checkBoxNow = new System.Windows.Forms.CheckBox();
            this.checkBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // SendButton
            // 
            this.SendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SendButton.Location = new System.Drawing.Point(16, 489);
            this.SendButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(205, 34);
            this.SendButton.TabIndex = 17;
            this.SendButton.Text = "SEND";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CloseButton.Location = new System.Drawing.Point(233, 489);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(205, 34);
            this.CloseButton.TabIndex = 16;
            this.CloseButton.Text = "CLOSE";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelName.Location = new System.Drawing.Point(16, 29);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(73, 28);
            this.labelName.TabIndex = 18;
            this.labelName.Text = "E-mail:";
            // 
            // Passwordlabel
            // 
            this.Passwordlabel.AutoSize = true;
            this.Passwordlabel.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Passwordlabel.Location = new System.Drawing.Point(12, 71);
            this.Passwordlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Passwordlabel.Name = "Passwordlabel";
            this.Passwordlabel.Size = new System.Drawing.Size(93, 28);
            this.Passwordlabel.TabIndex = 19;
            this.Passwordlabel.Text = "Password:";
            // 
            // Datelabel
            // 
            this.Datelabel.AutoSize = true;
            this.Datelabel.Font = new System.Drawing.Font("Segoe Print", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Datelabel.Location = new System.Drawing.Point(16, 110);
            this.Datelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Datelabel.Name = "Datelabel";
            this.Datelabel.Size = new System.Drawing.Size(38, 19);
            this.Datelabel.TabIndex = 20;
            this.Datelabel.Text = "Date:";
            // 
            // Recipientlabel
            // 
            this.Recipientlabel.AutoSize = true;
            this.Recipientlabel.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Recipientlabel.Location = new System.Drawing.Point(16, 168);
            this.Recipientlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Recipientlabel.Name = "Recipientlabel";
            this.Recipientlabel.Size = new System.Drawing.Size(91, 28);
            this.Recipientlabel.TabIndex = 21;
            this.Recipientlabel.Text = "Recipient:";
            // 
            // Bodylabel
            // 
            this.Bodylabel.AutoSize = true;
            this.Bodylabel.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Bodylabel.Location = new System.Drawing.Point(16, 297);
            this.Bodylabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Bodylabel.Name = "Bodylabel";
            this.Bodylabel.Size = new System.Drawing.Size(58, 28);
            this.Bodylabel.TabIndex = 22;
            this.Bodylabel.Text = "Body:";
            // 
            // Subjectlabel
            // 
            this.Subjectlabel.AutoSize = true;
            this.Subjectlabel.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Subjectlabel.Location = new System.Drawing.Point(16, 235);
            this.Subjectlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Subjectlabel.Name = "Subjectlabel";
            this.Subjectlabel.Size = new System.Drawing.Size(74, 28);
            this.Subjectlabel.TabIndex = 23;
            this.Subjectlabel.Text = "Subject:";
            // 
            // textBoxMyMail
            // 
            this.textBoxMyMail.BackColor = System.Drawing.Color.Firebrick;
            this.textBoxMyMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMyMail.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxMyMail.Location = new System.Drawing.Point(118, 23);
            this.textBoxMyMail.Name = "textBoxMyMail";
            this.textBoxMyMail.Size = new System.Drawing.Size(317, 26);
            this.textBoxMyMail.TabIndex = 24;
            // 
            // textBoxMyPassword
            // 
            this.textBoxMyPassword.BackColor = System.Drawing.Color.Firebrick;
            this.textBoxMyPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMyPassword.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxMyPassword.Location = new System.Drawing.Point(118, 64);
            this.textBoxMyPassword.Name = "textBoxMyPassword";
            this.textBoxMyPassword.PasswordChar = '*';
            this.textBoxMyPassword.Size = new System.Drawing.Size(317, 26);
            this.textBoxMyPassword.TabIndex = 25;
            // 
            // textBoxRecipent
            // 
            this.textBoxRecipent.BackColor = System.Drawing.Color.Firebrick;
            this.textBoxRecipent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRecipent.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxRecipent.Location = new System.Drawing.Point(21, 200);
            this.textBoxRecipent.Name = "textBoxRecipent";
            this.textBoxRecipent.Size = new System.Drawing.Size(414, 36);
            this.textBoxRecipent.TabIndex = 26;
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.BackColor = System.Drawing.Color.Firebrick;
            this.textBoxSubject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSubject.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSubject.Location = new System.Drawing.Point(21, 266);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(414, 36);
            this.textBoxSubject.TabIndex = 27;
            // 
            // textBoxBody
            // 
            this.textBoxBody.BackColor = System.Drawing.Color.Firebrick;
            this.textBoxBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBody.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxBody.Location = new System.Drawing.Point(21, 329);
            this.textBoxBody.Multiline = true;
            this.textBoxBody.Name = "textBoxBody";
            this.textBoxBody.Size = new System.Drawing.Size(418, 155);
            this.textBoxBody.TabIndex = 28;
            // 
            // yearBox
            // 
            this.yearBox.BackColor = System.Drawing.Color.Firebrick;
            this.yearBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yearBox.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.yearBox.Location = new System.Drawing.Point(344, 105);
            this.yearBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(91, 36);
            this.yearBox.TabIndex = 29;
            this.yearBox.Text = "2019";
            this.yearBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.yearBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yearBox_KeyPress);
            // 
            // MonthBox
            // 
            this.MonthBox.BackColor = System.Drawing.Color.Firebrick;
            this.MonthBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MonthBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MonthBox.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
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
            this.MonthBox.Location = new System.Drawing.Point(244, 104);
            this.MonthBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MonthBox.Name = "MonthBox";
            this.MonthBox.Size = new System.Drawing.Size(97, 36);
            this.MonthBox.TabIndex = 30;
            this.MonthBox.SelectedIndexChanged += new System.EventHandler(this.MonthBox_SelectedIndexChanged);
            // 
            // DayBox
            // 
            this.DayBox.BackColor = System.Drawing.Color.Firebrick;
            this.DayBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DayBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DayBox.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DayBox.FormattingEnabled = true;
            this.DayBox.Location = new System.Drawing.Point(187, 104);
            this.DayBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DayBox.Name = "DayBox";
            this.DayBox.Size = new System.Drawing.Size(54, 36);
            this.DayBox.TabIndex = 31;
            // 
            // MinBox
            // 
            this.MinBox.BackColor = System.Drawing.Color.Firebrick;
            this.MinBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MinBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinBox.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MinBox.FormattingEnabled = true;
            this.MinBox.Location = new System.Drawing.Point(127, 105);
            this.MinBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinBox.Name = "MinBox";
            this.MinBox.Size = new System.Drawing.Size(50, 36);
            this.MinBox.TabIndex = 32;
            // 
            // HourBox
            // 
            this.HourBox.BackColor = System.Drawing.Color.Firebrick;
            this.HourBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HourBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HourBox.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HourBox.FormattingEnabled = true;
            this.HourBox.Location = new System.Drawing.Point(72, 105);
            this.HourBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HourBox.Name = "HourBox";
            this.HourBox.Size = new System.Drawing.Size(51, 36);
            this.HourBox.TabIndex = 33;
            // 
            // checkBoxNow
            // 
            this.checkBoxNow.AutoSize = true;
            this.checkBoxNow.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxNow.Location = new System.Drawing.Point(288, 154);
            this.checkBoxNow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxNow.Name = "checkBoxNow";
            this.checkBoxNow.Size = new System.Drawing.Size(158, 32);
            this.checkBoxNow.TabIndex = 34;
            this.checkBoxNow.Text = "Send Mail Now!";
            this.checkBoxNow.UseVisualStyleBackColor = true;
            // 
            // checkBoxShowPassword
            // 
            this.checkBoxShowPassword.AutoSize = true;
            this.checkBoxShowPassword.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxShowPassword.Location = new System.Drawing.Point(118, 154);
            this.checkBoxShowPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxShowPassword.Name = "checkBoxShowPassword";
            this.checkBoxShowPassword.Size = new System.Drawing.Size(160, 32);
            this.checkBoxShowPassword.TabIndex = 35;
            this.checkBoxShowPassword.Text = "Show password!";
            this.checkBoxShowPassword.UseVisualStyleBackColor = true;
            this.checkBoxShowPassword.CheckedChanged += new System.EventHandler(this.checkBoxShowPassword_CheckedChanged);
            // 
            // AddEmailWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(454, 533);
            this.Controls.Add(this.checkBoxShowPassword);
            this.Controls.Add(this.checkBoxNow);
            this.Controls.Add(this.HourBox);
            this.Controls.Add(this.MinBox);
            this.Controls.Add(this.DayBox);
            this.Controls.Add(this.MonthBox);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.textBoxBody);
            this.Controls.Add(this.textBoxSubject);
            this.Controls.Add(this.textBoxRecipent);
            this.Controls.Add(this.textBoxMyPassword);
            this.Controls.Add(this.textBoxMyMail);
            this.Controls.Add(this.Subjectlabel);
            this.Controls.Add(this.Bodylabel);
            this.Controls.Add(this.Recipientlabel);
            this.Controls.Add(this.Datelabel);
            this.Controls.Add(this.Passwordlabel);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.CloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddEmailWindow";
            this.Text = "AddEmailWindow";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddEmailWindow_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AddEmailWindow_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label Passwordlabel;
        private System.Windows.Forms.Label Datelabel;
        private System.Windows.Forms.Label Recipientlabel;
        private System.Windows.Forms.Label Bodylabel;
        private System.Windows.Forms.Label Subjectlabel;
        private System.Windows.Forms.TextBox textBoxMyMail;
        private System.Windows.Forms.TextBox textBoxMyPassword;
        private System.Windows.Forms.TextBox textBoxRecipent;
        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.TextBox textBoxBody;
        private System.Windows.Forms.TextBox yearBox;
        private System.Windows.Forms.ComboBox MonthBox;
        private System.Windows.Forms.ComboBox DayBox;
        private System.Windows.Forms.ComboBox MinBox;
        private System.Windows.Forms.ComboBox HourBox;
        private System.Windows.Forms.CheckBox checkBoxNow;
        private System.Windows.Forms.CheckBox checkBoxShowPassword;
    }
}