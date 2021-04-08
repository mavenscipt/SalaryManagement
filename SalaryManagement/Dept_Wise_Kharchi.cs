using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SalaryManagement
{
    public partial class Dept_Wise_Kharchi : Form
    {
        Operations Op = new Operations();
        public Dept_Wise_Kharchi()
        {
            InitializeComponent();
        }

        private void Dept_Wise_Kharchi_Load(object sender, EventArgs e)
        {
            Bind();
        }
        public void Bind()
        {
            cmb_Dept_Name.DataSource = new BindingSource(Op.GetDataForCombo("select Id,Name from Department"), null);
            cmb_Dept_Name.DisplayMember = "Value";
            cmb_Dept_Name.ValueMember = "Key";
        }

        private void Cmb_Dept_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayData();
        }
        void DisplayData()
        {
            int EmployeeID = ((KeyValuePair<int, string>)cmb_Dept_Name.SelectedItem).Key;
            string Name = ((KeyValuePair<int, string>)cmb_Dept_Name.SelectedItem).Value;

            Op.getConnection();
            string query = "Select * from Kharchi where [Employee ID] IN (select id from tblEmployeeDetails where Department=" + EmployeeID+")" ;
            SqlDataAdapter sda = new SqlDataAdapter(query, Op.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
