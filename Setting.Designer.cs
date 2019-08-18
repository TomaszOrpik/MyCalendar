namespace MyCalendar
{
    partial class Setting
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
            this.buttonConfigureGoogleCalendar = new System.Windows.Forms.Button();
            this.buttonSetEmail = new System.Windows.Forms.Button();
            this.buttonStats = new System.Windows.Forms.Button();
            this.buttonColors = new System.Windows.Forms.Button();
            this.buttonDelVisits = new System.Windows.Forms.Button();
            this.buttonDelEmail = new System.Windows.Forms.Button();
            this.buttonDelNotes = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonConfigureGoogleCalendar
            // 
            this.buttonConfigureGoogleCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfigureGoogleCalendar.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonConfigureGoogleCalendar.Location = new System.Drawing.Point(85, 292);
            this.buttonConfigureGoogleCalendar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonConfigureGoogleCalendar.Name = "buttonConfigureGoogleCalendar";
            this.buttonConfigureGoogleCalendar.Size = new System.Drawing.Size(280, 47);
            this.buttonConfigureGoogleCalendar.TabIndex = 16;
            this.buttonConfigureGoogleCalendar.Text = "SET GOOGLE CALENDAR";
            this.buttonConfigureGoogleCalendar.UseVisualStyleBackColor = true;
            this.buttonConfigureGoogleCalendar.Click += new System.EventHandler(this.buttonConfigureGoogleCalendar_Click);
            // 
            // buttonSetEmail
            // 
            this.buttonSetEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetEmail.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSetEmail.Location = new System.Drawing.Point(85, 240);
            this.buttonSetEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSetEmail.Name = "buttonSetEmail";
            this.buttonSetEmail.Size = new System.Drawing.Size(280, 47);
            this.buttonSetEmail.TabIndex = 15;
            this.buttonSetEmail.Text = "SET DEFAULT E-MAIL";
            this.buttonSetEmail.UseVisualStyleBackColor = true;
            this.buttonSetEmail.Click += new System.EventHandler(this.buttonSetEmail_Click);
            // 
            // buttonStats
            // 
            this.buttonStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStats.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStats.Location = new System.Drawing.Point(85, 395);
            this.buttonStats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStats.Name = "buttonStats";
            this.buttonStats.Size = new System.Drawing.Size(280, 47);
            this.buttonStats.TabIndex = 14;
            this.buttonStats.Text = "STATISTICS";
            this.buttonStats.UseVisualStyleBackColor = true;
            this.buttonStats.Click += new System.EventHandler(this.buttonStats_Click);
            // 
            // buttonColors
            // 
            this.buttonColors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonColors.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonColors.Location = new System.Drawing.Point(85, 343);
            this.buttonColors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonColors.Name = "buttonColors";
            this.buttonColors.Size = new System.Drawing.Size(280, 47);
            this.buttonColors.TabIndex = 13;
            this.buttonColors.Text = "CHANGE COLORS";
            this.buttonColors.UseVisualStyleBackColor = true;
            this.buttonColors.Click += new System.EventHandler(this.buttonColors_Click);
            // 
            // buttonDelVisits
            // 
            this.buttonDelVisits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelVisits.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDelVisits.Location = new System.Drawing.Point(85, 188);
            this.buttonDelVisits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDelVisits.Name = "buttonDelVisits";
            this.buttonDelVisits.Size = new System.Drawing.Size(280, 47);
            this.buttonDelVisits.TabIndex = 12;
            this.buttonDelVisits.Text = "DELETE OLD VISITS";
            this.buttonDelVisits.UseVisualStyleBackColor = true;
            this.buttonDelVisits.Click += new System.EventHandler(this.buttonDelVisits_Click);
            // 
            // buttonDelEmail
            // 
            this.buttonDelEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelEmail.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDelEmail.Location = new System.Drawing.Point(85, 137);
            this.buttonDelEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDelEmail.Name = "buttonDelEmail";
            this.buttonDelEmail.Size = new System.Drawing.Size(280, 47);
            this.buttonDelEmail.TabIndex = 11;
            this.buttonDelEmail.Text = "DELETE OLD E-MAILS";
            this.buttonDelEmail.UseVisualStyleBackColor = true;
            this.buttonDelEmail.Click += new System.EventHandler(this.buttonDelEmail_Click);
            // 
            // buttonDelNotes
            // 
            this.buttonDelNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelNotes.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDelNotes.Location = new System.Drawing.Point(85, 85);
            this.buttonDelNotes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDelNotes.Name = "buttonDelNotes";
            this.buttonDelNotes.Size = new System.Drawing.Size(280, 47);
            this.buttonDelNotes.TabIndex = 10;
            this.buttonDelNotes.Text = "DELETE OLD NOTES";
            this.buttonDelNotes.UseVisualStyleBackColor = true;
            this.buttonDelNotes.Click += new System.EventHandler(this.buttonDelNotes_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbout.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAbout.Location = new System.Drawing.Point(85, 33);
            this.buttonAbout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(280, 47);
            this.buttonAbout.TabIndex = 9;
            this.buttonAbout.Text = "ABOUT";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.buttonConfigureGoogleCalendar);
            this.Controls.Add(this.buttonSetEmail);
            this.Controls.Add(this.buttonStats);
            this.Controls.Add(this.buttonColors);
            this.Controls.Add(this.buttonDelVisits);
            this.Controls.Add(this.buttonDelEmail);
            this.Controls.Add(this.buttonDelNotes);
            this.Controls.Add(this.buttonAbout);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Setting";
            this.Size = new System.Drawing.Size(468, 487);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonConfigureGoogleCalendar;
        private System.Windows.Forms.Button buttonSetEmail;
        private System.Windows.Forms.Button buttonStats;
        private System.Windows.Forms.Button buttonColors;
        private System.Windows.Forms.Button buttonDelVisits;
        private System.Windows.Forms.Button buttonDelEmail;
        private System.Windows.Forms.Button buttonDelNotes;
        private System.Windows.Forms.Button buttonAbout;
    }
}
