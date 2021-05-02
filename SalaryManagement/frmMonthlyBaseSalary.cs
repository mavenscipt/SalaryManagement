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
    public partial class frmMonthlyBaseSalary : Form
    {
        Operations op = new Operations();
        public frmMonthlyBaseSalary()
        {
            InitializeComponent();
        }
        //Monthly Base
        private void frmMonthlyBaseSalary_Load(object sender, EventArgs e)
        {
            ComboboxBind();
            
            
           
            //MessageBox.Show(days.ToString());


        }
        public double NumberConvertor(string value)
        {
            if (value == "") { value = "0"; }
            return Convert.ToDouble(value);
        }
        public int TotalNumberOfDaysInMonth()
        {
            return DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
        }
        public void ComboboxBind()
        {
            cmbEmployee.DataSource = new BindingSource(op.GetDataForCombo("select Id,Name from tblEmployeeDetails where SalaryType = 'Monthly Base' "), null);
            cmbEmployee.DisplayMember = "Value";
            cmbEmployee.ValueMember = "Key";
        }

        private void cmbEmployee_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int EmployeeID = ((KeyValuePair<int, string>)cmbEmployee.SelectedItem).Key;
            string Name = ((KeyValuePair<int, string>)cmbEmployee.SelectedItem).Value;
            
            txtSalary.Text = GetData("Select Salary from tblEmployeeDetails where Id ='" + EmployeeID + "'");
            txtKharchi.Text = GetData("Select SUM(Amount) from Kharchi where [Employee Id] = '" + EmployeeID + "' ");
            txtUpad.Text = GetData("Select [EMI] from tblUpad where [EmployeeId] = '" + EmployeeID + "' and [PendingAmount] <> 0 ");
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
        private void txtPresent_TextChanged(object sender, EventArgs e)
        {
            int days = TotalNumberOfDaysInMonth();
            if (txtPresent.Text.Length > 0)
            {
               DaysCalculation(days, Convert.ToInt32(txtPresent.Text));
            }
            else
            {
                txtLeave.Text = "0";
            }
        }
        public double PerDaySalary()
        {
            if (txtSalary.Text.Length > 0)
            {
                double days = TotalNumberOfDaysInMonth();
                double Salary = Convert.ToInt32(txtSalary.Text);
                double PerDay = Salary / days;
                //  MessageBox.Show(PerDay.ToString());
                return PerDay;
            }
            
            return 0;
        }
       // public Salary()
        public void DaysCalculation(int TotalDays,int Present)
        {
            double PerDaysalary = PerDaySalary();
            
            MessageBox.Show(PerDaysalary.ToString());
            double PayableSalary = 0;
            if (TotalDays == Present)
            {
                MessageBox.Show("Full Month not taken Any Leave");
                double ExtraSalary = Present + 3;
                PayableSalary = PerDaysalary * ExtraSalary;
                MessageBox.Show("Payable Salary" + PayableSalary);
                txtLeave.Text = "0";
            }

            int LeaveDay = TotalDays - Present;
            if(LeaveDay == 3)
            {
                double Sal = Present * PerDaysalary;
                MessageBox.Show("Not Cut Salary" + Sal);
                txtLeave.Text = "3";
            }
            if(LeaveDay > 3)
            {
                txtLeave.Text = LeaveDay.ToString();
                int LeaveCal = LeaveDay - 3;
                int CutSalary = LeaveCal * 2;
                int Pay = Present - CutSalary;
                double s = Pay * PerDaysalary;
                MessageBox.Show(s.ToString());
            }
            txtLeave.Text = LeaveDay.ToString();
            //   MessageBox.Show(LeaveDay.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PerDaySalary();
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

        private void txtSalary_TextChanged(object sender, EventArgs e)
        {
           double PerDaysalary = PerDaySalary();
            txtPerDaySalary.Text = PerDaysalary.ToString("0.00");
        }
    }
}
