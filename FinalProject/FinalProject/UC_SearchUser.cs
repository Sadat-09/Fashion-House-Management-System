﻿using System;
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
    public partial class UC_SearchUser : UserControl
    {
        function fn = new function();
        String query;
        String currentUser = "";
        
        public UC_SearchUser()
        {
            InitializeComponent();
        }

        public string ID
        {
            set { currentUser = value; }
        }

        private void UC_SearchUser_Load(object sender, EventArgs e)
        {
            query = "select * from users";
             DataSet ds=fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            query = "select * from users where username Like '" + txtUserName.Text + "%'"; 
            DataSet ds=fn.getData(query);
            guna2DataGridView1.DataSource=ds.Tables[0];
        }


        String userName;

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                userName = guna2DataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

            }
            catch
            {

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure?", "Delete Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                if (currentUser != userName)
                {
                    query = "delete from users where username ='" + userName + "'";
                    fn.setData(query, "User Record Deleted");
                    UC_SearchUser_Load(this, null);
                }
                else
                {
                    MessageBox.Show("Deleting own profile.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            UC_SearchUser_Load(this, null);
        }
    }
}
