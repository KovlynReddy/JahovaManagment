using JahovaDLL.JahovaBussiness;
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
    public partial class ViewJobs : Form
    {
        public List<Job> Jobs { get; set; } = new List<Job>();
        public ViewJobs()
        {
            InitializeComponent();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void ViewJobs_Load(object sender, EventArgs e)
        {
            JahovaDLL.BussinessLogic.BussinessAccess.JobDB JobsDB = new JahovaDLL.BussinessLogic.BussinessAccess.JobDB();
            Jobs = JobsDB.GetAllJobs();

            dataGridView1.DataSource = Jobs;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var currentJob = dataGridView1.CurrentRow.DataBoundItem as Job;
            MessageBox.Show(currentJob.JobId, currentJob.SupplierId);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
