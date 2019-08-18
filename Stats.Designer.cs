namespace MyCalendar
{
    partial class Stats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stats));
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelNotes = new System.Windows.Forms.Label();
            this.labelMails = new System.Windows.Forms.Label();
            this.labelEvents = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonClose.Location = new System.Drawing.Point(169, 215);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(187, 55);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "CLOSE";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelNotes
            // 
            this.labelNotes.AutoSize = true;
            this.labelNotes.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNotes.Location = new System.Drawing.Point(12, 30);
            this.labelNotes.Name = "labelNotes";
            this.labelNotes.Size = new System.Drawing.Size(402, 35);
            this.labelNotes.TabIndex = 1;
            this.labelNotes.Text = "You have 0 notes in witch 0 outdated!";
            // 
            // labelMails
            // 
            this.labelMails.AutoSize = true;
            this.labelMails.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMails.Location = new System.Drawing.Point(12, 86);
            this.labelMails.Name = "labelMails";
            this.labelMails.Size = new System.Drawing.Size(426, 35);
            this.labelMails.TabIndex = 2;
            this.labelMails.Text = "You have 0 e-mails in witch 0 outdated!";
            // 
            // labelEvents
            // 
            this.labelEvents.AutoSize = true;
            this.labelEvents.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEvents.Location = new System.Drawing.Point(12, 142);
            this.labelEvents.Name = "labelEvents";
            this.labelEvents.Size = new System.Drawing.Size(412, 35);
            this.labelEvents.TabIndex = 3;
            this.labelEvents.Text = "You have 0 events in witch 0 outdated!";
            // 
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(544, 296);
            this.Controls.Add(this.labelEvents);
            this.Controls.Add(this.labelMails);
            this.Controls.Add(this.labelNotes);
            this.Controls.Add(this.buttonClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Stats";
            this.Text = "Stats";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Stats_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Stats_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelNotes;
        private System.Windows.Forms.Label labelMails;
        private System.Windows.Forms.Label labelEvents;
    }
}