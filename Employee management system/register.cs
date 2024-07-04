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
    public partial class register : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-LHO60ST\SQLEXPRESS;Initial Catalog=emp_management;Integrated Security=True");
        string g;

        public object ConfigurationManager { get; private set; }

        public register()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login lg = new login();
            lg.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                g = "male";
            }
            else
           
                g = "female";

            try

            {

                //string projectConnection = ConfigurationManager.ConnectionStrings["employee"].ConnectionString;
                //SqlConnection con = new SqlConnection(projectConnection);
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-LHO60ST\\SQLEXPRESS;Initial Catalog=emp_management;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_reg", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param1 = new SqlParameter("@name", SqlDbType.VarChar);
                cmd.Parameters.Add(param1).Value = register_name.Text;
                SqlParameter param2 = new SqlParameter("@dob", SqlDbType.DateTime);
                cmd.Parameters.Add(param2).Value = date.Text;
                SqlParameter param3 = new SqlParameter("@gender", SqlDbType.VarChar);
                cmd.Parameters.Add(param3).Value = radioButton1.Text;
                SqlParameter param4 = new SqlParameter("@uname", SqlDbType.VarChar);
                cmd.Parameters.Add(param4).Value = register_uname.Text;
                SqlParameter param5 = new SqlParameter("@password", SqlDbType.VarChar);
                cmd.Parameters.Add(param5).Value = register_pwd.Text;
                SqlParameter param6 = new SqlParameter("@confrimpassword", SqlDbType.VarChar);
                cmd.Parameters.Add(param6).Value = register_cpwd.Text;
                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    MessageBox.Show("Registered Sucessfully");
                }
                else
                {
                    MessageBox.Show("Registration Failed");
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int check(string uname)
        { con.Open();
            string query = "select count(*)from sp_reg where='" + uname + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            int v=(int)cmd.ExecuteScalar();
            con.Close();
            return v;



        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                register_pwd.UseSystemPasswordChar = false;
                register_cpwd.UseSystemPasswordChar = false;
            }
            else
            {
              register_pwd.UseSystemPasswordChar = true;
              register_cpwd.UseSystemPasswordChar = true;
            }
        }

        private void register_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void reset_Click(object sender, EventArgs e)
        {
            register_name.Text = "";
            register_uname.Text = "";
            register_pwd.Text = "";
            register_cpwd.Text = "";

        }

        private void cancel_Click(object sender, EventArgs e)
        {

        }
    }
}

