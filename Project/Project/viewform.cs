using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project
{
    public partial class viewform : UserControl
    {
        SqlConnection sql = new SqlConnection(@"Server=ANDROID-5VJ4SY8\SQLEXPRESS; Database=dude; Integrated Security=true;");
        public viewform()
        {
            InitializeComponent();
        }

        private void checkinview_Click(object sender, EventArgs e)
        {
            sql.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from checkin", sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataview.AutoGenerateColumns = false;
            dataview.DataSource = dt;
            sql.Close();

        }

        private void checkoutview_Click(object sender, EventArgs e)
        {
            sql.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from checkout", sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataview.AutoGenerateColumns = false;
            dataview.DataSource = dt;
            sql.Close();
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            dataview.DataSource = null;
        }
    }
}
