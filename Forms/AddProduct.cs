using JahovaDLL.BussinessLogic.BussinessAccess;
using JahovaDLL.JahovaBussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JahovaManagment.Forms
{
    public partial class AddProduct : Form
    {
        public static bool PhotoUploaded { get; set; }
        public string Path { get; set; } = "C:\\Users\\User\\Desktop\\Ally\\JahovaManagment\\static";
        Image file;
        List<Job> jobs = new List<Job>();
        public AddProduct()
        {
            InitializeComponent();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            // get all jobs
            jobs = new JobDB().GetAllAciveJobs();
            // display jobs avaliable and isactive
            //foreach (var job in jobs)
            //{
            //    cmbJob.Items.Add($"job :{job.JodDescription} | JobId :{job.JobId} | SupplierId :{job.SupplierId}");
            //} 
            cmbJob.DataSource = jobs;
            cmbJob.DisplayMember = "JobDescription";
            // display headers in combo box
        }

        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(opnfd.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {   
            var newProduct = new Product();

            newProduct.JobId = jobs[cmbJob.SelectedIndex].JobId;
            newProduct.ProductDescription = txtDescription.Text;
            newProduct.ProductId = Guid.NewGuid().ToString();
           if (file != null)
            {
                newProduct.ProductImage = Path;
                pictureBox1.Image.Save(Path, ImageFormat.Jpeg);
            }
            newProduct.IsActive = 1;
            newProduct.ProductQuantity = Convert.ToInt32(txtTotalQ.Text);

            var job = new JobDB();
            job.AddProduct(newProduct);

            txtDescription.Text = "";
            txtSize.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
