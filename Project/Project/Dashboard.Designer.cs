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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.aboutbutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.searchbutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.updatebutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.billbutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.checkoutbutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.checkinbutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Exit = new Bunifu.Framework.UI.BunifuImageButton();
            this.Minimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.headpanel = new System.Windows.Forms.Panel();
            this.updateform1 = new Project.updateform();
            this.viewform1 = new Project.viewform();
            this.searchform1 = new Project.searchform();
            this.checkoutfrom1 = new Project.checkoutfrom();
            this.checkinform1 = new Project.checkinform();
            this.searchform2 = new Project.searchform();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.signout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
            this.headpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.signout);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Controls.Add(this.searchform1);
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
            this.aboutbutton.Location = new System.Drawing.Point(0, 414);
            this.aboutbutton.Name = "aboutbutton";
            this.aboutbutton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.aboutbutton.OnHovercolor = System.Drawing.Color.White;
            this.aboutbutton.OnHoverTextColor = System.Drawing.SystemColors.GrayText;
            this.aboutbutton.selected = false;
            this.aboutbutton.Size = new System.Drawing.Size(222, 37);
            this.aboutbutton.TabIndex = 5;
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
            this.searchbutton.Location = new System.Drawing.Point(0, 361);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.searchbutton.OnHovercolor = System.Drawing.Color.White;
            this.searchbutton.OnHoverTextColor = System.Drawing.SystemColors.GrayText;
            this.searchbutton.selected = false;
            this.searchbutton.Size = new System.Drawing.Size(223, 45);
            this.searchbutton.TabIndex = 4;
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
            this.updatebutton.ButtonText = "Update/Delete";
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
            this.updatebutton.Location = new System.Drawing.Point(0, 316);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.updatebutton.OnHovercolor = System.Drawing.Color.White;
            this.updatebutton.OnHoverTextColor = System.Drawing.SystemColors.GrayText;
            this.updatebutton.selected = false;
            this.updatebutton.Size = new System.Drawing.Size(223, 49);
            this.updatebutton.TabIndex = 3;
            this.updatebutton.Text = "Update/Delete";
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
            this.billbutton.ButtonText = "View";
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
            this.billbutton.Location = new System.Drawing.Point(0, 274);
            this.billbutton.Name = "billbutton";
            this.billbutton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.billbutton.OnHovercolor = System.Drawing.Color.White;
            this.billbutton.OnHoverTextColor = System.Drawing.SystemColors.GrayText;
            this.billbutton.selected = false;
            this.billbutton.Size = new System.Drawing.Size(223, 43);
            this.billbutton.TabIndex = 2;
            this.billbutton.Text = "View";
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
            this.checkoutbutton.Location = new System.Drawing.Point(0, 224);
            this.checkoutbutton.Name = "checkoutbutton";
            this.checkoutbutton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.checkoutbutton.OnHovercolor = System.Drawing.Color.White;
            this.checkoutbutton.OnHoverTextColor = System.Drawing.SystemColors.GrayText;
            this.checkoutbutton.selected = false;
            this.checkoutbutton.Size = new System.Drawing.Size(223, 48);
            this.checkoutbutton.TabIndex = 1;
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
            this.checkinbutton.Location = new System.Drawing.Point(0, 176);
            this.checkinbutton.Name = "checkinbutton";
            this.checkinbutton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.checkinbutton.OnHovercolor = System.Drawing.Color.White;
            this.checkinbutton.OnHoverTextColor = System.Drawing.SystemColors.GrayText;
            this.checkinbutton.selected = false;
            this.checkinbutton.Size = new System.Drawing.Size(223, 46);
            this.checkinbutton.TabIndex = 0;
            this.checkinbutton.Text = "Check In";
            this.checkinbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkinbutton.Textcolor = System.Drawing.Color.White;
            this.checkinbutton.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkinbutton.Click += new System.EventHandler(this.checkinbutton_Click);
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
            // headpanel
            // 
            this.headpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(33)))), ((int)(((byte)(73)))));
            this.headpanel.Controls.Add(this.label3);
            this.headpanel.Controls.Add(this.Minimize);
            this.headpanel.Controls.Add(this.Exit);
            this.headpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headpanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(33)))), ((int)(((byte)(73)))));
            this.headpanel.Location = new System.Drawing.Point(0, 0);
            this.headpanel.Name = "headpanel";
            this.headpanel.Size = new System.Drawing.Size(916, 38);
            this.headpanel.TabIndex = 1;
            // 
            // updateform1
            // 
            this.updateform1.Location = new System.Drawing.Point(224, 38);
            this.updateform1.Name = "updateform1";
            this.updateform1.Size = new System.Drawing.Size(689, 518);
            this.updateform1.TabIndex = 7;
            // 
            // viewform1
            // 
            this.viewform1.Location = new System.Drawing.Point(224, 38);
            this.viewform1.Name = "viewform1";
            this.viewform1.Size = new System.Drawing.Size(689, 518);
            this.viewform1.TabIndex = 6;
            // 
            // searchform1
            // 
            this.searchform1.Location = new System.Drawing.Point(229, 44);
            this.searchform1.Name = "searchform1";
            this.searchform1.Size = new System.Drawing.Size(689, 518);
            this.searchform1.TabIndex = 5;
            // 
            // checkoutfrom1
            // 
            this.checkoutfrom1.Location = new System.Drawing.Point(224, 38);
            this.checkoutfrom1.Name = "checkoutfrom1";
            this.checkoutfrom1.Size = new System.Drawing.Size(689, 518);
            this.checkoutfrom1.TabIndex = 3;
            // 
            // checkinform1
            // 
            this.checkinform1.Location = new System.Drawing.Point(224, 41);
            this.checkinform1.Name = "checkinform1";
            this.checkinform1.Size = new System.Drawing.Size(689, 518);
            this.checkinform1.TabIndex = 2;
            // 
            // searchform2
            // 
            this.searchform2.Location = new System.Drawing.Point(224, 38);
            this.searchform2.Name = "searchform2";
            this.searchform2.Size = new System.Drawing.Size(689, 518);
            this.searchform2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(5, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(319, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hotel Reservation Management System\r\n";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.headpanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.bunifuImageButton1.ErrorImage = null;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.InitialImage = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(40, 4);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(150, 164);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 6;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // signout
            // 
            this.signout.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.signout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.signout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.signout.BorderRadius = 0;
            this.signout.ButtonText = "Sign Out";
            this.signout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signout.DisabledColor = System.Drawing.Color.Gray;
            this.signout.Iconcolor = System.Drawing.Color.Transparent;
            this.signout.Iconimage = null;
            this.signout.Iconimage_right = null;
            this.signout.Iconimage_right_Selected = null;
            this.signout.Iconimage_Selected = null;
            this.signout.IconMarginLeft = 0;
            this.signout.IconMarginRight = 0;
            this.signout.IconRightVisible = true;
            this.signout.IconRightZoom = 0D;
            this.signout.IconVisible = true;
            this.signout.IconZoom = 90D;
            this.signout.IsTab = true;
            this.signout.Location = new System.Drawing.Point(1, 457);
            this.signout.Name = "signout";
            this.signout.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.signout.OnHovercolor = System.Drawing.Color.White;
            this.signout.OnHoverTextColor = System.Drawing.SystemColors.GrayText;
            this.signout.selected = false;
            this.signout.Size = new System.Drawing.Size(222, 33);
            this.signout.TabIndex = 6;
            this.signout.Text = "Sign Out";
            this.signout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.signout.Textcolor = System.Drawing.Color.White;
            this.signout.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signout.Click += new System.EventHandler(this.signout_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(916, 560);
            this.Controls.Add(this.headpanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkinform1);
            this.Controls.Add(this.searchform2);
            this.Controls.Add(this.updateform1);
            this.Controls.Add(this.viewform1);
            this.Controls.Add(this.checkoutfrom1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            this.headpanel.ResumeLayout(false);
            this.headpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton checkinbutton;
        private Bunifu.Framework.UI.BunifuFlatButton updatebutton;
        private Bunifu.Framework.UI.BunifuFlatButton billbutton;
        private Bunifu.Framework.UI.BunifuFlatButton checkoutbutton;
        private Bunifu.Framework.UI.BunifuFlatButton searchbutton;
        private Bunifu.Framework.UI.BunifuFlatButton aboutbutton;
        private Bunifu.Framework.UI.BunifuImageButton Exit;
        private Bunifu.Framework.UI.BunifuImageButton Minimize;
        private System.Windows.Forms.Panel headpanel;
        private searchform searchform1;
        private checkinform checkinform1;
        private checkoutfrom checkoutfrom1;
        private searchform searchform2;
        private viewform viewform1;
        private updateform updateform1;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton signout;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}