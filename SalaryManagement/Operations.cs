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

        public int InsertEmployee(string EmployeeName, string BirthDate, int Age, string Sex, int Adhar1, int Adhar2, int Adhar3, string Permanent, int Pincode, Double PersonalMobile, Double PersonalMobile2, Double FamilyMobile, Double FamilyMobil2, string OrignalDoc, string ReferenceName, double ReferenceMobile, string BankAccountHolderName, string BankName, string BranchName, string ISFCCode, double AccountNumber, string LastCompanyName, string LastCompanyWorkingTime, string Department, string Designation, string EmployeeCategory, string Contractor, string ResidenceStatus, string SalaryType, double salary)
        {
            SqlCommand cmd = new SqlCommand("Insert into tblEmployeeMaster");
            cmd.Connection = getConnection();
            
            return 0;
        }

      
    }
}
