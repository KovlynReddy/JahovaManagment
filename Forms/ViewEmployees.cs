using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JahovaDLL.BussinessLogic;
using JahovaDLL.DataAccess.EmployeeAccess;
using JahovaDLL.JohavaEmployeeManagment;

namespace JahovaManagment.Forms
{
    public partial class ViewEmployees : Form
    {
        public List<Employee> Employees { get; set; } = new List<Employee>();
        public ViewEmployees()
        {
            InitializeComponent();
        }

        private void ViewEmployees_Load(object sender, EventArgs e)
        {
            Employees = new EmployeeDB().GetAllEmployees();
            dataGridView1.DataSource = Employees;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var currentEmployee = dataGridView1.CurrentRow.DataBoundItem as Employee;
            MessageBox.Show(currentEmployee.EmployeeID, currentEmployee.EmployeeName);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
