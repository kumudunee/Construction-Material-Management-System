using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace construction_material_management_system.AllUserControls
{
    public partial class UC_Welcome : UserControl
    {
        public UC_Welcome()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        int num = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(num == 0)
            {
                label3.Location = new Point(105, 398);
                label3.ForeColor = Color.Orange;
                num++;
            }
            else if (num == 1)
            {
                label3.Location = new Point(105, 398);
                label3.ForeColor = Color.Green;
                num++;
            }
            else if (num == 2)
            {
                label3.Location = new Point(105, 398);
                label3.ForeColor = Color.RoyalBlue;
                num = 0;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

        }

        private void UC_Welcome_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
