using JahovaDLL.BussinessLogic.BussinessAccess;
using JahovaDLL.DataAccess.EmployeeAccess;
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
    public partial class TimeKeeper : Form
    {
        private float counter;

        public TimeKeeper()
        {
            InitializeComponent();
            counter = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Stop")
            {
                button1.Text = "Start";
                MessageBox.Show((counter/10).ToString(),counter.ToString());
                counter = 0 ;
                timer1.Enabled = false;
            }
            else
            {
                button1.Text = "Stop";
                timer1.Enabled = true;
               
            }
        }



        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (button1.Text != "Start")
            {
                counter++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void TimeKeeper_Load(object sender, EventArgs e)
        {
            var suppliers = new JobDB().GetAllSuppliers();
            var jobs = new JobDB().GetAllJobs();

            var employees = new EmployeeDB().GetAllEmployees();
            var tasks = new EmployeeDB().GetAllTasks();

            comboBox1.DataSource = employees;
            comboBox2.DataSource = tasks;


            comboBox1.DisplayMember = "EmployeeName";
            comboBox2.DisplayMember = "TaskDescription";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
