using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SalaryManagement
{
    public partial class frmAllKharchi : Form
    {
        public frmAllKharchi()
        {
            InitializeComponent();
        }
        Operations op = new Operations();
        private void frmAllKharchi_Load(object sender, EventArgs e)
        {
            rtbAll.Checked = true;
           // ShowAllKharchi("Select Name,Amount,Date from Kharchi");

            ComboboxBind(cmbDepartment, "select Id,Name from Department");
            ComboboxBind(cmbEmployee, "select Id,Name from tblEmployeeDetails");
                
            
        }
        public void ComboboxBind(ComboBox comboBox,string query)
        {
            comboBox.DataSource = new BindingSource(op.GetDataForCombo(query), null);
            comboBox.DisplayMember = "Value";
            comboBox.ValueMember = "Key";
        }
       
        public void UpdateBalance()
        {
            
            int Amount = 0;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                Amount = Amount + int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString());
            }
            txtTotal.Text = Amount.ToString();
            //Pending_Amount_Label.Text = pendig_Amount.ToString();
        }
        private void rtbEmployeeWise_CheckedChanged(object sender, EventArgs e)
        {
            panelHideShow(false, true);
            txtTotal.Text = "";
            dataGridView1.DataSource = null;
        }

       


        private void rtbDepartmentWise_CheckedChanged(object sender, EventArgs e)
        {
            panelHideShow(true, false);
            dataGridView1.DataSource = null;
            txtTotal.Text = "";

        }
        public void panelHideShow(bool Department,bool Employee)
        {
            pnlDepartment.Visible = Department;
            pnlEmployee.Visible = Employee;
        }

        private void rtbAll_CheckedChanged(object sender, EventArgs e)
        {
            panelHideShow(false, false);
            ShowAllKharchi("Select Name,Amount,Date from Kharchi");
           
        }

        public void ShowAllKharchi(string query)
        {
          
            SqlCommand cmd = new SqlCommand(query);
            cmd.Connection = op.getConnection();
            //SqlDataReader dr = cmd.ExecuteReader();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            
           

            if (dt != null && dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
                UpdateBalance();
            }
            else
            {
                dataGridView1.DataSource = null;
            }
           
        }
        public void Bind()
        {
           
        }


        private void rtbNonRecovered_CheckedChanged(object sender, EventArgs e)
        {
            panelHideShow(false, false);
        }

        private void cmbDepartment_SelectedValueChanged(object sender, EventArgs e)
        {
           // int EmployeeID = ((KeyValuePair<int, string>)cmbEmployee.SelectedItem).Key;
           // string Name = ((KeyValuePair<int, string>)cmbEmployee.SelectedItem).Value;
           // ShowAllKharchi("Select Name,Amount,Date from Kharchi where Employee ID = '"+ EmployeeID + "'");
        }

        private void cmbEmployee_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void cmbEmployee_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int EmployeeID = ((KeyValuePair<int, string>)cmbEmployee.SelectedItem).Key;
            // string Name = ((KeyValuePair<int, string>)cmbEmployee.SelectedItem).Value;
            ShowAllKharchi("Select Name,Amount,Date from Kharchi where [Employee ID] = '" + EmployeeID + "'");
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbDepartment_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int DepartmentID = ((KeyValuePair<int, string>)cmbDepartment.SelectedItem).Key;
            // string Name = ((KeyValuePair<int, string>)cmbEmployee.SelectedItem).Value;
            ShowAllKharchi("Select Name,Amount,Date from Kharchi where [Employee ID] = (select Id from tblEmployeeDetails where Department = "+ DepartmentID +")");
        }
    }
}
