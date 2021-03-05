using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

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
            //string EmployeeName = txtEmployeeName.Text;
            //string BirthDate = dtBirthDate.Text;
            //int Age = Convert.ToInt32(txtEmployeeName.Text);
            //string Sex = cmbSex.SelectedItem.ToString();
            //int AdharCard1 = Convert.ToInt32(txtAdharFirst.Text);
            //int AdharCard2 = Convert.ToInt32(txtAdharSecond.Text);
            //int AdharCard3 = Convert.ToInt32(txtAdharThird.Text);
            //string Permanent = txtPermanentAddress.Text;
            //int Pincode = Convert.ToInt32(txtPincode.Text);
            //Double PersonalMobile1 = Convert.ToDouble(txtPersonalMobile1.Text);
            //Double PersonalMobile2 = Convert.ToDouble(txtPersonalMobile2.Text);
            //Double FamilyMobile1 = Convert.ToDouble(txtFamilyMobile1.Text);
            //Double FamilyMobile2 = Convert.ToDouble(txtFamilyMobile2.Text);   
            //string OrignalDoc = cmborignalDoc.SelectedItem.ToString();
            //string ReferenceName = txtReferenceName.Text;
            //double ReferenceMobile = Convert.ToDouble(txtReferenceMobile.Text);
            //string BankAccountHolderName = txtAcHolderName.Text ;
            //string BankName = txtBankName.Text;
            //string BranchName = txtBranchName.Text;
            //string ISFCCode = txtISFCCode.Text;
            //double AccountNumber = Convert.ToDouble(txtAcNumber.Text);
            //string LastCompanyName = txtLastCompanyName.Text;
            //string LastCompanyWorkingTime = txtLastWorkTime.Text;
            //string  Department = cmbDepartment.SelectedItem.ToString();
            //string Designation = cmbDesignation.SelectedItem.ToString();
            //string EmployeeCategory = cmbEmployeecategory.SelectedItem.ToString();
            //string Contractor = cmbContract.SelectedItem.ToString();
            //string ResidenceStatus = "";
            //string SalaryType = "";

            //MessageBox.Show(Texts(txtEmployeeName));
            string EmployeeName = "Harshad";
            string BirthDate = "05/03/2021";
            int Age = Convert.ToInt32(18);
            string Sex = "Male";
            int AdharCard1 = Convert.ToInt32(0123);
            int AdharCard2 = Convert.ToInt32(0123);
            int AdharCard3 = Convert.ToInt32(3214);
            string Permanent = "Morbi";
            int Pincode = Convert.ToInt32(363641);
            Double PersonalMobile1 = Convert.ToDouble(9067664937);
            Double PersonalMobile2 = Convert.ToDouble(8866204346);
            Double FamilyMobile1 = Convert.ToDouble(9998146271);
            Double FamilyMobile2 = Convert.ToDouble(9586313298);
            string OrignalDoc = "Adhar";
            string ReferenceName = "Hak";
            double ReferenceMobile = Convert.ToDouble(8200943974);
            string BankAccountHolderName = "Harshad tretiya";
            string BankName = "SBI";
            string BranchName = "Savsar Plot";
            string ISFCCode = "SBI02822";
            double AccountNumber = Convert.ToDouble(2101455620133);
            string LastCompanyName = "BinaryRepublik";
            string LastCompanyWorkingTime = "1Year";
            int Department = 1;
            string Designation = "Developer";
            string EmployeeCategory = "General";
            string Contractor = "NutBoll";
            string ResidenceStatus = "Room";
            string SalaryType = "Fix";
            DateTime JoiningDate = DateTime.Today;
            string AdharCardImage =  ImageToBase64(,)


            //if (rtbWithRoom.Checked)
            //{
            //    ResidenceStatus = rtbWithRoom.Text;
            //}
            //else
            //{
            //    ResidenceStatus = rtbWithoutRoom.Text;
            // }

            //if (rtbDailyWages.Checked)
            //{
            //    SalaryType = rtbDailyWages.Text;
            //}
            //else if (rtbFix.Checked)
            //{
            //    SalaryType = rtbFix.Text;
            //}
            //else
            //{
            //    SalaryType = rtbMonthlyBase.Text;
            //}
            //double salary = Convert.ToDouble(txtSalary.Text);

            double salary = Convert.ToDouble(10000);

            Operations op = new Operations();
            //InsertEmployee();
            int result = op.InsertEmployee(EmployeeName, BirthDate, Age, Sex, AdharCard1, AdharCard2, AdharCard3, Permanent, Pincode, PersonalMobile1, PersonalMobile2, FamilyMobile1, FamilyMobile2, OrignalDoc, ReferenceName, ReferenceMobile, BankAccountHolderName, BankName, BranchName, ISFCCode, AccountNumber, LastCompanyName, LastCompanyWorkingTime, Department, Designation, EmployeeCategory, Contractor, ResidenceStatus, SalaryType, salary, JoiningDate);
            MessageBox.Show(result.ToString());
            //if(result > 0)
            //{
            //    MessageBox.Show("Record Save Successfully");
            //}

        }
        public string Texts(TextBox Name)
        {   
            return Name.Text ;
        }


        public string ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Convert Image to byte[]
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();

                // Convert byte[] to Base64 String
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }

        public Image Base64ToImage(string base64String)
        {
            // Convert Base64 String to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0,
              imageBytes.Length);

            // Convert byte[] to Image
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }
    }
}
