namespace MyCalendar
{
    partial class AddEventWindow
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
            this.labelStart = new System.Windows.Forms.Label();
            this.labelEnd = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.yearBox = new System.Windows.Forms.TextBox();
            this.MonthBox = new System.Windows.Forms.ComboBox();
            this.DayBox = new System.Windows.Forms.ComboBox();
            this.MinBox = new System.Windows.Forms.ComboBox();
            this.HourBox = new System.Windows.Forms.ComboBox();
            this.yearBox1 = new System.Windows.Forms.TextBox();
            this.MonthBox1 = new System.Windows.Forms.ComboBox();
            this.DayBox1 = new System.Windows.Forms.ComboBox();
            this.MinBox1 = new System.Windows.Forms.ComboBox();
            this.HourBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.DescriptionBox = new System.Windows.Forms.RichTextBox();
            this.checkBoxReminder = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelStart.Location = new System.Drawing.Point(12, 103);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(129, 35);
            this.labelStart.TabIndex = 1;
            this.labelStart.Text = "Start Date:";
            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.labelEnd.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEnd.Location = new System.Drawing.Point(12, 150);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(116, 35);
            this.labelEnd.TabIndex = 4;
            this.labelEnd.Text = "End Date:";
            // 
            // SaveButton
            // 
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SaveButton.Location = new System.Drawing.Point(140, 420);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(187, 42);
            this.SaveButton.TabIndex = 17;
            this.SaveButton.Text = "SAVE";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CloseButton.Location = new System.Drawing.Point(382, 420);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(187, 42);
            this.CloseButton.TabIndex = 16;
            this.CloseButton.Text = "CLOSE";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // yearBox
            // 
            this.yearBox.BackColor = System.Drawing.Color.OliveDrab;
            this.yearBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.yearBox.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.yearBox.Location = new System.Drawing.Point(578, 110);
            this.yearBox.Multiline = true;
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(121, 24);
            this.yearBox.TabIndex = 22;
            this.yearBox.Text = "2019";
            this.yearBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.yearBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yearBox_KeyPress);
            // 
            // MonthBox
            // 
            this.MonthBox.BackColor = System.Drawing.Color.OliveDrab;
            this.MonthBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MonthBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MonthBox.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Italic);
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
            this.MonthBox.Location = new System.Drawing.Point(426, 110);
            this.MonthBox.Name = "MonthBox";
            this.MonthBox.Size = new System.Drawing.Size(146, 28);
            this.MonthBox.TabIndex = 21;
            this.MonthBox.SelectedIndexChanged += new System.EventHandler(this.MonthBox_SelectedIndexChanged);
            // 
            // DayBox
            // 
            this.DayBox.BackColor = System.Drawing.Color.OliveDrab;
            this.DayBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DayBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DayBox.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Italic);
            this.DayBox.FormattingEnabled = true;
            this.DayBox.Location = new System.Drawing.Point(299, 110);
            this.DayBox.Name = "DayBox";
            this.DayBox.Size = new System.Drawing.Size(121, 28);
            this.DayBox.TabIndex = 20;
            // 
            // MinBox
            // 
            this.MinBox.BackColor = System.Drawing.Color.OliveDrab;
            this.MinBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MinBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinBox.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MinBox.FormattingEnabled = true;
            this.MinBox.Location = new System.Drawing.Point(213, 110);
            this.MinBox.Name = "MinBox";
            this.MinBox.Size = new System.Drawing.Size(80, 28);
            this.MinBox.TabIndex = 19;
            // 
            // HourBox
            // 
            this.HourBox.BackColor = System.Drawing.Color.OliveDrab;
            this.HourBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HourBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HourBox.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HourBox.FormattingEnabled = true;
            this.HourBox.Location = new System.Drawing.Point(140, 110);
            this.HourBox.Name = "HourBox";
            this.HourBox.Size = new System.Drawing.Size(67, 28);
            this.HourBox.TabIndex = 18;
            // 
            // yearBox1
            // 
            this.yearBox1.BackColor = System.Drawing.Color.OliveDrab;
            this.yearBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.yearBox1.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.yearBox1.Location = new System.Drawing.Point(578, 157);
            this.yearBox1.Multiline = true;
            this.yearBox1.Name = "yearBox1";
            this.yearBox1.Size = new System.Drawing.Size(121, 24);
            this.yearBox1.TabIndex = 27;
            this.yearBox1.Text = "2019";
            this.yearBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.yearBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yearBox1_KeyPress);
            // 
            // MonthBox1
            // 
            this.MonthBox1.BackColor = System.Drawing.Color.OliveDrab;
            this.MonthBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MonthBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MonthBox1.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Italic);
            this.MonthBox1.FormattingEnabled = true;
            this.MonthBox1.Items.AddRange(new object[] {
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
            this.MonthBox1.Location = new System.Drawing.Point(426, 157);
            this.MonthBox1.Name = "MonthBox1";
            this.MonthBox1.Size = new System.Drawing.Size(146, 28);
            this.MonthBox1.TabIndex = 26;
            this.MonthBox1.SelectedIndexChanged += new System.EventHandler(this.MonthBox1_SelectedIndexChanged);
            // 
            // DayBox1
            // 
            this.DayBox1.BackColor = System.Drawing.Color.OliveDrab;
            this.DayBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DayBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DayBox1.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Italic);
            this.DayBox1.FormattingEnabled = true;
            this.DayBox1.Location = new System.Drawing.Point(299, 157);
            this.DayBox1.Name = "DayBox1";
            this.DayBox1.Size = new System.Drawing.Size(121, 28);
            this.DayBox1.TabIndex = 25;
            // 
            // MinBox1
            // 
            this.MinBox1.BackColor = System.Drawing.Color.OliveDrab;
            this.MinBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MinBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinBox1.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MinBox1.FormattingEnabled = true;
            this.MinBox1.Location = new System.Drawing.Point(213, 157);
            this.MinBox1.Name = "MinBox1";
            this.MinBox1.Size = new System.Drawing.Size(80, 28);
            this.MinBox1.TabIndex = 24;
            // 
            // HourBox1
            // 
            this.HourBox1.BackColor = System.Drawing.Color.OliveDrab;
            this.HourBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HourBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HourBox1.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HourBox1.FormattingEnabled = true;
            this.HourBox1.Location = new System.Drawing.Point(140, 157);
            this.HourBox1.Name = "HourBox1";
            this.HourBox1.Size = new System.Drawing.Size(67, 28);
            this.HourBox1.TabIndex = 23;
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.BackColor = System.Drawing.Color.OliveDrab;
            this.textBoxLocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLocation.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxLocation.Location = new System.Drawing.Point(18, 56);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(681, 36);
            this.textBoxLocation.TabIndex = 28;
            this.textBoxLocation.Text = "Location";
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.OliveDrab;
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxName.Location = new System.Drawing.Point(18, 8);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(681, 36);
            this.textBoxName.TabIndex = 29;
            this.textBoxName.Text = "Name";
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.BackColor = System.Drawing.Color.OliveDrab;
            this.DescriptionBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescriptionBox.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DescriptionBox.Location = new System.Drawing.Point(18, 191);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(681, 164);
            this.DescriptionBox.TabIndex = 30;
            this.DescriptionBox.Text = "Description";
            // 
            // checkBoxReminder
            // 
            this.checkBoxReminder.AutoSize = true;
            this.checkBoxReminder.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxReminder.Location = new System.Drawing.Point(465, 361);
            this.checkBoxReminder.Name = "checkBoxReminder";
            this.checkBoxReminder.Size = new System.Drawing.Size(234, 39);
            this.checkBoxReminder.TabIndex = 31;
            this.checkBoxReminder.Text = "Send Remind SMS?";
            this.checkBoxReminder.UseVisualStyleBackColor = true;
            // 
            // AddEventWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(716, 474);
            this.Controls.Add(this.checkBoxReminder);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxLocation);
            this.Controls.Add(this.yearBox1);
            this.Controls.Add(this.MonthBox1);
            this.Controls.Add(this.DayBox1);
            this.Controls.Add(this.MinBox1);
            this.Controls.Add(this.HourBox1);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.MonthBox);
            this.Controls.Add(this.DayBox);
            this.Controls.Add(this.MinBox);
            this.Controls.Add(this.HourBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.labelEnd);
            this.Controls.Add(this.labelStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEventWindow";
            this.Text = "AddEventWindow";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddEventWindow_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AddEventWindow_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.TextBox yearBox;
        private System.Windows.Forms.ComboBox MonthBox;
        private System.Windows.Forms.ComboBox DayBox;
        private System.Windows.Forms.ComboBox MinBox;
        private System.Windows.Forms.ComboBox HourBox;
        private System.Windows.Forms.TextBox yearBox1;
        private System.Windows.Forms.ComboBox MonthBox1;
        private System.Windows.Forms.ComboBox DayBox1;
        private System.Windows.Forms.ComboBox MinBox1;
        private System.Windows.Forms.ComboBox HourBox1;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.RichTextBox DescriptionBox;
        private System.Windows.Forms.CheckBox checkBoxReminder;
    }
}