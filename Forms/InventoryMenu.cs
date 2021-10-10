using JahovaDLL.BussinessLogic.InventoryAccess;
using JahovaDLL.JahaovaInventoryManagment;
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

            new InventoryDB().AddMaterial(newmaterial);
        }
    }
}
