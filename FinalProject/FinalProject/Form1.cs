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
    public partial class Form1 : Form
    {
        function fn = new function();
        String query;
        DataSet ds;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            query = "select * from users";
             ds = fn.getData(query);

            if(ds.Tables[0].Rows.Count == 0)
            {
                if(txtUsername.Text=="new" && txtPassword.Text == "new")
                {
                    Admin ad = new Admin();
                    ad.Show();
                    this.Hide();
                }
            }
            else
            {
                query = "select * from users where username='" + txtUsername.Text + "' and pass = '" + txtPassword.Text + "' ";
                ds=fn.getData(query);
                if(ds.Tables[0].Rows.Count != 0)
                {
                    String role = ds.Tables[0].Rows[0][1].ToString();
                    if (role == "Admin")
                    {
                        Admin ad = new Admin(txtUsername.Text);
                        ad.Show();
                        this.Hide();
                    }
                    else if(role == "Salesman")
                    {
                        Salesman sales = new Salesman();
                        sales.Show();
                        this.Hide();

                    }
                   


                }
                else
                {
                    MessageBox.Show("Wrong User OR Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }







            //if (txtUsername.Text == "Admin" && txtPassword.Text == "Admin")

            //{
            //    Admin ad = new Admin();
            //    ad.Show();
            //    this.Hide();
            //}


            //else
            //{
            //    MessageBox.Show("Wrong Username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}
