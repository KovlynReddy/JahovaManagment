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
    public partial class UpdateEmployee : Form
    {
        private readonly Employee employee;

        public UpdateEmployee(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
        }

        private void UpdateEmployee_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new ReportsDB().GetAllEmployeeDailyEntries(employee.EmployeeID);

            var employees = new EmployeeDB().GetAllEmployees();
            var tasks = new EmployeeDB().GetAllTasks();

           // comboBox1.DataSource = employees;
            cmbTasks.DataSource = tasks;


            //comboBox1.DisplayMember = "EmployeeName";
            cmbTasks.DisplayMember = "TaskDescription";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DailyEntry newEntry = new DailyEntry();
            newEntry.EmployeeId = employee.EmployeeID;
            newEntry.DateTime = DateTime.Now;
            newEntry.DEID = Guid.NewGuid().ToString();
            newEntry.TaskId= ((ATask)cmbTasks.SelectedItem).TaskId;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
