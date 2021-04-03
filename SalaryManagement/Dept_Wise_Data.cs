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
    public partial class Dept_Wise_Data : Form
    {
        Operations Op = new Operations();
        public Dept_Wise_Data()
        {
            InitializeComponent();
        }

        private void Dept_Wise_Data_Load(object sender, EventArgs e)
        {
            ComboboxBind();
        }
        public void ComboboxBind()
        {
            cmd_dept_name.DataSource = new BindingSource(Op.GetDataForCombo("select Id,Name from Department"), null);
            cmd_dept_name.DisplayMember = "Value";
            cmd_dept_name.ValueMember = "Key";
        }

        private void Cmd_dept_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayData();
        }
        void DisplayData()
        {
            int EmployeeID = ((KeyValuePair<int, string>)cmd_dept_name.SelectedItem).Key;
            string Name = ((KeyValuePair<int, string>)cmd_dept_name.SelectedItem).Value;

            Op.getConnection();
            string query = "Select * from tblEmployeeDetails where Department="+EmployeeID;
            SqlDataAdapter sda = new SqlDataAdapter(query, Op.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dt.Columns.Add("Pic", Type.GetType("System.Byte[]"));
            foreach (DataRow draw in dt.Rows)
            {
                draw["Pic"] = File.ReadAllBytes(draw["Photo"].ToString());
            }
            //dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dt;
        }
    }
}
