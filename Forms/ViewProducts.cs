using JahovaDLL.JahovaBussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JahovaManagment.Forms
{
    public partial class ViewProducts : Form
    {
        public List<Product> Products { get; set; } = new List<Product>();
        public ViewProducts()
        {
            InitializeComponent();
        }

        private void ViewProducts_Load(object sender, EventArgs e)
        {
            JahovaDLL.BussinessLogic.BussinessAccess.JobDB ProductDB = new JahovaDLL.BussinessLogic.BussinessAccess.JobDB();
            Products = ProductDB.GetAllProducts();

            dataGridView1.DataSource = Products;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var currentProduct = dataGridView1.CurrentRow.DataBoundItem as Product;
            MessageBox.Show(currentProduct.ProductId, currentProduct.ProductSize.ToString()+"   "+currentProduct.ProductQuantity.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
