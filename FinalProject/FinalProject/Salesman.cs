using FinalProject.SalesmanUC;
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
    public partial class Salesman : Form
    {
        public Salesman()
        {
            InitializeComponent();
        }

        ///sgdgdhfhfhfhf
        private void btnAddClothes_Click(object sender, EventArgs e)
        {
            uC_S_AddClothes1.Visible = true;
            uC_S_AddClothes1.BringToFront();
        }

        private void btnViewClothes_Click(object sender, EventArgs e)
        {
            uC_S_ViewClothes1.Visible = true;
            uC_S_ViewClothes1.BringToFront();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void btnModifyClothes_Click(object sender, EventArgs e)
        {
            uC_S_ModifyCloth1.Visible = true;
            uC_S_ModifyCloth1.BringToFront();
        }

        private void btnSellClothes_Click(object sender, EventArgs e)
        {
            uC_S_SellCloth1.Visible = true;
            uC_S_SellCloth1.BringToFront();
        }

        private void Salesman_Load(object sender, EventArgs e)
        {
            //uC_S_Dashboard1.Visible = false;
            uC_S_AddClothes1.Visible = false;
            uC_S_ViewClothes1.Visible = false;
            uC_S_ModifyCloth1.Visible = false;
            uC_S_SellCloth1.Visible = false;
            //btnDashboard.PerformClick();
            btnAddClothes.PerformClick();
        }
    }
}
