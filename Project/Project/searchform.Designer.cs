namespace Project
{
    partial class searchform
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(searchform));
            this.dataview = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckInDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckOutDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PeopleNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtfname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.checkinsearch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.checkoutsearch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.refreshbtn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataview)).BeginInit();
            this.SuspendLayout();
            // 
            // dataview
            // 
            this.dataview.AllowUserToDeleteRows = false;
            this.dataview.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FirstName,
            this.LastName,
            this.RoomNo,
            this.RoomType,
            this.CheckInDate,
            this.CheckOutDate,
            this.PeopleNo,
            this.Gender,
            this.Address,
            this.Country});
            this.dataview.Location = new System.Drawing.Point(0, 145);
            this.dataview.Name = "dataview";
            this.dataview.ReadOnly = true;
            this.dataview.Size = new System.Drawing.Size(689, 373);
            this.dataview.TabIndex = 3;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id";
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.ID.DefaultCellStyle = dataGridViewCellStyle1;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 30;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "Firstname";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.FirstName.DefaultCellStyle = dataGridViewCellStyle2;
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "Lastname";
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.LastName.DefaultCellStyle = dataGridViewCellStyle3;
            this.LastName.HeaderText = "LastName";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // RoomNo
            // 
            this.RoomNo.DataPropertyName = "Roomno";
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.RoomNo.DefaultCellStyle = dataGridViewCellStyle4;
            this.RoomNo.HeaderText = "RoomNo";
            this.RoomNo.Name = "RoomNo";
            this.RoomNo.ReadOnly = true;
            this.RoomNo.Width = 60;
            // 
            // RoomType
            // 
            this.RoomType.DataPropertyName = "Roomtype";
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.RoomType.DefaultCellStyle = dataGridViewCellStyle5;
            this.RoomType.HeaderText = "RoomType";
            this.RoomType.Name = "RoomType";
            this.RoomType.ReadOnly = true;
            this.RoomType.Width = 70;
            // 
            // CheckInDate
            // 
            this.CheckInDate.DataPropertyName = "Checkindate";
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.CheckInDate.DefaultCellStyle = dataGridViewCellStyle6;
            this.CheckInDate.HeaderText = "CheckInDate";
            this.CheckInDate.Name = "CheckInDate";
            this.CheckInDate.ReadOnly = true;
            this.CheckInDate.Width = 75;
            // 
            // CheckOutDate
            // 
            this.CheckOutDate.DataPropertyName = "Checkoutdate";
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.CheckOutDate.DefaultCellStyle = dataGridViewCellStyle7;
            this.CheckOutDate.HeaderText = "CheckOutDate";
            this.CheckOutDate.Name = "CheckOutDate";
            this.CheckOutDate.ReadOnly = true;
            this.CheckOutDate.Width = 80;
            // 
            // PeopleNo
            // 
            this.PeopleNo.DataPropertyName = "People";
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.PeopleNo.DefaultCellStyle = dataGridViewCellStyle8;
            this.PeopleNo.HeaderText = "PeopleNo";
            this.PeopleNo.Name = "PeopleNo";
            this.PeopleNo.ReadOnly = true;
            this.PeopleNo.Width = 60;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            this.Gender.DefaultCellStyle = dataGridViewCellStyle9;
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.Width = 70;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            this.Address.DefaultCellStyle = dataGridViewCellStyle10;
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Country
            // 
            this.Country.DataPropertyName = "Country";
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            this.Country.DefaultCellStyle = dataGridViewCellStyle11;
            this.Country.HeaderText = "Country";
            this.Country.Name = "Country";
            this.Country.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label3.Location = new System.Drawing.Point(14, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "Search By Name";
            // 
            // txtfname
            // 
            this.txtfname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtfname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtfname.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtfname.HintForeColor = System.Drawing.Color.Black;
            this.txtfname.HintText = "Enter FirstName";
            this.txtfname.isPassword = false;
            this.txtfname.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtfname.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtfname.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.txtfname.LineThickness = 4;
            this.txtfname.Location = new System.Drawing.Point(158, 100);
            this.txtfname.Margin = new System.Windows.Forms.Padding(4);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(141, 35);
            this.txtfname.TabIndex = 22;
            this.txtfname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtfname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfname_KeyPress);
            // 
            // checkinsearch
            // 
            this.checkinsearch.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.checkinsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.checkinsearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.checkinsearch.BorderRadius = 0;
            this.checkinsearch.ButtonText = "CheckIn";
            this.checkinsearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkinsearch.DisabledColor = System.Drawing.Color.Gray;
            this.checkinsearch.Iconcolor = System.Drawing.Color.Transparent;
            this.checkinsearch.Iconimage = ((System.Drawing.Image)(resources.GetObject("checkinsearch.Iconimage")));
            this.checkinsearch.Iconimage_right = null;
            this.checkinsearch.Iconimage_right_Selected = null;
            this.checkinsearch.Iconimage_Selected = null;
            this.checkinsearch.IconMarginLeft = 0;
            this.checkinsearch.IconMarginRight = 0;
            this.checkinsearch.IconRightVisible = true;
            this.checkinsearch.IconRightZoom = 0D;
            this.checkinsearch.IconVisible = true;
            this.checkinsearch.IconZoom = 90D;
            this.checkinsearch.IsTab = false;
            this.checkinsearch.Location = new System.Drawing.Point(306, 87);
            this.checkinsearch.Name = "checkinsearch";
            this.checkinsearch.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.checkinsearch.OnHovercolor = System.Drawing.Color.White;
            this.checkinsearch.OnHoverTextColor = System.Drawing.SystemColors.ControlDark;
            this.checkinsearch.selected = false;
            this.checkinsearch.Size = new System.Drawing.Size(131, 48);
            this.checkinsearch.TabIndex = 23;
            this.checkinsearch.Text = "CheckIn";
            this.checkinsearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkinsearch.Textcolor = System.Drawing.Color.White;
            this.checkinsearch.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkinsearch.Click += new System.EventHandler(this.checkinsearch_Click);
            // 
            // checkoutsearch
            // 
            this.checkoutsearch.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.checkoutsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.checkoutsearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkoutsearch.BorderRadius = 0;
            this.checkoutsearch.ButtonText = "CheckOut";
            this.checkoutsearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkoutsearch.DisabledColor = System.Drawing.Color.Gray;
            this.checkoutsearch.Iconcolor = System.Drawing.Color.Transparent;
            this.checkoutsearch.Iconimage = ((System.Drawing.Image)(resources.GetObject("checkoutsearch.Iconimage")));
            this.checkoutsearch.Iconimage_right = null;
            this.checkoutsearch.Iconimage_right_Selected = null;
            this.checkoutsearch.Iconimage_Selected = null;
            this.checkoutsearch.IconMarginLeft = 0;
            this.checkoutsearch.IconMarginRight = 0;
            this.checkoutsearch.IconRightVisible = true;
            this.checkoutsearch.IconRightZoom = 0D;
            this.checkoutsearch.IconVisible = true;
            this.checkoutsearch.IconZoom = 90D;
            this.checkoutsearch.IsTab = false;
            this.checkoutsearch.Location = new System.Drawing.Point(443, 87);
            this.checkoutsearch.Name = "checkoutsearch";
            this.checkoutsearch.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.checkoutsearch.OnHovercolor = System.Drawing.Color.White;
            this.checkoutsearch.OnHoverTextColor = System.Drawing.SystemColors.ControlDark;
            this.checkoutsearch.selected = false;
            this.checkoutsearch.Size = new System.Drawing.Size(145, 48);
            this.checkoutsearch.TabIndex = 24;
            this.checkoutsearch.Text = "CheckOut";
            this.checkoutsearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkoutsearch.Textcolor = System.Drawing.Color.White;
            this.checkoutsearch.TextFont = new System.Drawing.Font("Century Gothic", 12F);
            this.checkoutsearch.Click += new System.EventHandler(this.checkoutsearch_Click);
            // 
            // refreshbtn
            // 
            this.refreshbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refreshbtn.BackgroundImage")));
            this.refreshbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refreshbtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshbtn.Location = new System.Drawing.Point(605, 87);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(48, 48);
            this.refreshbtn.TabIndex = 64;
            this.refreshbtn.UseVisualStyleBackColor = true;
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(14, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 19);
            this.label11.TabIndex = 65;
            this.label11.Text = "Search";
            // 
            // searchform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label11);
            this.Controls.Add(this.refreshbtn);
            this.Controls.Add(this.checkoutsearch);
            this.Controls.Add(this.checkinsearch);
            this.Controls.Add(this.txtfname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataview);
            this.Name = "searchform";
            this.Size = new System.Drawing.Size(689, 518);
            ((System.ComponentModel.ISupportInitialize)(this.dataview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataview;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtfname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckInDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckOutDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PeopleNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private Bunifu.Framework.UI.BunifuFlatButton checkinsearch;
        private Bunifu.Framework.UI.BunifuFlatButton checkoutsearch;
        private System.Windows.Forms.Button refreshbtn;
        private System.Windows.Forms.Label label11;
    }
}
