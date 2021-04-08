using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SalaryManagement
{
    public partial class MasterRegistration : Form
    {
        Operations Op = new Operations();
        string ImagePath,AdharPath,Pan_Path,Election_Path;
        public MasterRegistration()
        {
            InitializeComponent();
        }
        private void Save_Button_Click(object sender, EventArgs e)
        {
            bool Form_valid = Form_Valid();
            if (Form_valid==true)
            {
                double Adhar = double.Parse(txtAdharFirst.Text + txtAdharSecond.Text + txtAdharThird.Text);
                string abc=Op.InsertEmployee(txtEmployeeName.Text.ToString(),ImagePath,cmbSex.SelectedItem.ToString(),dtBirthDate.Value.ToString(),Convert.ToInt32(txtAge.Text),Adhar,txtPermanentAddress.Text,Convert.ToInt32(txtPincode.Text),Convert.ToDouble(txtPersonalMobile1.Text),Convert.ToDouble(txtPersonalMobile2.Text),Convert.ToDouble(txtFamilyMobile1.Text),Convert.ToDouble(txtFamilyMobile2.Text),txtReferenceName.Text,Convert.ToDouble(txtReferenceMobile.Text),cmbOriginalDoc.SelectedItem.ToString(),txtLastCompanyName.Text,txtLastWorkTime.Text,(int)cmbDepartment.SelectedValue,cmbDesignation.SelectedValue.ToString(),cmbEmployeecategory.SelectedItem.ToString(),cmbContract.SelectedValue.ToString(),getResidentialStatus(),getSalaryType(),Convert.ToDouble(txtSalary.Text),AdharPath,Pan_Path,Election_Path,txtAcHolderName.Text,txtBankName.Text,txtBranchName.Text,txtISFCCode.Text,Convert.ToDouble(txtAcNumber.Text));
                MessageBox.Show(abc);
            }
        }
        bool Form_Valid()
        {
            bool EmployeeName = EmployeeName_validation();
            bool Picture = Image_Validation();
            bool Gender = GenderValidation();
            bool Birthdate = BirthDateValidation();
            bool AdharNumber = AdharValidation();
            bool P_Address = Permanent_Address_Validation();
            bool Pincode = Pincode_Validation();
            bool P_Mobile = Personel_Mobile_Validation();
            bool F_Mobile = Family_Mobile1_Validation();
            bool F2_Mobile = Family_Mobile2_validation();
            bool R_Name = Reference_Name_Validation();
            bool R_Mobile = Reference_Mobile_Validation();
            bool O_Document = Original_Document_Validation();
            bool L_Company_Name = Last_Company_Name_Validation();
            bool L_Work_Time = Work_Time_Validation();
            bool C_Department = Department_Validation();
            bool C_Designation = Designation_Validation();
            bool C_Employee_Category = E_Category_Validation();
            bool C_Contractor = Contractor_Validation();
            bool C_Residential_Status = Residence_Status_Validation();
            bool C_SalaryType = SalaryTypeValidation();
            bool C_Salary = SalaryValidation();
            bool Adhar_Card = Adhar_Card_Validation();
            bool Pan_Card = Pan_Card_Validation();
            bool Election_Card = Election_Card_Validation();
            bool AC_Holder_Name = Account_HolderName_Validation();
            bool Bank_Name = Bank_Name_Validation();
            bool Branch_Name = Branch_Name_Validation();
            bool AC_Number = Ac_Number_Validation();
            bool IFSC = IFSC_Code_Validation();

            if (EmployeeName && Picture && Gender && Birthdate && AdharNumber && P_Address && Pincode && P_Mobile && F_Mobile && F2_Mobile && R_Name && R_Mobile && O_Document && L_Company_Name && L_Work_Time && C_Department && C_Designation && C_Employee_Category && C_Contractor && C_Residential_Status && C_SalaryType && C_Salary && Adhar_Card && Pan_Card && Election_Card && AC_Holder_Name && Bank_Name && Branch_Name && AC_Number && IFSC)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Common Function for Browse a file for Aadhar, Election and Pan.....
        void OpenFileDialog(TextBox txt, Button btn)
        {
            OpenFileDialog open_file = new OpenFileDialog();
            open_file.CheckFileExists = true;
            open_file.AddExtension = true;
            open_file.Multiselect = false;
            open_file.Filter = "PDF files (*.pdf)|*.pdf";
            if (open_file.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txt.Text = open_file.FileName;
                btn.Enabled = true;
            }
            else
            {
                btn.Enabled = false;
            }
        }
        //AadharDocument Upload Checkbox....
        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (Aadhar_checkbox.Checked == true)
            {
                OpenFileDialog(Aadhar_File_textbox, Aadhar_Button);
            }
            else
            {
                Aadhar_Button.Enabled = false;
            }
        }
        //PanCard Document Upload Checkbox....
        private void Pan_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (Pan_checkbox.Checked == true)
            {
                OpenFileDialog(Pan_textbox, Pan_Button);
            }
            else
            {
                Pan_Button.Enabled = false;
            }
        }
        //Election Card Document Upload Checkbox...
        private void Election_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (Election_checkbox.Checked == true)
            {
                OpenFileDialog(Election_textbox, Election_Button);
            }
            else
            {
                Election_Button.Enabled = false;
            }
        }

        //Common Function to Copy the file for Document...
        void copyFile(string Source, string Destination)
        {
            System.IO.File.Copy(Source, Destination, true);
            MessageBox.Show("File Uploaded Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Button to Upload Adhar Document...
        private void Aadhar_Button_Click(object sender, EventArgs e)
        {
            string filename = "Adhar_" + txtEmployeeName.Text + ".pdf";
            string destUrl = @"PDF\" + txtEmployeeName.Text;
            string SourcePath = Aadhar_File_textbox.Text;
            string setFileName = System.IO.Path.Combine(destUrl, filename);
            if (!System.IO.Directory.Exists("PDF"))
            {
                System.IO.Directory.CreateDirectory(destUrl);
                copyFile(SourcePath,setFileName);
                AdharPath = setFileName;
            }
            else if (!System.IO.Directory.Exists(destUrl))
            {
                System.IO.Directory.CreateDirectory(destUrl);
                copyFile(SourcePath, setFileName);
                AdharPath = setFileName;
            }
            else
            {
                copyFile(SourcePath, setFileName);
                AdharPath = setFileName;
            }
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Label27_Click(object sender, EventArgs e)
        {
            txtPincode.Focus();
        }
        private void Label33_Click(object sender, EventArgs e)
        {
            txtEmployeeName.Focus();
        }
        private void Label32_Click(object sender, EventArgs e)
        {
            dtBirthDate.Focus();
        }
        private void Label31_Click(object sender, EventArgs e)
        {
            txtAge.Focus();
        }
        private void Label30_Click(object sender, EventArgs e)
        {
            cmbSex.Focus();
        }
        private void Label29_Click(object sender, EventArgs e)
        {
            txtAdharFirst.Focus();
        }
        private void Label28_Click(object sender, EventArgs e)
        {
            txtPermanentAddress.Focus();
        }
        private void Label25_Click(object sender, EventArgs e)
        {
            txtPersonalMobile2.Focus();
        }
        private void Label26_Click(object sender, EventArgs e)
        {
            txtPersonalMobile1.Focus();
        }
        private void Label24_Click(object sender, EventArgs e)
        {
            txtFamilyMobile1.Focus();
        }
        private void Label23_Click(object sender, EventArgs e)
        {
            txtFamilyMobile2.Focus();
        }
        private void Label15_Click(object sender, EventArgs e)
        {
            txtReferenceName.Focus();
        }
        private void Label35_Click(object sender, EventArgs e)
        {
            txtReferenceMobile.Focus();
        }
        private void Label1_Click(object sender, EventArgs e)
        {
            cmbOriginalDoc.Focus();
        }
        private void Label14_Click(object sender, EventArgs e)
        {
            txtLastCompanyName.Focus();
        }
        private void Label13_Click(object sender, EventArgs e)
        {
            txtLastWorkTime.Focus();
        }
        private void Label20_Click(object sender, EventArgs e)
        {
            cmbDepartment.Focus();
        }
        private void Label37_Click(object sender, EventArgs e)
        {
            cmbDesignation.Focus();
        }
        private void Label21_Click(object sender, EventArgs e)
        {
            cmbEmployeecategory.Focus();
        }
        private void Label38_Click(object sender, EventArgs e)
        {
            cmbContract.Focus();
        }
        private void Label41_Click(object sender, EventArgs e)
        {
            txtSalary.Focus();
        }
        private void Label16_Click(object sender, EventArgs e)
        {
            txtAcHolderName.Focus();
        }
        private void Label36_Click(object sender, EventArgs e)
        {
            txtBankName.Focus();
        }
        private void Label17_Click(object sender, EventArgs e)
        {
            txtBranchName.Focus();
        }
        private void Label18_Click(object sender, EventArgs e)
        {
            txtAcNumber.Focus();
        }
        private void Label19_Click(object sender, EventArgs e)
        {
            txtISFCCode.Focus();
        }

        Image file;
        //Functionality of the Picturebox to get and show picture with copy...
        private void Picture_Browse_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "JPG (*.JPG)|*.jpg";
            //Copy File
            if (op.ShowDialog() == DialogResult.OK)
            {
                file = Image.FromFile(op.FileName);
                pictureBox1.Image = file;
                PictureBox_Path_textbox.Text = op.FileName;
                if (!System.IO.Directory.Exists("Employee_Image"))
                {
                    System.IO.Directory.CreateDirectory("Employee_Image");
                    System.IO.File.Copy(PictureBox_Path_textbox.Text, System.IO.Path.Combine("Employee_Image", System.IO.Path.GetFileName(PictureBox_Path_textbox.Text)), true);
                    ImagePath = System.IO.Path.Combine("Employee_Image", System.IO.Path.GetFileName(PictureBox_Path_textbox.Text)).ToString();
                }
                else
                {
                    System.IO.File.Copy(PictureBox_Path_textbox.Text, System.IO.Path.Combine("Employee_Image", System.IO.Path.GetFileName(PictureBox_Path_textbox.Text)), true);
                    ImagePath = System.IO.Path.Combine("Employee_Image", System.IO.Path.GetFileName(PictureBox_Path_textbox.Text)).ToString();
                }
            }
        }

        private void DtBirthDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime Dob = dtBirthDate.Value;
            DateTime Now = DateTime.Now;
            int Years = new DateTime(DateTime.Now.Subtract(Dob).Ticks).Year - 1;
            txtAge.Text = Years.ToString();
        }
        private void TxtAdharFirst_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtAdharFirst.Text, "[^0-9]"))
            {
                txtAdharFirst.Text = txtAdharFirst.Text.Remove(txtAdharFirst.Text.Length - 1);
            }
        }

        private void TxtAdharSecond_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtAdharSecond.Text, "[^0-9]"))
            {
                txtAdharSecond.Text = txtAdharSecond.Text.Remove(txtAdharSecond.Text.Length - 1);
            }
        }

        private void TxtAdharThird_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtAdharThird.Text, "[^0-9]"))
            {
                txtAdharThird.Text = txtAdharThird.Text.Remove(txtAdharThird.Text.Length - 1);
            }
        }
        bool EmployeeName_validation()
        {
            if (txtEmployeeName.Text == "" || txtEmployeeName.Text == null)
            {
                Employee_Name_ErrorProvider.SetError(txtEmployeeName, "Name is the Required Field.");
                return false;
            }
            else if (!Regex.Match(txtEmployeeName.Text, "^[a-zA-Z\\s]+$").Success)
            {
                Employee_Name_ErrorProvider.SetError(txtEmployeeName, "Please Enter the correct name.");
                return false;
            }
            else
            {
                Employee_Name_ErrorProvider.SetError(txtEmployeeName, "");
                return true;
            }
        }
        private void TxtPincode_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPincode.Text, "[^0-9\\s]"))
            {
                txtPincode.Text = txtPincode.Text.Remove(txtPincode.Text.Length - 1);
            }
        }

        private void EmployeeName_validating(object sender, CancelEventArgs e)
        {
            EmployeeName_validation();
        }

        private void GenderValidating(object sender, CancelEventArgs e)
        {
            GenderValidation();
        }
        bool GenderValidation()
        {
            if (!string.IsNullOrEmpty(cmbSex.SelectedText))
            {
                Sex_ErrorProvider.SetError(cmbSex, "Gender is Required Field.");
                return false;
            }
            else
            {
                Sex_ErrorProvider.SetError(cmbSex, "");
                return true;
            }
        }

        private void BirthDateValidating(object sender, CancelEventArgs e)
        {
            BirthDateValidation();
        }
        bool BirthDateValidation()
        {
            DateTime Dob = dtBirthDate.Value;
            DateTime Now = DateTime.Now;
            int Years = new DateTime(DateTime.Now.Subtract(Dob).Ticks).Year - 1;
            if (dtBirthDate.Value == DateTime.Now)
            {
                BirthDate_ErrorProvider.SetError(dtBirthDate, "Please Select Your Birthdate");
                return false;
            }
            else if (!(Years >= 18))
            {
                BirthDate_ErrorProvider.SetError(dtBirthDate, "Years Should be Greater than 18");
                return false;
            }
            else
            {
                BirthDate_ErrorProvider.SetError(dtBirthDate, "");
                return true;
            }
        }
        bool AdharValidation()
        {
            if (txtAdharFirst.Text.Length < 4)
            {
                AdharNumber_ErrorProvider.SetError(txtAdharThird, "Please Provide the Correct Aadhar Number");
                return false;
            }
            else if (txtAdharSecond.Text.Length < 4)
            {
                AdharNumber_ErrorProvider.SetError(txtAdharThird, "Please Provide the Correct Aadhar Number");
                return false;
            }
            else if (txtAdharThird.Text.Length < 4)
            {
                AdharNumber_ErrorProvider.SetError(txtAdharThird, "Please Provide the Correct Aadhar Number");
                return false;
            }
            else
            {
                AdharNumber_ErrorProvider.SetError(txtAdharThird, "");
                return true;
            }
        }

        private void First_Four_Adhar_Valdating(object sender, CancelEventArgs e)
        {
            AdharValidation();
        }

        private void Second_Four_Adhar_Validating(object sender, CancelEventArgs e)
        {
            AdharValidation();
        }

        private void Thirtd_Four_Adhar_Validating(object sender, CancelEventArgs e)
        {
            AdharValidation();
        }

        private void TxtPermanentAddress_Validating(object sender, CancelEventArgs e)
        {
            Permanent_Address_Validation();
        }
        bool Permanent_Address_Validation()
        {
            if (txtPermanentAddress.Text.Length <= 0)
            {
                P_Address_ErrorProvider.SetError(txtPermanentAddress, "This is Required Field.");
                return false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txtPermanentAddress.Text, "^[#.0-9a-zA-Z\\s,-]+$"))
            {
                P_Address_ErrorProvider.SetError(txtPermanentAddress, "Invalid Address.");
                return false;
            }
            else
            {
                P_Address_ErrorProvider.SetError(txtPermanentAddress, "");
                return true;
            }
        }

        private void Pincode_Validating(object sender, CancelEventArgs e)
        {
            Pincode_Validation();
        }
        bool Pincode_Validation()
        {
            if (txtPincode.Text.Length <= 0)
            {
                Pincode_ErrorProvider.SetError(txtPincode, "Pincode is Required Field.");
                return false;
            }
            else if (txtPincode.Text.Length != 6)
            {
                Pincode_ErrorProvider.SetError(txtPincode, "Invalid Pincode.");
                return false;
            }
            else
            {
                Pincode_ErrorProvider.SetError(txtPincode, "");
                return true;
            }
        }

        private void Personal_Mobile_Validating(object sender, CancelEventArgs e)
        {
            Personel_Mobile_Validation();
        }
        bool Personel_Mobile_Validation()
        {
            if (txtPersonalMobile1.Text.Length == 0)
            {
                P_Mobile_ErrorProvider.SetError(txtPersonalMobile1, "Required");
                return false;
            }
            else if (txtPersonalMobile1.Text.Length < 10)
            {
                P_Mobile_ErrorProvider.SetError(txtPersonalMobile1, "Invalid Personel Mobile Number");
                return false;
            }
            else
            {
                P_Mobile_ErrorProvider.SetError(txtPersonalMobile1, "");
                return true;
            }
        }

        private void TxtPersonalMobile1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPersonalMobile1.Text, "[^0-9]"))
            {
                txtPersonalMobile1.Text = txtPersonalMobile1.Text.Remove(txtPersonalMobile1.Text.Length - 1);
            }
        }

        private void TxtPersonalMobile2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPersonalMobile2.Text, "[^0-9]"))
            {
                txtPersonalMobile2.Text = txtPersonalMobile2.Text.Remove(txtPersonalMobile2.Text.Length - 1);
            }
        }

        private void TxtFamilyMobile1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtFamilyMobile1.Text, "[^0-9]"))
            {
                txtFamilyMobile1.Text = txtFamilyMobile1.Text.Remove(txtFamilyMobile1.Text.Length - 1);
            }
        }

        private void TxtFamilyMobile2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtFamilyMobile2.Text, "[^0-9]"))
            {
                txtFamilyMobile2.Text = txtFamilyMobile2.Text.Remove(txtFamilyMobile2.Text.Length - 1);
            }
        }

        private void Family_Mobile1_Validating(object sender, CancelEventArgs e)
        {
            Family_Mobile1_Validation();
        }
        bool Family_Mobile1_Validation()
        {
            if (txtFamilyMobile1.Text.Length == 0)
            {
                F_Mobile_ErrorProvider.SetError(txtFamilyMobile1, "Required");
                return false;
            }
            else if (txtPersonalMobile1.Text.Length < 10)
            {
                F_Mobile_ErrorProvider.SetError(txtFamilyMobile1, "Invalid Personel Mobile Number");
                return false;
            }
            else
            {
                F_Mobile_ErrorProvider.SetError(txtFamilyMobile1, "");
                return true;
            }
        }

        private void Family_Mobile2_Validating(object sender, CancelEventArgs e)
        {
            Family_Mobile2_validation();
        }
        bool Family_Mobile2_validation()
        {
            if (txtFamilyMobile2.Text.Length == 0)
            {
                F2_Mobile_ErrorProvider.SetError(txtFamilyMobile2, "Required");
                return false;
            }
            else if (txtPersonalMobile1.Text.Length < 10)
            {
                F2_Mobile_ErrorProvider.SetError(txtFamilyMobile2, "Invalid Personel Mobile Number");
                return false;
            }
            else
            {
                F2_Mobile_ErrorProvider.SetError(txtFamilyMobile2, "");
                return true;
            }
        }

        private void TxtReferenceName_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtReferenceName.Text, "[^a-zA-Z\\s]"))
            {
                txtReferenceName.Text = txtReferenceName.Text.Remove(txtReferenceName.Text.Length - 1);
            }
        }

        private void TxtReferenceMobile_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtReferenceMobile.Text, "[^0-9]"))
            {
                txtReferenceMobile.Text = txtReferenceMobile.Text.Remove(txtReferenceMobile.Text.Length - 1);
            }
        }

        private void Reference_Name_Validating(object sender, CancelEventArgs e)
        {
            Reference_Name_Validation();
        }
        bool Reference_Name_Validation()
        {
            if (txtReferenceName.Text.Length == 0)
            {
                Reference_Name_ErrorProvider.SetError(txtReferenceName, "Required");
                return false;
            }
            else
            {
                Reference_Name_ErrorProvider.SetError(txtReferenceName, "");
                return true;
            }
        }

        private void Reference_Mobile_Validating(object sender, CancelEventArgs e)
        {
            Reference_Mobile_Validation();
        }
        bool Reference_Mobile_Validation()
        {
            if (txtReferenceMobile.Text.Length == 0)
            {
                Reference_Mobile_ErrorProvider.SetError(txtReferenceMobile, "Required");
                return false;
            }
            else if (txtReferenceMobile.Text.Length != 10)
            {
                Reference_Mobile_ErrorProvider.SetError(txtReferenceMobile, "Invalid Mobile Number.");
                return false;
            }
            else
            {
                Reference_Mobile_ErrorProvider.SetError(txtReferenceMobile, "");
                return true;
            }
        }

        private void Original_Document_Validating(object sender, CancelEventArgs e)
        {
            Original_Document_Validation();
        }
        bool Original_Document_Validation()
        {
            if (!string.IsNullOrEmpty(cmbOriginalDoc.SelectedText))
            {
                O_Document_C_ErrorProvider.SetError(cmbOriginalDoc, "Required");
                return false;
            }
            else
            {
                O_Document_C_ErrorProvider.SetError(cmbOriginalDoc, "");
                return true;
            }
        }

        private void TxtLastCompanyName_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtLastCompanyName.Text, "[^a-zA-Z\\s]"))
            {
                txtLastCompanyName.Text = txtLastCompanyName.Text.Remove(txtLastCompanyName.Text.Length - 1);
            }
        }

        private void Last_Company_Name_Validating(object sender, CancelEventArgs e)
        {
            Last_Company_Name_Validation();
        }
        bool Last_Company_Name_Validation()
        {
            if (txtLastCompanyName.Text.Length == 0)
            {
                Company_Name_ErrorProvider.SetError(txtLastCompanyName, "Reqired");
                return false;
            }
            else
            {
                Company_Name_ErrorProvider.SetError(txtLastCompanyName, "");
                return true;
            }
        }

        private void Work_Time_Validating(object sender, CancelEventArgs e)
        {
            Work_Time_Validation();
        }
        bool Work_Time_Validation()
        {
            if (txtLastWorkTime.Text.Length == 0)
            {
                Work_Time_ErrorProvider.SetError(txtLastWorkTime, "Required");
                return false;
            }
            else
            {
                Work_Time_ErrorProvider.SetError(txtLastWorkTime, "");
                return true;
            }
        }

        private void Aadhar_Card_Validating(object sender, CancelEventArgs e)
        {
            Adhar_Card_Validation();
        }
        bool Adhar_Card_Validation()
        {
            if (Aadhar_File_textbox.Text.Length == 0)
            {
                Adhar_Document_ErrorProvider.SetError(Aadhar_Button, "Required");
                return false;
            }
            else
            {
                Adhar_Document_ErrorProvider.SetError(Aadhar_Button, "");
                return true;
            }
        }

        private void Pan_Card_Validating(object sender, CancelEventArgs e)
        {
            Pan_Card_Validation();
        }
        bool Pan_Card_Validation()
        {
            if (Pan_textbox.Text.Length <= 0)
            {
                Pan_ErrorProvider.SetError(Pan_Button, "Required");
                return false;
            }
            else
            {
                Pan_ErrorProvider.SetError(Pan_Button, "");
                return true;
            }
        }

        private void Election_Card_Validating(object sender, CancelEventArgs e)
        {
            Election_Card_Validation();
        }
        bool Election_Card_Validation()
        {
            if (Election_textbox.Text.Length <= 0)
            {
                Election_ErrorProvider.SetError(Election_Button, "Required");
                return false;
            }
            else
            {
                Election_ErrorProvider.SetError(Election_Button, "");
                return true;
            }
        }

        private void TxtAcHolderName_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtAcHolderName.Text, "[^a-zA-Z\\s]"))
            {
                txtAcHolderName.Text = txtAcHolderName.Text.Remove(txtAcHolderName.Text.Length - 1);
            }
        }

        private void Account_HolderName_Validating(object sender, CancelEventArgs e)
        {
            Account_HolderName_Validation();
        }
        bool Account_HolderName_Validation()
        {
            if (txtAcHolderName.Text.Length <= 0)
            {
                A_Name_ErrorProvider.SetError(txtAcHolderName, "Required");
                return false;
            }
            else
            {
                A_Name_ErrorProvider.SetError(txtAcHolderName, "");
                return true;
            }
        }

        private void TxtBankName_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtBankName.Text, "[^a-zA-Z\\s]"))
            {
                txtBankName.Text = txtBankName.Text.Remove(txtBankName.Text.Length - 1);
            }
        }

        private void BankName_Validating(object sender, CancelEventArgs e)
        {
            Bank_Name_Validation();
        }
        bool Bank_Name_Validation()
        {
            if (txtBankName.Text.Length <= 0)
            {
                Bank_Name_ErrorProvider.SetError(txtBankName, "Required");
                return false;
            }
            else
            {
                Bank_Name_ErrorProvider.SetError(txtBankName, "");
                return true;
            }
        }

        private void TxtBranchName_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtBranchName.Text, "[^a-zA-Z\\s]"))
            {
                txtBranchName.Text = txtBranchName.Text.Remove(txtBranchName.Text.Length - 1);
            }
        }

        private void Branch_Name_Validating(object sender, CancelEventArgs e)
        {
            Branch_Name_Validation();
        }
        bool Branch_Name_Validation()
        {
            if (txtBranchName.Text.Length <= 0)
            {
                Branch_Name_ErrorProvider.SetError(txtBranchName, "Required");
                return false;
            }
            else
            {
                Branch_Name_ErrorProvider.SetError(txtBranchName, "");
                return true;
            }
        }

        private void TxtAcNumber_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtAcNumber.Text, "[^0-9]"))
            {
                txtAcNumber.Text = txtAcNumber.Text.Remove(txtAcNumber.Text.Length - 1);
            }
        }

        private void Ac_Number_Validating(object sender, CancelEventArgs e)
        {
            Ac_Number_Validation();
        }
        bool Ac_Number_Validation()
        {
            if (txtAcNumber.Text.Length <= 0)
            {
                A_Number_ErrorProvider.SetError(txtAcNumber, "Required");
                return false;
            }
            else
            {
                A_Number_ErrorProvider.SetError(txtAcNumber, "");
                return true;
            }
        }
        private void TxtISFCCode_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtISFCCode.Text, "[^a-zA-Z0-9]"))
            {
                txtISFCCode.Text = txtISFCCode.Text.Remove(txtISFCCode.Text.Length - 1);
            }
        }

        private void IFSC_Code_Validating(object sender, CancelEventArgs e)
        {
            IFSC_Code_Validation();
        }
        bool IFSC_Code_Validation()
        {
            string regex = "^[A-Z]{4}0[A-Z0-9]{6}$";
            if (txtISFCCode.Text.Length <= 0)
            {
                IFSC_ErrorProvider.SetError(txtISFCCode, "Required");
                return false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txtISFCCode.Text, regex))
            {
                IFSC_ErrorProvider.SetError(txtISFCCode, "Invalid");
                return false;
            }
            else
            {
                IFSC_ErrorProvider.SetError(txtISFCCode, "");
                return true;
            }
        }

        private void Image_Validating(object sender, CancelEventArgs e)
        {
            Image_Validation();
        }
        bool Image_Validation()
        {
            if (PictureBox_Path_textbox.Text.Length <= 0)
            {
                picturebox_ErrorProvider.SetError(picture_Browse_Button, "Required");
                return false;
            }
            else
            {
                picturebox_ErrorProvider.SetError(picture_Browse_Button, "");
                return true;
            }
        }

        private void MasterRegistration_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mainDataSet4.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter1.Fill(this.mainDataSet4.Department);
            // TODO: This line of code loads data into the 'mainDataSet2.Contractor' table. You can move, or remove it, as needed.
            this.contractorTableAdapter.Fill(this.mainDataSet2.Contractor);
            // TODO: This line of code loads data into the 'mainDataSet1.Designation' table. You can move, or remove it, as needed.
            this.designationTableAdapter.Fill(this.mainDataSet1.Designation);
            // TODO: This line of code loads data into the 'mainDataSet.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.mainDataSet.Department);
        }

        private void TxtSalary_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtSalary.Text, "[^0-9]"))
            {
                txtSalary.Text = txtSalary.Text.Remove(txtSalary.Text.Length - 1);
            }
        }

        private void Salary_Validating(object sender, CancelEventArgs e)
        {
            SalaryValidation();
        }
        bool SalaryValidation()
        {
            if (txtSalary.Text.Length <= 0)
            {
                Salary_ErrorProvider.SetError(txtSalary, "Required");
                return false;
            }
            else
            {
                Salary_ErrorProvider.SetError(txtSalary, "");
                return true;
            }
        }

        private void Department_Validating(object sender, CancelEventArgs e)
        {
            Department_Validation();
        }
        bool Department_Validation()
        {
            if (!string.IsNullOrEmpty(cmbDepartment.SelectedText))
            {
                Department_ErrorProvider.SetError(cmbDepartment, "Required");
                return false;
            }
            else
            {
                Department_ErrorProvider.SetError(cmbDepartment, "");
                return true;
            }
        }

        private void Designation_Validating(object sender, CancelEventArgs e)
        {
            Designation_Validation();
        }
        bool Designation_Validation()
        {
            if (!string.IsNullOrEmpty(cmbDesignation.SelectedText))
            {
                Designation_ErrorProvider.SetError(cmbDesignation, "Required");
                return false;
            }
            else
            {
                Designation_ErrorProvider.SetError(cmbDesignation, "");
                return true;
            }
        }

        private void E_Category_Validating(object sender, CancelEventArgs e)
        {
            E_Category_Validation();
        }
        bool E_Category_Validation()
        {
            if (!string.IsNullOrEmpty(cmbEmployeecategory.SelectedText))
            {
                E_Category_ErrorProvider.SetError(cmbEmployeecategory, "Required");
                return false;
            }
            else
            {
                E_Category_ErrorProvider.SetError(cmbEmployeecategory, "");
                return true;
            }
        }

        private void Contractor_Validating(object sender, CancelEventArgs e)
        {
            Contractor_Validation();
        }
        bool Contractor_Validation()
        {
            if (!string.IsNullOrEmpty(cmbContract.SelectedText))
            {
                Contractor_ErrorProvider.SetError(cmbContract, "Required");
                return false;
            }
            else
            {
                Contractor_ErrorProvider.SetError(cmbContract, "");
                return true;
            }
        }

        private void Salary_Type_Validating(object sender, CancelEventArgs e)
        {
            SalaryTypeValidation();
        }
        bool SalaryTypeValidation()
        {
            if (rtbMonthlyBase.Checked == false && rtbFix.Checked == false && rtbDailyWages.Checked == false)
            {
                Salary_Type_ErrorProvider.SetError(rtbDailyWages, "Required Field");
                return false;
            }
            else
            {
                Salary_Type_ErrorProvider.SetError(rtbDailyWages, "");
                return true;
            }
        }
        string getSalaryType()
        {
            if (rtbMonthlyBase.Checked)
            {
                return rtbMonthlyBase.Text.ToString();
            }
            else if (rtbFix.Checked)
            {
                return rtbFix.Text.ToString();
            }
            else if (rtbDailyWages.Checked)
            {
                return rtbFix.Text.ToString();
            }
            else
            {
                return "None";
            }
        }
        string getResidentialStatus()
        {
            if (rtbWithoutRoom.Checked)
            {
                return rtbWithoutRoom.Text.ToString();
            }
            else if (rtbWithRoom.Checked)
            {
                return rtbWithRoom.Text.ToString();
            }
            else
            {
                return "None";
            }
        }
        private void FixSalary_Validating(object sender, CancelEventArgs e)
        {
            SalaryTypeValidation();
        }

        private void Pan_Button_Click_1(object sender, EventArgs e)
        {
            string filename = "Pan_" + txtEmployeeName.Text + ".pdf";
            string destUrl = @"PDF\" + txtEmployeeName.Text;
            string SourcePath = Pan_textbox.Text;
            string setFileName = System.IO.Path.Combine(destUrl, filename);
            if (!System.IO.Directory.Exists("PDF"))
            {
                System.IO.Directory.CreateDirectory(destUrl);
                copyFile(SourcePath, setFileName);
                Pan_Path = setFileName;
            }
            else if (!System.IO.Directory.Exists(destUrl))
            {
                System.IO.Directory.CreateDirectory(destUrl);
                copyFile(SourcePath,setFileName);
                Pan_Path = setFileName;
            }
            else
            {
                copyFile(SourcePath, setFileName);
                Pan_Path = setFileName;
            }
        }

        private void Election_Button_Click_1(object sender, EventArgs e)
        {

            string filename = "Election_" + txtEmployeeName.Text + ".pdf";
            string destUrl = @"PDF\" + txtEmployeeName.Text;
            string SourcePath = Election_textbox.Text;
            string setFileName = System.IO.Path.Combine(destUrl, filename);
            if (!System.IO.Directory.Exists("PDF"))
            {
                System.IO.Directory.CreateDirectory(destUrl);
                copyFile(SourcePath, setFileName);
                Election_Path = setFileName;
            }
            else if (!System.IO.Directory.Exists(destUrl))
            {
                System.IO.Directory.CreateDirectory(destUrl);
                copyFile(SourcePath, setFileName);
                Election_Path = setFileName;
            }
            else
            {
                copyFile(SourcePath, setFileName);
                Election_Path = setFileName;
            }
        }

        private void Daily_Wages_Validating(object sender, CancelEventArgs e)
        {
            SalaryTypeValidation();
        }

        private void Residence_Status_Validating(object sender, CancelEventArgs e)
        {
            Residence_Status_Validation();
        }
        bool Residence_Status_Validation()
        {
            if (rtbWithRoom.Checked == false && rtbWithoutRoom.Checked == false)
            {
                Residential_ErrorProvider.SetError(rtbWithoutRoom, "Required");
                return false;
            }
            else
            {
                Residential_ErrorProvider.SetError(rtbWithoutRoom, "");
                return true;
            }
        }
    }
}
