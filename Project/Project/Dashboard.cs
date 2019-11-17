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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            
            checkinform1.Show();
            checkinform1.BringToFront();
        }
        private void checkinbutton_Click(object sender, EventArgs e)
        {
            checkoutfrom1.Hide();
            checkinform1.Show();
            checkinform1.BringToFront();
        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            checkinform1.Hide();
            checkoutfrom1.Show();
            checkoutfrom1.BringToFront();
        }
        private void billbutton_Click(object sender, EventArgs e)
        {
            checkinform1.Hide();
            checkoutfrom1.Hide();
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            checkinform1.Hide();
            checkoutfrom1.Hide();
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            checkinform1.Hide();
            checkoutfrom1.Hide();
        }

        private void aboutbutton_Click(object sender, EventArgs e)
        {
            checkinform1.Hide();
            checkoutfrom1.Hide();
        }
        private void headpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
