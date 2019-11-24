using System;
using System.Data.SqlClient;
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
        private void clear()
        {
            txtfirstname.Text = "";
            txtlastname.Text = "";
            txtroomno.Text = "";
            txtroomtype.SelectedIndex = -1;
            txtcheckintime.Value = DateTime.Now;
            txtcheckouttime.Value = DateTime.Now;
            txtpeopleno.SelectedIndex = -1;
            txtgender.SelectedIndex = -1;
            txtaddress.Text = "";
            txtcountry.Text = "";
        }

        private void loadcombo()
        {
            sql.Open();
            SqlCommand cmd = new SqlCommand("select Roomno from checkin order by Roomno asc", sql);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            { 
                loadroom.Items.Add(dr["Roomno"].ToString()); 
            }
            sql.Close();
        }

        private void checkoutfrom_Load(object sender, EventArgs e)
        {
            txtroomno.Enabled = false;
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
                string rtype = (String)dr["Roomtype"].ToString();
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

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            sql.Open();

           if(txtfirstname.Text.Length == 0 && txtlastname.Text.Length == 0 && txtroomno.Text.Length == 0 && txtpeopleno.Text.Length == 0 && txtaddress.Text.Length == 0 && txtcountry.Text.Length == 0 && txtroomno.Text.Length == 0 && txtgender.Text.Length == 0 && txtroomtype.Text.Length == 0)
            {
                MessageBox.Show("Empty Fields Cannot Be Checked OUT");
            }

            else
            {
                SqlCommand cmd = new SqlCommand("Insert Into checkout(Firstname,Lastname,Roomno,Roomtype,Checkindate,Checkoutdate,People,Gender,Address,Country)" +
                "values('" + txtfirstname.Text + "','" + txtlastname.Text + "','" + txtroomno.Text + "','" + txtroomtype.Text + "','" + txtcheckintime.Text + "','" + txtcheckouttime.Text + "','" + txtpeopleno.Text + "','" + txtgender.Text + "','" + txtaddress.Text + "','" + txtcountry.Text + "')", sql);
                MessageBox.Show("Thank You For Staying With US");
                cmd.ExecuteNonQuery();
                clear();
                loadroom.Items.Clear();
                SqlCommand cd = new SqlCommand("Delete from checkin where Roomno='" + loadroom.SelectedItem.ToString() + "'", sql);
                cd.ExecuteNonQuery();
            }
            sql.Close();
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            loadroom.Items.Clear();
            clear();
            loadcombo();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            sql.Open();
            if(txtfirstname.Text.Length == 0 && txtlastname.Text.Length == 0 && txtroomno.Text.Length == 0 && txtpeopleno.Text.Length == 0 && txtaddress.Text.Length == 0 && txtcountry.Text.Length == 0 && txtroomno.Text.Length == 0 && txtgender.Text.Length == 0 && txtroomtype.Text.Length == 0)
            {
                MessageBox.Show("You Cannot Delete The Empty Fields Please Select A Room");
            }
            else
            {
                SqlCommand cmd = new SqlCommand("Delete from checkin where Roomno='" + loadroom.Text + "'", sql);
                cmd.ExecuteNonQuery();
                loadroom.Items.Clear();
                clear();
            }
      
            sql.Close();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            sql.Open();
            if (txtfirstname.Text.Length == 0 && txtlastname.Text.Length == 0 && txtroomno.Text.Length == 0 && txtpeopleno.Text.Length == 0 && txtaddress.Text.Length == 0 && txtcountry.Text.Length == 0 && txtroomno.Text.Length == 0 && txtgender.Text.Length == 0 && txtroomtype.Text.Length == 0)
            {
                MessageBox.Show("Empty Fields Cannot Be Updated");
            }
            else
            {
                SqlCommand cmd = new SqlCommand("Update checkin set Firstname='" + txtfirstname.Text + "', Lastname='" + txtlastname.Text + "',Roomno='" + txtroomno.Text + "',Roomtype='" + txtroomtype.Text + "',Checkindate='" + txtcheckintime.Text + "',Checkoutdate='" + txtcheckouttime.Text + "',People='" + txtpeopleno.Text + "',Gender='" + txtgender.Text + "',Address='" + txtaddress.Text + "',Country='" + txtcountry.Text + "' where Roomno='" + loadroom.Text + "'", sql);
                cmd.ExecuteNonQuery();
                loadroom.Items.Clear();
                clear();
                MessageBox.Show("UPDATED Profile Successfully");
            }
            sql.Close();
        }

        private void txtfirstname_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!char.IsLetter(ch) && ch!=8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtlastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtaddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtcountry_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}
