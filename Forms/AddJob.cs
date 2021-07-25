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
    public partial class AddJob : Form
    {
        public static bool PhotoUploaded { get; set; }
        public string Path { get; set; } = "C:\\Users\\User\\Desktop\\Ally\\JahovaManagment\\static";
        Image file;
        List<Supplier> suppliers = new List<Supplier>();
         
        public AddJob()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(opnfd.FileName);
                PhotoUploaded = true;
                file = Image.FromFile(opnfd.FileName);

            }
        }

        private void AddNewJob_Click(object sender, EventArgs e)
        {
            var newJob = new Job();

            newJob.SupplierId = suppliers[cmbSupplier.SelectedIndex].SupplierId;
            newJob.JobDescription = txtJobDescription.Text;
            newJob.JobId = Guid.NewGuid().ToString();
            newJob.StartDate = dateTimePicker1.Value;
            newJob.EndDate = dateTimePicker2.Value;
            newJob.TotalQuantity = Convert.ToInt32(txtTotalQ.Text);
            newJob.IsActive = 1;

            var job = new JobDB();
            job.AddJob(newJob);
        }

        private void AddJob_Load(object sender, EventArgs e)
        {
            suppliers = new JobDB().GetAllSuppliers();

            //foreach ( var supllier in suppliers) {

            //    cmbSupplier.Items.Add($"SupplierName :{supllier.SupplierName} | SupplierId :{supllier.SupplierId}");

            //}
            cmbSupplier.DataSource = suppliers;
            cmbSupplier.DisplayMember = "SupplerName";
        }

        private void cmbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
