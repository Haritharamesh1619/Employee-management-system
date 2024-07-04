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
    public partial class employee : Form
    {
        public employee()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void employee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'emp_managementDataSet.tbl_empdetail' table. You can move, or remove it, as needed.
            this.tbl_empdetailTableAdapter.Fill(this.emp_managementDataSet.tbl_empdetail);

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dashboard db= new dashboard();
            db.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-LHO60ST\\SQLEXPRESS;Initial Catalog=emp_management;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_employee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param1 = new SqlParameter("@emp_id", SqlDbType.Int);
                cmd.Parameters.Add(param1).Value = txt_id.Text;
                SqlParameter param2 = new SqlParameter("@emp_name", SqlDbType.VarChar);
                cmd.Parameters.Add(param2).Value = txt_name.Text;
                SqlParameter param3 = new SqlParameter("@emp_gender", SqlDbType.VarChar);
                cmd.Parameters.Add(param3).Value = gender.Text;
                SqlParameter param4 = new SqlParameter("@emp_dob", SqlDbType.VarChar);
                cmd.Parameters.Add(param4).Value = date.Text;
                SqlParameter param5 = new SqlParameter("@emp_address", SqlDbType.VarChar);
                cmd.Parameters.Add(param5).Value = txt_address.Text;
                SqlParameter param6 = new SqlParameter("@emp_position", SqlDbType.VarChar);
                cmd.Parameters.Add(param6).Value = position.Text;
                SqlParameter param7 = new SqlParameter("@emp_edu", SqlDbType.VarChar);
                cmd.Parameters.Add(param7).Value = education.Text;
                SqlParameter param8 = new SqlParameter("@emp_phone", SqlDbType.VarChar);
                cmd.Parameters.Add(param8).Value = txt_phn.Text;
                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    MessageBox.Show("Data Inserted Sucessfully");
                }
                else
                {
                    MessageBox.Show("Data Insertion Failed");
                }
                con.Close(); ;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_address_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_phn_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-LHO60ST\\SQLEXPRESS;Initial Catalog=emp_management;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_update", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param1 = new SqlParameter("@emp_id", SqlDbType.Int);
            cmd.Parameters.Add(param1).Value = txt_id.Text;
            SqlParameter param2 = new SqlParameter("@emp_name", SqlDbType.VarChar);
            cmd.Parameters.Add(param2).Value = txt_name.Text;
            SqlParameter param3 = new SqlParameter("@emp_gender", SqlDbType.VarChar);
            cmd.Parameters.Add(param3).Value = gender.Text;
            SqlParameter param4 = new SqlParameter("@emp_dob", SqlDbType.VarChar);
            cmd.Parameters.Add(param4).Value = date.Text;
            SqlParameter param5 = new SqlParameter("@emp_address", SqlDbType.VarChar);
            cmd.Parameters.Add(param5).Value = txt_address.Text;
            SqlParameter param6 = new SqlParameter("@emp_position", SqlDbType.VarChar);
            cmd.Parameters.Add(param6).Value = position.Text;
            SqlParameter param7 = new SqlParameter("@emp_edu", SqlDbType.VarChar);
            cmd.Parameters.Add(param7).Value = education.Text;
            SqlParameter param8 = new SqlParameter("@emp_phone", SqlDbType.VarChar);
            cmd.Parameters.Add(param8).Value = txt_phn.Text;
            int i = cmd.ExecuteNonQuery();

            if (i > 0)
            {
                MessageBox.Show("Data updated Sucessfully");
            }
            else
            {
                MessageBox.Show("Data update Failed");
            }
            con.Close(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-LHO60ST\\SQLEXPRESS;Initial Catalog=emp_management;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_delete", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param1 = new SqlParameter("@emp_id", SqlDbType.Int);
            cmd.Parameters.Add(param1).Value = txt_id.Text;
            int i = cmd.ExecuteNonQuery();

            if (i > 0)
            {
                MessageBox.Show("Data deleted Sucessfully");
            }
            else
            {
                MessageBox.Show("Data delete Failed");
            }
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txt_id.Text = "";
            txt_name.Text = "";
            gender.Text = "";
            date.Text = "";
            txt_address.Text = "";
            position.Text = "";
            education.Text = "";
            txt_phn.Text = "";
            txt_id.Focus(); 



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-LHO60ST\\SQLEXPRESS;Initial Catalog=emp_management;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from sp_empdetail", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-LHO60ST\\SQLEXPRESS;Initial Catalog=emp_management;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_search", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter param1 = new SqlParameter("@emp_id", SqlDbType.Int);
            cmd.Parameters.Add(param1).Value = txt_id.Text;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt= new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
           
            con.Close();
        }
    }
}
