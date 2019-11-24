using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project
{
    public partial class searchform : UserControl
    {
        SqlConnection sql = new SqlConnection(@"Server=ANDROID-5VJ4SY8\SQLEXPRESS; Database=dude; Integrated Security=true;");
        public searchform()
        {
            InitializeComponent();
        }

        private void checkinsearch_Click(object sender, EventArgs e)
        {
            sql.Open();
            if (txtfname.Text.Length == 0)
            {
                MessageBox.Show("Empty Fields Cannot Be Search");
            }
            else
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from checkin where Firstname='" + txtfname.Text + "'", sql);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataview.AutoGenerateColumns = false;
                dataview.DataSource = dt;
                sql.Close();
            }
        }

        private void checkoutsearch_Click(object sender, EventArgs e)
        {
            sql.Open();
            if (txtfname.Text.Length == 0)
            {
                MessageBox.Show("Empty Fields Cannot Be Search");
            }
            else
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from checkout where Firstname='" + txtfname.Text + "' ", sql);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataview.AutoGenerateColumns = false;
                dataview.DataSource = dt;
                sql.Close();
            }
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            dataview.DataSource = null;
            txtfname.Text = "";
        }

        private void txtfname_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!char.IsLetter(ch) && ch!=8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}
