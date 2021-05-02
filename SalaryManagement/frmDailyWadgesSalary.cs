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
    public partial class frmDailyWadgesSalary : Form
    {
        public frmDailyWadgesSalary()
        {
            InitializeComponent();
        }
        Operations op = new Operations();
        private void frmDailyWadgesSalary_Load(object sender, EventArgs e)
        {
            ComboboxBind();
        }
        public void ComboboxBind()
        {
            cmbEmployee.DataSource = new BindingSource(op.GetDataForCombo("select Id,Name from tblEmployeeDetails where SalaryType = 'Daily Wages' "), null);
            cmbEmployee.DisplayMember = "Value";
            cmbEmployee.ValueMember = "Key";
        }

        private void cmbEmployee_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbEmployee_SelectionChangeCommitted(object sender, EventArgs e)
        {

            int EmployeeID = ((KeyValuePair<int, string>)cmbEmployee.SelectedItem).Key;
            string Name = ((KeyValuePair<int, string>)cmbEmployee.SelectedItem).Value;
            txtSalary.Text = GetData("Select Salary from tblEmployeeDetails where Id ='" + EmployeeID + "'");
            txtKharchi.Text = GetData("Select SUM(Amount) from Kharchi where [Employee Id] = '"+EmployeeID+"' ");
            txtUpad.Text = GetData("Select [EMI] from tblUpad where [EmployeeId] = '" + EmployeeID + "' and [PendingAmount] <> 0 ");

        //    txtNetSalary.Text = SalaryCalculation().ToString();
        
        }
        public string GetData(string query)
        {
            
            SqlCommand cmd = new SqlCommand(query);
            cmd.Connection = op.getConnection();
            return Convert.ToString(cmd.ExecuteScalar());
        }
        public double SalaryCalculation()
        {
            string Salary = txtSalary.Text;
            string RoomRent = txtRoomRent.Text;
            string Upad = txtUpad.Text;
            string Kharchi = txtKharchi.Text;
            string Present = txtPresent.Text;
            string OverTime = txtOverTime.Text;

            double BasicSalary = (NumberConvertor(Salary) * NumberConvertor(Present)) + (NumberConvertor(OverTime));
            double Debits = NumberConvertor(Upad) + NumberConvertor(Kharchi) + NumberConvertor(RoomRent);
            double result = BasicSalary - Debits;
            return result;
        }
        public double NumberConvertor(string value)
        {
            if(value == "") { value = "0"; }
            return Convert.ToDouble(value) ;
        }
        

        private void cmbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtOverTime_TextChanged(object sender, EventArgs e)
        {
            txtNetSalary.Text = SalaryCalculation().ToString();
        }

        private void txtPresent_TextChanged(object sender, EventArgs e)
        {
            txtNetSalary.Text = SalaryCalculation().ToString();
        }

        private void txtRoomRent_TextChanged(object sender, EventArgs e)
        {
            txtNetSalary.Text = SalaryCalculation().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //After successfully Save
            int EmployeeID = ((KeyValuePair<int, string>)cmbEmployee.SelectedItem).Key;
            string Name = ((KeyValuePair<int, string>)cmbEmployee.SelectedItem).Value;
            
            if(Name=="Select")
            {
                MessageBox.Show("Please Select Employee");
                cmbEmployee.Focus();
            }
            else if(txtPresent.Text =="")
            {
                MessageBox.Show("Please Enter Present of the Employee");
                txtPresent.Focus();
            }
            else
            {
                //After successfully Delete
                int Salary = SaveSalary(EmployeeID, Name);
                if(Salary > 0)
                {
                   int Kharchi = UpdateKharchi(EmployeeID);
                   int Upad = UpadUpdate(EmployeeID);
                    MessageBox.Show("Salary Save Successfully...");
                }
                

            }


        }
        public int SaveSalary(int EmployeeId,string EmployeeName)
        {
            string today = "22-02-2021";// DateTime.Now.Date.ToString("dd/MM/yyyy");

            // today = today;
            // MessageBox.Show(today);
            //double BasicSalary = (NumberConvertor(txtSalary.Text) * NumberConvertor(txtPresent.Text));
            SqlCommand cmd = new SqlCommand("Insert into  tblDailySalary ([EmployeeID],[EmployeeName],[BasicSalary],[Kharchi],[Upad],[RoomRent],[OverTime],[Present],[NetSalary],[Date]) values ('" + EmployeeId + "','" + EmployeeName + "','" + NumberConvertor(txtSalary.Text) + "','" + NumberConvertor(txtKharchi.Text) + "','" + NumberConvertor(txtUpad.Text) + "','" + NumberConvertor(txtRoomRent.Text) + "','" + NumberConvertor(txtOverTime.Text) + "','" + NumberConvertor(txtPresent.Text) + "','" + NumberConvertor(txtNetSalary.Text) + "','" + today + "') ");
            cmd.Connection = op.getConnection();
            return cmd.ExecuteNonQuery();
          
        }


        public int UpdateKharchi(int EmployeeId)
        {
            SqlCommand cmd = new SqlCommand("Delete from Kharchi where [Employee Id] = '" + EmployeeId + "' ");
            cmd.Connection = op.getConnection();
            return  cmd.ExecuteNonQuery();
            
            
        }
        public int UpadUpdate(int EmployeeID)
        {
            double Amount = 0, PendingAmount = 0, RecoveredAmount = 0, EMI = 0;
            
            SqlCommand cmd = new SqlCommand("Select * from tblUpad where [EmployeeId] = '" + EmployeeID + " '");
            cmd.Connection = op.getConnection();
            SqlDataReader dr =  cmd.ExecuteReader();
            while(dr.Read())
            {
                if(dr.HasRows)
                {
                    Amount = Convert.ToDouble(dr[2]);
                    PendingAmount = Convert.ToDouble(dr[3]);
                    RecoveredAmount = Convert.ToDouble(dr[4]);
                    EMI = Convert.ToDouble(dr[5]);
                }
                

            }

            if(RecoveredAmount  != Amount)
            {
               
                double RecoverdCalculation = RecoveredAmount + EMI;
                double PendingAmountCalculation = Amount - RecoverdCalculation;
                return SaveUpdateUpad(EmployeeID, PendingAmountCalculation, RecoverdCalculation);

            }
            return 0;
        }
        public int SaveUpdateUpad(int EmployeeId, double PendingAmount, double Recovered)
        {
            SqlCommand cmd = new SqlCommand("Update tblUpad set PendingAmount='"+PendingAmount+"', RecoveredAmount='"+Recovered+ "' where EmployeeId='"+EmployeeId+"'");
            cmd.Connection = op.getConnection();
            return cmd.ExecuteNonQuery();
            

        
        }

        private void txtPresent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtOverTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtRoomRent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
