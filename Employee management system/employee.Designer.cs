namespace Employee_management_system
{
    partial class employee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.empidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empgenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empdobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emppositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empeduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblempdetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emp_managementDataSet = new Employee_management_system.emp_managementDataSet();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.gender = new System.Windows.Forms.ComboBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.position = new System.Windows.Forms.ComboBox();
            this.education = new System.Windows.Forms.ComboBox();
            this.txt_phn = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.exit = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tbl_empdetailTableAdapter = new Employee_management_system.emp_managementDataSetTableAdapters.tbl_empdetailTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblempdetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emp_managementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(413, 530);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee Details";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Employee ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Employee Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Employee Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Employee DoB";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Employee Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 425);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Employee Position";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 493);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(209, 25);
            this.label8.TabIndex = 9;
            this.label8.Text = "Employee Education";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 563);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "Employee Phone";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empidDataGridViewTextBoxColumn,
            this.empnameDataGridViewTextBoxColumn,
            this.empgenderDataGridViewTextBoxColumn,
            this.empdobDataGridViewTextBoxColumn,
            this.empaddressDataGridViewTextBoxColumn,
            this.emppositionDataGridViewTextBoxColumn,
            this.empeduDataGridViewTextBoxColumn,
            this.empphoneDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblempdetailBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(413, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(656, 404);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // empidDataGridViewTextBoxColumn
            // 
            this.empidDataGridViewTextBoxColumn.DataPropertyName = "emp_id";
            this.empidDataGridViewTextBoxColumn.HeaderText = "emp_id";
            this.empidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.empidDataGridViewTextBoxColumn.Name = "empidDataGridViewTextBoxColumn";
            this.empidDataGridViewTextBoxColumn.Width = 150;
            // 
            // empnameDataGridViewTextBoxColumn
            // 
            this.empnameDataGridViewTextBoxColumn.DataPropertyName = "emp_name";
            this.empnameDataGridViewTextBoxColumn.HeaderText = "emp_name";
            this.empnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.empnameDataGridViewTextBoxColumn.Name = "empnameDataGridViewTextBoxColumn";
            this.empnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // empgenderDataGridViewTextBoxColumn
            // 
            this.empgenderDataGridViewTextBoxColumn.DataPropertyName = "emp_gender";
            this.empgenderDataGridViewTextBoxColumn.HeaderText = "emp_gender";
            this.empgenderDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.empgenderDataGridViewTextBoxColumn.Name = "empgenderDataGridViewTextBoxColumn";
            this.empgenderDataGridViewTextBoxColumn.Width = 150;
            // 
            // empdobDataGridViewTextBoxColumn
            // 
            this.empdobDataGridViewTextBoxColumn.DataPropertyName = "emp_dob";
            this.empdobDataGridViewTextBoxColumn.HeaderText = "emp_dob";
            this.empdobDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.empdobDataGridViewTextBoxColumn.Name = "empdobDataGridViewTextBoxColumn";
            this.empdobDataGridViewTextBoxColumn.Width = 150;
            // 
            // empaddressDataGridViewTextBoxColumn
            // 
            this.empaddressDataGridViewTextBoxColumn.DataPropertyName = "emp_address";
            this.empaddressDataGridViewTextBoxColumn.HeaderText = "emp_address";
            this.empaddressDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.empaddressDataGridViewTextBoxColumn.Name = "empaddressDataGridViewTextBoxColumn";
            this.empaddressDataGridViewTextBoxColumn.Width = 150;
            // 
            // emppositionDataGridViewTextBoxColumn
            // 
            this.emppositionDataGridViewTextBoxColumn.DataPropertyName = "emp_position";
            this.emppositionDataGridViewTextBoxColumn.HeaderText = "emp_position";
            this.emppositionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.emppositionDataGridViewTextBoxColumn.Name = "emppositionDataGridViewTextBoxColumn";
            this.emppositionDataGridViewTextBoxColumn.Width = 150;
            // 
            // empeduDataGridViewTextBoxColumn
            // 
            this.empeduDataGridViewTextBoxColumn.DataPropertyName = "emp_edu";
            this.empeduDataGridViewTextBoxColumn.HeaderText = "emp_edu";
            this.empeduDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.empeduDataGridViewTextBoxColumn.Name = "empeduDataGridViewTextBoxColumn";
            this.empeduDataGridViewTextBoxColumn.Width = 150;
            // 
            // empphoneDataGridViewTextBoxColumn
            // 
            this.empphoneDataGridViewTextBoxColumn.DataPropertyName = "emp_phone";
            this.empphoneDataGridViewTextBoxColumn.HeaderText = "emp_phone";
            this.empphoneDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.empphoneDataGridViewTextBoxColumn.Name = "empphoneDataGridViewTextBoxColumn";
            this.empphoneDataGridViewTextBoxColumn.Width = 150;
            // 
            // tblempdetailBindingSource
            // 
            this.tblempdetailBindingSource.DataMember = "tbl_empdetail";
            this.tblempdetailBindingSource.DataSource = this.emp_managementDataSet;
            // 
            // emp_managementDataSet
            // 
            this.emp_managementDataSet.DataSetName = "emp_managementDataSet";
            this.emp_managementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(222, 108);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(168, 26);
            this.txt_id.TabIndex = 12;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(224, 157);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(168, 26);
            this.txt_name.TabIndex = 13;
            // 
            // gender
            // 
            this.gender.FormattingEnabled = true;
            this.gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gender.Location = new System.Drawing.Point(222, 210);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(168, 28);
            this.gender.TabIndex = 14;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(224, 343);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(168, 26);
            this.txt_address.TabIndex = 15;
            this.txt_address.TextChanged += new System.EventHandler(this.txt_address_TextChanged);
            // 
            // position
            // 
            this.position.FormattingEnabled = true;
            this.position.Items.AddRange(new object[] {
            "IT coordinator",
            "Technical support",
            "Network Engineer",
            "Network administrator",
            "IT security specialist",
            "Junior Developer",
            "senior Developer",
            "Project Manager",
            "Project Head",
            "Cloud Engineer",
            "DevOps Engineer",
            "software Tester",
            "Quality Assurance Tester",
            "Database Administrator",
            "Systems Analyst",
            "Data Analyst",
            "HR Manager",
            "HR Coordinator",
            "Account Manager",
            "clerk"});
            this.position.Location = new System.Drawing.Point(224, 422);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(168, 28);
            this.position.TabIndex = 16;
            this.position.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // education
            // 
            this.education.FormattingEnabled = true;
            this.education.Items.AddRange(new object[] {
            "MBA",
            "BCA",
            "B.Com",
            "BE (IT)",
            "BE (CS)",
            "M.Com",
            "M.Sc (CS)",
            "B.TECH"});
            this.education.Location = new System.Drawing.Point(222, 490);
            this.education.Name = "education";
            this.education.Size = new System.Drawing.Size(169, 28);
            this.education.TabIndex = 17;
            // 
            // txt_phn
            // 
            this.txt_phn.Location = new System.Drawing.Point(222, 563);
            this.txt_phn.Name = "txt_phn";
            this.txt_phn.Size = new System.Drawing.Size(168, 26);
            this.txt_phn.TabIndex = 18;
            this.txt_phn.TextChanged += new System.EventHandler(this.txt_phn_TextChanged);
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(224, 269);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(172, 26);
            this.date.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(553, 530);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 38);
            this.button2.TabIndex = 20;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(671, 530);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 38);
            this.button3.TabIndex = 21;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(788, 530);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 38);
            this.button4.TabIndex = 22;
            this.button4.Text = "Reset";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(947, 23);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(57, 20);
            this.linkLabel1.TabIndex = 24;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "HOME";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Red;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.Black;
            this.exit.Location = new System.Drawing.Point(1021, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(39, 38);
            this.exit.TabIndex = 25;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(889, 530);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(101, 38);
            this.button5.TabIndex = 26;
            this.button5.Text = "View";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // tbl_empdetailTableAdapter
            // 
            this.tbl_empdetailTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Employee_management_system.Properties.Resources.employee;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1081, 605);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.date);
            this.Controls.Add(this.txt_phn);
            this.Controls.Add(this.education);
            this.Controls.Add(this.position);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "employee";
            this.Load += new System.EventHandler(this.employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblempdetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emp_managementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.ComboBox position;
        private System.Windows.Forms.ComboBox education;
        private System.Windows.Forms.TextBox txt_phn;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button button5;
        private emp_managementDataSet emp_managementDataSet;
        private System.Windows.Forms.BindingSource tblempdetailBindingSource;
        private emp_managementDataSetTableAdapters.tbl_empdetailTableAdapter tbl_empdetailTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn empidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empgenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empdobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empaddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emppositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empeduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empphoneDataGridViewTextBoxColumn;
    }
}