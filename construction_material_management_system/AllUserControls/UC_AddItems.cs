using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace construction_material_management_system.AllUserControls
{
    public partial class UC_AddItems : UserControl
    {
        function fn = new function();
        String query;
        public UC_AddItems()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            if(txtItemName.Text != "" && txtCategory.Text != "" && txtPrice.Text != "")
            {
                query = "insert into construction (name,category,price) values('" + txtItemName.Text + "','" + txtCategory.Text + "'," + txtPrice.Text + ")";
                fn.setData(query);
                clearAll();
            }
            else
            {
                MessageBox.Show("Fill all fields.", "Warning..!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        public void clearAll()
        {
            txtCategory.SelectedIndex = -1;
            txtItemName.Clear();
            txtPrice.Clear();
        }

        private void UC_AddItems_Load(object sender, EventArgs e)
        {
            
        }

        private void UC_AddItems_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
