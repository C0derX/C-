namespace Project
{
    partial class viewform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewform));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.checkinview = new Bunifu.Framework.UI.BunifuFlatButton();
            this.checkoutview = new Bunifu.Framework.UI.BunifuFlatButton();
            this.refreshbtn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.dataview = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataview)).BeginInit();
            this.SuspendLayout();
            // 
            // checkinview
            // 
            this.checkinview.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.checkinview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.checkinview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkinview.BorderRadius = 0;
            this.checkinview.ButtonText = "Check In View";
            this.checkinview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkinview.DisabledColor = System.Drawing.Color.Gray;
            this.checkinview.Iconcolor = System.Drawing.Color.Transparent;
            this.checkinview.Iconimage = null;
            this.checkinview.Iconimage_right = null;
            this.checkinview.Iconimage_right_Selected = null;
            this.checkinview.Iconimage_Selected = null;
            this.checkinview.IconMarginLeft = 0;
            this.checkinview.IconMarginRight = 0;
            this.checkinview.IconRightVisible = true;
            this.checkinview.IconRightZoom = 0D;
            this.checkinview.IconVisible = true;
            this.checkinview.IconZoom = 90D;
            this.checkinview.IsTab = false;
            this.checkinview.Location = new System.Drawing.Point(3, 84);
            this.checkinview.Name = "checkinview";
            this.checkinview.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.checkinview.OnHovercolor = System.Drawing.Color.White;
            this.checkinview.OnHoverTextColor = System.Drawing.SystemColors.GrayText;
            this.checkinview.selected = false;
            this.checkinview.Size = new System.Drawing.Size(187, 48);
            this.checkinview.TabIndex = 1;
            this.checkinview.Text = "Check In View";
            this.checkinview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkinview.Textcolor = System.Drawing.Color.White;
            this.checkinview.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkinview.Click += new System.EventHandler(this.checkinview_Click);
            // 
            // checkoutview
            // 
            this.checkoutview.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.checkoutview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.checkoutview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkoutview.BorderRadius = 0;
            this.checkoutview.ButtonText = "Check Out View";
            this.checkoutview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkoutview.DisabledColor = System.Drawing.Color.Gray;
            this.checkoutview.Iconcolor = System.Drawing.Color.Transparent;
            this.checkoutview.Iconimage = null;
            this.checkoutview.Iconimage_right = null;
            this.checkoutview.Iconimage_right_Selected = null;
            this.checkoutview.Iconimage_Selected = null;
            this.checkoutview.IconMarginLeft = 0;
            this.checkoutview.IconMarginRight = 0;
            this.checkoutview.IconRightVisible = true;
            this.checkoutview.IconRightZoom = 0D;
            this.checkoutview.IconVisible = true;
            this.checkoutview.IconZoom = 90D;
            this.checkoutview.IsTab = false;
            this.checkoutview.Location = new System.Drawing.Point(221, 84);
            this.checkoutview.Name = "checkoutview";
            this.checkoutview.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.checkoutview.OnHovercolor = System.Drawing.Color.White;
            this.checkoutview.OnHoverTextColor = System.Drawing.SystemColors.GrayText;
            this.checkoutview.selected = false;
            this.checkoutview.Size = new System.Drawing.Size(187, 48);
            this.checkoutview.TabIndex = 3;
            this.checkoutview.Text = "Check Out View";
            this.checkoutview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkoutview.Textcolor = System.Drawing.Color.White;
            this.checkoutview.TextFont = new System.Drawing.Font("Century Gothic", 12F);
            this.checkoutview.Click += new System.EventHandler(this.checkoutview_Click);
            // 
            // refreshbtn
            // 
            this.refreshbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refreshbtn.BackgroundImage")));
            this.refreshbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refreshbtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshbtn.Location = new System.Drawing.Point(435, 84);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(48, 48);
            this.refreshbtn.TabIndex = 63;
            this.refreshbtn.UseVisualStyleBackColor = true;
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(12, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 19);
            this.label11.TabIndex = 64;
            this.label11.Text = "View Data";
            // 
            // dataview
            // 
            this.dataview.AllowUserToDeleteRows = false;
            this.dataview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataview.Location = new System.Drawing.Point(0, 153);
            this.dataview.Name = "dataview";
            this.dataview.ReadOnly = true;
            this.dataview.Size = new System.Drawing.Size(689, 362);
            this.dataview.TabIndex = 65;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "Firstname";
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            this.FirstName.DefaultCellStyle = dataGridViewCellStyle11;
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "Lastname";
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            this.LastName.DefaultCellStyle = dataGridViewCellStyle12;
            this.LastName.HeaderText = "LastName";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // RoomNo
            // 
            this.RoomNo.DataPropertyName = "Roomno";
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            this.RoomNo.DefaultCellStyle = dataGridViewCellStyle13;
            this.RoomNo.HeaderText = "RoomNo";
            this.RoomNo.Name = "RoomNo";
            this.RoomNo.ReadOnly = true;
            // 
            // RoomType
            // 
            this.RoomType.DataPropertyName = "Roomtype";
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            this.RoomType.DefaultCellStyle = dataGridViewCellStyle14;
            this.RoomType.HeaderText = "RoomType";
            this.RoomType.Name = "RoomType";
            this.RoomType.ReadOnly = true;
            // 
            // CheckInDate
            // 
            this.CheckInDate.DataPropertyName = "Checkindate";
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            this.CheckInDate.DefaultCellStyle = dataGridViewCellStyle15;
            this.CheckInDate.HeaderText = "CheckInDate";
            this.CheckInDate.Name = "CheckInDate";
            this.CheckInDate.ReadOnly = true;
            // 
            // CheckOutDate
            // 
            this.CheckOutDate.DataPropertyName = "Checkoutdate";
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            this.CheckOutDate.DefaultCellStyle = dataGridViewCellStyle16;
            this.CheckOutDate.HeaderText = "CheckOutDate";
            this.CheckOutDate.Name = "CheckOutDate";
            this.CheckOutDate.ReadOnly = true;
            // 
            // PeopleNo
            // 
            this.PeopleNo.DataPropertyName = "People";
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            this.PeopleNo.DefaultCellStyle = dataGridViewCellStyle17;
            this.PeopleNo.HeaderText = "PeopleNo";
            this.PeopleNo.Name = "PeopleNo";
            this.PeopleNo.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            this.Gender.DefaultCellStyle = dataGridViewCellStyle18;
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black;
            this.Address.DefaultCellStyle = dataGridViewCellStyle19;
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Country
            // 
            this.Country.DataPropertyName = "Country";
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            this.Country.DefaultCellStyle = dataGridViewCellStyle20;
            this.Country.HeaderText = "Country";
            this.Country.Name = "Country";
            this.Country.ReadOnly = true;
            // 
            // viewform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataview);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.refreshbtn);
            this.Controls.Add(this.checkoutview);
            this.Controls.Add(this.checkinview);
            this.Name = "viewform";
            this.Size = new System.Drawing.Size(689, 518);
            ((System.ComponentModel.ISupportInitialize)(this.dataview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton checkinview;
        private Bunifu.Framework.UI.BunifuFlatButton checkoutview;
        private System.Windows.Forms.Button refreshbtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataview;
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
    }
}
