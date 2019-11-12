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
    public partial class Dashboard : Form
    {
        SqlConnection sql = new SqlConnection(@"Server=ANDROID-5VJ4SY8\SQLEXPRESS; Database=dude; Integrated Security=true;");
        DataSet ds = new DataSet();
        public Dashboard()
        {
            InitializeComponent();
        }
        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            checkinpanel.Visible = false;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var gend = gender.SelectedIndex.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkinbutton_Click(object sender, EventArgs e)
        {
            checkinpanel.Visible = true;
        }

        private void billbutton_Click(object sender, EventArgs e)
        {
            checkinpanel.Visible = false;
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            checkinpanel.Visible = false;

        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            checkinpanel.Visible = false;

        }

        private void aboutbutton_Click(object sender, EventArgs e)
        {
            checkinpanel.Visible = false;
        }

        private void roomno_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void roomno_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
            else if (roomno.Text.Length <= 100)
            {
                e.Handled = false;
                //MessageBox.Show("Please Input Room Number Less 100","WE HAVE ROOM UPTO 100");
            }

        }

        private void bunifuMaterialTextbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!char.IsDigit(ch) && ch !=8 && ch != 46)
            {
                e.Handled = true;
            }
            
            else if (peopleno.Text.Length <= '4')
            {
                e.Handled = false;
                //MessageBox.Show("Please Input Number Less 4");
            }
        }

        private void roomtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            var roomtp = roomtype.SelectedIndex.ToString();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            sql.Open();

            if (checkintime.MinDate < checkouttime.MaxDate)
            {
                MessageBox.Show("Please FIll The Date Correctly");
            }

            else if (firstname.Text.Length==0 && lastname.Text.Length==0 && roomno.Text.Length == 0 && peopleno.Text.Length ==0 && address.Text.Length==0 && country.Text.Length==0 && roomno.Text.Length==0 )
            {
                MessageBox.Show("Please Fill The Fields Corretly ");
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
                    MessageBox.Show("Thank You For CheckIN");
                }

                sql.Close();
            }

        }
    }
}
