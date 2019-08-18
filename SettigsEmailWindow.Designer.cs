namespace MyCalendar
{
    partial class SettigsEmailWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettigsEmailWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.textBoxSecret = new System.Windows.Forms.TextBox();
            this.textBoxClientID = new System.Windows.Forms.TextBox();
            this.textBoxProjectID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Configure Google Calendar: ";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linkLabel1.Location = new System.Drawing.Point(312, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(150, 35);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "CLICK HERE!";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // textBoxMail
            // 
            this.textBoxMail.BackColor = System.Drawing.Color.SteelBlue;
            this.textBoxMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMail.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxMail.Location = new System.Drawing.Point(12, 267);
            this.textBoxMail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(681, 36);
            this.textBoxMail.TabIndex = 29;
            this.textBoxMail.Text = "Google Account (e-mail name)";
            this.textBoxMail.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxMail_MouseClick);
            // 
            // textBoxSecret
            // 
            this.textBoxSecret.BackColor = System.Drawing.Color.SteelBlue;
            this.textBoxSecret.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSecret.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSecret.Location = new System.Drawing.Point(12, 225);
            this.textBoxSecret.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSecret.Name = "textBoxSecret";
            this.textBoxSecret.Size = new System.Drawing.Size(681, 36);
            this.textBoxSecret.TabIndex = 30;
            this.textBoxSecret.Text = "Client Secret";
            this.textBoxSecret.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxSecret_MouseClick);
            // 
            // textBoxClientID
            // 
            this.textBoxClientID.BackColor = System.Drawing.Color.SteelBlue;
            this.textBoxClientID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxClientID.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxClientID.Location = new System.Drawing.Point(12, 183);
            this.textBoxClientID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxClientID.Name = "textBoxClientID";
            this.textBoxClientID.Size = new System.Drawing.Size(681, 36);
            this.textBoxClientID.TabIndex = 31;
            this.textBoxClientID.Text = "Client ID";
            this.textBoxClientID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxClientID_MouseClick);
            // 
            // textBoxProjectID
            // 
            this.textBoxProjectID.BackColor = System.Drawing.Color.SteelBlue;
            this.textBoxProjectID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxProjectID.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxProjectID.Location = new System.Drawing.Point(12, 141);
            this.textBoxProjectID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxProjectID.Name = "textBoxProjectID";
            this.textBoxProjectID.Size = new System.Drawing.Size(681, 36);
            this.textBoxProjectID.TabIndex = 32;
            this.textBoxProjectID.Text = "Project ID";
            this.textBoxProjectID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxProjectID_MouseClick);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(668, 90);
            this.label2.TabIndex = 33;
            this.label2.Text = "Fill the pools below with information from configuration process (remember to ena" +
    "ble Google API in project name!):";
            // 
            // SaveButton
            // 
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SaveButton.Location = new System.Drawing.Point(61, 309);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(273, 42);
            this.SaveButton.TabIndex = 35;
            this.SaveButton.Text = "SAVE";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CloseButton.Location = new System.Drawing.Point(350, 309);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(273, 42);
            this.CloseButton.TabIndex = 34;
            this.CloseButton.Text = "CLOSE";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SettigsEmailWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(706, 379);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxProjectID);
            this.Controls.Add(this.textBoxClientID);
            this.Controls.Add(this.textBoxSecret);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SettigsEmailWindow";
            this.Text = "SettigsEmailWindow";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SettingEmailWindow_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SettingEmailWindow_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.TextBox textBoxSecret;
        private System.Windows.Forms.TextBox textBoxClientID;
        private System.Windows.Forms.TextBox textBoxProjectID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CloseButton;
    }
}