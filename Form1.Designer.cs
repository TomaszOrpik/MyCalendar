namespace MyCalendar
{
    partial class Form1
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

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.buttonNextMonth = new System.Windows.Forms.Button();
            this.buttonPrevMonth = new System.Windows.Forms.Button();
            this.panelCalendar = new System.Windows.Forms.Panel();
            this.setting1 = new MyCalendar.Setting();
            this.addEvent1 = new MyCalendar.AddEvent();
            this.addEmail1 = new MyCalendar.AddEmail();
            this.addNote1 = new MyCalendar.AddNote();
            this.Clock = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.button35 = new System.Windows.Forms.Button();
            this.button36 = new System.Windows.Forms.Button();
            this.button37 = new System.Windows.Forms.Button();
            this.button38 = new System.Windows.Forms.Button();
            this.button39 = new System.Windows.Forms.Button();
            this.button40 = new System.Windows.Forms.Button();
            this.button41 = new System.Windows.Forms.Button();
            this.button42 = new System.Windows.Forms.Button();
            this.labelTu = new System.Windows.Forms.Label();
            this.labelW = new System.Windows.Forms.Label();
            this.labelTh = new System.Windows.Forms.Label();
            this.labelF = new System.Windows.Forms.Label();
            this.labelSt = new System.Windows.Forms.Label();
            this.labelSu = new System.Windows.Forms.Label();
            this.labelM = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.buttonAddNote = new System.Windows.Forms.Button();
            this.buttonSendEmail = new System.Windows.Forms.Button();
            this.buttonAddVisit = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelCalendar.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxMonth.Font = new System.Drawing.Font("Segoe Print", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxMonth.FormattingEnabled = true;
            this.comboBoxMonth.Items.AddRange(new object[] {
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
            this.comboBoxMonth.Location = new System.Drawing.Point(36, -1);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(131, 39);
            this.comboBoxMonth.TabIndex = 1;
            this.comboBoxMonth.SelectedIndexChanged += new System.EventHandler(this.comboBoxMonth_SelectedIndexChanged);
            // 
            // textBoxYear
            // 
            this.textBoxYear.BackColor = System.Drawing.Color.White;
            this.textBoxYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxYear.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxYear.Location = new System.Drawing.Point(214, -1);
            this.textBoxYear.Multiline = true;
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(90, 30);
            this.textBoxYear.TabIndex = 6;
            this.textBoxYear.Text = "2019";
            this.textBoxYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxYear_KeyPress);
            // 
            // buttonNextMonth
            // 
            this.buttonNextMonth.BackColor = System.Drawing.Color.White;
            this.buttonNextMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNextMonth.Font = new System.Drawing.Font("Sigmar One", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNextMonth.Location = new System.Drawing.Point(315, -1);
            this.buttonNextMonth.Name = "buttonNextMonth";
            this.buttonNextMonth.Size = new System.Drawing.Size(31, 30);
            this.buttonNextMonth.TabIndex = 7;
            this.buttonNextMonth.Text = ">";
            this.buttonNextMonth.UseVisualStyleBackColor = false;
            this.buttonNextMonth.Click += new System.EventHandler(this.buttonNextMonth_Click);
            // 
            // buttonPrevMonth
            // 
            this.buttonPrevMonth.BackColor = System.Drawing.Color.White;
            this.buttonPrevMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrevMonth.Font = new System.Drawing.Font("Sigmar One", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPrevMonth.Location = new System.Drawing.Point(-1, -1);
            this.buttonPrevMonth.Name = "buttonPrevMonth";
            this.buttonPrevMonth.Size = new System.Drawing.Size(31, 30);
            this.buttonPrevMonth.TabIndex = 8;
            this.buttonPrevMonth.Text = "<";
            this.buttonPrevMonth.UseVisualStyleBackColor = false;
            this.buttonPrevMonth.Click += new System.EventHandler(this.buttonPrevMonth_Click);
            // 
            // panelCalendar
            // 
            this.panelCalendar.BackColor = System.Drawing.Color.White;
            this.panelCalendar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCalendar.Controls.Add(this.setting1);
            this.panelCalendar.Controls.Add(this.addEvent1);
            this.panelCalendar.Controls.Add(this.addEmail1);
            this.panelCalendar.Controls.Add(this.addNote1);
            this.panelCalendar.Controls.Add(this.Clock);
            this.panelCalendar.Controls.Add(this.button1);
            this.panelCalendar.Controls.Add(this.button2);
            this.panelCalendar.Controls.Add(this.button3);
            this.panelCalendar.Controls.Add(this.button4);
            this.panelCalendar.Controls.Add(this.button5);
            this.panelCalendar.Controls.Add(this.button6);
            this.panelCalendar.Controls.Add(this.button7);
            this.panelCalendar.Controls.Add(this.button8);
            this.panelCalendar.Controls.Add(this.button9);
            this.panelCalendar.Controls.Add(this.button10);
            this.panelCalendar.Controls.Add(this.button11);
            this.panelCalendar.Controls.Add(this.button12);
            this.panelCalendar.Controls.Add(this.button13);
            this.panelCalendar.Controls.Add(this.button14);
            this.panelCalendar.Controls.Add(this.button15);
            this.panelCalendar.Controls.Add(this.button16);
            this.panelCalendar.Controls.Add(this.button17);
            this.panelCalendar.Controls.Add(this.button18);
            this.panelCalendar.Controls.Add(this.button19);
            this.panelCalendar.Controls.Add(this.button20);
            this.panelCalendar.Controls.Add(this.button21);
            this.panelCalendar.Controls.Add(this.button22);
            this.panelCalendar.Controls.Add(this.button23);
            this.panelCalendar.Controls.Add(this.button24);
            this.panelCalendar.Controls.Add(this.button25);
            this.panelCalendar.Controls.Add(this.button26);
            this.panelCalendar.Controls.Add(this.button27);
            this.panelCalendar.Controls.Add(this.button28);
            this.panelCalendar.Controls.Add(this.button29);
            this.panelCalendar.Controls.Add(this.button30);
            this.panelCalendar.Controls.Add(this.button31);
            this.panelCalendar.Controls.Add(this.button32);
            this.panelCalendar.Controls.Add(this.button33);
            this.panelCalendar.Controls.Add(this.button34);
            this.panelCalendar.Controls.Add(this.button35);
            this.panelCalendar.Controls.Add(this.button36);
            this.panelCalendar.Controls.Add(this.button37);
            this.panelCalendar.Controls.Add(this.button38);
            this.panelCalendar.Controls.Add(this.button39);
            this.panelCalendar.Controls.Add(this.button40);
            this.panelCalendar.Controls.Add(this.button41);
            this.panelCalendar.Controls.Add(this.button42);
            this.panelCalendar.Controls.Add(this.labelTu);
            this.panelCalendar.Controls.Add(this.labelW);
            this.panelCalendar.Controls.Add(this.labelTh);
            this.panelCalendar.Controls.Add(this.labelF);
            this.panelCalendar.Controls.Add(this.labelSt);
            this.panelCalendar.Controls.Add(this.labelSu);
            this.panelCalendar.Controls.Add(this.labelM);
            this.panelCalendar.Controls.Add(this.comboBoxMonth);
            this.panelCalendar.Controls.Add(this.buttonNextMonth);
            this.panelCalendar.Controls.Add(this.buttonPrevMonth);
            this.panelCalendar.Controls.Add(this.textBoxYear);
            this.panelCalendar.Location = new System.Drawing.Point(0, 5);
            this.panelCalendar.Margin = new System.Windows.Forms.Padding(0);
            this.panelCalendar.Name = "panelCalendar";
            this.panelCalendar.Size = new System.Drawing.Size(352, 397);
            this.panelCalendar.TabIndex = 9;
            this.panelCalendar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelCalendar_MouseDown);
            this.panelCalendar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelCalendar_MouseMove);
            // 
            // setting1
            // 
            this.setting1.BackColor = System.Drawing.Color.SteelBlue;
            this.setting1.Location = new System.Drawing.Point(-1, -1);
            this.setting1.Margin = new System.Windows.Forms.Padding(4);
            this.setting1.Name = "setting1";
            this.setting1.Size = new System.Drawing.Size(468, 487);
            this.setting1.TabIndex = 21;
            // 
            // addEvent1
            // 
            this.addEvent1.BackColor = System.Drawing.Color.OliveDrab;
            this.addEvent1.Location = new System.Drawing.Point(-1, -1);
            this.addEvent1.Margin = new System.Windows.Forms.Padding(4);
            this.addEvent1.Name = "addEvent1";
            this.addEvent1.Size = new System.Drawing.Size(468, 487);
            this.addEvent1.TabIndex = 21;
            // 
            // addEmail1
            // 
            this.addEmail1.BackColor = System.Drawing.Color.Firebrick;
            this.addEmail1.Location = new System.Drawing.Point(-1, -1);
            this.addEmail1.Margin = new System.Windows.Forms.Padding(4);
            this.addEmail1.Name = "addEmail1";
            this.addEmail1.Size = new System.Drawing.Size(468, 487);
            this.addEmail1.TabIndex = 21;
            // 
            // addNote1
            // 
            this.addNote1.BackColor = System.Drawing.Color.Gold;
            this.addNote1.Location = new System.Drawing.Point(-1, -1);
            this.addNote1.Margin = new System.Windows.Forms.Padding(4);
            this.addNote1.Name = "addNote1";
            this.addNote1.Size = new System.Drawing.Size(468, 487);
            this.addNote1.TabIndex = 21;
            // 
            // Clock
            // 
            this.Clock.AutoSize = true;
            this.Clock.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clock.ForeColor = System.Drawing.Color.Black;
            this.Clock.Location = new System.Drawing.Point(135, 360);
            this.Clock.Name = "Clock";
            this.Clock.Size = new System.Drawing.Size(95, 34);
            this.Clock.TabIndex = 91;
            this.Clock.Text = "00:00";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(9, 65);
            this.button1.Margin = new System.Windows.Forms.Padding(1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 45);
            this.button1.TabIndex = 49;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(56, 65);
            this.button2.Margin = new System.Windows.Forms.Padding(1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 45);
            this.button2.TabIndex = 50;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(103, 65);
            this.button3.Margin = new System.Windows.Forms.Padding(1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 45);
            this.button3.TabIndex = 51;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(150, 65);
            this.button4.Margin = new System.Windows.Forms.Padding(1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(45, 45);
            this.button4.TabIndex = 52;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(197, 65);
            this.button5.Margin = new System.Windows.Forms.Padding(1);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(45, 45);
            this.button5.TabIndex = 53;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(243, 65);
            this.button6.Margin = new System.Windows.Forms.Padding(1);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(45, 45);
            this.button6.TabIndex = 54;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Red;
            this.button7.Location = new System.Drawing.Point(290, 65);
            this.button7.Margin = new System.Windows.Forms.Padding(1);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(45, 45);
            this.button7.TabIndex = 55;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(9, 112);
            this.button8.Margin = new System.Windows.Forms.Padding(1);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(45, 45);
            this.button8.TabIndex = 56;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(56, 112);
            this.button9.Margin = new System.Windows.Forms.Padding(1);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(45, 45);
            this.button9.TabIndex = 57;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(103, 112);
            this.button10.Margin = new System.Windows.Forms.Padding(1);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(45, 45);
            this.button10.TabIndex = 58;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(150, 112);
            this.button11.Margin = new System.Windows.Forms.Padding(1);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(45, 45);
            this.button11.TabIndex = 59;
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(197, 112);
            this.button12.Margin = new System.Windows.Forms.Padding(1);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(45, 45);
            this.button12.TabIndex = 60;
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(243, 112);
            this.button13.Margin = new System.Windows.Forms.Padding(1);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(45, 45);
            this.button13.TabIndex = 61;
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.Color.Red;
            this.button14.Location = new System.Drawing.Point(290, 112);
            this.button14.Margin = new System.Windows.Forms.Padding(1);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(45, 45);
            this.button14.TabIndex = 62;
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(9, 159);
            this.button15.Margin = new System.Windows.Forms.Padding(1);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(45, 45);
            this.button15.TabIndex = 63;
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.FlatAppearance.BorderSize = 0;
            this.button16.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(56, 159);
            this.button16.Margin = new System.Windows.Forms.Padding(1);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(45, 45);
            this.button16.TabIndex = 64;
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button17.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.Location = new System.Drawing.Point(103, 159);
            this.button17.Margin = new System.Windows.Forms.Padding(1);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(45, 45);
            this.button17.TabIndex = 65;
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.FlatAppearance.BorderSize = 0;
            this.button18.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.Location = new System.Drawing.Point(150, 159);
            this.button18.Margin = new System.Windows.Forms.Padding(1);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(45, 45);
            this.button18.TabIndex = 66;
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.FlatAppearance.BorderSize = 0;
            this.button19.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.Location = new System.Drawing.Point(197, 159);
            this.button19.Margin = new System.Windows.Forms.Padding(1);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(45, 45);
            this.button19.TabIndex = 67;
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.FlatAppearance.BorderSize = 0;
            this.button20.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.Location = new System.Drawing.Point(243, 159);
            this.button20.Margin = new System.Windows.Forms.Padding(1);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(45, 45);
            this.button20.TabIndex = 68;
            this.button20.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            this.button21.FlatAppearance.BorderSize = 0;
            this.button21.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.ForeColor = System.Drawing.Color.Red;
            this.button21.Location = new System.Drawing.Point(290, 159);
            this.button21.Margin = new System.Windows.Forms.Padding(1);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(45, 45);
            this.button21.TabIndex = 69;
            this.button21.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.FlatAppearance.BorderSize = 0;
            this.button22.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button22.Location = new System.Drawing.Point(9, 206);
            this.button22.Margin = new System.Windows.Forms.Padding(1);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(45, 45);
            this.button22.TabIndex = 70;
            this.button22.UseVisualStyleBackColor = true;
            // 
            // button23
            // 
            this.button23.FlatAppearance.BorderSize = 0;
            this.button23.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button23.Location = new System.Drawing.Point(56, 206);
            this.button23.Margin = new System.Windows.Forms.Padding(1);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(45, 45);
            this.button23.TabIndex = 71;
            this.button23.UseVisualStyleBackColor = true;
            // 
            // button24
            // 
            this.button24.FlatAppearance.BorderSize = 0;
            this.button24.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button24.Location = new System.Drawing.Point(103, 206);
            this.button24.Margin = new System.Windows.Forms.Padding(1);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(45, 45);
            this.button24.TabIndex = 72;
            this.button24.UseVisualStyleBackColor = true;
            // 
            // button25
            // 
            this.button25.FlatAppearance.BorderSize = 0;
            this.button25.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button25.Location = new System.Drawing.Point(150, 206);
            this.button25.Margin = new System.Windows.Forms.Padding(1);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(45, 45);
            this.button25.TabIndex = 73;
            this.button25.UseVisualStyleBackColor = true;
            // 
            // button26
            // 
            this.button26.FlatAppearance.BorderSize = 0;
            this.button26.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button26.Location = new System.Drawing.Point(197, 206);
            this.button26.Margin = new System.Windows.Forms.Padding(1);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(45, 45);
            this.button26.TabIndex = 74;
            this.button26.UseVisualStyleBackColor = true;
            // 
            // button27
            // 
            this.button27.FlatAppearance.BorderSize = 0;
            this.button27.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button27.Location = new System.Drawing.Point(243, 206);
            this.button27.Margin = new System.Windows.Forms.Padding(1);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(45, 45);
            this.button27.TabIndex = 75;
            this.button27.UseVisualStyleBackColor = true;
            // 
            // button28
            // 
            this.button28.FlatAppearance.BorderSize = 0;
            this.button28.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button28.ForeColor = System.Drawing.Color.Red;
            this.button28.Location = new System.Drawing.Point(290, 206);
            this.button28.Margin = new System.Windows.Forms.Padding(1);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(45, 45);
            this.button28.TabIndex = 76;
            this.button28.UseVisualStyleBackColor = true;
            // 
            // button29
            // 
            this.button29.FlatAppearance.BorderSize = 0;
            this.button29.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button29.Location = new System.Drawing.Point(9, 253);
            this.button29.Margin = new System.Windows.Forms.Padding(1);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(45, 45);
            this.button29.TabIndex = 77;
            this.button29.UseVisualStyleBackColor = true;
            // 
            // button30
            // 
            this.button30.FlatAppearance.BorderSize = 0;
            this.button30.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button30.Location = new System.Drawing.Point(56, 253);
            this.button30.Margin = new System.Windows.Forms.Padding(1);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(45, 45);
            this.button30.TabIndex = 78;
            this.button30.UseVisualStyleBackColor = true;
            // 
            // button31
            // 
            this.button31.FlatAppearance.BorderSize = 0;
            this.button31.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button31.Location = new System.Drawing.Point(103, 253);
            this.button31.Margin = new System.Windows.Forms.Padding(1);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(45, 45);
            this.button31.TabIndex = 79;
            this.button31.UseVisualStyleBackColor = true;
            // 
            // button32
            // 
            this.button32.FlatAppearance.BorderSize = 0;
            this.button32.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button32.Location = new System.Drawing.Point(150, 253);
            this.button32.Margin = new System.Windows.Forms.Padding(1);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(45, 45);
            this.button32.TabIndex = 80;
            this.button32.UseVisualStyleBackColor = true;
            // 
            // button33
            // 
            this.button33.FlatAppearance.BorderSize = 0;
            this.button33.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button33.Location = new System.Drawing.Point(197, 253);
            this.button33.Margin = new System.Windows.Forms.Padding(1);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(45, 45);
            this.button33.TabIndex = 81;
            this.button33.UseVisualStyleBackColor = true;
            // 
            // button34
            // 
            this.button34.FlatAppearance.BorderSize = 0;
            this.button34.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button34.Location = new System.Drawing.Point(243, 253);
            this.button34.Margin = new System.Windows.Forms.Padding(1);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(45, 45);
            this.button34.TabIndex = 82;
            this.button34.UseVisualStyleBackColor = true;
            // 
            // button35
            // 
            this.button35.FlatAppearance.BorderSize = 0;
            this.button35.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button35.ForeColor = System.Drawing.Color.Red;
            this.button35.Location = new System.Drawing.Point(290, 253);
            this.button35.Margin = new System.Windows.Forms.Padding(1);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(45, 45);
            this.button35.TabIndex = 83;
            this.button35.UseVisualStyleBackColor = true;
            // 
            // button36
            // 
            this.button36.FlatAppearance.BorderSize = 0;
            this.button36.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button36.Location = new System.Drawing.Point(9, 300);
            this.button36.Margin = new System.Windows.Forms.Padding(1);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(45, 45);
            this.button36.TabIndex = 84;
            this.button36.UseVisualStyleBackColor = true;
            // 
            // button37
            // 
            this.button37.FlatAppearance.BorderSize = 0;
            this.button37.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button37.Location = new System.Drawing.Point(56, 300);
            this.button37.Margin = new System.Windows.Forms.Padding(1);
            this.button37.Name = "button37";
            this.button37.Size = new System.Drawing.Size(45, 45);
            this.button37.TabIndex = 85;
            this.button37.UseVisualStyleBackColor = true;
            // 
            // button38
            // 
            this.button38.FlatAppearance.BorderSize = 0;
            this.button38.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button38.Location = new System.Drawing.Point(103, 300);
            this.button38.Margin = new System.Windows.Forms.Padding(1);
            this.button38.Name = "button38";
            this.button38.Size = new System.Drawing.Size(45, 45);
            this.button38.TabIndex = 86;
            this.button38.UseVisualStyleBackColor = true;
            // 
            // button39
            // 
            this.button39.FlatAppearance.BorderSize = 0;
            this.button39.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button39.Location = new System.Drawing.Point(150, 300);
            this.button39.Margin = new System.Windows.Forms.Padding(1);
            this.button39.Name = "button39";
            this.button39.Size = new System.Drawing.Size(45, 45);
            this.button39.TabIndex = 87;
            this.button39.UseVisualStyleBackColor = true;
            // 
            // button40
            // 
            this.button40.FlatAppearance.BorderSize = 0;
            this.button40.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button40.Location = new System.Drawing.Point(197, 300);
            this.button40.Margin = new System.Windows.Forms.Padding(1);
            this.button40.Name = "button40";
            this.button40.Size = new System.Drawing.Size(45, 45);
            this.button40.TabIndex = 88;
            this.button40.UseVisualStyleBackColor = true;
            // 
            // button41
            // 
            this.button41.FlatAppearance.BorderSize = 0;
            this.button41.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button41.Location = new System.Drawing.Point(243, 300);
            this.button41.Margin = new System.Windows.Forms.Padding(1);
            this.button41.Name = "button41";
            this.button41.Size = new System.Drawing.Size(45, 45);
            this.button41.TabIndex = 89;
            this.button41.UseVisualStyleBackColor = true;
            // 
            // button42
            // 
            this.button42.FlatAppearance.BorderSize = 0;
            this.button42.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button42.ForeColor = System.Drawing.Color.Red;
            this.button42.Location = new System.Drawing.Point(290, 300);
            this.button42.Margin = new System.Windows.Forms.Padding(1);
            this.button42.Name = "button42";
            this.button42.Size = new System.Drawing.Size(45, 45);
            this.button42.TabIndex = 90;
            this.button42.UseVisualStyleBackColor = true;
            // 
            // labelTu
            // 
            this.labelTu.AutoSize = true;
            this.labelTu.Font = new System.Drawing.Font("Bauhaus 93", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTu.Location = new System.Drawing.Point(59, 44);
            this.labelTu.Name = "labelTu";
            this.labelTu.Size = new System.Drawing.Size(36, 19);
            this.labelTu.TabIndex = 16;
            this.labelTu.Text = "Tue";
            // 
            // labelW
            // 
            this.labelW.AutoSize = true;
            this.labelW.Font = new System.Drawing.Font("Bauhaus 93", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelW.Location = new System.Drawing.Point(105, 44);
            this.labelW.Name = "labelW";
            this.labelW.Size = new System.Drawing.Size(42, 19);
            this.labelW.TabIndex = 15;
            this.labelW.Text = "Wed";
            // 
            // labelTh
            // 
            this.labelTh.AutoSize = true;
            this.labelTh.Font = new System.Drawing.Font("Bauhaus 93", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTh.Location = new System.Drawing.Point(154, 44);
            this.labelTh.Name = "labelTh";
            this.labelTh.Size = new System.Drawing.Size(36, 19);
            this.labelTh.TabIndex = 14;
            this.labelTh.Text = "Thu";
            // 
            // labelF
            // 
            this.labelF.AutoSize = true;
            this.labelF.Font = new System.Drawing.Font("Bauhaus 93", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelF.Location = new System.Drawing.Point(208, 44);
            this.labelF.Name = "labelF";
            this.labelF.Size = new System.Drawing.Size(22, 19);
            this.labelF.TabIndex = 13;
            this.labelF.Text = "Fr";
            // 
            // labelSt
            // 
            this.labelSt.AutoSize = true;
            this.labelSt.Font = new System.Drawing.Font("Bauhaus 93", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSt.Location = new System.Drawing.Point(246, 44);
            this.labelSt.Name = "labelSt";
            this.labelSt.Size = new System.Drawing.Size(32, 19);
            this.labelSt.TabIndex = 12;
            this.labelSt.Text = "Sat";
            // 
            // labelSu
            // 
            this.labelSu.AutoSize = true;
            this.labelSu.Font = new System.Drawing.Font("Bauhaus 93", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSu.ForeColor = System.Drawing.Color.Red;
            this.labelSu.Location = new System.Drawing.Point(292, 44);
            this.labelSu.Name = "labelSu";
            this.labelSu.Size = new System.Drawing.Size(34, 19);
            this.labelSu.TabIndex = 11;
            this.labelSu.Text = "Sun";
            // 
            // labelM
            // 
            this.labelM.AutoSize = true;
            this.labelM.Font = new System.Drawing.Font("Bauhaus 93", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelM.Location = new System.Drawing.Point(11, 44);
            this.labelM.Name = "labelM";
            this.labelM.Size = new System.Drawing.Size(41, 19);
            this.labelM.TabIndex = 10;
            this.labelM.Text = "Mon";
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Red;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(352, 5);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(50, 50);
            this.buttonClose.TabIndex = 11;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // buttonAddNote
            // 
            this.buttonAddNote.BackColor = System.Drawing.Color.Gold;
            this.buttonAddNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddNote.Image = global::MyCalendar.Properties.Resources.notesmall;
            this.buttonAddNote.Location = new System.Drawing.Point(352, 55);
            this.buttonAddNote.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAddNote.Name = "buttonAddNote";
            this.buttonAddNote.Size = new System.Drawing.Size(50, 50);
            this.buttonAddNote.TabIndex = 19;
            this.buttonAddNote.UseVisualStyleBackColor = false;
            this.buttonAddNote.Click += new System.EventHandler(this.buttonAddNote_Click);
            // 
            // buttonSendEmail
            // 
            this.buttonSendEmail.BackColor = System.Drawing.Color.Firebrick;
            this.buttonSendEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSendEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSendEmail.Image = global::MyCalendar.Properties.Resources.mailsmall;
            this.buttonSendEmail.Location = new System.Drawing.Point(352, 105);
            this.buttonSendEmail.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSendEmail.Name = "buttonSendEmail";
            this.buttonSendEmail.Size = new System.Drawing.Size(50, 50);
            this.buttonSendEmail.TabIndex = 18;
            this.buttonSendEmail.UseVisualStyleBackColor = false;
            this.buttonSendEmail.Click += new System.EventHandler(this.buttonSendEmail_Click);
            // 
            // buttonAddVisit
            // 
            this.buttonAddVisit.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonAddVisit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddVisit.Image = global::MyCalendar.Properties.Resources.mapssmall;
            this.buttonAddVisit.Location = new System.Drawing.Point(352, 155);
            this.buttonAddVisit.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAddVisit.Name = "buttonAddVisit";
            this.buttonAddVisit.Size = new System.Drawing.Size(50, 50);
            this.buttonAddVisit.TabIndex = 17;
            this.buttonAddVisit.UseVisualStyleBackColor = false;
            this.buttonAddVisit.Click += new System.EventHandler(this.buttonAddVisit_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSettings.Image = global::MyCalendar.Properties.Resources.settingssmall;
            this.buttonSettings.Location = new System.Drawing.Point(352, 205);
            this.buttonSettings.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(50, 50);
            this.buttonSettings.TabIndex = 16;
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "MyCalendar";
            this.notifyIcon.Visible = true;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hideToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(128, 76);
            // 
            // hideToolStripMenuItem
            // 
            this.hideToolStripMenuItem.Name = "hideToolStripMenuItem";
            this.hideToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.hideToolStripMenuItem.Text = "Hide";
            this.hideToolStripMenuItem.Click += new System.EventHandler(this.hideToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(409, 407);
            this.Controls.Add(this.buttonAddNote);
            this.Controls.Add(this.buttonSendEmail);
            this.Controls.Add(this.buttonAddVisit);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.panelCalendar);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::MyCalendar.Properties.Settings.Default, "WindowLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = global::MyCalendar.Properties.Settings.Default.WindowLocation;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Coral;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelCalendar.ResumeLayout(false);
            this.panelCalendar.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxMonth;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Button buttonNextMonth;
        private System.Windows.Forms.Button buttonPrevMonth;
        private System.Windows.Forms.Panel panelCalendar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.Button button35;
        private System.Windows.Forms.Button button36;
        private System.Windows.Forms.Button button37;
        private System.Windows.Forms.Button button38;
        private System.Windows.Forms.Button button39;
        private System.Windows.Forms.Button button40;
        private System.Windows.Forms.Button button41;
        private System.Windows.Forms.Button button42;
        private System.Windows.Forms.Label labelTu;
        private System.Windows.Forms.Label labelW;
        private System.Windows.Forms.Label labelTh;
        private System.Windows.Forms.Label labelF;
        private System.Windows.Forms.Label labelSt;
        private System.Windows.Forms.Label labelSu;
        private System.Windows.Forms.Label labelM;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonAddVisit;
        private System.Windows.Forms.Button buttonSendEmail;
        private System.Windows.Forms.Button buttonAddNote;
        private System.Windows.Forms.Label Clock;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem hideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private Setting setting1;
        private AddEvent addEvent1;
        private AddEmail addEmail1;
        private AddNote addNote1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}

