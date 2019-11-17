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
    public partial class checkinform : UserControl
    {
        SqlConnection sql = new SqlConnection(@"Server=ANDROID-5VJ4SY8\SQLEXPRESS; Database=dude; Integrated Security=true;");
        DataSet ds = new DataSet();

        public checkinform()
        {
            InitializeComponent();
        }

        private void clear()
        {
            firstname.Text = "";
            lastname.Text = "";
            roomno.Text = "";
            roomtype.Text = "";
            peopleno.Text = "";
            gender.Text = "";
            address.Text = "";
            country.Text = "";
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            sql.Open();
            DateTime first = Convert.ToDateTime(checkintime.Text);
            DateTime last = Convert.ToDateTime(checkouttime.Text);
            DateTime now = Convert.ToDateTime(DateTime.Today);
            if (first < now)
            {
                MessageBox.Show("Please FIll The Check In Date Correctly");
            }

            else if (last <= now)
            {
                MessageBox.Show("Please FIll The Check Out Date Correctly");
            }

            else if (firstname.Text.Length == 0 && lastname.Text.Length == 0 && roomno.Text.Length == 0 && peopleno.Text.Length == 0 && address.Text.Length == 0 && country.Text.Length == 0 && roomno.Text.Length == 0 && gender.Text.Length == 0 && roomtype.Text.Length == 0)
            {
                MessageBox.Show("Please Fill The EMPTY Fields Corretly ");
            }

            else
            {
                SqlCommand sq = new SqlCommand("SELECT * FROM checkin WHERE Roomno='" + roomno.Text + "'", sql);
                SqlDataAdapter da = new SqlDataAdapter(sq);
                da.Fill(ds);
                int i = ds.Tables[0].Rows.Count;
                if (i > 0)
                {
                    MessageBox.Show("RoomNo " + roomno.Text + " Already Exist ");
                    ds.Clear();
                }

                else
                {
                    SqlCommand cmd = new SqlCommand("Insert Into checkin(Firstname,Lastname,Roomno,Roomtype,Checkindate,Checkoutdate,People,Gender,Address,Country) " +
                     " Values('" + firstname.Text + "','" + lastname.Text + "','" + roomno.Text + "','" + roomtype.Text + "','" + checkintime.Text + "','" + checkouttime.Text + "','" + peopleno.Text + "','" + gender.Text + "','" + address.Text + "','" + country.Text + "')", sql);
                    cmd.ExecuteNonQuery();
                    clear();
                    MessageBox.Show("Thank You For CheckIN");
                }
            }
            sql.Close();
        }

        private void roomtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            var roomtp = roomtype.SelectedIndex.ToString();
        }

        private void peopleno_SelectedIndexChanged(object sender, EventArgs e)
        {
            var peopletp = peopleno.SelectedIndex.ToString();
        }

        private void gender_SelectedIndexChanged(object sender, EventArgs e)
        {
            var gend = gender.SelectedIndex.ToString();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            sql.Open();
            SqlCommand sq = new SqlCommand("SELECT * FROM checkin WHERE Roomno='" + roomno.Text + "'", sql);
            SqlDataAdapter da = new SqlDataAdapter(sq);
            da.Fill(ds);
            int i = ds.Tables[0].Rows.Count;
            if (i > 0)
            {
                MessageBox.Show("RoomNo " + roomno.Text + " Isn't Available ");
                ds.Clear();
            }
            else
            {
                MessageBox.Show("RoomNo " + roomno.Text + " Available ");
            }
            sql.Close();
        }

        private void roomno_OnValueChanged(object sender, EventArgs e)
        {
            int roomNo = 0;
            try
            {
                roomNo = Convert.ToInt32(roomno.Text);
            }
            catch (Exception)
            {
                roomNo = 0;
            }
            if (roomNo < 100)
            {

            }
            else
            {
                roomno.Text = "100";
            }
        }
        private void roomno_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }

        }

        private void firstname_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void lastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void address_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void country_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void checkinform_Load(object sender, EventArgs e)
        {

        }
    }
}
