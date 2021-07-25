using JahovaDLL.DataAccess.EmployeeAccess;
using JahovaDLL.JohavaEmployeeManagment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JahovaManagment.Forms
{
    public partial class AddEmployee : Form
    {
    public static bool PhotoUploaded { get; set; }
        public string Path { get; set; } = "C:\\Users\\User\\Desktop\\Ally\\JahovaManagment\\static\\";
        Image file;
        public AddEmployee()
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

        private void AddNewEmployee_Click(object sender, EventArgs e)
        {
            var newEmployee = new Employee();
            
            newEmployee.EmployeeName =txtEmployeeName.Text;
            newEmployee.EmployeeID = Guid.NewGuid().ToString();
            if (file != null)
            {
                Path += newEmployee.EmployeeName + newEmployee.EmployeeID;
                newEmployee.EmployeeImage = Path;
                pictureBox1.Image.Save(Path, ImageFormat.Jpeg);
            }

            new EmployeeDB().AddEmployee(newEmployee);
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
           // pictureBox1.Image = new Bitmap("C:\\Users\\User\\Desktop\\Ally\\JahovaManagment\\static\\Muffins1cfa4a8a-bd08-437c-a79a-93a81cca912b");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CameraImaging camera = new CameraImaging(txtEmployeeName.Text);
            //camera.StartVideo();
            //camera.StopVideo();
            Thread.Sleep(2000);
            camera.StopVideo();
            string filename = @"C:\Users\User\Desktop\Ally\JahovaManagment\static\" + txtEmployeeName.Text + ".png";
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
                txtEmployeeName.Text = camera.Text;
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
