﻿using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        SqlConnection sql = new SqlConnection(@"Server=ANDROID-5VJ4SY8\SQLEXPRESS; Database=dude; Integrated Security=true;");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();

        public Form1()
        {
            InitializeComponent();
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }


        private void Label10_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm f = new LoginForm();
            f.ShowDialog();
        }

        private void BunifuMaterialTextbox4_OnValueChanged(object sender, EventArgs e)
        {
            password.isPassword = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            sql.Open();
            var cmd = new SqlCommand();

            if (usernametxt.Text.Length == 0)
            {
                MessageBox.Show("Please Input Your Username");
            }

            else if (firstname.Text.Length == 0)
            {
                MessageBox.Show("Please Insert Your First Name");
            }

            else if (lastname.Text.Length == 0)
            {
                MessageBox.Show("Please Insert Your Last Name");
            }

            else if (password.Text.Length == 0)
            {
                MessageBox.Show("Please Enter Your Password");
            }
            else if (checkbox.Checked == false)
            {
                MessageBox.Show("Please Tick Mark The CheckBox");
            }

            else
            {
                cmd = new SqlCommand("SELECT * FROM userdata WHERE username='" + usernametxt.Text + "'", sql);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                int i = ds.Tables[0].Rows.Count;
                if (i > 0)
                {
                    MessageBox.Show("Username " + usernametxt.Text + " Already Exist ");
                    ds.Clear();
                }

                else
                {
                    cmd = new SqlCommand("Insert Into userdata(username,firstname,lastname,password) Values('" + usernametxt.Text + "','" + firstname.Text + "','" + lastname.Text + "','" + password.Text + "')", sql);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thank You For Registration");
                }
            }

            sql.Close();
        }
    }
}