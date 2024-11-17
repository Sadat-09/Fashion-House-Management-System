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
    public partial class UC_S_AddClothes : UserControl
    {
        function f1 = new function();
        String query;


        public UC_S_AddClothes()
        {
            InitializeComponent();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
           {
               if (txtId.Text != "" && txtClothName.Text != "" && txtQuantity.Text != "" && txtPriceUnit.Text != "")
               {
                    String cid = txtId.Text;
                    String cname = txtClothName.Text;
                    Int64 quantity = Convert.ToInt64(txtQuantity.Text);
                    Int64 perunit = Convert.ToInt64(txtPriceUnit.Text);

                    query = "Insert into cloth(cid,cname,quantity,perUnit) values('" + cid + "','" + cname + "','" + quantity + "','" + perunit + "')";
                    f1.setData(query, "Cloth added to database.");
                }
                else
                {
                    MessageBox.Show("Enter all data.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Please enter data properly.");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        public void clearAll()
        {
            txtId.Clear();
            txtClothName.Clear();
            txtQuantity.Clear();
            txtPriceUnit.Clear();
        }

    }
}
