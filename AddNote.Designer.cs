namespace MyCalendar
{
    partial class AddNote
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
            this.DescriptionBox = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.ReminderBox = new System.Windows.Forms.CheckBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // yearBox
            // 
            this.yearBox.BackColor = System.Drawing.Color.Gold;
            this.yearBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.yearBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.yearBox.Location = new System.Drawing.Point(385, 7);
            this.yearBox.Margin = new System.Windows.Forms.Padding(4);
            this.yearBox.Multiline = true;
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(79, 26);
            this.yearBox.TabIndex = 14;
            this.yearBox.Text = "2019";
            this.yearBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.yearBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yearBox_KeyPress);
            // 
            // MonthBox
            // 
            this.MonthBox.BackColor = System.Drawing.Color.Gold;
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
            this.MonthBox.Location = new System.Drawing.Point(256, 4);
            this.MonthBox.Margin = new System.Windows.Forms.Padding(4);
            this.MonthBox.Name = "MonthBox";
            this.MonthBox.Size = new System.Drawing.Size(120, 25);
            this.MonthBox.TabIndex = 13;
            this.MonthBox.SelectedIndexChanged += new System.EventHandler(this.MonthBox_SelectedIndexChanged);
            // 
            // DayBox
            // 
            this.DayBox.BackColor = System.Drawing.Color.Gold;
            this.DayBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DayBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DayBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DayBox.FormattingEnabled = true;
            this.DayBox.Location = new System.Drawing.Point(151, 4);
            this.DayBox.Margin = new System.Windows.Forms.Padding(4);
            this.DayBox.Name = "DayBox";
            this.DayBox.Size = new System.Drawing.Size(96, 25);
            this.DayBox.TabIndex = 12;
            // 
            // MinBox
            // 
            this.MinBox.BackColor = System.Drawing.Color.Gold;
            this.MinBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MinBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MinBox.FormattingEnabled = true;
            this.MinBox.Location = new System.Drawing.Point(75, 4);
            this.MinBox.Margin = new System.Windows.Forms.Padding(4);
            this.MinBox.Name = "MinBox";
            this.MinBox.Size = new System.Drawing.Size(67, 25);
            this.MinBox.TabIndex = 11;
            // 
            // HourBox
            // 
            this.HourBox.BackColor = System.Drawing.Color.Gold;
            this.HourBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HourBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HourBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HourBox.FormattingEnabled = true;
            this.HourBox.Location = new System.Drawing.Point(7, 4);
            this.HourBox.Margin = new System.Windows.Forms.Padding(4);
            this.HourBox.Name = "HourBox";
            this.HourBox.Size = new System.Drawing.Size(59, 25);
            this.HourBox.TabIndex = 10;
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.BackColor = System.Drawing.Color.Gold;
            this.DescriptionBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescriptionBox.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DescriptionBox.Location = new System.Drawing.Point(11, 87);
            this.DescriptionBox.Margin = new System.Windows.Forms.Padding(4);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(440, 283);
            this.DescriptionBox.TabIndex = 17;
            this.DescriptionBox.Text = "Description";
            this.DescriptionBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DescriptionBox_MouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel1.Location = new System.Drawing.Point(12, 68);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 12);
            this.panel1.TabIndex = 16;
            // 
            // TitleBox
            // 
            this.TitleBox.BackColor = System.Drawing.Color.Gold;
            this.TitleBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TitleBox.Font = new System.Drawing.Font("Segoe Print", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TitleBox.Location = new System.Drawing.Point(11, 37);
            this.TitleBox.Margin = new System.Windows.Forms.Padding(4);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(457, 24);
            this.TitleBox.TabIndex = 15;
            this.TitleBox.Text = "Title";
            this.TitleBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TitleBox_MouseClick);
            // 
            // ReminderBox
            // 
            this.ReminderBox.AutoSize = true;
            this.ReminderBox.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ReminderBox.Location = new System.Drawing.Point(287, 378);
            this.ReminderBox.Margin = new System.Windows.Forms.Padding(4);
            this.ReminderBox.Name = "ReminderBox";
            this.ReminderBox.Size = new System.Drawing.Size(152, 39);
            this.ReminderBox.TabIndex = 18;
            this.ReminderBox.Text = "Remind Me";
            this.ReminderBox.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SaveButton.Location = new System.Drawing.Point(49, 421);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(364, 52);
            this.SaveButton.TabIndex = 19;
            this.SaveButton.Text = "SAVE";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AddNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ReminderBox);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TitleBox);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.MonthBox);
            this.Controls.Add(this.DayBox);
            this.Controls.Add(this.MinBox);
            this.Controls.Add(this.HourBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddNote";
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
        private System.Windows.Forms.RichTextBox DescriptionBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TitleBox;
        private System.Windows.Forms.CheckBox ReminderBox;
        private System.Windows.Forms.Button SaveButton;
    }
}
