using JahovaDLL.BussinessLogic.BussinessAccess;
using JahovaDLL.BussinessLogic.ReportAccess;
using JahovaDLL.DataAccess.EmployeeAccess;
using JahovaDLL.Models.JohavaEmployeeManagment;
using LiveCharts;
using LiveCharts.Wpf;
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
    public partial class EndShift : Form
    {
        public EndShift()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //cartesianChart1.Series.Clear();
            //SeriesCollection series = new SeriesCollection();
            //var years = (from o in revenueBindingSource.DataSource as List<Revenue>
            //             select new { Year = o.Year }).Distinct();
            //foreach (var year in years)
            //{
            //    List<double> values = new List<double>();
            //    for (int month = 1; month <= 12; month++)
            //    {
            //        double value = 0;
            //        var data = from o in revenueBindingSource.DataSource as List<Revenue>
            //                   where o.Year.Equals(year.Year) && o.Month.Equals(month)
            //                   orderby o.Month ascending
            //                   select new { o.Value, o.Month };
            //        if (data.SingleOrDefault() != null)
            //            value = data.SingleOrDefault().Value;
            //        values.Add(value);
            //    }
            //    series.Add(new LineSeries() { Title = year.Year.ToString(), Values = new ChartValues<double>(values) });
            //}
            //cartesianChart1.Series = series;
        }

        private void EndShift_Load(object sender, EventArgs e)
        {
            var dailyentries = new ReportsDB().GetAllDailyEntries();
            var jobs = new JobDB().GetAllJobs();
            var products = new JobDB().GetAllProducts();
            var tasks = new EmployeeDB().GetAllTasks();
            var employees = new EmployeeDB().GetAllEmployees();

            comboBox2.DataSource = tasks;
            comboBox2.DisplayMember = "TaskDescription";

            //var jobgraph = jobs.Select(m => new { Name = m.JobDescription, Required = m.TotalQuantity, current = m.CurrentQuantity, date = m.StartDate });

            #region Chart1
            cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Task"
            });
            cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Quantity"
            });
            cartesianChart1.LegendLocation = LiveCharts.LegendLocation.Right;

            cartesianChart1.Series.Clear();
            SeriesCollection series = new SeriesCollection();
            List<int> values = new List<int>();
            foreach (var task in tasks)
            {
                values.Add(task.TaskQuantityDone);
                series.Add(new LineSeries() { Title = task.TaskDescription, Values = new ChartValues<int>(values) });

            }

            cartesianChart1.Series = series;
            #endregion

            #region Chart2
            cartesianChart2.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Product"
            });
            cartesianChart2.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Quantity"
            });
            cartesianChart2.LegendLocation = LiveCharts.LegendLocation.Right;

            cartesianChart2.Series.Clear();
            SeriesCollection series0 = new SeriesCollection();
            List<int> values0 = new List<int>();
            foreach (var product in products)
            {
                values0.Add(product.ProductQuantity);
                series0.Add(new LineSeries() { Title = product.ProductDescription, Values = new ChartValues<int>(values0) });

            }

            cartesianChart2.Series = series0;
            #endregion

            #region Chart3
            cartesianChart3.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Date"
            });
            cartesianChart3.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Quantity"
            });
            cartesianChart3.LegendLocation = LiveCharts.LegendLocation.Right;

            cartesianChart3.Series.Clear();
            SeriesCollection series3 = new SeriesCollection();
            List<int> values3 = new List<int>();
            foreach (var task in tasks)
            {
                values3.Add(task.TaskQuantityDone);
                series3.Add(new LineSeries() { Title = task.TaskDescription, Values = new ChartValues<int>(values3) });

            }

            cartesianChart3.Series = series3;
            #endregion

            #region Chart4
            cartesianChart4.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Date"
            });
            cartesianChart4.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Quantity"
            });
            #endregion

            #region BarChart1

            chart1.Series.Clear();
            var series1 = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Tasks",
                Color = System.Drawing.Color.Green
            };

            chart1.Series.Add(series1);

            foreach (var task in tasks)
            {
                series1.Points.AddXY(task.TaskDescription, (task.TaskQuantityDone));
            }
            chart1.Invalidate();
            #endregion

            #region BarChart2

            chart2.Series.Clear();
            var series2 = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Dates",
                Color = System.Drawing.Color.Green
            };

            chart2.Series.Add(series2);

            foreach (var task in dailyentries)
            {
                series2.Points.AddXY(task.DateTime, (task.QuantityProduced));
            }
            chart2.Invalidate();
            #endregion


            #region BarChart3

            chart4.Series.Clear();
            var series6 = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Products",
                Color = System.Drawing.Color.Green
            };

            chart4.Series.Add(series6);

            foreach (var task in products)
            {
                series6.Points.AddXY(task.ProductDescription, (task.ProductCompleted));
            }
            //chart4.Invalidate();
            #endregion

            #region BarChart4

            chart3.Series.Clear();
            var series7 = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Jobs",
                Color = System.Drawing.Color.Green
            };

            chart3.Series.Add(series7);

            foreach (var task in jobs)
            {
                series7.Points.AddXY(task.JobDescription, (task.CurrentQuantity));
            }
            chart3.Invalidate();
            #endregion

        }

        private void chart1_Click(object sender, EventArgs e)
        {
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pieChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {
         
        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // jobs

            var tasks = new EmployeeDB().GetAllTasks();
            var dailyentries = new ReportsDB().GetAllDailyEntries();
            var jobs = new JobDB().GetAllJobs();

            tasks = tasks.Where(m=>m.TaskId == ((ATask)(comboBox2.SelectedItem)).TaskId).ToList();
            dailyentries = dailyentries.Where(m =>m.TaskId == tasks.FirstOrDefault().TaskId).ToList();
            chart2.Series.Clear();
            var series2 = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Dates",
                Color = System.Drawing.Color.Green
            };

            chart2.Series.Add(series2);

            foreach (var task in dailyentries)
            {
                series2.Points.AddXY(task.DateTime, (task.QuantityProduced));
            }
            chart2.Invalidate();


            #region Chart3

            cartesianChart4.LegendLocation = LiveCharts.LegendLocation.Right;

            cartesianChart4.Series.Clear();
            SeriesCollection series3 = new SeriesCollection();
            List<int> values3 = new List<int>();
            foreach (var task in dailyentries)
            {
                values3.Add(task.QuantityProduced);
                series3.Add(new LineSeries() { Title = task.DateTime.ToString(), Values = new ChartValues<int>(values3) });

            }

            cartesianChart4.Series = series3;
            #endregion



        }
    }

    public class TaskEmployeeChartModel {
        public int Quantity { get; set; }
        public string Employee { get; set; }
    }  
    public class TaskChartModel {
        public int Quantity { get; set; }
        public string Date { get; set; }
    }  
    public class JobChartModel {
        public int Quantity { get; set; }
        public string Product { get; set; }
    }  
    public class ProductChartModel {
        public int Quantity { get; set; }
        public string Task { get; set; }
    }
}
