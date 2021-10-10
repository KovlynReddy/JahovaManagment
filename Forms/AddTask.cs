using JahovaDLL.BussinessLogic.BussinessAccess;
using JahovaDLL.BussinessLogic.InventoryAccess;
using JahovaDLL.DataAccess.EmployeeAccess;
using JahovaDLL.JahaovaInventoryManagment;
using JahovaDLL.JahovaBussiness;
using JahovaDLL.Models.JohavaEmployeeManagment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JahovaManagment.Forms
{
    public partial class AddTask : Form
    {
        List<Job> Jobs = new List<Job>();

        public List<Product> Products { get; private set; }

        List<ATask> Tasks = new List<ATask>();

        public List<Material> Materials { get; private set; }

        private List<Material> MaterialsExtra;

        public AddTask()
        {
            InitializeComponent();
        }

        private void AddATask_Click(object sender, EventArgs e)
        {
            var newTask = new ATask();
            newTask.TaskId = Guid.NewGuid().ToString();
            if (IsntFirstStep.Checked) {
                newTask.StepNumber = Convert.ToInt32(StepNumber.Value);
            newTask.PreviousStep =  ((ATask)cmbTasks.SelectedItem).TaskId;// get from list and combo box
            }
            newTask.MaterialId = ((Material)cmbMaterial.SelectedItem).MaterialId;
            newTask.MaterialAmount = (int)spnMaterials.Value;
            newTask.MaterialIdExtra = ((Material)cmbMaterialsExtra.SelectedItem).MaterialId;
            newTask.MaterialAmountExtra = (int)spnMaterialsExtra.Value;
            newTask.StepNumber = (int)StepNumber.Value ;
            newTask.JobId = ((Job)cmbJobs.SelectedItem).JobId;// get from list and combo box
            newTask.TaskQuantityRequired = Convert.ToInt32(spnQuantity.Value);
            newTask.TaskDescription = redDescribe.Text;

            new EmployeeDB().AddTask(newTask);
            this.Close();
        }

        private void AddTask_Load(object sender, EventArgs e)
        {
            Jobs = new JobDB().GetAllJobs();
            Products = new JobDB().GetAllProducts();
            Tasks = new EmployeeDB().GetAllTasks();
            Materials = new InventoryDB().GetAllMaterials();
            MaterialsExtra = new InventoryDB().GetAllMaterials();

            cmbMaterial.DataSource = Materials;
            cmbMaterial.DisplayMember = "Name";
            cmbMaterialsExtra.DataSource = MaterialsExtra;
            cmbMaterialsExtra.DisplayMember = "Name";
            cmbJobs.DataSource = Jobs;
            cmbJobs.DisplayMember = "JobDescription";
            cmbProducts.DataSource = Products;
            cmbProducts.DisplayMember = "ProductDiscrption";
            cmbTasks.DataSource =Tasks;
            cmbTasks.DisplayMember = "TaskDescription";
        }

        private void AddPicture_Click(object sender, EventArgs e)
        {
            CameraImaging camera = new CameraImaging(cmbTasks.Text);
            //camera.StartVideo();
            //camera.StopVideo();
            Thread.Sleep(2000);
            camera.StopVideo();
            string filename = @"C:\Users\User\Desktop\Ally\JahovaManagment\static\" + cmbTasks.Text + ".png";
            if (camera.Text != null)
            {

                pictureBox1.Image = camera.bitmap;
                pictureBox1.Image = (Bitmap)Image.FromFile(filename);

                var image = pictureBox1.Image;
                var rgbarray = ImageToByteArray(image);

                //LuminanceSource source = new RGBLuminanceSource(rgbarray, image.Width, image.Height RGBLuminance.Format(RGB32));
                //BinaryBitmap bitmap = new BinaryBitmap(new HybridBinarizer(source));

                //BarcodeReader Reader = new BarcodeReader();
                //Result result = Reader.Decode(source);

                cmbTasks.Text = camera.Text;
            }
            pictureBox1.Image = (Bitmap)Image.FromFile(filename);
        }

        public static byte[] ImageToByteArray(Image img)
        {
            using (var stream = new MemoryStream())
            {
                img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return stream.ToArray();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbJobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            Products = new JobDB().GetAllProducts().Where(m => m.JobId == ((Job)cmbJobs.SelectedItem).JobId).ToList();

            
            cmbProducts.DataSource = Products;
            cmbProducts.DisplayMember = "ProductDescription";
           
        }

        private void cmbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tasks = new EmployeeDB().GetAllTasks().Where(m => m.JobId == ((Job)cmbJobs.SelectedItem).JobId).ToList();

            
            cmbTasks.DataSource = Tasks;
            cmbTasks.DisplayMember = "TaskDescription";
        }
    }
}
