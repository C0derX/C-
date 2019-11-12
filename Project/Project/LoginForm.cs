using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class LoginForm : Form
    {
        SqlConnection sql = new SqlConnection(@"Server=ANDROID-5VJ4SY8\SQLEXPRESS; Database=dude; Integrated Security=true;");

        void savecredientals()
        {
            if (bunifuCheckbox2.Checked == true)
            {
                Properties.Settings.Default.Username = username.Text;
                Properties.Settings.Default.Password = password.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Username = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Save();
            }
        }

        void loadcredientals()
        {
            if(Properties.Settings.Default.Username != String.Empty)
            {
                username.Text = Properties.Settings.Default.Username;
                password.Text = Properties.Settings.Default.Password;
                bunifuCheckbox2.Checked = true;
            }
        }

        public LoginForm()
        {
            InitializeComponent();
            loadcredientals();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void BunifuMaterialTextbox4_OnValueChanged(object sender, EventArgs e)
        {
            password.isPassword = true;
        }

        private void Label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Label10_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(username.Text)==true && string.IsNullOrEmpty(password.Text)==true)
            {
                MessageBox.Show("Both fields are Required");
            }

            else
            {
                SqlCommand cmd = new SqlCommand("select * from userdata where username=@user and password=@pass ", sql);
                cmd.Parameters.AddWithValue("@user", username.Text);
                cmd.Parameters.AddWithValue("@pass", password.Text);
                sql.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows==true)
                {
                    savecredientals();
                    this.Hide();
                    Dashboard d = new Dashboard();
                    d.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Login Unsuccessful");
                }
                sql.Close();

            }
        }
    }
}
