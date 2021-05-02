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

    public partial class FrmFixSalaryList : Form
    {
        int SalaryId;
        double UpadEMI;
        double Kharchi;
        Operations op = new Operations();
        public FrmFixSalaryList()
        {
            InitializeComponent();
        }

        private void FrmFixSalaryList_Load(object sender, EventArgs e)
        {
            
            ComboboxBind();
           
        }
       


        public void ComboboxBind()
        {
            cmbEmployee.DataSource = new BindingSource(op.GetDataForCombo("select Id,Name from tblEmployeeDetails where SalaryType = 'fix Salary'"), null);
            cmbEmployee.DisplayMember = "Value";
            cmbEmployee.ValueMember = "Key";
        }
        public void Bind()
        {
            int EmployeeID = ((KeyValuePair<int, string>)cmbEmployee.SelectedItem).Key;
            string Name = ((KeyValuePair<int, string>)cmbEmployee.SelectedItem).Value;
            SqlCommand cmd;
            cmd = new SqlCommand("select [Id],[EmployeeName],[BasicSalary],[Kharchi],[Upad],[RoomRent],[Present],[NetSalary],[Date] from tblFixSalary where [EmployeeID] = '" + EmployeeID + "'  Order By  Id DESC");
            cmd.Connection = op.getConnection();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt != null && dt.Rows.Count > 0)
            {

                DGV.DataSource = dt;
            }
            else
            {
                DGV.DataSource = null;
            }


        }

        private void cmbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void DGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            SalaryId = Convert.ToInt32(DGV.Rows[e.RowIndex].Cells[0].Value);
            Kharchi = Convert.ToDouble(DGV.Rows[e.RowIndex].Cells[3].Value);
            UpadEMI = Convert.ToDouble(DGV.Rows[e.RowIndex].Cells[4].Value);


        }
        private void cmbEmployee_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Bind();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int EmployeeID = ((KeyValuePair<int, string>)cmbEmployee.SelectedItem).Key;
            string Name = ((KeyValuePair<int, string>)cmbEmployee.SelectedItem).Value;

            



            DialogResult Result = MessageBox.Show("Are You Sure You Want to Delete Salary", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Result == DialogResult.Yes)
            {
                if (SalaryId > 0)
                {
                    BackendOperations(EmployeeID, Name, UpadEMI, Kharchi);
                }

                int result = op.DataInsert("Delete from  tblFixSalary where [EmployeeID] = '" + EmployeeID + "' and Id = '" + SalaryId + "' ");
                if (result > 0)
                {
                    MessageBox.Show("Salary Delete Successfully");
                   
                    cmbEmployee.SelectedIndex = 0;
                    ComboboxBind();
                    Bind();
                }
            }

        }

        public void BackendOperations(int EmployeeId,string EmployeeName, double upad,double kharchi)
        {                   
            SqlCommand cmd = new SqlCommand("insert into Kharchi ([Name],[Employee ID],[Amount],[Date])" +
                "values('"+EmployeeName+"','"+EmployeeId+"','"+kharchi+"','"+ DateTime.Now.ToShortDateString() + "')");
            cmd.Connection = op.getConnection();
            cmd.ExecuteNonQuery();
                       
            double PendingAmount = GetData("Select [PendingAmount] from tblUpad where [EmployeeId] = '" + EmployeeId + "'");
            double RecoverdAmount = GetData("Select [RecoveredAmount] from tblUpad where [EmployeeId] = '" + EmployeeId + "'");
            double Amount = GetData("Select [Amount] from tblUpad where [EmployeeId] = '" + EmployeeId + "'");
            if(Amount != RecoverdAmount)
            {
                double pd = PendingAmount + upad;
                double rAmount = RecoverdAmount - upad;
                cmd = new SqlCommand("update tblUpad set [PendingAmount]='" + pd + "',[RecoveredAmount]='" + rAmount + "' where [EmployeeId] = '" + EmployeeId + "'");
                cmd.Connection = op.getConnection();
                cmd.ExecuteNonQuery();
            }
            else
            {
                

            }



        }
        public double GetData(string query)
        {

            SqlCommand cmd = new SqlCommand(query);
            cmd.Connection = op.getConnection();
            return Convert.ToDouble(cmd.ExecuteScalar());
        }
        private void DGV_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            SalaryId = Convert.ToInt32(DGV.Rows[e.RowIndex].Cells[0].Value);
            Kharchi = Convert.ToDouble(DGV.Rows[e.RowIndex].Cells[3].Value);
            UpadEMI = Convert.ToDouble(DGV.Rows[e.RowIndex].Cells[4].Value);
        }

        private void DGV_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void DGV_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (DGV.Rows.Count > 0)
                {
                    contextMenuStrip1.Enabled = true;
                }
                else
                {
                    contextMenuStrip1.Visible = false;
                }
            }
        }
    }
}
