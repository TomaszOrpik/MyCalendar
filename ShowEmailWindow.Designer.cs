namespace MyCalendar
{
    partial class ShowEmailWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowEmailWindow));
            this.buttonClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Datelabel = new System.Windows.Forms.Label();
            this.MyMaillabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.Subjectlabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Recipientlabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Bodylabel = new System.Windows.Forms.Label();
            this.Sendedlabel = new System.Windows.Forms.Label();
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
            this.buttonClose.TabIndex = 19;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "Mail send at:";
            // 
            // Datelabel
            // 
            this.Datelabel.AutoSize = true;
            this.Datelabel.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Datelabel.Location = new System.Drawing.Point(100, 12);
            this.Datelabel.Name = "Datelabel";
            this.Datelabel.Size = new System.Drawing.Size(51, 24);
            this.Datelabel.TabIndex = 22;
            this.Datelabel.Text = "DATE";
            // 
            // MyMaillabel
            // 
            this.MyMaillabel.AutoSize = true;
            this.MyMaillabel.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MyMaillabel.Location = new System.Drawing.Point(60, 36);
            this.MyMaillabel.Name = "MyMaillabel";
            this.MyMaillabel.Size = new System.Drawing.Size(57, 24);
            this.MyMaillabel.TabIndex = 24;
            this.MyMaillabel.Text = "EMAIL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(3, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = "From:";
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
            this.buttonDelete.TabIndex = 20;
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // Subjectlabel
            // 
            this.Subjectlabel.AutoSize = true;
            this.Subjectlabel.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Subjectlabel.Location = new System.Drawing.Point(3, 108);
            this.Subjectlabel.Name = "Subjectlabel";
            this.Subjectlabel.Size = new System.Drawing.Size(77, 24);
            this.Subjectlabel.TabIndex = 28;
            this.Subjectlabel.Text = "SUBJECT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(3, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 24);
            this.label5.TabIndex = 27;
            this.label5.Text = "Subject:";
            // 
            // Recipientlabel
            // 
            this.Recipientlabel.AutoSize = true;
            this.Recipientlabel.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Recipientlabel.Location = new System.Drawing.Point(40, 60);
            this.Recipientlabel.Name = "Recipientlabel";
            this.Recipientlabel.Size = new System.Drawing.Size(88, 24);
            this.Recipientlabel.TabIndex = 26;
            this.Recipientlabel.Text = "RECIPIENT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(3, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 24);
            this.label3.TabIndex = 25;
            this.label3.Text = "To:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(3, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 24);
            this.label4.TabIndex = 29;
            this.label4.Text = "Body:";
            // 
            // Bodylabel
            // 
            this.Bodylabel.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Bodylabel.Location = new System.Drawing.Point(1, 156);
            this.Bodylabel.Name = "Bodylabel";
            this.Bodylabel.Size = new System.Drawing.Size(307, 123);
            this.Bodylabel.TabIndex = 30;
            this.Bodylabel.Text = "BODY";
            // 
            // Sendedlabel
            // 
            this.Sendedlabel.AutoSize = true;
            this.Sendedlabel.Font = new System.Drawing.Font("Segoe Print", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Sendedlabel.ForeColor = System.Drawing.Color.Black;
            this.Sendedlabel.Location = new System.Drawing.Point(12, 309);
            this.Sendedlabel.Name = "Sendedlabel";
            this.Sendedlabel.Size = new System.Drawing.Size(130, 24);
            this.Sendedlabel.TabIndex = 31;
            this.Sendedlabel.Text = "Mail not Sended!";
            // 
            // ShowEmailWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(329, 345);
            this.Controls.Add(this.Sendedlabel);
            this.Controls.Add(this.Bodylabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Subjectlabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Recipientlabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MyMaillabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Datelabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShowEmailWindow";
            this.Text = "ShowEmailWindow";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ShowEmailWindow_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ShowEmailWindow_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Datelabel;
        private System.Windows.Forms.Label MyMaillabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Subjectlabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Recipientlabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Bodylabel;
        private System.Windows.Forms.Label Sendedlabel;
    }
}