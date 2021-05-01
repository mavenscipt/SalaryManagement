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
    public partial class View_Details : Form
    {
        public int ViewId;
        public View_Details()
        {
            InitializeComponent();
        }


        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Comming Soon","Comming Soon",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void View_Details_Load(object sender, EventArgs e)
        {
            Operations op = new Operations();
            SqlCommand cmd = new SqlCommand("Select * from tblEmployeeDetails Where Id=@Id");
            cmd.Parameters.AddWithValue("@ID", ViewId);
            cmd.Connection = op.getConnection();
            //Getting Data from the Form.....
            using (SqlDataReader sdr = cmd.ExecuteReader())
            {
                sdr.Read();
                lbl_Name.Text = sdr["Name"].ToString();
                lbl_ImagePath.Text = sdr["Photo"].ToString();
                pictureBox1.ImageLocation = sdr["Photo"].ToString();
                lbl_Gender.Text = sdr["Sex"].ToString();
                lbl_BirthDate.Text = sdr["BirthDate"].ToString();
                lbl_age.Text = sdr["Age"].ToString();
                lbl_AdharNumber.Text= sdr["AdharNo"].ToString();
                lbl_Address.Text = sdr["PermanentAddress"].ToString();
                lbl_Pincode.Text = sdr["Pincode"].ToString();
                lbl_Personal_Mobile.Text = sdr["PersonalMobile"].ToString();
                lbl_Personal_Mobile_2.Text = sdr["PersonalMobile2"].ToString();
                lbl_Family_Mobile_Number.Text = sdr["FamilyContact"].ToString();
                lbl_Family_Mobile_Number_2.Text = sdr["FamilyContact2"].ToString();
                lbl_Reference_Name.Text = sdr["ReferenceName"].ToString();
                lbl_Reference_Mobile.Text = sdr["ReferenceMobile"].ToString();
                lbl_Original_Document.Text = sdr["OrignalDocumentSubmited"].ToString();
                lbl_Last_Company_Name.Text = sdr["LastCompanyName"].ToString();
                lbl_Last_Company_Work_Time.Text = sdr["LastCompanyWorkTime"].ToString();
                lbl_Department.Text= sdr["Department"].ToString();
                lbl_Designation.Text= sdr["Designation"].ToString();
                lbl_Employee_Category.Text = sdr["EmployeeCategory"].ToString();
                lbl_Contractor.Text = sdr["Contractor"].ToString();
                lbl_Residential_Status.Text= sdr["Residencestatus"].ToString();
                lbl_Salary_Type.Text = sdr["SalaryType"].ToString();
                lbl_salary.Text = sdr["Salary"].ToString();
                lbl_AdharCard.Text = sdr["Adharcard"].ToString();
                lbl_Pancard.Text = sdr["Pancard"].ToString();
                lbl_ElectionCard.Text = sdr["Electioncard"].ToString();
                lbl_Ac_Holder_Name.Text = sdr["BankAcHolderName"].ToString();
                lbl_Branch_Name.Text = sdr["Branch"].ToString();
                lbl_Ac_Number.Text = sdr["AcNumber"].ToString();
                lbl_IFSC_Code.Text = sdr["ISFCCode"].ToString();
                lbl_Bank_Name.Text = sdr["BankName"].ToString();
            }
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void brn_ViewAdhar_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(lbl_AdharCard.Text);
        }

        private void btn_ViewPan_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(lbl_Pancard.Text);
        }

        private void btn_ViewElection_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(lbl_ElectionCard.Text);
        }
    }
}
