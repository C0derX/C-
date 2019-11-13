namespace Project
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gender = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.checkbox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.button1 = new System.Windows.Forms.Button();
            this.password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lastname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.firstname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.usernametxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 524);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(43, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "We Create, We Design\r\n       We Develop\r\n";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(47, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 195);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.gender);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.checkbox);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.password);
            this.panel2.Controls.Add(this.lastname);
            this.panel2.Controls.Add(this.firstname);
            this.panel2.Controls.Add(this.usernametxt);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(330, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(349, 524);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // gender
            // 
            this.gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gender.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.gender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.gender.FormattingEnabled = true;
            this.gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gender.Location = new System.Drawing.Point(23, 281);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(294, 29);
            this.gender.TabIndex = 3;
            this.gender.SelectedIndexChanged += new System.EventHandler(this.gender_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label11.Location = new System.Drawing.Point(17, 255);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 21);
            this.label11.TabIndex = 8;
            this.label11.Text = "Gender:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label10.AutoEllipsis = true;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label10.Location = new System.Drawing.Point(298, 2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 30);
            this.label10.TabIndex = 7;
            this.label10.Text = "-";
            this.label10.Click += new System.EventHandler(this.Label10_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(191, 475);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 33);
            this.button2.TabIndex = 7;
            this.button2.Text = "Sign In";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // checkbox
            // 
            this.checkbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkbox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkbox.Checked = false;
            this.checkbox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.checkbox.ForeColor = System.Drawing.Color.White;
            this.checkbox.Location = new System.Drawing.Point(25, 386);
            this.checkbox.Name = "checkbox";
            this.checkbox.Size = new System.Drawing.Size(20, 20);
            this.checkbox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(20, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(290, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "Sign Up";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // password
            // 
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.password.HintForeColor = System.Drawing.Color.Black;
            this.password.HintText = "Enter Password";
            this.password.isPassword = true;
            this.password.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.password.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.password.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.password.LineThickness = 3;
            this.password.Location = new System.Drawing.Point(22, 341);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(290, 29);
            this.password.TabIndex = 4;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.password.OnValueChanged += new System.EventHandler(this.BunifuMaterialTextbox4_OnValueChanged);
            // 
            // lastname
            // 
            this.lastname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lastname.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lastname.HintForeColor = System.Drawing.Color.Black;
            this.lastname.HintText = "Enter Last Name";
            this.lastname.isPassword = false;
            this.lastname.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.lastname.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.lastname.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.lastname.LineThickness = 3;
            this.lastname.Location = new System.Drawing.Point(22, 217);
            this.lastname.Margin = new System.Windows.Forms.Padding(4);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(290, 29);
            this.lastname.TabIndex = 2;
            this.lastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.lastname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lastname_KeyPress);
            // 
            // firstname
            // 
            this.firstname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.firstname.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.firstname.HintForeColor = System.Drawing.Color.Black;
            this.firstname.HintText = "Enter First Name";
            this.firstname.isPassword = false;
            this.firstname.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.firstname.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.firstname.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.firstname.LineThickness = 3;
            this.firstname.Location = new System.Drawing.Point(22, 154);
            this.firstname.Margin = new System.Windows.Forms.Padding(4);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(290, 29);
            this.firstname.TabIndex = 1;
            this.firstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.firstname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firstname_KeyPress);
            // 
            // usernametxt
            // 
            this.usernametxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernametxt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.usernametxt.HintForeColor = System.Drawing.Color.Black;
            this.usernametxt.HintText = "Enter Username";
            this.usernametxt.isPassword = false;
            this.usernametxt.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.usernametxt.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.usernametxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.usernametxt.LineThickness = 3;
            this.usernametxt.Location = new System.Drawing.Point(22, 93);
            this.usernametxt.Margin = new System.Windows.Forms.Padding(4);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(290, 29);
            this.usernametxt.TabIndex = 0;
            this.usernametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label9.Location = new System.Drawing.Point(16, 481);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 21);
            this.label9.TabIndex = 2;
            this.label9.Text = "Already a member ?";
            this.label9.Click += new System.EventHandler(this.Label9_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label6.Location = new System.Drawing.Point(58, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(239, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "I Agree Terms and Conditions\r\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label8.Location = new System.Drawing.Point(19, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 21);
            this.label8.TabIndex = 2;
            this.label8.Text = "Password :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label5.Location = new System.Drawing.Point(19, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Last Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label4.Location = new System.Drawing.Point(17, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "First Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label3.Location = new System.Drawing.Point(17, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "User Name :";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label7.Location = new System.Drawing.Point(324, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "X";
            this.label7.Click += new System.EventHandler(this.Label7_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label2.Location = new System.Drawing.Point(3, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Staff Sign Up";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel2;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.panel1;
            this.bunifuDragControl2.Vertical = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 524);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox password;
        private Bunifu.Framework.UI.BunifuMaterialTextbox lastname;
        private Bunifu.Framework.UI.BunifuMaterialTextbox firstname;
        private Bunifu.Framework.UI.BunifuMaterialTextbox usernametxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuCheckbox checkbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox gender;
    }
}

