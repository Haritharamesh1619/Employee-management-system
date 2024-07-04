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
    public partial class view : Form
    {
        public view()
        {
            InitializeComponent();
        }
       readonly SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-LHO60ST\SQLEXPRESS;Initial Catalog=emp_management;Integrated Security=True");
        private void fetchemp()
        { 
            try 
            { 
                con.Open();
                string query= "select * from tbl_empdetail where emp_id='"+txt_id.Text+"'";
                SqlCommand cmd=new SqlCommand(query, con);
                DataTable dt=new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    empid.Text = dr["emp_id"].ToString();
                    empname.Text = dr["emp_name"].ToString();
                    empgender.Text = dr["emp_gender"].ToString();
                    empdob.Text = dr["emp_dob"].ToString();
                    empadd.Text = dr["emp_address"].ToString();
                    empposition.Text = dr["emp_position"].ToString();
                    empedu.Text = dr["emp_edu"].ToString();
                    empphn.Text = dr["emp_phone"].ToString();

                    empid.Visible = true;
                    empname.Visible = true; 
                    empgender.Visible = true;
                    empdob.Visible = true;
                    empadd.Visible = true;
                    empposition.Visible = true;
                    empedu.Visible = true;
                    empphn.Visible = true;

                }
                con.Close();


            } 
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        
        }
        private void view_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dashboard db = new dashboard();
            db.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fetchemp();
        }
    }
}
