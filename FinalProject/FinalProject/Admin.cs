using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Admin : Form
    {
        String user = "";
        public Admin()
        {
            InitializeComponent();
        }

        public string ID
        {
            get { return user.ToString(); }
        }
        public Admin(String username)
        {
            InitializeComponent();
            userNamelabel.Text = username;
            
            user = username;
            uC_SearchUser1.ID= ID;
            uC_Profile1.ID = ID;
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            uC_Dashboard1.Visible = true;
            uC_Dashboard1.BringToFront();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            uC_Dashboard1.Visible = false;
            uC_AddUser1.Visible = false;
            uC_SearchUser1.Visible = false;
            uC_Profile1.Visible = false;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            uC_AddUser1.Visible=true;
            uC_AddUser1.BringToFront();
        }

        private void btnSearchuser_Click(object sender, EventArgs e)
        {
            uC_SearchUser1.Visible=true;
            uC_SearchUser1.BringToFront();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            uC_Profile1.Visible=true;
            uC_Profile1.BringToFront();
        }
    }
}
