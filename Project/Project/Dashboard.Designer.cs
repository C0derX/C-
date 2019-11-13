namespace Project
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.aboutbutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.searchbutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.updatebutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.billbutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.checkoutbutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.checkinbutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Minimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.Exit = new Bunifu.Framework.UI.BunifuImageButton();
            this.checkinpanel = new System.Windows.Forms.Panel();
            this.peopleno = new System.Windows.Forms.ComboBox();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.checkouttime = new System.Windows.Forms.DateTimePicker();
            this.checkintime = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.ComboBox();
            this.roomtype = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.country = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lastname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.address = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.roomno = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.firstname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            this.checkinpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.aboutbutton);
            this.panel1.Controls.Add(this.searchbutton);
            this.panel1.Controls.Add(this.updatebutton);
            this.panel1.Controls.Add(this.billbutton);
            this.panel1.Controls.Add(this.checkoutbutton);
            this.panel1.Controls.Add(this.checkinbutton);
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 521);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // aboutbutton
            // 
            this.aboutbutton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.aboutbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.aboutbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.aboutbutton.BorderRadius = 0;
            this.aboutbutton.ButtonText = "About";
            this.aboutbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aboutbutton.DisabledColor = System.Drawing.Color.Gray;
            this.aboutbutton.Iconcolor = System.Drawing.Color.Transparent;
            this.aboutbutton.Iconimage = null;
            this.aboutbutton.Iconimage_right = null;
            this.aboutbutton.Iconimage_right_Selected = null;
            this.aboutbutton.Iconimage_Selected = null;
            this.aboutbutton.IconMarginLeft = 0;
            this.aboutbutton.IconMarginRight = 0;
            this.aboutbutton.IconRightVisible = true;
            this.aboutbutton.IconRightZoom = 0D;
            this.aboutbutton.IconVisible = true;
            this.aboutbutton.IconZoom = 90D;
            this.aboutbutton.IsTab = true;
            this.aboutbutton.Location = new System.Drawing.Point(0, 408);
            this.aboutbutton.Name = "aboutbutton";
            this.aboutbutton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.aboutbutton.OnHovercolor = System.Drawing.Color.White;
            this.aboutbutton.OnHoverTextColor = System.Drawing.SystemColors.GrayText;
            this.aboutbutton.selected = false;
            this.aboutbutton.Size = new System.Drawing.Size(222, 48);
            this.aboutbutton.TabIndex = 1;
            this.aboutbutton.Text = "About";
            this.aboutbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.aboutbutton.Textcolor = System.Drawing.Color.White;
            this.aboutbutton.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutbutton.Click += new System.EventHandler(this.aboutbutton_Click);
            // 
            // searchbutton
            // 
            this.searchbutton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.searchbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.searchbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.searchbutton.BorderRadius = 0;
            this.searchbutton.ButtonText = "Search";
            this.searchbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchbutton.DisabledColor = System.Drawing.Color.Gray;
            this.searchbutton.Iconcolor = System.Drawing.Color.Transparent;
            this.searchbutton.Iconimage = null;
            this.searchbutton.Iconimage_right = null;
            this.searchbutton.Iconimage_right_Selected = null;
            this.searchbutton.Iconimage_Selected = null;
            this.searchbutton.IconMarginLeft = 0;
            this.searchbutton.IconMarginRight = 0;
            this.searchbutton.IconRightVisible = true;
            this.searchbutton.IconRightZoom = 0D;
            this.searchbutton.IconVisible = true;
            this.searchbutton.IconZoom = 90D;
            this.searchbutton.IsTab = true;
            this.searchbutton.Location = new System.Drawing.Point(0, 357);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.searchbutton.OnHovercolor = System.Drawing.Color.White;
            this.searchbutton.OnHoverTextColor = System.Drawing.SystemColors.GrayText;
            this.searchbutton.selected = false;
            this.searchbutton.Size = new System.Drawing.Size(223, 48);
            this.searchbutton.TabIndex = 0;
            this.searchbutton.Text = "Search";
            this.searchbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.searchbutton.Textcolor = System.Drawing.Color.White;
            this.searchbutton.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // updatebutton
            // 
            this.updatebutton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.updatebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.updatebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.updatebutton.BorderRadius = 0;
            this.updatebutton.ButtonText = "Update";
            this.updatebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updatebutton.DisabledColor = System.Drawing.Color.Gray;
            this.updatebutton.Iconcolor = System.Drawing.Color.Transparent;
            this.updatebutton.Iconimage = null;
            this.updatebutton.Iconimage_right = null;
            this.updatebutton.Iconimage_right_Selected = null;
            this.updatebutton.Iconimage_Selected = null;
            this.updatebutton.IconMarginLeft = 0;
            this.updatebutton.IconMarginRight = 0;
            this.updatebutton.IconRightVisible = true;
            this.updatebutton.IconRightZoom = 0D;
            this.updatebutton.IconVisible = true;
            this.updatebutton.IconZoom = 90D;
            this.updatebutton.IsTab = true;
            this.updatebutton.Location = new System.Drawing.Point(0, 310);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.updatebutton.OnHovercolor = System.Drawing.Color.White;
            this.updatebutton.OnHoverTextColor = System.Drawing.SystemColors.GrayText;
            this.updatebutton.selected = false;
            this.updatebutton.Size = new System.Drawing.Size(223, 48);
            this.updatebutton.TabIndex = 0;
            this.updatebutton.Text = "Update";
            this.updatebutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.updatebutton.Textcolor = System.Drawing.Color.White;
            this.updatebutton.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // billbutton
            // 
            this.billbutton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.billbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.billbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.billbutton.BorderRadius = 0;
            this.billbutton.ButtonText = "Bill";
            this.billbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.billbutton.DisabledColor = System.Drawing.Color.Gray;
            this.billbutton.Iconcolor = System.Drawing.Color.Transparent;
            this.billbutton.Iconimage = null;
            this.billbutton.Iconimage_right = null;
            this.billbutton.Iconimage_right_Selected = null;
            this.billbutton.Iconimage_Selected = null;
            this.billbutton.IconMarginLeft = 0;
            this.billbutton.IconMarginRight = 0;
            this.billbutton.IconRightVisible = true;
            this.billbutton.IconRightZoom = 0D;
            this.billbutton.IconVisible = true;
            this.billbutton.IconZoom = 90D;
            this.billbutton.IsTab = true;
            this.billbutton.Location = new System.Drawing.Point(0, 261);
            this.billbutton.Name = "billbutton";
            this.billbutton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.billbutton.OnHovercolor = System.Drawing.Color.White;
            this.billbutton.OnHoverTextColor = System.Drawing.SystemColors.GrayText;
            this.billbutton.selected = false;
            this.billbutton.Size = new System.Drawing.Size(223, 48);
            this.billbutton.TabIndex = 0;
            this.billbutton.Text = "Bill";
            this.billbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.billbutton.Textcolor = System.Drawing.Color.White;
            this.billbutton.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billbutton.Click += new System.EventHandler(this.billbutton_Click);
            // 
            // checkoutbutton
            // 
            this.checkoutbutton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.checkoutbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.checkoutbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkoutbutton.BorderRadius = 0;
            this.checkoutbutton.ButtonText = "Check Out";
            this.checkoutbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkoutbutton.DisabledColor = System.Drawing.Color.Gray;
            this.checkoutbutton.Iconcolor = System.Drawing.Color.Transparent;
            this.checkoutbutton.Iconimage = null;
            this.checkoutbutton.Iconimage_right = null;
            this.checkoutbutton.Iconimage_right_Selected = null;
            this.checkoutbutton.Iconimage_Selected = null;
            this.checkoutbutton.IconMarginLeft = 0;
            this.checkoutbutton.IconMarginRight = 0;
            this.checkoutbutton.IconRightVisible = true;
            this.checkoutbutton.IconRightZoom = 0D;
            this.checkoutbutton.IconVisible = true;
            this.checkoutbutton.IconZoom = 90D;
            this.checkoutbutton.IsTab = true;
            this.checkoutbutton.Location = new System.Drawing.Point(0, 215);
            this.checkoutbutton.Name = "checkoutbutton";
            this.checkoutbutton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.checkoutbutton.OnHovercolor = System.Drawing.Color.White;
            this.checkoutbutton.OnHoverTextColor = System.Drawing.SystemColors.GrayText;
            this.checkoutbutton.selected = false;
            this.checkoutbutton.Size = new System.Drawing.Size(223, 48);
            this.checkoutbutton.TabIndex = 0;
            this.checkoutbutton.Text = "Check Out";
            this.checkoutbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkoutbutton.Textcolor = System.Drawing.Color.White;
            this.checkoutbutton.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutbutton.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // checkinbutton
            // 
            this.checkinbutton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.checkinbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.checkinbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkinbutton.BorderRadius = 0;
            this.checkinbutton.ButtonText = "Check In";
            this.checkinbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkinbutton.DisabledColor = System.Drawing.Color.Gray;
            this.checkinbutton.Iconcolor = System.Drawing.Color.Transparent;
            this.checkinbutton.Iconimage = null;
            this.checkinbutton.Iconimage_right = null;
            this.checkinbutton.Iconimage_right_Selected = null;
            this.checkinbutton.Iconimage_Selected = null;
            this.checkinbutton.IconMarginLeft = 0;
            this.checkinbutton.IconMarginRight = 0;
            this.checkinbutton.IconRightVisible = true;
            this.checkinbutton.IconRightZoom = 0D;
            this.checkinbutton.IconVisible = true;
            this.checkinbutton.IconZoom = 90D;
            this.checkinbutton.IsTab = true;
            this.checkinbutton.Location = new System.Drawing.Point(0, 163);
            this.checkinbutton.Name = "checkinbutton";
            this.checkinbutton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.checkinbutton.OnHovercolor = System.Drawing.Color.White;
            this.checkinbutton.OnHoverTextColor = System.Drawing.SystemColors.GrayText;
            this.checkinbutton.selected = false;
            this.checkinbutton.Size = new System.Drawing.Size(223, 48);
            this.checkinbutton.TabIndex = 0;
            this.checkinbutton.Text = "Check In";
            this.checkinbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkinbutton.Textcolor = System.Drawing.Color.White;
            this.checkinbutton.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkinbutton.Click += new System.EventHandler(this.checkinbutton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(33)))), ((int)(((byte)(73)))));
            this.panel2.Controls.Add(this.Minimize);
            this.panel2.Controls.Add(this.Exit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(33)))), ((int)(((byte)(73)))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(914, 38);
            this.panel2.TabIndex = 1;
            // 
            // Minimize
            // 
            this.Minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(33)))), ((int)(((byte)(73)))));
            this.Minimize.Image = ((System.Drawing.Image)(resources.GetObject("Minimize.Image")));
            this.Minimize.ImageActive = null;
            this.Minimize.Location = new System.Drawing.Point(840, 0);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(38, 38);
            this.Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minimize.TabIndex = 1;
            this.Minimize.TabStop = false;
            this.Minimize.Zoom = 10;
            this.Minimize.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(33)))), ((int)(((byte)(73)))));
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.ImageActive = null;
            this.Exit.Location = new System.Drawing.Point(879, 1);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(34, 37);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Exit.TabIndex = 0;
            this.Exit.TabStop = false;
            this.Exit.Zoom = 10;
            this.Exit.Click += new System.EventHandler(this.close_Click);
            // 
            // checkinpanel
            // 
            this.checkinpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkinpanel.Controls.Add(this.peopleno);
            this.checkinpanel.Controls.Add(this.bunifuFlatButton3);
            this.checkinpanel.Controls.Add(this.bunifuFlatButton1);
            this.checkinpanel.Controls.Add(this.checkouttime);
            this.checkinpanel.Controls.Add(this.checkintime);
            this.checkinpanel.Controls.Add(this.label6);
            this.checkinpanel.Controls.Add(this.label9);
            this.checkinpanel.Controls.Add(this.bunifuFlatButton2);
            this.checkinpanel.Controls.Add(this.label7);
            this.checkinpanel.Controls.Add(this.label5);
            this.checkinpanel.Controls.Add(this.gender);
            this.checkinpanel.Controls.Add(this.roomtype);
            this.checkinpanel.Controls.Add(this.label10);
            this.checkinpanel.Controls.Add(this.label8);
            this.checkinpanel.Controls.Add(this.label4);
            this.checkinpanel.Controls.Add(this.label2);
            this.checkinpanel.Controls.Add(this.country);
            this.checkinpanel.Controls.Add(this.lastname);
            this.checkinpanel.Controls.Add(this.label1);
            this.checkinpanel.Controls.Add(this.address);
            this.checkinpanel.Controls.Add(this.roomno);
            this.checkinpanel.Controls.Add(this.firstname);
            this.checkinpanel.Controls.Add(this.label3);
            this.checkinpanel.Controls.Add(this.bunifuCustomLabel1);
            this.checkinpanel.Location = new System.Drawing.Point(222, 38);
            this.checkinpanel.Name = "checkinpanel";
            this.checkinpanel.Size = new System.Drawing.Size(689, 518);
            this.checkinpanel.TabIndex = 2;
            this.checkinpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // peopleno
            // 
            this.peopleno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.peopleno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.peopleno.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.peopleno.ForeColor = System.Drawing.SystemColors.Window;
            this.peopleno.FormattingEnabled = true;
            this.peopleno.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.peopleno.Location = new System.Drawing.Point(123, 254);
            this.peopleno.Name = "peopleno";
            this.peopleno.Size = new System.Drawing.Size(141, 29);
            this.peopleno.TabIndex = 12;
            this.peopleno.SelectedIndexChanged += new System.EventHandler(this.peopleno_SelectedIndexChanged);
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "ADD RECORD";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = null;
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(246, 380);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(189, 48);
            this.bunifuFlatButton3.TabIndex = 10;
            this.bunifuFlatButton3.Text = "ADD RECORD";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "ADD RECORD";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(722, 641);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(402, 78);
            this.bunifuFlatButton1.TabIndex = 10;
            this.bunifuFlatButton1.Text = "ADD RECORD";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // checkouttime
            // 
            this.checkouttime.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkouttime.Location = new System.Drawing.Point(530, 192);
            this.checkouttime.Name = "checkouttime";
            this.checkouttime.Size = new System.Drawing.Size(142, 23);
            this.checkouttime.TabIndex = 5;
            // 
            // checkintime
            // 
            this.checkintime.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkintime.Location = new System.Drawing.Point(123, 190);
            this.checkintime.Name = "checkintime";
            this.checkintime.Size = new System.Drawing.Size(141, 23);
            this.checkintime.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label6.Location = new System.Drawing.Point(421, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Check Out";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label9.Location = new System.Drawing.Point(15, 316);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 21);
            this.label9.TabIndex = 11;
            this.label9.Text = "Address";
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Check In";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = null;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = true;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(383, 654);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.SystemColors.GrayText;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(372, 78);
            this.bunifuFlatButton2.TabIndex = 0;
            this.bunifuFlatButton2.Text = "Check In";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.checkinbutton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label7.Location = new System.Drawing.Point(4, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "No Of People";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label5.Location = new System.Drawing.Point(18, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Check In";
            // 
            // gender
            // 
            this.gender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gender.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender.ForeColor = System.Drawing.SystemColors.Window;
            this.gender.FormattingEnabled = true;
            this.gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gender.Location = new System.Drawing.Point(530, 252);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(142, 29);
            this.gender.TabIndex = 7;
            this.gender.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // roomtype
            // 
            this.roomtype.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.roomtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roomtype.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomtype.ForeColor = System.Drawing.SystemColors.Window;
            this.roomtype.FormattingEnabled = true;
            this.roomtype.Items.AddRange(new object[] {
            "Single",
            "Double"});
            this.roomtype.Location = new System.Drawing.Point(530, 126);
            this.roomtype.Name = "roomtype";
            this.roomtype.Size = new System.Drawing.Size(142, 29);
            this.roomtype.TabIndex = 3;
            this.roomtype.SelectedIndexChanged += new System.EventHandler(this.roomtype_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label10.Location = new System.Drawing.Point(423, 320);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 21);
            this.label10.TabIndex = 10;
            this.label10.Text = "Country";
            this.label10.Click += new System.EventHandler(this.label8_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label8.Location = new System.Drawing.Point(422, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 21);
            this.label8.TabIndex = 10;
            this.label8.Text = "Gender";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label4.Location = new System.Drawing.Point(422, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Room Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label2.Location = new System.Drawing.Point(19, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Room No ";
            // 
            // country
            // 
            this.country.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.country.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.country.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.country.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.country.HintForeColor = System.Drawing.Color.Black;
            this.country.HintText = "Enter Country";
            this.country.isPassword = false;
            this.country.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.country.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.country.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.country.LineThickness = 4;
            this.country.Location = new System.Drawing.Point(530, 318);
            this.country.Margin = new System.Windows.Forms.Padding(4);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(142, 25);
            this.country.TabIndex = 9;
            this.country.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.country.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.country_KeyPress);
            // 
            // lastname
            // 
            this.lastname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lastname.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lastname.HintForeColor = System.Drawing.Color.Black;
            this.lastname.HintText = "Enter lastname";
            this.lastname.isPassword = false;
            this.lastname.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.lastname.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.lastname.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.lastname.LineThickness = 4;
            this.lastname.Location = new System.Drawing.Point(530, 64);
            this.lastname.Margin = new System.Windows.Forms.Padding(4);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(142, 25);
            this.lastname.TabIndex = 1;
            this.lastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.lastname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lastname_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label1.Location = new System.Drawing.Point(422, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Last Name ";
            // 
            // address
            // 
            this.address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.address.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.address.HintForeColor = System.Drawing.Color.Black;
            this.address.HintText = "Enter Address";
            this.address.isPassword = false;
            this.address.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.address.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.address.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.address.LineThickness = 4;
            this.address.Location = new System.Drawing.Point(123, 312);
            this.address.Margin = new System.Windows.Forms.Padding(4);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(141, 25);
            this.address.TabIndex = 8;
            this.address.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.address.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.address_KeyPress);
            // 
            // roomno
            // 
            this.roomno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roomno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.roomno.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.roomno.HintForeColor = System.Drawing.Color.Black;
            this.roomno.HintText = "Enter RoomNo";
            this.roomno.isPassword = false;
            this.roomno.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.roomno.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.roomno.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.roomno.LineThickness = 4;
            this.roomno.Location = new System.Drawing.Point(123, 128);
            this.roomno.Margin = new System.Windows.Forms.Padding(4);
            this.roomno.Name = "roomno";
            this.roomno.Size = new System.Drawing.Size(141, 25);
            this.roomno.TabIndex = 2;
            this.roomno.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.roomno.OnValueChanged += new System.EventHandler(this.roomno_OnValueChanged);
            this.roomno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.roomno_KeyPress);
            // 
            // firstname
            // 
            this.firstname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.firstname.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.firstname.HintForeColor = System.Drawing.Color.Black;
            this.firstname.HintText = "Enter firstname";
            this.firstname.isPassword = false;
            this.firstname.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.firstname.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.firstname.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.firstname.LineThickness = 4;
            this.firstname.Location = new System.Drawing.Point(123, 66);
            this.firstname.Margin = new System.Windows.Forms.Padding(4);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(141, 25);
            this.firstname.TabIndex = 0;
            this.firstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.firstname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firstname_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label3.Location = new System.Drawing.Point(19, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "First Name ";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(5, 5);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(80, 21);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Check In";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(914, 558);
            this.Controls.Add(this.checkinpanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            this.checkinpanel.ResumeLayout(false);
            this.checkinpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton Exit;
        private Bunifu.Framework.UI.BunifuImageButton Minimize;
        private System.Windows.Forms.Panel checkinpanel;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox firstname;
        private Bunifu.Framework.UI.BunifuMaterialTextbox lastname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox roomno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox roomtype;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker checkintime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker checkouttime;
        private Bunifu.Framework.UI.BunifuFlatButton checkinbutton;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuFlatButton updatebutton;
        private Bunifu.Framework.UI.BunifuFlatButton billbutton;
        private Bunifu.Framework.UI.BunifuFlatButton checkoutbutton;
        private Bunifu.Framework.UI.BunifuFlatButton searchbutton;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuFlatButton aboutbutton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuMaterialTextbox country;
        private Bunifu.Framework.UI.BunifuMaterialTextbox address;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private System.Windows.Forms.ComboBox peopleno;
    }
}