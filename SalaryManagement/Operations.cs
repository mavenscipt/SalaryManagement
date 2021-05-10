using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
namespace SalaryManagement
{
    class Operations
    {        
        public int UpdateId;
        public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SalaryMainDb.mdf;Integrated Security=True;MultipleActiveResultSets=True");
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
            //cmd.Connection = getConnection();
            cmd.CommandType = CommandType.StoredProcedure;
            return cmd.ExecuteNonQuery();        
        }
        public string DeleteData(int Id)
        {
            SqlCommand cmd = new SqlCommand("Delete from tblEmployeeDetails where ID=@Id");
            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.Connection = getConnection();
            cmd.ExecuteNonQuery();
            return "Success";
        }
        //public int UserExisting(string users)
        //{
        //    SqlCommand cmd = new SqlCommand("SPGetUserCount");
        //    cmd.Parameters.AddWithValue("Username", users);
        //    SqlParameter Parm = new SqlParameter();
        //    var returnparameters = cmd.Parameters.Add("count",SqlDbType.Int);
        //    returnparameters.Direction = ParameterDirection.ReturnValue;
        //    cmd.Connection = getConnection();
        //    cmd.CommandType = CommandType.StoredProcedure;
        //     cmd.ExecuteNonQuery();        
        //    return (int)returnparameters.Value;
        //}
        public Dictionary<int, string> GetDataForCombo(string query)
        {
            Dictionary<int, string> Result = new Dictionary<int, string>();
            Result.Add(0, "Select");
            SqlCommand cmd = new SqlCommand(query);
            cmd.Connection = getConnection();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Result.Add(Convert.ToInt32(dr[0].ToString()), dr[1].ToString());
            }
            return Result;
        }
        public Dictionary<int, string> GetEmployeeName()
        {
            Dictionary<int, string> Employee = new Dictionary<int, string>();
            Employee.Add(0, "Select");
            SqlCommand cmd = new SqlCommand("Select Id,Name from tblEmployeeDetails");
            cmd.Connection = getConnection();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Employee.Add(Convert.ToInt32(dr[0].ToString()), dr[1].ToString());
            }
            return Employee;
        }
        //public Dictionary<int,string> GetUserName()
        //{
        //    Dictionary<int,string> Users = new Dictionary<int,string>();
        //    Users.Add(0, "Select");
        //    SqlCommand cmd = new SqlCommand("SPSelectAllUsers");
        //    cmd.Connection = getConnection();
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    SqlDataReader dr = cmd.ExecuteReader();
        //    while (dr.Read())
        //    {
        //        Users.Add(Convert.ToInt32(dr[0].ToString()), dr[1].ToString());        
        //    }
        //    return Users;
        //}
        //public int ChangePassword(string User,string Password)
        //{
        //    SqlCommand cmd = new SqlCommand("SPUpdatePassword");
        //    cmd.Parameters.AddWithValue("Username", User);
        //    cmd.Parameters.AddWithValue("Password", Password);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Connection = getConnection();
        //    return cmd.ExecuteNonQuery();         
        //}
        //public int DeleteUsers(string username)
        //{
        //    SqlCommand cmd = new SqlCommand("SPDeleteuser");
        //    cmd.Connection = getConnection();
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("Username",username);
        //    return cmd.ExecuteNonQuery();
        //}
        public string InsertEmployee(string EmployeeName,string Photo, string Sex, string BirthDate, int Age,  Double Adhar, string P_Address, int Pincode, Double PersonalMobile, Double PersonalMobile2, Double FamilyMobile, Double FamilyMobil2, string ReferenceName, double ReferenceMobile, string OrignalDoc, string LastCompanyName, string LastCompanyWorkingTime, int Department, string Designation, string EmployeeCategory, string Contractor, string ResidenceStatus, string SalaryType, double salary, string Adhar_Card,string Pan_Card,string Election_Card, string BankAccountHolderName, string BankName, string BranchName, string ISFCCode, double AccountNumber)
        {
            SqlCommand cmd = new SqlCommand("Insert into tblEmployeeDetails(Name,Photo,Sex,BirthDate,Age,AdharNo,PermanentAddress,Pincode,PersonalMobile,PersonalMobile2,FamilyContact,FamilyContact2,ReferenceName,ReferenceMobile,OrignalDocumentSubmited,LastCompanyName,LastCompanyWorkTime,Department,Designation,EmployeeCategory,Contractor,ResidenceStatus,SalaryType,Salary,Adharcard,Electioncard,Pancard,BankAcHolderName,Branch,AcNumber,ISFCCode,BankName) values(@Name,@Photo,@Sex,@Birthdate,@Age,@AdharNo,@P_Address,@Pincode,@P_Mobile1,@P_Mobile2,@F_Mobile1,@F_Mobile2,@R_Name,@R_Mobile,@O_Doc_Submitted,@L_Company_Name,@L_WorkTime,@Dept,@Designation,@E_Category,@Contractor,@R_Status,@S_Type,@Salary,@Adhar,@Election,@Pan,@B_A_H_Name,@BR_Name,@AC_Number,@ISFC_Code,@B_Name)");
            Console.WriteLine();
            cmd.Parameters.AddWithValue("@Name", EmployeeName);
            cmd.Parameters.AddWithValue("@Photo", Photo);
            cmd.Parameters.AddWithValue("@Sex", Sex);
            cmd.Parameters.AddWithValue("@Birthdate", Convert.ToDateTime(BirthDate));
            cmd.Parameters.AddWithValue("@Age", Age);
            cmd.Parameters.AddWithValue("@AdharNo", Adhar);
            cmd.Parameters.AddWithValue("@P_Address", P_Address);
            cmd.Parameters.AddWithValue("@Pincode", Pincode);
            cmd.Parameters.AddWithValue("@P_Mobile1", PersonalMobile);
            cmd.Parameters.AddWithValue("@P_Mobile2", PersonalMobile2);
            cmd.Parameters.AddWithValue("@F_Mobile1", FamilyMobile);
            cmd.Parameters.AddWithValue("@F_Mobile2", FamilyMobil2);
            cmd.Parameters.AddWithValue("@R_Name", ReferenceName);
            cmd.Parameters.AddWithValue("@R_Mobile", ReferenceMobile);
            cmd.Parameters.AddWithValue("@O_Doc_Submitted", OrignalDoc);
            cmd.Parameters.AddWithValue("@L_Company_Name", LastCompanyName);
            cmd.Parameters.AddWithValue("@L_WorkTime", LastCompanyWorkingTime);
            cmd.Parameters.AddWithValue("@Dept", Department);
            cmd.Parameters.AddWithValue("@Designation", Designation);
            cmd.Parameters.AddWithValue("@E_Category", EmployeeCategory);
            cmd.Parameters.AddWithValue("@Contractor", Contractor);
            cmd.Parameters.AddWithValue("@R_Status", ResidenceStatus);
            cmd.Parameters.AddWithValue("@S_Type", SalaryType);
            cmd.Parameters.AddWithValue("@Salary", salary);
            cmd.Parameters.AddWithValue("@Adhar", Adhar_Card);
            cmd.Parameters.AddWithValue("@Election", Election_Card);
            cmd.Parameters.AddWithValue("@Pan", Pan_Card);
            cmd.Parameters.AddWithValue("@B_A_H_Name", BankAccountHolderName);
            cmd.Parameters.AddWithValue("@B_Name", BankName);
            cmd.Parameters.AddWithValue("@BR_Name", BranchName);
            cmd.Parameters.AddWithValue("@ISFC_Code", ISFCCode);
            cmd.Parameters.AddWithValue("@AC_Number", AccountNumber);
            cmd.Connection = getConnection();
               cmd.ExecuteNonQuery();            
            return "Success";
        }
        public string UpdateData(int id,string EmployeeName, string Photo, string Sex, string BirthDate, int Age, Double Adhar, string P_Address, int Pincode, Double PersonalMobile, Double PersonalMobile2, Double FamilyMobile, Double FamilyMobil2, string ReferenceName, double ReferenceMobile, string OrignalDoc, string LastCompanyName, string LastCompanyWorkingTime, int Department, string Designation, string EmployeeCategory, string Contractor, string ResidenceStatus, string SalaryType, double salary, string Adhar_Card, string Pan_Card, string Election_Card, string BankAccountHolderName, string BankName, string BranchName, string ISFCCode, double AccountNumber)
        {
            SqlCommand cmd = new SqlCommand("Update tblEmployeeDetails set Name=@Name,Photo=@Photo,Sex=@Sex,BirthDate=@Birthdate,Age=@Age,AdharNo=@AdharNo,PermanentAddress=@P_Address,Pincode=@Pincode,PersonalMobile=@P_Mobile1,PersonalMobile2=@P_Mobile2,FamilyContact=@F_Mobile1,FamilyContact2=@F_Mobile2,ReferenceName=@R_Name,ReferenceMobile=@R_Mobile,OrignalDocumentSubmited=@O_Doc_Submitted,LastCompanyName=@L_Company_Name,LastCompanyWorkTime=@L_WorkTime,Department=@Dept,Designation=@Designation,EmployeeCategory=@E_Category,Contractor=@Contractor,ResidenceStatus=@R_Status,SalaryType=@S_Type,Salary=@Salary,Adharcard=@Adhar,Electioncard=@Election,Pancard=@Pan,BankAcHolderName=@B_A_H_Name,Branch=@BR_Name,AcNumber=@AC_Number,ISFCCode=@ISFC_Code,BankName=@B_Name where Id=@Id");
            cmd.Parameters.AddWithValue("@Id",id);
            cmd.Parameters.AddWithValue("@Name", EmployeeName);
            cmd.Parameters.AddWithValue("@Photo", Photo);
            cmd.Parameters.AddWithValue("@Sex", Sex);
            cmd.Parameters.AddWithValue("@Birthdate", Convert.ToDateTime(BirthDate));
            cmd.Parameters.AddWithValue("@Age", Age);
            cmd.Parameters.AddWithValue("@AdharNo", Adhar);
            cmd.Parameters.AddWithValue("@P_Address", P_Address);
            cmd.Parameters.AddWithValue("@Pincode", Pincode);
            cmd.Parameters.AddWithValue("@P_Mobile1", PersonalMobile);
            cmd.Parameters.AddWithValue("@P_Mobile2", PersonalMobile2);
            cmd.Parameters.AddWithValue("@F_Mobile1", FamilyMobile);
            cmd.Parameters.AddWithValue("@F_Mobile2", FamilyMobil2);
            cmd.Parameters.AddWithValue("@R_Name", ReferenceName);
            cmd.Parameters.AddWithValue("@R_Mobile", ReferenceMobile);
            cmd.Parameters.AddWithValue("@O_Doc_Submitted", OrignalDoc);
            cmd.Parameters.AddWithValue("@L_Company_Name", LastCompanyName);
            cmd.Parameters.AddWithValue("@L_WorkTime", LastCompanyWorkingTime);
            cmd.Parameters.AddWithValue("@Dept", Department);
            cmd.Parameters.AddWithValue("@Designation", Designation);
            cmd.Parameters.AddWithValue("@E_Category", EmployeeCategory);
            cmd.Parameters.AddWithValue("@Contractor", Contractor);
            cmd.Parameters.AddWithValue("@R_Status", ResidenceStatus);
            cmd.Parameters.AddWithValue("@S_Type", SalaryType);
            cmd.Parameters.AddWithValue("@Salary", salary);
            cmd.Parameters.AddWithValue("@Adhar", Adhar_Card);
            cmd.Parameters.AddWithValue("@Election", Election_Card);
            cmd.Parameters.AddWithValue("@Pan", Pan_Card);
            cmd.Parameters.AddWithValue("@B_A_H_Name", BankAccountHolderName);
            cmd.Parameters.AddWithValue("@B_Name", BankName);
            cmd.Parameters.AddWithValue("@BR_Name", BranchName);
            cmd.Parameters.AddWithValue("@ISFC_Code", ISFCCode);
            cmd.Parameters.AddWithValue("@AC_Number", AccountNumber);
            cmd.Connection = getConnection();
            cmd.ExecuteNonQuery();
            Console.WriteLine("Data Stored Successfully");
            return "Updated";
        }
    }
}