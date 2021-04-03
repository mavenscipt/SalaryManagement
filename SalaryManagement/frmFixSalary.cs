using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SalaryManagement
{
    public partial class frmFixSalary : Form
    {
        Operations op = new Operations();
        int Id;
        public frmFixSalary()
        {
            InitializeComponent();
        }

        private void frmFixSalary_Load(object sender, EventArgs e)
        {
            ComboboxBind();
        }
        public void ComboboxBind()
        {
            cmbEmployee.DataSource = new BindingSource(op.GetDataForCombo("select Id,Name from tblEmployeeDetails where SalaryType = 'fix'"), null);
            cmbEmployee.DisplayMember = "Value";
            cmbEmployee.ValueMember = "Key";
        }

        private void cmbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            Id = ((KeyValuePair<int, string>)cmbEmployee.SelectedItem).Key;
            txtSalary.Text = op.GetSingleItemValue("select Salary from tblEmployeeDetails where Id='" + Id + "'");
            txtUpad.Text = op.GetSingleItemValue("select EMI from tblUpad where EmployeeId='" + Id + "'");
            txtKharchi.Text = op.GetSingleItemValue("select [Amount] from Kharchi where [Employee ID]='" + Id + "'");
            //change();
            string Value = ((KeyValuePair<int, string>)cmbEmployee.SelectedItem).Value;

            if (Value == "Select")
            {
                PanelSalary.Visible = false;
            }
            else
            {
                PanelSalary.Visible = true;
            }

        }

        private void cmbEmployee_SelectedValueChanged(object sender, EventArgs e)
        {

        }
        public void change()
        {
            double Salary = Convert.ToDouble(txtSalary.Text);
            double UPADEMI = Convert.ToDouble(txtUpad.Text);
            double Kharchi = Convert.ToDouble(txtKharchi.Text);
            double RoomRent = 0;
            if (txtRoomRent.Text.Length > 0)
            {
                RoomRent = Convert.ToDouble(txtRoomRent.Text);
            }
            double Payable = Salary - UPADEMI - Kharchi - RoomRent;
            txtPayableSalary.Text = Payable.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double RoomRent = 0;
            double Present = 0;
            if (txtPresent.Text.Length != 0)
            {
                Present = Convert.ToDouble(txtPresent.Text);
            }
            else if (txtRoomRent.Text.Length !=0)
            {
                RoomRent = Convert.ToDouble(txtRoomRent.Text);
            }
            
                int employeeID = Id;
                double Salary = Convert.ToDouble(txtSalary.Text);
                double UPADEMI = Convert.ToDouble(txtUpad.Text);
                double Kharchi = Convert.ToDouble(txtKharchi.Text);
                
                
                double FinalSalary = Convert.ToDouble(txtPayableSalary.Text);
               
                int result = op.DataInsert("insert into Salary (EmployeeID,Salary,UPADEMI,Kharchi,RoomRent,FinalSalary) Values ('" + Id + "','" + Salary + "','" + UPADEMI + "','" + Kharchi + "','" + RoomRent + "','" + FinalSalary + "')");
                if (result > 0)
                {
                    MessageBox.Show("Data Insert Successfully");
                }
            

        }

        private void txtRoomRent_TextChanged(object sender, EventArgs e)
        {
            change();
        }

        private void txtRoomRent_TextChanged_1(object sender, EventArgs e)
        {
            change();
        }

        private void PanelSalary_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtKharchi_TextChanged(object sender, EventArgs e)
        {
            string Value = ((KeyValuePair<int, string>)cmbEmployee.SelectedItem).Value;
            if (Value != "Select")
            {
                double Salary = Convert.ToDouble(txtSalary.Text);
                double UPADEMI = Convert.ToDouble(txtUpad.Text);
                double Kharchi = Convert.ToDouble(txtKharchi.Text);
                txtPayableSalary.Text = (Salary - UPADEMI - Kharchi).ToString();
            }
           
        }

        private void txtUpad_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void txtSalary_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
