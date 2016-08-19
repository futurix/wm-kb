namespace FuturixRu
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu;

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
            System.Windows.Forms.MenuItem miSep1;
            System.Windows.Forms.MenuItem miSep2;
            System.Windows.Forms.MenuItem miSep3;
            this.mainMenu = new System.Windows.Forms.MainMenu();
            this.mEdit = new System.Windows.Forms.MenuItem();
            this.miCut = new System.Windows.Forms.MenuItem();
            this.miCopy = new System.Windows.Forms.MenuItem();
            this.miPaste = new System.Windows.Forms.MenuItem();
            this.miClear = new System.Windows.Forms.MenuItem();
            this.miOpen = new System.Windows.Forms.MenuItem();
            this.miSave = new System.Windows.Forms.MenuItem();
            this.mTools = new System.Windows.Forms.MenuItem();
            this.miAbout = new System.Windows.Forms.MenuItem();
            this.miClose = new System.Windows.Forms.MenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button25 = new System.Windows.Forms.Button();
            this.button37 = new System.Windows.Forms.Button();
            this.button38 = new System.Windows.Forms.Button();
            this.button40 = new System.Windows.Forms.Button();
            this.button45 = new System.Windows.Forms.Button();
            this.button46 = new System.Windows.Forms.Button();
            this.button47 = new System.Windows.Forms.Button();
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
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtMain = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            miSep1 = new System.Windows.Forms.MenuItem();
            miSep2 = new System.Windows.Forms.MenuItem();
            miSep3 = new System.Windows.Forms.MenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // miSep1
            // 
            miSep1.Text = "-";
            // 
            // miSep2
            // 
            miSep2.Text = "-";
            // 
            // miSep3
            // 
            miSep3.Text = "-";
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.Add(this.mEdit);
            this.mainMenu.MenuItems.Add(this.mTools);
            // 
            // mEdit
            // 
            this.mEdit.MenuItems.Add(this.miCut);
            this.mEdit.MenuItems.Add(this.miCopy);
            this.mEdit.MenuItems.Add(this.miPaste);
            this.mEdit.MenuItems.Add(miSep1);
            this.mEdit.MenuItems.Add(this.miClear);
            this.mEdit.MenuItems.Add(miSep2);
            this.mEdit.MenuItems.Add(this.miOpen);
            this.mEdit.MenuItems.Add(this.miSave);
            this.mEdit.Text = "Edit";
            // 
            // miCut
            // 
            this.miCut.Text = "Cut";
            this.miCut.Click += new System.EventHandler(this.miCut_Click);
            // 
            // miCopy
            // 
            this.miCopy.Text = "Copy";
            this.miCopy.Click += new System.EventHandler(this.miCopy_Click);
            // 
            // miPaste
            // 
            this.miPaste.Text = "Paste";
            this.miPaste.Click += new System.EventHandler(this.miPaste_Click);
            // 
            // miClear
            // 
            this.miClear.Text = "Clear";
            this.miClear.Click += new System.EventHandler(this.miClear_Click);
            // 
            // miOpen
            // 
            this.miOpen.Text = "Open";
            this.miOpen.Click += new System.EventHandler(this.miOpen_Click);
            // 
            // miSave
            // 
            this.miSave.Text = "Save";
            this.miSave.Click += new System.EventHandler(this.miSave_Click);
            // 
            // mTools
            // 
            this.mTools.MenuItems.Add(this.miAbout);
            this.mTools.MenuItems.Add(miSep3);
            this.mTools.MenuItems.Add(this.miClose);
            this.mTools.Text = "Tools";
            // 
            // miAbout
            // 
            this.miAbout.Text = "About";
            this.miAbout.Click += new System.EventHandler(this.miAbout_Click);
            // 
            // miClose
            // 
            this.miClose.Text = "Close";
            this.miClose.Click += new System.EventHandler(this.miClose_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.button25);
            this.panel1.Controls.Add(this.button37);
            this.panel1.Controls.Add(this.button38);
            this.panel1.Controls.Add(this.button40);
            this.panel1.Controls.Add(this.button45);
            this.panel1.Controls.Add(this.button46);
            this.panel1.Controls.Add(this.button47);
            this.panel1.Controls.Add(this.button26);
            this.panel1.Controls.Add(this.button27);
            this.panel1.Controls.Add(this.button28);
            this.panel1.Controls.Add(this.button29);
            this.panel1.Controls.Add(this.button30);
            this.panel1.Controls.Add(this.button31);
            this.panel1.Controls.Add(this.button32);
            this.panel1.Controls.Add(this.button33);
            this.panel1.Controls.Add(this.button34);
            this.panel1.Controls.Add(this.button35);
            this.panel1.Controls.Add(this.button36);
            this.panel1.Controls.Add(this.button13);
            this.panel1.Controls.Add(this.button14);
            this.panel1.Controls.Add(this.button15);
            this.panel1.Controls.Add(this.button16);
            this.panel1.Controls.Add(this.button17);
            this.panel1.Controls.Add(this.button18);
            this.panel1.Controls.Add(this.button19);
            this.panel1.Controls.Add(this.button20);
            this.panel1.Controls.Add(this.button21);
            this.panel1.Controls.Add(this.button22);
            this.panel1.Controls.Add(this.button23);
            this.panel1.Controls.Add(this.button24);
            this.panel1.Controls.Add(this.button12);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 160);
            // 
            // button25
            // 
            this.button25.BackColor = System.Drawing.SystemColors.Window;
            this.button25.Location = new System.Drawing.Point(396, 120);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(36, 40);
            this.button25.TabIndex = 46;
            this.button25.Text = "-";
            this.button25.Click += new System.EventHandler(this.buttonLetter_Click);
            // 
            // button37
            // 
            this.button37.BackColor = System.Drawing.SystemColors.Window;
            this.button37.Location = new System.Drawing.Point(324, 80);
            this.button37.Name = "button37";
            this.button37.Size = new System.Drawing.Size(36, 40);
            this.button37.TabIndex = 45;
            this.button37.Text = "\"";
            this.button37.Click += new System.EventHandler(this.buttonLetter_Click);
            // 
            // button38
            // 
            this.button38.BackColor = System.Drawing.SystemColors.Window;
            this.button38.Location = new System.Drawing.Point(324, 120);
            this.button38.Name = "button38";
            this.button38.Size = new System.Drawing.Size(36, 40);
            this.button38.TabIndex = 44;
            this.button38.Text = ",";
            this.button38.Click += new System.EventHandler(this.buttonLetter_Click);
            // 
            // button40
            // 
            this.button40.BackColor = System.Drawing.SystemColors.Window;
            this.button40.Location = new System.Drawing.Point(360, 120);
            this.button40.Name = "button40";
            this.button40.Size = new System.Drawing.Size(36, 40);
            this.button40.TabIndex = 42;
            this.button40.Text = ".";
            this.button40.Click += new System.EventHandler(this.buttonLetter_Click);
            // 
            // button45
            // 
            this.button45.BackColor = System.Drawing.SystemColors.Window;
            this.button45.Location = new System.Drawing.Point(72, 120);
            this.button45.Name = "button45";
            this.button45.Size = new System.Drawing.Size(252, 40);
            this.button45.TabIndex = 37;
            this.button45.Text = " ";
            this.button45.Click += new System.EventHandler(this.buttonLetter_Click);
            // 
            // button46
            // 
            this.button46.BackColor = System.Drawing.SystemColors.Window;
            this.button46.Location = new System.Drawing.Point(36, 120);
            this.button46.Name = "button46";
            this.button46.Size = new System.Drawing.Size(36, 40);
            this.button46.TabIndex = 36;
            this.button46.Text = "!";
            this.button46.Click += new System.EventHandler(this.buttonLetter_Click);
            // 
            // button47
            // 
            this.button47.BackColor = System.Drawing.SystemColors.Window;
            this.button47.Location = new System.Drawing.Point(0, 120);
            this.button47.Name = "button47";
            this.button47.Size = new System.Drawing.Size(36, 40);
            this.button47.TabIndex = 35;
            this.button47.Text = "?";
            this.button47.Click += new System.EventHandler(this.buttonLetter_Click);
            // 
            // button26
            // 
            this.button26.BackColor = System.Drawing.SystemColors.Window;
            this.button26.Location = new System.Drawing.Point(360, 80);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(72, 40);
            this.button26.TabIndex = 34;
            this.button26.Text = "згл";
            this.button26.Click += new System.EventHandler(this.buttonShift_Click);
            // 
            // button27
            // 
            this.button27.BackColor = System.Drawing.SystemColors.Window;
            this.button27.Location = new System.Drawing.Point(396, 0);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(36, 40);
            this.button27.TabIndex = 33;
            this.button27.Text = "Ъ";
            this.button27.Click += new System.EventHandler(this.buttonLetter_Click);
            // 
            // button28
            // 
            this.button28.BackColor = System.Drawing.SystemColors.Window;
            this.button28.Location = new System.Drawing.Point(108, 80);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(36, 40);
            this.button28.TabIndex = 32;
            this.button28.Text = "М";
            this.button28.Click += new System.EventHandler(this.buttonLetter_Click);
            // 
            // button29
            // 
            this.button29.BackColor = System.Drawing.SystemColors.Window;
            this.button29.Location = new System.Drawing.Point(216, 80);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(36, 40);
            this.button29.TabIndex = 31;
            this.button29.Text = "Ь";
            this.button29.Click += new System.EventHandler(this.buttonLetter_Click);
            // 
            // button30
            // 
            this.button30.BackColor = System.Drawing.SystemColors.Window;
            this.button30.Location = new System.Drawing.Point(180, 0);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(36, 40);
            this.button30.TabIndex = 30;
            this.button30.Text = "Н";
            this.button30.Click += new System.EventHandler(this.buttonLetter_Click);
            // 
            // button31
            // 
            this.button31.BackColor = System.Drawing.SystemColors.Window;
            this.button31.Location = new System.Drawing.Point(252, 80);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(36, 40);
            this.button31.TabIndex = 29;
            this.button31.Text = "Б";
            this.button31.Click += new System.EventHandler(this.buttonLetter_Click);
            // 
            // button32
            // 
            this.button32.BackColor = System.Drawing.SystemColors.Window;
            this.button32.Location = new System.Drawing.Point(72, 40);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(36, 40);
            this.button32.TabIndex = 28;
            this.button32.Text = "В";
            this.button32.Click += new System.EventHandler(this.buttonLetter_Click);
            // 
            // button33
            // 
            this.button33.BackColor = System.Drawing.SystemColors.Window;
            this.button33.Location = new System.Drawing.Point(36, 0);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(36, 40);
            this.button33.TabIndex = 27;
            this.button33.Text = "Ц";
            this.button33.Click += new System.EventHandler(this.buttonLetter_Click);
            // 
            // button34
            // 
            this.button34.BackColor = System.Drawing.SystemColors.Window;
            this.button34.Location = new System.Drawing.Point(324, 40);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(36, 40);
            this.button34.TabIndex = 26;
            this.button34.Text = "Ж";
            this.button34.Click += new System.EventHandler(this.buttonLetter_Click);
            // 
            // button35
            // 
            this.button35.BackColor = System.Drawing.SystemColors.Window;
            this.button35.Location = new System.Drawing.Point(324, 0);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(36, 40);
            this.button35.TabIndex = 25;
            this.button35.Text = "З";
            this.button35.Click += new System.EventHandler(this.buttonLetter_Click);
            // 
            // button36
            // 
            this.button36.BackColor = System.Drawing.SystemColors.Window;
            this.button36.Location = new System.Drawing.Point(36, 80);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(36, 40);
            this.button36.TabIndex = 24;
            this.button36.Text = "Ч";
            this.button36.Click += new System.EventHandler(this.buttonLetter_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.SystemColors.Window;
            this.button13.Location = new System.Drawing.Point(432, 0);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(48, 160);
            this.button13.TabIndex = 23;
            this.button13.Text = "<";
            this.button13.Click += new System.EventHandler(this.buttonBackspace_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.SystemColors.Window;
            this.button14.Location = new System.Drawing.Point(288, 0);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(36, 40);
            this.button14.TabIndex = 22;
            this.button14.Text = "Щ";
            this.button14.Click += new System.EventHandler(this.buttonLetter_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.SystemColors.Window;
            this.button15.Location = new System.Drawing.Point(252, 40);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(36, 40);
            this.button15.TabIndex = 21;
            this.button15.Text = "Л";
            this.button15.Click += new System.EventHandler(this.buttonLetter_Click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.SystemColors.Window;
            this.button16.Location = new System.Drawing.Point(108, 0);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(36, 40);
            this.button16.TabIndex = 20;
            this.button16.Text = "К";
            this.button16.Click += new System.EventHandler(this.buttonLetter_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.SystemColors.Window;
            this.button17.Location = new System.Drawing.Point(396, 40);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(36, 40);
            this.button17.TabIndex = 19;
            this.button17.Text = "Ё";
            this.button17.Click += new System.EventHandler(this.buttonLetter_Click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.SystemColors.Window;
            this.button18.Location = new System.Drawing.Point(0, 0);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(36, 40);
            this.button18.TabIndex = 18;
            this.button18.Text = "Й";
            this.button18.Click += new System.EventHandler(this.buttonLetter_Click);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.SystemColors.Window;
            this.button19.Location = new System.Drawing.Point(360, 0);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(36, 40);
            this.button19.TabIndex = 17;
            this.button19.Text = "Х";
            this.button19.Click += new System.EventHandler(this.buttonLetter_Click);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.SystemColors.Window;
            this.button20.Location = new System.Drawing.Point(216, 0);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(36, 40);
            this.button20.TabIndex = 16;
            this.button20.Text = "Г";
            this.button20.Click += new System.EventHandler(this.buttonLetter_Click);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.SystemColors.Window;
            this.button21.Location = new System.Drawing.Point(0, 40);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(36, 40);
            this.button21.TabIndex = 15;
            this.button21.Text = "Ф";
            this.button21.Click += new System.EventHandler(this.buttonLetter_Click);
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.SystemColors.Window;
            this.button22.Location = new System.Drawing.Point(288, 40);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(36, 40);
            this.button22.TabIndex = 14;
            this.button22.Text = "Д";
            this.button22.Click += new System.EventHandler(this.buttonLetter_Click);
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.SystemColors.Window;
            this.button23.Location = new System.Drawing.Point(72, 80);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(36, 40);
            this.button23.TabIndex = 13;
            this.button23.Text = "С";
            this.button23.Click += new System.EventHandler(this.buttonLetter_Click);
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.SystemColors.Window;
            this.button24.Location = new System.Drawing.Point(108, 40);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(36, 40);
            this.button24.TabIndex = 12;
            this.button24.Text = "А";
            this.button24.Click += new System.EventHandler(this.buttonLetter_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.SystemColors.Window;
            this.button12.Location = new System.Drawing.Point(288, 80);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(36, 40);
            this.button12.TabIndex = 11;
            this.button12.Text = "Ю";
            this.button12.Click += new System.EventHandler(this.buttonLetter_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.Window;
            this.button11.Location = new System.Drawing.Point(360, 40);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(36, 40);
            this.button11.TabIndex = 10;
            this.button11.Text = "Э";
            this.button11.Click += new System.EventHandler(this.buttonLetter_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.Window;
            this.button10.Location = new System.Drawing.Point(216, 40);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(36, 40);
            this.button10.TabIndex = 9;
            this.button10.Text = "О";
            this.button10.Click += new System.EventHandler(this.buttonLetter_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.Window;
            this.button9.Location = new System.Drawing.Point(144, 80);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(36, 40);
            this.button9.TabIndex = 8;
            this.button9.Text = "И";
            this.button9.Click += new System.EventHandler(this.buttonLetter_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.Window;
            this.button8.Location = new System.Drawing.Point(144, 40);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(36, 40);
            this.button8.TabIndex = 7;
            this.button8.Text = "П";
            this.button8.Click += new System.EventHandler(this.buttonLetter_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.Window;
            this.button7.Location = new System.Drawing.Point(72, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(36, 40);
            this.button7.TabIndex = 6;
            this.button7.Text = "У";
            this.button7.Click += new System.EventHandler(this.buttonLetter_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Window;
            this.button6.Location = new System.Drawing.Point(36, 40);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(36, 40);
            this.button6.TabIndex = 5;
            this.button6.Text = "Ы";
            this.button6.Click += new System.EventHandler(this.buttonLetter_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Window;
            this.button5.Location = new System.Drawing.Point(180, 80);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(36, 40);
            this.button5.TabIndex = 4;
            this.button5.Text = "Т";
            this.button5.Click += new System.EventHandler(this.buttonLetter_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Window;
            this.button4.Location = new System.Drawing.Point(180, 40);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(36, 40);
            this.button4.TabIndex = 3;
            this.button4.Text = "Р";
            this.button4.Click += new System.EventHandler(this.buttonLetter_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Window;
            this.button3.Location = new System.Drawing.Point(144, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(36, 40);
            this.button3.TabIndex = 2;
            this.button3.Text = "Е";
            this.button3.Click += new System.EventHandler(this.buttonLetter_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Window;
            this.button2.Location = new System.Drawing.Point(252, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ш";
            this.button2.Click += new System.EventHandler(this.buttonLetter_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(0, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Я";
            this.button1.Click += new System.EventHandler(this.buttonLetter_Click);
            // 
            // txtMain
            // 
            this.txtMain.AcceptsReturn = true;
            this.txtMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMain.Location = new System.Drawing.Point(0, 0);
            this.txtMain.Multiline = true;
            this.txtMain.Name = "txtMain";
            this.txtMain.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMain.Size = new System.Drawing.Size(480, 216);
            this.txtMain.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 216);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 160);
            // 
            // dlgOpen
            // 
            this.dlgOpen.Filter = "Text files|*.txt";
            // 
            // dlgSave
            // 
            this.dlgSave.FileName = "Notes.txt";
            this.dlgSave.Filter = "Text files|*.txt";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(480, 376);
            this.Controls.Add(this.txtMain);
            this.Controls.Add(this.panel2);
            this.Location = new System.Drawing.Point(0, 52);
            this.Menu = this.mainMenu;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Futurix i18n";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.MainForm_Closing);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem miCopy;
        private System.Windows.Forms.MenuItem miPaste;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMain;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
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
        private System.Windows.Forms.Button button37;
        private System.Windows.Forms.Button button38;
        private System.Windows.Forms.Button button40;
        private System.Windows.Forms.Button button45;
        private System.Windows.Forms.Button button46;
        private System.Windows.Forms.Button button47;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuItem mEdit;
        private System.Windows.Forms.MenuItem mTools;
        private System.Windows.Forms.MenuItem miCut;
        private System.Windows.Forms.MenuItem miClear;
        private System.Windows.Forms.MenuItem miOpen;
        private System.Windows.Forms.MenuItem miSave;
        private System.Windows.Forms.MenuItem miClose;
        private System.Windows.Forms.MenuItem miAbout;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.SaveFileDialog dlgSave;
    }
}

