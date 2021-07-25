using JahovaManagment.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JahovaManagment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddSupplier ASForm = new AddSupplier();
            ASForm.Location = label3.Location;
            ASForm.Show();
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddJob ASForm = new AddJob();
            ASForm.Location = label3.Location;
            ASForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddProduct ASForm = new AddProduct();
            ASForm.Location = label3.Location;
            ASForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddEmployee ASForm = new AddEmployee();
            ASForm.Location = label3.Location;
            ASForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddDepartment ASForm = new AddDepartment();
            ASForm.Location = label3.Location;
            ASForm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ViewSuppliers ASForm = new ViewSuppliers();
            ASForm.Location = label3.Location;
            ASForm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ViewJobs ASForm = new ViewJobs();
            ASForm.Location = label3.Location;
            ASForm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ViewProducts ASForm = new ViewProducts();
            ASForm.Location = label3.Location;
            ASForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewEmployees ASForm = new ViewEmployees();
            ASForm.Location = label3.Location;
            ASForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewEmployees ASForm = new ViewEmployees();
            ASForm.Location = label3.Location;
            ASForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            new TimeKeeper().Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            new StartShift().Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            new EndShift().Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            new Today().Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            new Today().Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            new EmployeeRegister().Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            new AddTask().Show();
        }
    }
}
