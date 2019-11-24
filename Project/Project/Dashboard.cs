using System;
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

        private void Dashboard_Load(object sender, EventArgs e)
        {   
            checkinform1.Show();
            checkinform1.BringToFront();
            checkoutfrom1.Hide();
            viewform1.Hide();
            searchform1.Hide();
            updateform1.Hide();
        }
        private void checkinbutton_Click(object sender, EventArgs e)
        {
            checkinform1.Show();
            checkinform1.BringToFront();
            checkoutfrom1.Hide();
            viewform1.Hide();
            searchform2.Hide();
            updateform1.Hide();
        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            checkoutfrom1.Show();
            checkoutfrom1.BringToFront();
            checkinform1.Hide();
            viewform1.Hide();
            searchform2.Hide();
            updateform1.Hide();

        }
        private void billbutton_Click(object sender, EventArgs e)
        {
            viewform1.Show();
            viewform1.BringToFront();
            checkinform1.Hide();
            checkoutfrom1.Hide();
            searchform2.Hide();
            updateform1.Hide();
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            updateform1.Show();
            updateform1.BringToFront();
            checkinform1.Hide();
            checkoutfrom1.Hide();
            viewform1.Hide();
            searchform2.Hide();
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            searchform2.Show();
            searchform2.BringToFront();
            checkinform1.Hide();
            checkoutfrom1.Hide();
            viewform1.Hide();
            updateform1.Hide();
        }

        private void signout_Click(object sender, EventArgs e)
        {
            LoginForm l = new LoginForm();
            this.Hide();
            l.ShowDialog();
        }
    }
}
