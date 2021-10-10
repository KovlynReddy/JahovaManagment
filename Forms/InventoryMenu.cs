using JahovaDLL.BussinessLogic.InventoryAccess;
using JahovaDLL.BussinessLogic.ReportAccess;
using JahovaDLL.JahaovaInventoryManagment;
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
    public partial class InventoryMenu : Form
    {
        public InventoryMenu()
        {
            InitializeComponent();
        }

        private void InventoryMenu_Load(object sender, EventArgs e)
        {
            // get all materials 
            var materials = new InventoryDB().GetMaterial(string.Empty);
            // get all inventory
            
            dataGridView1.DataSource = materials;
            // get all used
            // get all transactions 

            var entries = new ReportsDB().GetAllDailyEntries().Where(m => m.MaterialId!= null);
            var materialids = entries.Select(m => m.MaterialId).Distinct().ToList();

            foreach (var id in materialids)
            {
                int total = 0;
                var selectedMaterial = materials.FirstOrDefault(m=>m.MaterialId==id);

                foreach (var entry in entries)
                {
                    if (entry.MaterialId == selectedMaterial.MaterialId)
                    {
                        total -= entry.MaterialAmount;
                    }
                }
                selectedMaterial.Quantity = total;
                new InventoryDB().UpdateMaterial(selectedMaterial);

            }

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Material newmaterial = new Material();
            newmaterial.MaterialId = Guid.NewGuid().ToString();
            newmaterial.Name = textBox1.Text;
            newmaterial.Description = textBox1.Text;
            newmaterial.Quantity = (int)numericUpDown1.Value;

            var addmaterial = new DailyEntry();
            addmaterial.MaterialId = newmaterial.MaterialId;
            addmaterial.MaterialAmount = newmaterial.Quantity;
            addmaterial.Note = "AddingMaterial";

            new ReportsDB().AddDailyEntry(addmaterial);

            new InventoryDB().AddMaterial(newmaterial);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var newmaterial = (dataGridView1.SelectedRows[0].DataBoundItem as Material);
            var addmaterial = new DailyEntry();
            addmaterial.MaterialId = newmaterial.MaterialId;
            addmaterial.MaterialAmount = newmaterial.Quantity;
            addmaterial.Note = "AddingMaterial";
            addmaterial.DateTime = DateTime.Now;
            addmaterial.DEID = Guid.NewGuid().ToString();

            new ReportsDB().AddDailyEntry(addmaterial);

        }
    }
}
