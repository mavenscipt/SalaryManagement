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
    public partial class MasterRegistration : Form
    {
        public MasterRegistration()
        {
            InitializeComponent();
        }

        private void MasterRegistration_Load(object sender, EventArgs e)
        {
            //VScrollBar vScroller = new VScrollBar();
            //vScroller.Height = 200;
            //vScroller.Width = 30;
            //this.Controls.Add(vScroller);
            //vScroller.Dock = DockStyle.Right;
            //vScroller.Width = 30;
            //vScroller.Height = 200;
            ////authorGroup.Name = "VScrollBar1";
            //vScroller.Minimum = 0;
            //vScroller.Maximum = 100;
            //vScroller.Value = 40; 
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Texts(txtEmployeeName));
            string EmployeeName = txtEmployeeName.Text;
            string BirthDate = dtBirthDate.Text;
            int Age = Convert.ToInt32(txtEmployeeName.Text);
            string Sex = cmbSex.SelectedItem.ToString();
            int AdharCard1 = Convert.ToInt32(txtAdharFirst.Text);
            int AdharCard2 = Convert.ToInt32(txtAdharSecond.Text);
            int AdharCard3 = Convert.ToInt32(txtAdharThird.Text);
            string Permanent = txtPermanentAddress.Text;
            int Pincode = Convert.ToInt32(txtPincode.Text);
            Double PersonalMobile1 = Convert.ToDouble(txtPersonalMobile1.Text);
            Double PersonalMobile2 = Convert.ToDouble(txtPersonalMobile2.Text);
            Double FamilyMobile1 = Convert.ToDouble(txtFamilyMobile1.Text);
            Double FamilyMobile2 = Convert.ToDouble(txtFamilyMobile2.Text);   
            string OrignalDoc = cmborignalDoc.SelectedItem.ToString();
            string ReferenceName = txtReferenceName.Text;
            double ReferenceMobile = Convert.ToDouble(txtReferenceMobile.Text);
            string BankAccountHolderName = txtAcHolderName.Text ;
            string BankName = txtBankName.Text;
            string BranchName = txtBranchName.Text;
            string ISFCCode = txtISFCCode.Text;
            double AccountNumber = Convert.ToDouble(txtAcNumber.Text);
            string LastCompanyName = txtLastCompanyName.Text;
            string LastCompanyWorkingTime = txtLastWorkTime.Text;
            string  Department = cmbDepartment.SelectedItem.ToString();
            string Designation = cmbDesignation.SelectedItem.ToString();
            string EmployeeCategory = cmbEmployeecategory.SelectedItem.ToString();
            string Contractor = cmbContract.SelectedItem.ToString();
            string ResidenceStatus = "";
            string SalaryType = "";
            

            if (rtbWithRoom.Checked)
            {
                ResidenceStatus = rtbWithRoom.Text;
            }
            else
            {
                ResidenceStatus = rtbWithoutRoom.Text;
             }

            if (rtbDailyWages.Checked)
            {
                SalaryType = rtbDailyWages.Text;
            }
            else if (rtbFix.Checked)
            {
                SalaryType = rtbFix.Text;
            }
            else
            {
                SalaryType = rtbMonthlyBase.Text;
            }
            double salary = Convert.ToDouble(txtSalary.Text);


            Operations op = new Operations();
            //InsertEmployee();
            int result = op.InsertEmployee(EmployeeName, BirthDate, Age, Sex, AdharCard1, AdharCard2, AdharCard3, Permanent, Pincode, PersonalMobile1, PersonalMobile2, FamilyMobile1, FamilyMobile2, OrignalDoc, ReferenceName, ReferenceMobile, BankAccountHolderName, BankName, BranchName, ISFCCode, AccountNumber, LastCompanyName, LastCompanyWorkingTime, Department, Designation, EmployeeCategory, Contractor, ResidenceStatus, SalaryType, salary);
            if(result > 0)
            {
                MessageBox.Show("Record Save Successfully");
            }

        }
        public string Texts(TextBox Name)
        {   
            return Name.Text ;
        }
    }
}
