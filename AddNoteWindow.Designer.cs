namespace MyCalendar
{
    partial class AddNoteWindow
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
            this.HourBox = new System.Windows.Forms.ComboBox();
            this.MinBox = new System.Windows.Forms.ComboBox();
            this.DayBox = new System.Windows.Forms.ComboBox();
            this.MonthBox = new System.Windows.Forms.ComboBox();
            this.yearBox = new System.Windows.Forms.TextBox();
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DescriptionBox = new System.Windows.Forms.RichTextBox();
            this.ReminderBox = new System.Windows.Forms.CheckBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HourBox
            // 
            this.HourBox.BackColor = System.Drawing.Color.Gold;
            this.HourBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HourBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HourBox.Font = new System.Drawing.Font("Segoe Script", 5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HourBox.FormattingEnabled = true;
            this.HourBox.Location = new System.Drawing.Point(12, 12);
            this.HourBox.Name = "HourBox";
            this.HourBox.Size = new System.Drawing.Size(54, 19);
            this.HourBox.TabIndex = 5;
            // 
            // MinBox
            // 
            this.MinBox.BackColor = System.Drawing.Color.Gold;
            this.MinBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MinBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinBox.Font = new System.Drawing.Font("Segoe Script", 5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MinBox.FormattingEnabled = true;
            this.MinBox.Location = new System.Drawing.Point(72, 12);
            this.MinBox.Name = "MinBox";
            this.MinBox.Size = new System.Drawing.Size(64, 19);
            this.MinBox.TabIndex = 6;
            // 
            // DayBox
            // 
            this.DayBox.BackColor = System.Drawing.Color.Gold;
            this.DayBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DayBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DayBox.Font = new System.Drawing.Font("Segoe Script", 5F, System.Drawing.FontStyle.Italic);
            this.DayBox.FormattingEnabled = true;
            this.DayBox.Location = new System.Drawing.Point(142, 12);
            this.DayBox.Name = "DayBox";
            this.DayBox.Size = new System.Drawing.Size(73, 19);
            this.DayBox.TabIndex = 7;
            // 
            // MonthBox
            // 
            this.MonthBox.BackColor = System.Drawing.Color.Gold;
            this.MonthBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MonthBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MonthBox.Font = new System.Drawing.Font("Segoe Script", 5F, System.Drawing.FontStyle.Italic);
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
            this.MonthBox.Location = new System.Drawing.Point(221, 12);
            this.MonthBox.Name = "MonthBox";
            this.MonthBox.Size = new System.Drawing.Size(110, 19);
            this.MonthBox.TabIndex = 8;
            this.MonthBox.SelectedIndexChanged += new System.EventHandler(this.MonthBox_SelectedIndexChanged);
            // 
            // yearBox
            // 
            this.yearBox.BackColor = System.Drawing.Color.Gold;
            this.yearBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.yearBox.Font = new System.Drawing.Font("Segoe Script", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.yearBox.Location = new System.Drawing.Point(337, 12);
            this.yearBox.Multiline = true;
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(74, 19);
            this.yearBox.TabIndex = 9;
            this.yearBox.Text = "2019";
            this.yearBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.yearBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yearBox_KeyPress);
            // 
            // TitleBox
            // 
            this.TitleBox.BackColor = System.Drawing.Color.Gold;
            this.TitleBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TitleBox.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TitleBox.Location = new System.Drawing.Point(12, 46);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(581, 29);
            this.TitleBox.TabIndex = 10;
            this.TitleBox.Text = "Title";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(13, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 10);
            this.panel1.TabIndex = 11;
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.BackColor = System.Drawing.Color.Gold;
            this.DescriptionBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescriptionBox.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DescriptionBox.Location = new System.Drawing.Point(12, 105);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(581, 415);
            this.DescriptionBox.TabIndex = 12;
            this.DescriptionBox.Text = "Description";
            // 
            // ReminderBox
            // 
            this.ReminderBox.AutoSize = true;
            this.ReminderBox.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ReminderBox.Location = new System.Drawing.Point(441, 526);
            this.ReminderBox.Name = "ReminderBox";
            this.ReminderBox.Size = new System.Drawing.Size(123, 32);
            this.ReminderBox.TabIndex = 13;
            this.ReminderBox.Text = "Remind Me";
            this.ReminderBox.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SaveButton.Location = new System.Drawing.Point(19, 602);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(273, 42);
            this.SaveButton.TabIndex = 15;
            this.SaveButton.Text = "SAVE";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CloseButton.Location = new System.Drawing.Point(308, 602);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(273, 42);
            this.CloseButton.TabIndex = 14;
            this.CloseButton.Text = "CLOSE";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // AddNoteWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(605, 656);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ReminderBox);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TitleBox);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.MonthBox);
            this.Controls.Add(this.DayBox);
            this.Controls.Add(this.MinBox);
            this.Controls.Add(this.HourBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddNoteWindow";
            this.Text = "AddNoteWindow";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddNoteWindow_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AddNoteWindow_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox HourBox;
        private System.Windows.Forms.ComboBox MinBox;
        private System.Windows.Forms.ComboBox DayBox;
        private System.Windows.Forms.ComboBox MonthBox;
        private System.Windows.Forms.TextBox yearBox;
        private System.Windows.Forms.TextBox TitleBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox DescriptionBox;
        private System.Windows.Forms.CheckBox ReminderBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CloseButton;
    }
}