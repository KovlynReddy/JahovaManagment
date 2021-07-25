using JahovaDLL.BussinessLogic.BussinessAccess;
using JahovaDLL.DataAccess.EmployeeAccess;
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
        List<ATask> Tasks = new List<ATask>();


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
                newTask.StepNumber = 1 ;
            newTask.JobId = ((Job)cmbJobs.SelectedItem).JobId;// get from list and combo box
            newTask.TaskQuantityRequired = Convert.ToInt32(spnQuantity.Value);
            newTask.TaskDescription = redDescribe.Text;

            new EmployeeDB().AddTask(newTask);
            this.Close();
        }

        private void AddTask_Load(object sender, EventArgs e)
        {
            Jobs = new JobDB().GetAllJobs();
            Tasks = new EmployeeDB().GetAllTasks();

            cmbJobs.DataSource = Jobs;
            cmbJobs.DisplayMember = "JobDescription";
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
    }
}
