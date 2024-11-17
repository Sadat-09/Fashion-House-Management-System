using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.SalesmanUC
{
    public partial class UC_S_ModifyCloth : UserControl
    {
        function f1 = new function();
        String query;

        public UC_S_ModifyCloth()
        {
            InitializeComponent();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtClothId.Text != "")
            {
                query = "select * from cloth where cid = '" + txtClothId.Text + "'";
                DataSet ds = f1.getData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtClothName.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtAvailableQuantity.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtPriceUnit.Text = ds.Tables[0].Rows[0][4].ToString();

                }

                else
                {
                    MessageBox.Show("No cloth with ID :" + txtClothId.Text + " exists.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            else
            {
                clearAll();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void clearAll()
        {
            txtClothId.Clear();
            txtClothName.Clear();
            txtAvailableQuantity.Clear();
            txtPriceUnit.Clear();

            if (txtAddQuantity.Text != "0")
            {
                txtAddQuantity.Text = "0";
            }
            else
            {
                txtAddQuantity.Text = "0";
            }

        }

        Int64 totalQuantity;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String cname = txtClothName.Text;
            Int64 quantity = Int64.Parse(txtAvailableQuantity.Text);
            Int64 addQuantity = Int64.Parse(txtAddQuantity.Text);
            Int64 unitprice = Int64.Parse(txtPriceUnit.Text);

            totalQuantity = quantity + addQuantity;

            query = "update cloth set cname = '" + cname + "',quantity= " + totalQuantity + ",perUnit = " + unitprice + " where cid = '" + txtClothId.Text + "' ";
            f1.setData(query, "Cloth details updated.");
        }
    }
}