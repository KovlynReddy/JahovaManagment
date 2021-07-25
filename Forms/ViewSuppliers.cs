using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JahovaDLL;
using JahovaDLL.JahovaBussiness;

namespace JahovaManagment.Forms
{
    public partial class ViewSuppliers : Form
    {
        public List<Supplier> Suppliers { get; set; } = new List<Supplier>();
        public ViewSuppliers()
        {
            InitializeComponent();
        }

        private void ViewSuppliers_Load(object sender, EventArgs e)
        {
            JahovaDLL.BussinessLogic.BussinessAccess.JobDB SupplierDB = new JahovaDLL.BussinessLogic.BussinessAccess.JobDB();
            Suppliers = SupplierDB.GetAllSuppliers();

            dataGridView1.DataSource = Suppliers;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            var currentSupplier = dataGridView1.CurrentRow.DataBoundItem as Supplier;
            MessageBox.Show(currentSupplier.SupplerName, currentSupplier.SupplierId);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
