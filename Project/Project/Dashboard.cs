using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

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
    }
}
