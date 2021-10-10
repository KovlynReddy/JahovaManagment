using JahovaDLL.BussinessLogic.BussinessAccess;
using JahovaDLL.BussinessLogic.ReportAccess;
using JahovaDLL.DataAccess.EmployeeAccess;
using JahovaDLL.JohavaEmployeeManagment;
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
    public partial class EmployeeRegister : Form
    {
        public EmployeeRegister()
        {
            InitializeComponent();
        }

        private void EmployeeRegister_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new EmployeeDB().GetAllEmployees();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e) 
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            Employee selectedemployee = dataGridView1.SelectedRows[0].DataBoundItem as Employee;
            textBox1.Text = selectedemployee.EmployeeID;
            textBox2.Text = selectedemployee.EmployeeName;
            if (selectedemployee.EmployeeImage != null)
            {
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newregister = new DailyRegister();
            newregister.Date = DateTime.Today.Date;
            newregister.DRID = Guid.NewGuid().ToString();
            newregister.EmployeeId = textBox1.Text;
            newregister.IsHere = radioButton1.Checked ? 1 : 0 ;
            new ReportsDB().AddDailyRegister(newregister);

            dataGridView2.DataSource = new ReportsDB().GetTodaysDailyRegisters();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newEmployee = new Employee();

            newEmployee.EmployeeName = textBox2.Text;
            newEmployee.EmployeeID = Guid.NewGuid().ToString();


            new EmployeeDB().AddEmployee(newEmployee);
        }
    }
}
