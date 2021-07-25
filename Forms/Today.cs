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
    public partial class Today : Form
    {
        public Today()
        {
            InitializeComponent();
        }

        private void Today_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new EmployeeDB().GetAllTasks();

            var PresentEmployeesIds = new ReportsDB().GetTodaysDailyRegisters().Where(m => m.IsHere == 1);
            List<Employee> ListEmployeesPresent = new List<Employee>();
            foreach (var employee in PresentEmployeesIds)
            {
                ListEmployeesPresent.Add(new EmployeeDB().GetAEmployee(employee.EmployeeId));
            }

            var today = new ReportsDB().GetAllTodayEntry();
            today = today.Where(m => m.Date.Date == DateTime.Today).ToList();
            dataGridView3.DataSource = today;

            var dailyEntries = new ReportsDB().GetAllDailyEntries();
            dailyEntries = dailyEntries.Where(m => m.DateTime.Date == DateTime.Today).ToList();
            dataGridView4.DataSource = dailyEntries;



            dataGridView2.DataSource = ListEmployeesPresent;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Employee selectedemployee = dataGridView2.SelectedRows[0].DataBoundItem as Employee;
            ATask selectedtask = dataGridView1.SelectedRows[0].DataBoundItem as ATask;
            new DailyEntries(selectedemployee,selectedtask).Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee selectedemployee = dataGridView2.SelectedRows[0].DataBoundItem as Employee;
            ATask selectedTask = dataGridView1.SelectedRows[0].DataBoundItem as ATask;
            if (selectedTask == null)
            {

            var selectedToday = dataGridView3.SelectedRows[0].DataBoundItem as TodayEntry;
            }

            DailyEntry newentry = new DailyEntry();
            newentry.DEID = Guid.NewGuid().ToString();
            newentry.TaskId = selectedTask.TaskId;
            newentry.EmployeeId = selectedemployee.EmployeeID;
            newentry.IsEndOfDay = 0;
            newentry.IsTaskComplete = 0;
            newentry.DateTime = DateTime.Now;

            new ReportsDB().AddDailyEntry(newentry);

            var dailyEntries = new ReportsDB().GetAllDailyEntries();
            dailyEntries = dailyEntries.Where( m => m.DateTime.Date == DateTime.Today).ToList();
            dataGridView4.DataSource = dailyEntries;
            // add init entry to say this employee is binded to task
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ATask selectedemployee = dataGridView1.SelectedRows[0].DataBoundItem as ATask;
            new DailyEntries(selectedemployee).Show();
        }
    }
}
