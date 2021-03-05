using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Drawing;
namespace SalaryManagement
{
   
    class Operations
    {
        
        public SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Maindb.mdf;Integrated Security=True;User Instance=True;MultipleActiveResultSets=True");
        public SqlConnection getConnection()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public int CreateUsers(string users,string Pass,int Role)
        {
                SqlCommand cmd = new SqlCommand("SPCreateUser");
                cmd.Parameters.AddWithValue("Username", users);
                cmd.Parameters.AddWithValue("Password", Pass);
                cmd.Parameters.AddWithValue("Role", Role);
                cmd.Connection = getConnection();
                cmd.CommandType = CommandType.StoredProcedure;
                return cmd.ExecuteNonQuery();        
        }
        public int UserExisting(string users)
        {
            SqlCommand cmd = new SqlCommand("SPGetUserCount");
            cmd.Parameters.AddWithValue("Username", users);
            SqlParameter Parm = new SqlParameter();
            var returnparameters = cmd.Parameters.Add("count",SqlDbType.Int);
            returnparameters.Direction = ParameterDirection.ReturnValue;
            
            cmd.Connection = getConnection();
            cmd.CommandType = CommandType.StoredProcedure;
             cmd.ExecuteNonQuery();        
            return (int)returnparameters.Value;
        }
        public Dictionary<int,string> GetUserName()
        {
            Dictionary<int,string> Users = new Dictionary<int,string>();
            Users.Add(0, "Select");
            SqlCommand cmd = new SqlCommand("SPSelectAllUsers");
            cmd.Connection = getConnection();
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Users.Add(Convert.ToInt32(dr[0].ToString()), dr[1].ToString());        
            }
            return Users;
        }
        public int ChangePassword(string User,string Password)
        {
            SqlCommand cmd = new SqlCommand("SPUpdatePassword");
            cmd.Parameters.AddWithValue("Username", User);
            cmd.Parameters.AddWithValue("Password", Password);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = getConnection();
            return cmd.ExecuteNonQuery();         
        }
        public int DeleteUsers(string username)
        {
            SqlCommand cmd = new SqlCommand("SPDeleteuser");
            cmd.Connection = getConnection();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Username",username);
            return cmd.ExecuteNonQuery();
        }

        public int InsertEmployee(string EmployeeName, string BirthDate, int Age, string Sex, int Adhar1, int Adhar2, int Adhar3, string Permanent, int Pincode, Double PersonalMobile, Double PersonalMobile2, Double FamilyMobile, Double FamilyMobil2, string OrignalDoc, string ReferenceName, double ReferenceMobile, string BankAccountHolderName, string BankName, string BranchName, string ISFCCode, double AccountNumber, string LastCompanyName, string LastCompanyWorkingTime, int Department, string Designation, string EmployeeCategory, string Contractor, string ResidenceStatus, string SalaryType, double salary,DateTime JoiningDate)
        {


            SqlCommand cmd = new SqlCommand("INSERT INTO tblEmployeeDetails (Name, BirthDate, Age, Sex, AdharNo, JoiningDate, PermanentAddress, PermanentPincode, PersonalMobile, PersonalMobile2, FamilyContact, FamilyContact2, LastCompanyName, LastCompanyWorkTime,OrignalDocumentSubmited, BankAcHolderName, BankName, Branch, AcNumber, ISFCCode, Reference, ReferenceMobile, Department, EmployeeCategory, Designation, ContractorType, SalaryType,Residencestatus) VALUES (@Name,@Birthdate,@Age,@Sex,@AdharNo,@JoiningDate,@Permanent,@Pincode,@PersonalMobile1,@PersonalMobile2,@FamilyMobile,@FamilyMobil2,@LastCompanyName,@LastCompanyWorkingTime,@OrignalDoc,@BankAccountHolderName,@BankName,@BranchName,@AccountNumber,@ISFCCode,@ReferenceName,@ReferenceMobile,@Department,@EmployeeCategory,@Designation,@Contractor,@SalaryType,@ResidenceStatus)");
                //@BankAccountHolderName,@BankName,@BranchName,@AccountNumber,@ISFCCode,@ReferenceName,@ReferenceMobile,@Department,@EmployeeCategory,@Designation,@Contractor,@SalaryType,@ResidenceStatus)");
            string adhar1 = Adhar1.ToString();
            string adhar2 = Adhar2.ToString();
            string adhar3 = Adhar3.ToString();
            string Adhar = Adhar1 + "" + Adhar2 + "" + Adhar3;
            //(@EmployeeCategory,@Designation,@Contractor,@SalaryType,@ResidenceStatus,@Adhar)
            cmd.Parameters.AddWithValue("@Name",EmployeeName);
            cmd.Parameters.AddWithValue("@Birthdate",BirthDate);
            cmd.Parameters.AddWithValue("@Age",Age);
            cmd.Parameters.AddWithValue("@Sex", Sex);
            cmd.Parameters.AddWithValue("@AdharNo", Convert.ToInt64(Adhar));
            cmd.Parameters.AddWithValue("@JoiningDate", JoiningDate);           
            cmd.Parameters.AddWithValue("@Permanent", Permanent);
            cmd.Parameters.AddWithValue("@Pincode", Pincode);
             cmd.Parameters.AddWithValue("@PersonalMobile1", PersonalMobile);
             cmd.Parameters.AddWithValue("@PersonalMobile2", PersonalMobile2);
             cmd.Parameters.AddWithValue("@FamilyMobile", FamilyMobile);
             cmd.Parameters.AddWithValue("@FamilyMobil2", FamilyMobil2);
             cmd.Parameters.AddWithValue("@LastCompanyName", LastCompanyName);
             cmd.Parameters.AddWithValue("@LastCompanyWorkingTime", LastCompanyWorkingTime);
             cmd.Parameters.AddWithValue("@OrignalDoc", OrignalDoc);
             cmd.Parameters.AddWithValue("@BankAccountHolderName", BankAccountHolderName);
             cmd.Parameters.AddWithValue("@BankName", BankName);
             cmd.Parameters.AddWithValue("@BranchName", BranchName);
             cmd.Parameters.AddWithValue("@AccountNumber", AccountNumber);
             cmd.Parameters.AddWithValue("@ISFCCode", ISFCCode);
             cmd.Parameters.AddWithValue("@ReferenceName", ReferenceName);
             cmd.Parameters.AddWithValue("@ReferenceMobile", ReferenceMobile);
             cmd.Parameters.AddWithValue("@Department", Department);
             cmd.Parameters.AddWithValue("@EmployeeCategory", EmployeeCategory);
             cmd.Parameters.AddWithValue("@Designation", Designation);
             cmd.Parameters.AddWithValue("@Contractor", Contractor);
             cmd.Parameters.AddWithValue("@SalaryType", SalaryType);
             cmd.Parameters.AddWithValue("@ResidenceStatus", ResidenceStatus);
 

            cmd.Connection = getConnection();
            return cmd.ExecuteNonQuery();
            
            //return 0;
        }

        public string ImageToBase64(Image image,System.Drawing.Imaging.ImageFormat format)
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
