﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_management_system
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            employee emp = new employee();
            emp.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            view v = new view();
            v.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            salary s = new salary();
            s.Show();
            this.Hide();
        }
    }
}
