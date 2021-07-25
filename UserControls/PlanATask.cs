using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;  
using System.Windows.Forms;
using JahovaDLL.Models.JohavaEmployeeManagment;
using JahovaDLL.BussinessLogic.BussinessAccess;
using JahovaDLL.DataAccess.EmployeeAccess;

namespace JahovaManagment.UserControls
{
    public partial class PlanATask : UserControl
    {
        List<ATask> tasks = new List<ATask>();
        public PlanATask()
        {
            InitializeComponent();
        }

        private void Confirm_CheckedChanged(object sender, EventArgs e)
        {      

            

        }

        public void OnShiftStarting(object source , EventArgs args) {
        
            // code on button click
        }

        private void PlanATask_Load(object sender, EventArgs e)
        {
            tasks = new EmployeeDB().GetAllTasks();
            cmbTask.DataSource = tasks;
            
        }
    }
    }

