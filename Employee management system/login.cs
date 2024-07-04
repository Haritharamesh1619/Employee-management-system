using Employee_management_system;
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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-LHO60ST\SQLEXPRESS;Initial Catalog=emp_management;Integrated Security=True");


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                login_pwd.UseSystemPasswordChar=false;
            }
            else
            {
                login_pwd.UseSystemPasswordChar = true;
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            register rg=new register();
            rg.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-LHO60ST\SQLEXPRESS;Initial Catalog=emp_management;Integrated Security=True");
            //string projectConnection = ConfigurationManager.ConnectionStrings["kitConnection"].ConnectionString;
            //SqlConnection con = new SqlConnection(projectConnection);
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_log", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param1 = new SqlParameter("@uname", SqlDbType.VarChar);
            cmd.Parameters.Add(param1).Value = login_uname.Text;
            SqlParameter param2 = new SqlParameter("@password", SqlDbType.VarChar);
            cmd.Parameters.Add(param2).Value = login_pwd.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            int a = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());

            if (a > 0)
            {
                dashboard db = new dashboard();
                db.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("InValid User");
            }
            con.Close();

        }
    }
    }

