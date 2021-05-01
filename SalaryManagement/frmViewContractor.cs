using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SalaryManagement
{
    public partial class frmViewContractor : Form
    {
        Operations Op = new Operations();
        public frmViewContractor()
        {
            InitializeComponent();
        }

        private void frmViewContractor_Load(object sender, EventArgs e)
        {
            BindCombo();
            DisplayData();
        }
        private void BindCombo()
        {
            cmbDepartment.DataSource = new BindingSource(Op.GetDataForCombo("select Id,Name from Department"), null);
            cmbDepartment.DisplayMember = "Value";
            cmbDepartment.ValueMember = "Key";
        }
        private void DisplayData()
        {
            Op.getConnection();
            string query = "Select * from Contractor";
            SqlDataAdapter sda = new SqlDataAdapter(query, Op.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dt;
        }
    }
}
