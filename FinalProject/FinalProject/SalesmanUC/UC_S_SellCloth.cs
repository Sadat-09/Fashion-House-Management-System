using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.SalesmanUC
{
    public partial class UC_S_SellCloth : UserControl
    {
        function f1 = new function();
        String query;
        DataSet ds;
        public UC_S_SellCloth()
        {
            InitializeComponent();
        }


        //sbhfsgfyufgufgafsa

        private void UC_S_SellCloth_Load(object sender, EventArgs e)
        {
            listBoxClothes.Items.Clear();
            query = "select cname from cloth where quantity > '0' ";
            ds = f1.getData(query);

            int i = 0;
            while (i < ds.Tables[0].Rows.Count)
            {
                listBoxClothes.Items.Add(ds.Tables[0].Rows[i][0].ToString());
                i++;
            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_S_SellCloth_Load(this, null);
            clearAll();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            listBoxClothes.Items.Clear();
            query = "select cname from cloth where cname like '" + txtSearch.Text + "%' and quantity >'0'";
            ds = f1.getData(query);

            int i = 0;
            while (i < ds.Tables[0].Rows.Count)
            {
                listBoxClothes.Items.Add(ds.Tables[0].Rows[i][0].ToString());
                i++;
            }
        }

        private void listBoxClothes_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNoOfUnit.Clear();
            String name = listBoxClothes.GetItemText(listBoxClothes.SelectedItem);
            txtClothName.Text = name;
            query = "select cid,perUnit from cloth where cname = '" + name + "'";
            ds = f1.getData(query);
            txtClothId.Text = ds.Tables[0].Rows[0][0].ToString();
            txtPriceUnit.Text = ds.Tables[0].Rows[0][1].ToString();
        }

        private void txtNoOfUnit_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtNoOfUnit.Text != "")
                {
                    Int64 unitPrice = Int64.Parse(txtPriceUnit.Text);
                    Int64 noofunit = Int64.Parse(txtNoOfUnit.Text);
                    Int64 totalAmount = unitPrice * noofunit;
                    txtTotalPrice.Text = totalAmount.ToString();

                }
                else
                {
                    txtTotalPrice.Clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error has occurred.\nPlease select from list first and try again. ");
            }
        }
        private void clearAll()
        {
            txtClothId.Clear();
            txtClothName.Clear();
            txtPriceUnit.Clear();
            txtNoOfUnit.Clear();

        }

        protected int n, totalAmount = 0;
        protected Int64 quantity, newQuantity;

        int vAmount;
        String vId;
        protected Int64 noUnit;

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (vId != null)
            {
                try
                {
                    guna2DataGridView1.Rows.RemoveAt(this.guna2DataGridView1.SelectedRows[0].Index);
                }
                catch
                {

                }
                finally
                {
                    query = "select quantity from cloth where cid = '" + vId + "'";
                    ds = f1.getData(query);
                    quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                    newQuantity = quantity + noUnit;

                    query = "update cloth set quantity = '" + newQuantity + "' where cid ='" + vId + "'";
                    f1.setData(query, "Cloth removed from the cart.");
                    totalAmount = totalAmount - vAmount;
                    totalLabel.Text = "Tk. " + totalAmount.ToString();


                }
                UC_S_SellCloth_Load(this, null);
            }
        }

        private void btnPurchasePrint_Click(object sender, EventArgs e)
        {
            DGVPrinter print = new DGVPrinter();
            print.Title = "Cloth Invoice";
            print.SubTitle = String.Format("Date: {0}", DateTime.Now.Date);
            print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            print.PageNumbers = true;
            print.PageNumberInHeader = false;
            print.PorportionalColumns = true;
            print.HeaderCellAlignment = StringAlignment.Near;
            print.Footer = "Total Payable Amount :" + totalLabel.Text;
            print.FooterSpacing = 15;
            print.PrintDataGridView(guna2DataGridView1);

            totalAmount = 0;
            totalLabel.Text = "Tk. 00";
            guna2DataGridView1.DataSource = 0;
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                vAmount = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
                vId = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                noUnit = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch (Exception)
            {

            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (txtClothId.Text != "")
            {
                query = "select quantity from cloth where cid = '" + txtClothId.Text + "'";
                ds = f1.getData(query);

                quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                newQuantity = quantity - Int64.Parse(txtNoOfUnit.Text);

                if (newQuantity >= 0)
                {
                    n = guna2DataGridView1.Rows.Add();
                    guna2DataGridView1.Rows[n].Cells[0].Value = txtClothId.Text;
                    guna2DataGridView1.Rows[n].Cells[1].Value = txtClothName.Text;
                    guna2DataGridView1.Rows[n].Cells[2].Value = txtPriceUnit.Text;
                    guna2DataGridView1.Rows[n].Cells[3].Value = txtNoOfUnit.Text;
                    guna2DataGridView1.Rows[n].Cells[4].Value = txtTotalPrice.Text;

                    totalAmount = totalAmount + int.Parse(txtTotalPrice.Text);
                    totalLabel.Text = "Tk." + totalAmount.ToString();

                    query = "update cloth set quantity = '" + newQuantity + "' where cid = '" + txtClothId.Text + "'";
                    f1.setData(query, "Cloth Added.");


                }
                else
                {
                    MessageBox.Show("Out of stock.\n Only" + quantity + "Left", "WARNING!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                clearAll();
                UC_S_SellCloth_Load(this, null);
            }
            else
            {
                MessageBox.Show("Select cloth first.", "Information!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

}