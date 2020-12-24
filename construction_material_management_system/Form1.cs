using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace construction_material_management_system
{
    public partial class Form1 : Form
    {
        function fn = new function();
        String query;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dashboard dash = new Dashboard("Guest");
            dash.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            query = "select username,pass from employee where username ='"+txtUsername.Text+"' and pass='"+txtPassword.Text+"'";
            DataSet ds = fn.getData(query);

            if(ds.Tables[0].Rows.Count != 0)
            {
                Dashboard dash = new Dashboard("Admin");
                dash.Show();
                this.Hide();

            }
            else
            {
                txtPassword.Clear();
            }
        }
    }
}
