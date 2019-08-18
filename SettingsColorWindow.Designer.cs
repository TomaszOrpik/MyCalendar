namespace MyCalendar
{
    partial class SettingsColorWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsColorWindow));
            this.labelBackground = new System.Windows.Forms.Label();
            this.BackgroundBox = new System.Windows.Forms.ComboBox();
            this.DaysBox = new System.Windows.Forms.ComboBox();
            this.labelDays = new System.Windows.Forms.Label();
            this.BusyBox = new System.Windows.Forms.ComboBox();
            this.labelBusy = new System.Windows.Forms.Label();
            this.TodayBox = new System.Windows.Forms.ComboBox();
            this.labelToday = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelBackground
            // 
            this.labelBackground.AutoSize = true;
            this.labelBackground.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBackground.Location = new System.Drawing.Point(12, 21);
            this.labelBackground.Name = "labelBackground";
            this.labelBackground.Size = new System.Drawing.Size(200, 35);
            this.labelBackground.TabIndex = 0;
            this.labelBackground.Text = "Background Color:";
            // 
            // BackgroundBox
            // 
            this.BackgroundBox.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BackgroundBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackgroundBox.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BackgroundBox.FormattingEnabled = true;
            this.BackgroundBox.Items.AddRange(new object[] {
            "White",
            "Black",
            "Gray",
            "Yellow",
            "Orange",
            "Red",
            "Blue",
            "Green",
            "Violet",
            "Pink"});
            this.BackgroundBox.Location = new System.Drawing.Point(227, 18);
            this.BackgroundBox.Name = "BackgroundBox";
            this.BackgroundBox.Size = new System.Drawing.Size(191, 43);
            this.BackgroundBox.TabIndex = 31;
            // 
            // DaysBox
            // 
            this.DaysBox.BackColor = System.Drawing.Color.SteelBlue;
            this.DaysBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DaysBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DaysBox.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DaysBox.FormattingEnabled = true;
            this.DaysBox.Items.AddRange(new object[] {
            "White",
            "Black",
            "Gray",
            "Yellow",
            "Orange",
            "Red",
            "Blue",
            "Green",
            "Violet",
            "Pink"});
            this.DaysBox.Location = new System.Drawing.Point(227, 73);
            this.DaysBox.Name = "DaysBox";
            this.DaysBox.Size = new System.Drawing.Size(191, 43);
            this.DaysBox.TabIndex = 33;
            // 
            // labelDays
            // 
            this.labelDays.AutoSize = true;
            this.labelDays.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDays.Location = new System.Drawing.Point(12, 76);
            this.labelDays.Name = "labelDays";
            this.labelDays.Size = new System.Drawing.Size(129, 35);
            this.labelDays.TabIndex = 32;
            this.labelDays.Text = "Days Color:";
            // 
            // BusyBox
            // 
            this.BusyBox.BackColor = System.Drawing.Color.SteelBlue;
            this.BusyBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BusyBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BusyBox.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BusyBox.FormattingEnabled = true;
            this.BusyBox.Items.AddRange(new object[] {
            "White",
            "Black",
            "Gray",
            "Yellow",
            "Orange",
            "Red",
            "Blue",
            "Green",
            "Violet",
            "Pink"});
            this.BusyBox.Location = new System.Drawing.Point(227, 127);
            this.BusyBox.Name = "BusyBox";
            this.BusyBox.Size = new System.Drawing.Size(191, 43);
            this.BusyBox.TabIndex = 35;
            // 
            // labelBusy
            // 
            this.labelBusy.AutoSize = true;
            this.labelBusy.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBusy.Location = new System.Drawing.Point(12, 130);
            this.labelBusy.Name = "labelBusy";
            this.labelBusy.Size = new System.Drawing.Size(184, 35);
            this.labelBusy.TabIndex = 34;
            this.labelBusy.Text = "Busy Days Color:";
            // 
            // TodayBox
            // 
            this.TodayBox.BackColor = System.Drawing.Color.SteelBlue;
            this.TodayBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TodayBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TodayBox.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TodayBox.FormattingEnabled = true;
            this.TodayBox.Items.AddRange(new object[] {
            "White",
            "Black",
            "Gray",
            "Yellow",
            "Orange",
            "Red",
            "Blue",
            "Green",
            "Violet",
            "Pink"});
            this.TodayBox.Location = new System.Drawing.Point(227, 182);
            this.TodayBox.Name = "TodayBox";
            this.TodayBox.Size = new System.Drawing.Size(191, 43);
            this.TodayBox.TabIndex = 37;
            // 
            // labelToday
            // 
            this.labelToday.AutoSize = true;
            this.labelToday.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelToday.Location = new System.Drawing.Point(12, 185);
            this.labelToday.Name = "labelToday";
            this.labelToday.Size = new System.Drawing.Size(190, 35);
            this.labelToday.TabIndex = 36;
            this.labelToday.Text = "Today Day Color:";
            // 
            // SaveButton
            // 
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SaveButton.Location = new System.Drawing.Point(18, 251);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(194, 42);
            this.SaveButton.TabIndex = 39;
            this.SaveButton.Text = "SAVE";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CloseButton.Location = new System.Drawing.Point(224, 251);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(194, 42);
            this.CloseButton.TabIndex = 38;
            this.CloseButton.Text = "CLOSE";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SettingsColorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(434, 335);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.TodayBox);
            this.Controls.Add(this.labelToday);
            this.Controls.Add(this.BusyBox);
            this.Controls.Add(this.labelBusy);
            this.Controls.Add(this.DaysBox);
            this.Controls.Add(this.labelDays);
            this.Controls.Add(this.BackgroundBox);
            this.Controls.Add(this.labelBackground);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsColorWindow";
            this.Text = "SettingsColorWindow";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SettingsColorWindow_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SettingsColorWindow_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBackground;
        private System.Windows.Forms.ComboBox BackgroundBox;
        private System.Windows.Forms.ComboBox DaysBox;
        private System.Windows.Forms.Label labelDays;
        private System.Windows.Forms.ComboBox BusyBox;
        private System.Windows.Forms.Label labelBusy;
        private System.Windows.Forms.ComboBox TodayBox;
        private System.Windows.Forms.Label labelToday;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CloseButton;
    }
}