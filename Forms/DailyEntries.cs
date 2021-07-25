using JahovaDLL.BussinessLogic.BussinessAccess;
using JahovaDLL.BussinessLogic.ReportAccess;
using JahovaDLL.DataAccess.EmployeeAccess;
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
    public partial class DailyEntries : Form
    {
        private readonly Employee employee;
        private readonly ATask task;

        public DailyEntries()
        {
            InitializeComponent();
        }
        public DailyEntries(ATask task) :this()
        {
            comboBox2.SelectedItem = task;
            this.task = task;
        }
        public DailyEntries(TodayEntry entry):this()
        {

        }

        public DailyEntries(Employee employee):this()
        {
            this.employee = employee;
        }
        public DailyEntries(Employee employee,ATask task):this()
        {
            this.employee = employee;
            this.task = task;
        }


        private void DailyEntries_Load(object sender, EventArgs e)
        {
            var suppliers = new JobDB().GetAllSuppliers();
            var jobs = new JobDB().GetAllJobs();

            var employees = new EmployeeDB().GetAllEmployees();
            var tasks = new EmployeeDB().GetAllTasks();

            comboBox1.DataSource = employees ;
            comboBox2.DataSource =  tasks;


            if (employee != null)
            {
                int index1 = employees.FindIndex(m => m.EmployeeID == employee.EmployeeID);
                comboBox1.SelectedIndex = index1;
            }
            if (task != null)
            {
                int index2 = tasks.FindIndex(m=>m.TaskId==task.TaskId);
                comboBox2.SelectedIndex = index2;
            }
       
            comboBox1.DisplayMember = "EmployeeName";
            comboBox2.DisplayMember = "TaskDescription";
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            DailyEntry newentry = new DailyEntry();
            newentry.TaskId = (comboBox2.SelectedItem as ATask).TaskId;
            newentry.EmployeeId = (comboBox1.SelectedItem as Employee).EmployeeID;
            newentry.DateTime = DateTime.Now;
            newentry.DEID = Guid.NewGuid().ToString(); 
            newentry.QuantityProduced = (int)numericUpDown2.Value;
            newentry.IsEndOfDay = 0;
            newentry.IsTaskComplete = 0;
            newentry.Note = richTextBox1.Text;
            newentry.OnTime =  1 ;
            newentry.Rating =  Convert.ToInt32(comboBox3.Text);

            new ReportsDB().AddDailyEntry(newentry);


            var tasks = new EmployeeDB().GetAllTasks();
            var theetasks = tasks.FirstOrDefault(m=>m.TaskId==newentry.TaskId);

            var jobs = new JobDB().GetAllJobs();
            var taskjob = jobs.FirstOrDefault(m => m.JobId == theetasks.JobId);
            
            var products = new JobDB().GetAllProducts();
            var taskproduct = products.FirstOrDefault(m=>m.JobId == taskjob.JobId);

            var producttasks = tasks.Where(m=>m.JobId==theetasks.JobId).ToList() ;
            var jobproducts = products.Where(m=>m.JobId == theetasks.JobId).ToList();


           // var productasks = tasks.Where(m=>m.JobId == taskproduct.JobId).ToList();
           // var today = new ReportsDB().GetAllTodayEntry();
           // today = today.Where(m => m.Date.Date == DateTime.Today && m.JobId == theetasks.JobId).ToList();


            // update task
            theetasks.TaskQuantityDone += newentry.QuantityProduced;
            if (theetasks.TaskQuantityDone == theetasks.TaskQuantityRequired)// and last step
            {
               //                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               taskproduct.IsActive = 0;
            }

            new EmployeeDB().UpdateTask(theetasks);

            if (false)// all products done job done 
            {
            //new JobDB().UpdateJob();
            //new JobDB().UpdateProduct();

            }

            // if all products done , job is done

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
