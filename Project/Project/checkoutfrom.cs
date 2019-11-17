using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class checkoutfrom : UserControl
    {
        SqlConnection sql = new SqlConnection(@"Server=ANDROID-5VJ4SY8\SQLEXPRESS; Database=dude; Integrated Security=true;");

        public checkoutfrom()
        {
            InitializeComponent();
        }

        private void loadcombo()
        {
            sql.Open();
            SqlCommand cmd = new SqlCommand("select Roomno from checkin", sql);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                loadroom.Items.Add(dr[0].ToString());
            }
            sql.Close();
        }

        private void checkoutfrom_Load(object sender, EventArgs e)
        {
            loadcombo();
        }

        private void loadroom_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from checkin where Roomno='" + loadroom.Text+ "'", sql);
            sql.Open();
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string fname = (string)dr["Firstname"].ToString();
                string lname = (string)dr["Lastname"].ToString();
                string rno = (string)dr["Roomno"].ToString();
                string rtype = (string)dr["Roomtype"].ToString();
                string cindate = (string)dr["Checkindate"].ToString();
                string coutime = (string)dr["Checkoutdate"].ToString();
                string speople = (string)dr["People"].ToString();
                string sgender = (string)dr["Gender"].ToString();
                string saddress = (string)dr["Address"].ToString();
                string scountry = (string)dr["Country"].ToString();
                txtfirstname.Text = fname;
                txtlastname.Text = lname;
                txtroomno.Text = rno;
                txtroomtype.Text = rtype;
                txtcheckintime.Text = cindate;
                txtcheckouttime.Text = coutime;
                txtpeopleno.Text = speople;
                txtgender.Text = sgender;
                txtaddress.Text = saddress;
                txtcountry.Text = scountry;
            }
            sql.Close();
           
        }
    }
}
