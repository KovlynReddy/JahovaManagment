using JahovaDLL.BussinessLogic.BussinessAccess;
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
    public partial class AddSupplier : Form
    {
        public static bool PhotoUploaded { get; set; }
        public string Path { get; set; } = "C:\\Users\\User\\Desktop\\Ally\\JahovaManagment\\static";
        Image file;
        public AddSupplier()
        {
            InitializeComponent();
        }

        private void AddSupplier_Load(object sender, EventArgs e)
        {
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(opnfd.FileName);
                PhotoUploaded = true;
                file = pictureBox1.Image;

            }

        }

        private void txtSupplierName_TextChanged(object sender, EventArgs e)
        {
            //pictureBox1.Image = new Bitmap("C:\\Users\\User\\Desktop\\Ally\\JahovaManagment\\static\\Muffins1cfa4a8a-bd08-437c-a79a-93a81cca912b");

        }

        private void AddNewSupplier_Click(object sender, EventArgs e)
        {
       
            var newSupplier = new Supplier();

            newSupplier.SupplerName = txtSupplierName.Text;
            newSupplier.SupplierId = Guid.NewGuid().ToString();
            newSupplier.DateStartedBussines = DateTime.Now;


            var supplier = new JobDB();
            supplier.AddSupplier(newSupplier);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
