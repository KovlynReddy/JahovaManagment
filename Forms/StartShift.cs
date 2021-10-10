using JahovaDLL.BussinessLogic.BussinessAccess;
using JahovaDLL.BussinessLogic.ReportAccess;
using JahovaDLL.DataAccess.EmployeeAccess;
using JahovaDLL.JahovaBussiness;
using JahovaDLL.JohavaEmployeeManagment;
using JahovaDLL.Models.JohavaEmployeeManagment;
using JahovaDLL.Models.Reports;
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
    public partial class StartShift : Form
    {
        private List<Supplier> suppliers;
        private List<Job> jobs;
        private List<Product> products;
        private List<Employee> employees;
        private List<ATask> tasks;
        private List<TodayEntry> today;

        public StartShift()
        {
            InitializeComponent();
        }

        private void StartShift_Load(object sender, EventArgs e)
        {
             suppliers = new JobDB().GetAllSuppliers();
             jobs = new JobDB().GetAllJobs();
             products = new JobDB().GetAllProducts();

             employees = new EmployeeDB().GetAllEmployees();
             tasks = new EmployeeDB().GetAllTasks();

             today = new ReportsDB().GetAllTodayEntry();
            today = today.Where(m => m.Date.Date == DateTime.Today).ToList();
            dataGridView1.DataSource = today;

            comboBox1.DataSource = jobs;
            comboBox2.DataSource = products;
            comboBox3.DataSource = tasks;


            comboBox1.DisplayMember = "JobDescription";
            comboBox2.DisplayMember = "ProductDescription";
            comboBox3.DisplayMember = "TaskDescription";
        }

        private void Assign_Click(object sender, EventArgs e)
        {
            Job job = comboBox1.SelectedItem as Job;

            TodayEntry newentry = new TodayEntry();
            newentry.TodayId = Guid.NewGuid().ToString();
            newentry.JobId = job.JobId;
            newentry.Notes = "Test";
            newentry.Date = DateTime.Now;

            new ReportsDB().AddTodayEntry(newentry);

            var today = new ReportsDB().GetAllTodayEntry();
            today = today.Where(m => m.Date.Date == DateTime.Today).ToList();
            dataGridView1.DataSource = today;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = today;

            products = new JobDB().GetAllProducts();
            products = products.Where(m=>m.JobId==((Job)comboBox1.SelectedItem).JobId).ToList();

            comboBox1.DataSource = jobs;
            comboBox2.DataSource = products;
            comboBox3.DataSource = tasks;


            comboBox1.DisplayMember = "JobDescription";
            comboBox2.DisplayMember = "ProductDescription";
            comboBox3.DisplayMember = "TaskDescription";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            tasks = new EmployeeDB().GetAllTasks();
            tasks = tasks.Where(m => m.JobId == ((Job)comboBox1.SelectedItem).JobId).ToList();

            comboBox1.DataSource = jobs;
            comboBox2.DataSource = products;
            comboBox3.DataSource = tasks;


            comboBox1.DisplayMember = "JobDescription";
            comboBox2.DisplayMember = "ProductDescription";
            comboBox3.DisplayMember = "TaskDescription";
        }
    }
}
