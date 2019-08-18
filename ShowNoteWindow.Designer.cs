namespace MyCalendar
{
    partial class ShowNoteWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowNoteWindow));
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelNameDate = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelNoteName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DescriptionBox = new System.Windows.Forms.RichTextBox();
            this.labelReminder = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Red;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 13F);
            this.buttonClose.Location = new System.Drawing.Point(282, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(35, 35);
            this.buttonClose.TabIndex = 12;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Gray;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 13F);
            this.buttonDelete.Image = global::MyCalendar.Properties.Resources.deletesmall;
            this.buttonDelete.Location = new System.Drawing.Point(282, 298);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(35, 35);
            this.buttonDelete.TabIndex = 13;
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelNameDate
            // 
            this.labelNameDate.AutoSize = true;
            this.labelNameDate.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Italic);
            this.labelNameDate.Location = new System.Drawing.Point(12, 9);
            this.labelNameDate.Name = "labelNameDate";
            this.labelNameDate.Size = new System.Drawing.Size(86, 24);
            this.labelNameDate.TabIndex = 14;
            this.labelNameDate.Text = "Note Date:";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Italic);
            this.labelDate.Location = new System.Drawing.Point(93, 9);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(136, 24);
            this.labelDate.TabIndex = 15;
            this.labelDate.Text = "11/11/11 11:11";
            // 
            // labelNoteName
            // 
            this.labelNoteName.AutoSize = true;
            this.labelNoteName.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Italic);
            this.labelNoteName.Location = new System.Drawing.Point(12, 49);
            this.labelNoteName.Name = "labelNoteName";
            this.labelNoteName.Size = new System.Drawing.Size(63, 30);
            this.labelNoteName.TabIndex = 16;
            this.labelNoteName.Text = "Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(12, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(131, 8);
            this.panel1.TabIndex = 17;
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.BackColor = System.Drawing.Color.Gold;
            this.DescriptionBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescriptionBox.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DescriptionBox.Location = new System.Drawing.Point(12, 96);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(305, 196);
            this.DescriptionBox.TabIndex = 18;
            this.DescriptionBox.Text = "Description";
            // 
            // labelReminder
            // 
            this.labelReminder.AutoSize = true;
            this.labelReminder.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelReminder.Location = new System.Drawing.Point(20, 308);
            this.labelReminder.Name = "labelReminder";
            this.labelReminder.Size = new System.Drawing.Size(184, 24);
            this.labelReminder.TabIndex = 19;
            this.labelReminder.Text = "You didn\'t set reminder!";
            // 
            // ShowNoteWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(329, 345);
            this.Controls.Add(this.labelReminder);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelNoteName);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelNameDate);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShowNoteWindow";
            this.Text = "ShowNoteWindow";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ShowNoteWindow_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ShowNoteWindow_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelNameDate;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelNoteName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox DescriptionBox;
        private System.Windows.Forms.Label labelReminder;
    }
}