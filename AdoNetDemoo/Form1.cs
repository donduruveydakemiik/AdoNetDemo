using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetDemoo
{
    public partial class Form1 : Form
    {
        ProductDal _productDal = new ProductDal();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            dgwProducts.DataSource = _productDal.GetAll(); //datasource nesne ister.
        }

        private void lblUnitPrice_Click(object sender, EventArgs e)
        {

        }

        private void lblStockAmount_Click(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            _productDal.Add
                (
                new Product
                {
                    Name = txtName.Text,
                    UnitPrice = Convert.ToDecimal(txtUnitPrice.Text),
                    StockAmount = Convert.ToInt32(txtStockAmount.Text)

                }
                );
            MessageBox.Show("Product Added.");
            txtName.Text = "";
            txtUnitPrice.Text = "";
            txtStockAmount.Text = "";
            dgwProducts.DataSource = _productDal.GetAll();

        }



        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtname2.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            txtUnitPrice2.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            txtStockAmount2.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            Product product = new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                Name = txtname2.Text,
                UnitPrice = Convert.ToDecimal(txtUnitPrice2.Text),
                StockAmount = Convert.ToInt32(txtStockAmount2.Text)
            };
            _productDal.Update(product);
            MessageBox.Show("Updated.");
            dgwProducts.DataSource = _productDal.GetAll();


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Product product = new Product { Id= Convert.ToInt32(dgwProducts.SelectedRows[0].Cells[0].Value) };
            _productDal.Delete(product);
            MessageBox.Show("Deleted.");
            txtname2.Text = "";
            txtUnitPrice2.Text = "";
            txtStockAmount2.Text = "";
            dgwProducts.DataSource = _productDal.GetAll();

        }

        private void dgwProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
   