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
    public partial class frmDepartmentWiseKharchi : Form
    {
        Operations Op = new Operations();
        public frmDepartmentWiseKharchi()
        {
            InitializeComponent();
        }

        private void Dept_Wise_Kharchi_Load(object sender, EventArgs e)
        {
            Bind();
            Amount_Label.Text =Pending_Amount_Label.Text= "0";
            panel1.Visible = false;
        }
        public void Bind()
        {
            cmb_Dept_Name.DataSource = new BindingSource(Op.GetDataForCombo("select Id,Name from Department"), null);
            cmb_Dept_Name.DisplayMember = "Value";
            cmb_Dept_Name.ValueMember = "Key";
            cmb_Employee_Name.DataSource = new BindingSource(Op.GetDataForCombo("select Id,Name from tblEmployeeDetails"), null);
            cmb_Employee_Name.DisplayMember = "Value";
            cmb_Employee_Name.ValueMember = "Key";
        }
        public void UpdateBalance()
        {
            int Amount=0,pendig_Amount = 0;
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                Amount= Amount+ int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                pendig_Amount += int.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
            }
            Amount_Label.Text = Amount.ToString();
            Pending_Amount_Label.Text = pendig_Amount.ToString();
        }
        private void Cmb_Dept_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Dept_Name.SelectedText != "Select")
            {
                panel1.Visible = true;
                int EmployeeID = ((KeyValuePair<int, string>)cmb_Dept_Name.SelectedItem).Key;
                string Name = ((KeyValuePair<int, string>)cmb_Dept_Name.SelectedItem).Value;

                Op.getConnection();
                string query = "Select * from Kharchi where [Employee ID] IN (select id from tblEmployeeDetails where Department=" + EmployeeID + ")";
                SqlDataAdapter sda = new SqlDataAdapter(query, Op.con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                UpdateBalance();
            }
            else
            {
                panel1.Visible = false;
            }
        }

        private void Cmb_Employee_Name_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmb_Employee_Name.SelectedText != "Select")
            {
                panel1.Visible = true;
                string Name = ((KeyValuePair<int, string>)cmb_Employee_Name.SelectedItem).Value;
                Op.getConnection();
                string query = "Select * from Kharchi where [Employee ID] IN (select id from tblEmployeeDetails where Name='" + Name + "')";
                SqlDataAdapter sda = new SqlDataAdapter(query, Op.con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                UpdateBalance();
            }
            else
            {
                panel1.Visible = false;
            }
        }
    }
}
