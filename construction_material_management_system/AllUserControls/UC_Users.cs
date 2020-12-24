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
    public partial class UC_Users : UserControl
    {
        function fn = new function();
        String query;
        public UC_Users()
        {
            InitializeComponent();
        }

        private void UC_Users_Load(object sender, EventArgs e)
        {
            getMaxID();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(txtName.Text != "" && txtMobile.Text != "" && txtGender.Text != "" && txtEmail.Text != "" && txtUsername.Text != "" && txtPassword.Text != "")
            {
                String name = txtName.Text;
                String mobile = txtMobile.Text;
                String gender = txtGender.Text;
                String email = txtEmail.Text;
                String username = txtUsername.Text;
                String pass = txtPassword.Text;

                query = "insert into employee (ename,mobile,gender,emailid,username,pass) values ('"+name+"',"+mobile+",'"+gender+"','"+email+"','"+username+"','"+pass+"')";
                fn.setData(query);

                clearAll();
                getMaxID();
            }
            else
            {
                MessageBox.Show("Fill all fields.", "Warning..!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //================================methods==========================
        public void getMaxID()
        {
            query = "select max(eid) from employee";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows[0][0].ToString() != "")
            {
                Int64 num = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                labelToSET.Text = (num + 1).ToString();

            }
        }
        public void clearAll()
        {
            txtName.Clear();
            txtMobile.Clear();
            txtGender.SelectedIndex = -1;
            txtEmail.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                if (MessageBox.Show("Are you sure?", "confirmation...!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    query = "delete from employee where eid = " + txtID.Text + "";
                    fn.setData(query);
                    tabControl1_SelectedIndexChanged(this, null);
                }
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex == 1)
            {
                query = "select * from employee";
                DataSet ds = fn.getData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                query = "select * from employee";
                DataSet ds = fn.getData(query);
                guna2DataGridView2.DataSource = ds.Tables[0];
            }
        }

        private void UC_Users_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
