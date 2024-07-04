using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_management_system
{
    public partial class salary : Form
    {
        public salary()
        {
            InitializeComponent();
        }
        readonly SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-LHO60ST\SQLEXPRESS;Initial Catalog=emp_management;Integrated Security=True");

        private void fetchemp()
        {
            try
            {
                if (txtid.Text == "")
                {
                    MessageBox.Show("Enter Employee Id");

                }
                else
                {
                    con.Open();
                    string query = "select * from tbl_empdetail where emp_id='" + txtid.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    DataTable dt = new DataTable();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                  
                    sda.Fill(dt);
                    if (dt.Rows.Count==1)
                    {
                        txtname.Text = dt.Rows[0][1].ToString();
                        txtps.Text = dt.Rows[0][5].ToString();
                    }
                    con.Close();
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            { 
                con.Close();
            }
        }

            private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dashboard db = new dashboard();
            db.Show();
            this.Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int dailybase;
        int total;
        private void view_Click(object sender, EventArgs e)
        {
            if(txtps.Text=="")
            {
                MessageBox.Show("Select An Employee");
            }
            else if (txtwd.Text == " " || Convert.ToInt32(txtwd.Text) > 31)
            {
                MessageBox.Show("Enter A valid numerber of days");
            }
            else
            {
                if (txtps.Text == " Project Manager") 
                { 
                    dailybase = 3000;
                }
                else if (txtps.Text == " Project Head;Data Analyst;Cloud Engineer;DevOps Engineer")
                {
                    dailybase = 2500;
                }
                else if (txtps.Text == " senior Developer;Quality Assurance Tester;IT security specialist")
                {
                    dailybase = 2000;
                }
                else if (txtps.Text == " Junior Developer;IT coordinator;HR Coordinator,software Tester")
                {
                    dailybase = 1500;
                }
                else if  (txtps.Text == " Technical support;Network administrator;Database Administrator")
                {
                    dailybase = 1000;
                }
                else if  (txtps.Text == " Systems Analyst")
                {
                    dailybase = 800;
                }
                else 
                {
                    dailybase = 500;
                }
                total = dailybase * Convert.ToInt32(txtwd.Text);
                richTextBox1.Text = "Employee ID :"+ txtid + "\n"+ "Employee Name :"+ txtname +"\n" + "Employee Position :"+ txtps + "\n"+ "Daily salary :"+ dailybase +"\n" + "Total Amount :" +total ;
            }
        }

        private void fetch_Click(object sender, EventArgs e)
        {
            fetchemp();
        }
    }
}
