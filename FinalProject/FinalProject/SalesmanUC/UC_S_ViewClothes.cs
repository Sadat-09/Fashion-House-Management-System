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
    public partial class UC_S_ViewClothes : UserControl
    {
        function f1 = new function();
        String query;


        public UC_S_ViewClothes()
        {
            InitializeComponent();
        }




        private void setDataGridView(String query)
        {
            DataSet ds = f1.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];

        }

        String clothId;


        //fsgdgdhgdhdhffhrh

        private void UC_S_ViewClothes_Load(object sender, EventArgs e)
        {
            query = "select * from cloth";
            setDataGridView(query);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            query = "select * from cloth where cname like '" + txtSearch.Text + "%'";
            setDataGridView(query);
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                clothId = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }

            catch
            {

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure", "Delete Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    query = "delete from cloth where cid = '" + clothId + "'";
                    f1.setData(query, "Cloth record deleted.");
                    UC_S_ViewClothes_Load(this, null);
                }
            }
            catch
            {

            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_S_ViewClothes_Load(this, null);
        }
    }
}