namespace MyCalendar
{
    partial class AddEvent
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.labelEnd = new System.Windows.Forms.Label();
            this.labelStart = new System.Windows.Forms.Label();
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
            this.DescriptionBox = new System.Windows.Forms.RichTextBox();
            this.checkBoxReminder = new System.Windows.Forms.CheckBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.OliveDrab;
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName.Font = new System.Drawing.Font("Segoe Print", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxName.Location = new System.Drawing.Point(8, 7);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(447, 24);
            this.textBoxName.TabIndex = 31;
            this.textBoxName.Text = "Name";
            this.textBoxName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxName_MouseClick);
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.BackColor = System.Drawing.Color.OliveDrab;
            this.textBoxLocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLocation.Font = new System.Drawing.Font("Segoe Print", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxLocation.Location = new System.Drawing.Point(8, 36);
            this.textBoxLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(447, 24);
            this.textBoxLocation.TabIndex = 30;
            this.textBoxLocation.Text = "Location";
            this.textBoxLocation.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxLocation_MouseClick);
            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.labelEnd.Font = new System.Drawing.Font("Segoe Print", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEnd.Location = new System.Drawing.Point(3, 116);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(81, 24);
            this.labelEnd.TabIndex = 33;
            this.labelEnd.Text = "End Date:";
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Font = new System.Drawing.Font("Segoe Print", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelStart.Location = new System.Drawing.Point(3, 62);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(91, 24);
            this.labelStart.TabIndex = 32;
            this.labelStart.Text = "Start Date:";
            // 
            // yearBox
            // 
            this.yearBox.BackColor = System.Drawing.Color.OliveDrab;
            this.yearBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.yearBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.yearBox.Location = new System.Drawing.Point(333, 89);
            this.yearBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yearBox.Multiline = true;
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(121, 25);
            this.yearBox.TabIndex = 38;
            this.yearBox.Text = "2019";
            this.yearBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.yearBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yearBox_KeyPress);
            // 
            // MonthBox
            // 
            this.MonthBox.BackColor = System.Drawing.Color.OliveDrab;
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
            this.MonthBox.Location = new System.Drawing.Point(208, 87);
            this.MonthBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MonthBox.Name = "MonthBox";
            this.MonthBox.Size = new System.Drawing.Size(116, 25);
            this.MonthBox.TabIndex = 37;
            this.MonthBox.SelectedIndexChanged += new System.EventHandler(this.MonthBox_SelectedIndexChanged);
            // 
            // DayBox
            // 
            this.DayBox.BackColor = System.Drawing.Color.OliveDrab;
            this.DayBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DayBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DayBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DayBox.FormattingEnabled = true;
            this.DayBox.Location = new System.Drawing.Point(137, 87);
            this.DayBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DayBox.Name = "DayBox";
            this.DayBox.Size = new System.Drawing.Size(64, 25);
            this.DayBox.TabIndex = 36;
            // 
            // MinBox
            // 
            this.MinBox.BackColor = System.Drawing.Color.OliveDrab;
            this.MinBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MinBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MinBox.FormattingEnabled = true;
            this.MinBox.Location = new System.Drawing.Point(69, 87);
            this.MinBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinBox.Name = "MinBox";
            this.MinBox.Size = new System.Drawing.Size(61, 25);
            this.MinBox.TabIndex = 35;
            // 
            // HourBox
            // 
            this.HourBox.BackColor = System.Drawing.Color.OliveDrab;
            this.HourBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HourBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HourBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HourBox.FormattingEnabled = true;
            this.HourBox.Location = new System.Drawing.Point(8, 87);
            this.HourBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HourBox.Name = "HourBox";
            this.HourBox.Size = new System.Drawing.Size(55, 25);
            this.HourBox.TabIndex = 34;
            // 
            // yearBox1
            // 
            this.yearBox1.BackColor = System.Drawing.Color.OliveDrab;
            this.yearBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.yearBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.yearBox1.Location = new System.Drawing.Point(333, 142);
            this.yearBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yearBox1.Multiline = true;
            this.yearBox1.Name = "yearBox1";
            this.yearBox1.Size = new System.Drawing.Size(121, 25);
            this.yearBox1.TabIndex = 43;
            this.yearBox1.Text = "2019";
            this.yearBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.yearBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yearBox1_KeyPress);
            // 
            // MonthBox1
            // 
            this.MonthBox1.BackColor = System.Drawing.Color.OliveDrab;
            this.MonthBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MonthBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MonthBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
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
            this.MonthBox1.Location = new System.Drawing.Point(208, 142);
            this.MonthBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MonthBox1.Name = "MonthBox1";
            this.MonthBox1.Size = new System.Drawing.Size(116, 25);
            this.MonthBox1.TabIndex = 42;
            this.MonthBox1.SelectedIndexChanged += new System.EventHandler(this.MonthBox1_SelectedIndexChanged);
            // 
            // DayBox1
            // 
            this.DayBox1.BackColor = System.Drawing.Color.OliveDrab;
            this.DayBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DayBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DayBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DayBox1.FormattingEnabled = true;
            this.DayBox1.Location = new System.Drawing.Point(137, 142);
            this.DayBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DayBox1.Name = "DayBox1";
            this.DayBox1.Size = new System.Drawing.Size(64, 25);
            this.DayBox1.TabIndex = 41;
            // 
            // MinBox1
            // 
            this.MinBox1.BackColor = System.Drawing.Color.OliveDrab;
            this.MinBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MinBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MinBox1.FormattingEnabled = true;
            this.MinBox1.Location = new System.Drawing.Point(69, 142);
            this.MinBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinBox1.Name = "MinBox1";
            this.MinBox1.Size = new System.Drawing.Size(61, 25);
            this.MinBox1.TabIndex = 40;
            // 
            // HourBox1
            // 
            this.HourBox1.BackColor = System.Drawing.Color.OliveDrab;
            this.HourBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HourBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HourBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HourBox1.FormattingEnabled = true;
            this.HourBox1.Location = new System.Drawing.Point(8, 142);
            this.HourBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HourBox1.Name = "HourBox1";
            this.HourBox1.Size = new System.Drawing.Size(55, 25);
            this.HourBox1.TabIndex = 39;
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.BackColor = System.Drawing.Color.OliveDrab;
            this.DescriptionBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescriptionBox.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DescriptionBox.Location = new System.Drawing.Point(8, 172);
            this.DescriptionBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(447, 213);
            this.DescriptionBox.TabIndex = 44;
            this.DescriptionBox.Text = "Description";
            this.DescriptionBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DescriptionBox_MouseClick);
            // 
            // checkBoxReminder
            // 
            this.checkBoxReminder.AutoSize = true;
            this.checkBoxReminder.Font = new System.Drawing.Font("Segoe Print", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxReminder.Location = new System.Drawing.Point(275, 390);
            this.checkBoxReminder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxReminder.Name = "checkBoxReminder";
            this.checkBoxReminder.Size = new System.Drawing.Size(169, 28);
            this.checkBoxReminder.TabIndex = 45;
            this.checkBoxReminder.Text = "Send Remind SMS?";
            this.checkBoxReminder.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SaveButton.Location = new System.Drawing.Point(124, 423);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(201, 42);
            this.SaveButton.TabIndex = 46;
            this.SaveButton.Text = "SAVE";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AddEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.checkBoxReminder);
            this.Controls.Add(this.DescriptionBox);
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
            this.Controls.Add(this.labelEnd);
            this.Controls.Add(this.labelStart);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxLocation);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddEvent";
            this.Size = new System.Drawing.Size(468, 487);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.Label labelStart;
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
        private System.Windows.Forms.RichTextBox DescriptionBox;
        private System.Windows.Forms.CheckBox checkBoxReminder;
        private System.Windows.Forms.Button SaveButton;
    }
}
