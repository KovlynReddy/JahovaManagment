using JahovaDLL.BussinessLogic.BussinessAccess;
using JahovaDLL.BussinessLogic.ReportAccess;
using JahovaDLL.DataAccess.EmployeeAccess;
using JahovaDLL.JahovaBussiness;
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
    public partial class WaitingForKeys : Form
    {
        public DailyEntry Entry { get; set; }
        public int[] TaskTotals = new int[5];
        public bool[] TaskEnables = new bool[5];

        public List<ATask> AllTasks { get; set; }
        public List<TodayEntry> AllJobs { get; set; }
        public WaitingForKeys()
        {
            InitializeComponent();
        }

        private void WaitingForKeys_Load(object sender, EventArgs e)
        {
              var allTasks = new EmployeeDB().GetAllTasks();

            var today = new ReportsDB().GetAllTodayEntry();
            today = today.Where(m => m.Date.Date == DateTime.Today).ToList();

            AllJobs = today;


            var selectedTasks = new List<ATask>();
            foreach (var todayjob in today)
            {
                selectedTasks.AddRange(allTasks.Where(m => m.JobId == todayjob.JobId).ToList());

            }


            AllTasks = selectedTasks;

            if (selectedTasks[0] != null)
            {
                var buttonp = new Label { Text = $"P = {selectedTasks[0].TaskDescription}" };
                buttonp.Location.Offset(4,4);
                panel1.Controls.Add(buttonp);
                TaskEnables[0] = true;
            }
            if (selectedTasks[1] != null)
            {
                var buttonl = new Label { Text = $"L = {selectedTasks[0].TaskDescription}" };
                buttonl.Location.Offset(8, 8);
                panel1.Controls.Add(buttonl);
                TaskEnables[1] = true;
            }
            if (selectedTasks[2] != null)
            {
                var buttonm = new Label { Text = $"M = {selectedTasks[0].TaskDescription}" };
                buttonm.Location.Offset(12, 12);
                panel1.Controls.Add(buttonm); TaskEnables[2] = true;
                TaskEnables[2] = true;
            }
            if (selectedTasks[3] != null)
            {
                var buttonj = new Label { Text = $"J = {selectedTasks[0].TaskDescription}" };
                buttonj.Location.Offset(16, 16);
                panel1.Controls.Add(buttonj); TaskEnables[3] = true;
            }
        }

        private void WaitingForKeys_KeyPress(object sender, KeyPressEventArgs e)
        {
            var choice = e.KeyChar;


            switch (choice){
                case 'p':
                    if (TaskEnables[0])
                    {
                        TaskTotals[0]++;
                    //MessageBox.Show("Rivvet Done", TaskTotals[0].ToString());
                        label1.Text = TaskTotals[0].ToString();
                    }
                    break;

                case 'l':
                    if (TaskEnables[1])
                    {
                        TaskTotals[1]++;
                    //MessageBox.Show("Buckle Done", TaskTotals[1].ToString());
                        label2.Text = TaskTotals[1].ToString();
                    }
                    break;

                case 'm':
                    if (TaskEnables[2])
                    {
                        TaskTotals[2]++;
                      //  MessageBox.Show("Hammer Done", TaskTotals[2].ToString());
                        label3.Text = TaskTotals[2].ToString();
                    }
                    break;

                case 'j':
                    if (TaskEnables[3])
                    {
                        TaskTotals[3]++;
                        //  MessageBox.Show("Hammer Done", TaskTotals[2].ToString());
                        label4.Text = TaskTotals[3].ToString();
                    }
                    break;

                default:
                    MessageBox.Show("Key Pressed", choice.ToString());
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
        }

        private void WaitingForKeys_FormClosing(object sender, FormClosingEventArgs e)
        {

            for (int i = 0; i < 4 ; i++)
            {
                if (AllTasks[i] == null)
                {
                    continue;
                }
                var task = AllTasks[i];
               var selectedTask = task; // get selected Task
                DailyEntry newentry = new DailyEntry();
                newentry.EmployeeId = "KeyboardPressTest";// get id
                newentry.QuantityProduced = TaskTotals[i];//get task total
                newentry.TaskId = selectedTask.TaskId;
                newentry.DateTime = DateTime.Now;
                newentry.DEID = Guid.NewGuid().ToString();
                newentry.Note = "KeyBoardEntry";

                new ReportsDB().AddDailyEntry(newentry);


                var tasks = new EmployeeDB().GetAllTasks();
                var theetasks = tasks.FirstOrDefault(m => m.TaskId == newentry.TaskId);

                var jobs = new JobDB().GetAllJobs();
                var taskjob = jobs.FirstOrDefault(m => m.JobId == theetasks.JobId);

                var products = new JobDB().GetAllProducts();
                var taskproduct = products.FirstOrDefault(m => m.JobId == taskjob.JobId);

                var producttasks = tasks.Where(m => m.JobId == theetasks.JobId).ToList();
                var jobproducts = products.Where(m => m.JobId == theetasks.JobId).ToList();

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

                selectedTask = new EmployeeDB().GetAllTasks().FirstOrDefault(m => m.TaskId == selectedTask.TaskId);
                // if all products done , job is done
                var SelectedTaskJob = jobs.FirstOrDefault(m => m.JobId == selectedTask.JobId);
                var SelectedJobTasks = tasks.Where(m => m.JobId == SelectedTaskJob.JobId).ToList();
                var lasttask = SelectedJobTasks.Last();

                if (lasttask.TaskId == selectedTask.TaskId)
                {
                    var today = new ReportsDB().GetAllTodayEntry();
                    today = today.Where(m => m.Date.Date == DateTime.Today).ToList();

                    var todayproduct = today.FirstOrDefault(m => m.JobId == SelectedTaskJob.JobId);
                    todayproduct.IsComplete = selectedTask.TaskQuantityDone;

                    SelectedTaskJob.CurrentQuantity = todayproduct.IsComplete;


                    new ReportsDB().UpdateTodayEntry(todayproduct);
                    new JobDB().UpdateJob(SelectedTaskJob);
                    //new JobDB().UpdateProduct(selectedTask);
                    // update today
                }

            }

        }
    }
}
