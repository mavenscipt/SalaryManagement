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
    public partial class frmUpad : Form
    {
        int UpadId=0;
        Operations op = new Operations();
        public frmUpad()
        {
            InitializeComponent();
        }

        private void Upad_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Now;
            ComboboxBind();
        }
        public void ComboboxBind()
        {
            cmb_Employee_Name.DataSource = new BindingSource(op.GetDataForCombo("select Id,Name from tblEmployeeDetails"), null);
            cmb_Employee_Name.DisplayMember = "Value";
            cmb_Employee_Name.ValueMember = "Key";
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            if (Save_Button.Text == "Save")
            {

                int EmployeeID = ((KeyValuePair<int, string>)cmb_Employee_Name.SelectedItem).Key;
                string Name = ((KeyValuePair<int, string>)cmb_Employee_Name.SelectedItem).Value;
                SqlCommand cmd1 = new SqlCommand("Select COUNT(*) from tblUpad where EmployeeId=@EmployeeId");
                cmd1.Parameters.AddWithValue("@EmployeeId",EmployeeID);
                cmd1.Connection = op.getConnection();
                int count = Convert.ToInt32(cmd1.ExecuteScalar());
                MessageBox.Show(count.ToString());
                if (count == 1)
                {
                    SqlCommand cmd = new SqlCommand("Update tblUpad set Amount+=@Amount,PendingAmount+=@P_Amount,Date=@date where EmployeeId=@E_Id");
                    cmd.Parameters.AddWithValue("@Amount", Convert.ToInt32(txt_amount.Text));
                    cmd.Parameters.AddWithValue("@P_Amount", Convert.ToInt32(txt_amount.Text));
                    cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value.ToString());
                    cmd.Parameters.AddWithValue("@E_Id", EmployeeID);
                    cmd.Connection = op.getConnection();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Success");
                    Bind();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("Insert into tblUpad(EmployeeId,Employee_Name,Amount,PendingAmount,Date) values(@employeeid,@EmployeeName,@amount,@P_Amount,@date)");
                    cmd.Parameters.AddWithValue("@employeeid", EmployeeID);
                    cmd.Parameters.AddWithValue("@EmployeeName", Name);
                    cmd.Parameters.AddWithValue("@amount", Convert.ToInt32(txt_amount.Text));
                    cmd.Parameters.AddWithValue("@P_Amount", Convert.ToInt32(txt_amount.Text));
                    cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value.ToString());
                    cmd.Connection = op.getConnection();
                    cmd.ExecuteNonQuery();
                }
            }
            else if (Save_Button.Text == "Update")
            {
                int EmployeeID = ((KeyValuePair<int, string>)cmb_Employee_Name.SelectedItem).Key;
                int amount = Convert.ToInt32(txt_amount.Text);
                int pending_amount = Convert.ToInt32(txt_amount.Text);
                SqlCommand cmd = new SqlCommand("Select * from tblUpad where EmployeeId=@E_ID");
                cmd.Parameters.AddWithValue("@E_ID", EmployeeID);
                DataTable dt = new DataTable();
                cmd.Connection = op.getConnection();
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    sdr.Read();
                    if ((amount < int.Parse(sdr["Amount"].ToString())) || (amount > int.Parse(sdr["Amount"].ToString())))
                    {
                        SqlCommand cmd1 = new SqlCommand("Update tblUpad set Amount=@Amount,PendingAmount=@P_Amount-RecoveredAmount,Date=@date where EmployeeId=@E_Id");
                        cmd1.Parameters.AddWithValue("@Amount", amount);
                        cmd1.Parameters.AddWithValue("@P_Amount", pending_amount);
                        cmd1.Parameters.AddWithValue("@date", dateTimePicker1.Value.ToString());
                        cmd1.Parameters.AddWithValue("@E_Id", EmployeeID);
                        cmd1.Connection = op.getConnection();
                        cmd1.ExecuteNonQuery();
                        MessageBox.Show("Success");
                        Bind();
                    }
                    else
                    {
                        SqlCommand cmd2 = new SqlCommand("Update tblUpad set Amount=@Amount,PendingAmount=@P_Amount,Date=@date where EmployeeId=@E_Id");
                        cmd2.Parameters.AddWithValue("@Amount", amount);
                        cmd2.Parameters.AddWithValue("@P_Amount", pending_amount);
                        cmd2.Parameters.AddWithValue("@date", dateTimePicker1.Value.ToString());
                        cmd2.Parameters.AddWithValue("@E_Id", EmployeeID);
                        cmd2.Connection = op.getConnection();
                        cmd2.ExecuteNonQuery();
                        MessageBox.Show("Success");
                        Bind();
                    }
                }
            }
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Reset();
            if (radioButton2.Checked == true)
            {
                Save_Button.Text = "Update";
            }
            else
            {
                dataGridView1.Visible = false;
                txt_amount.Clear();
                cmb_Employee_Name.ResetText();
                dateTimePicker1.ResetText();
            }
        }

        private void Cmb_Employee_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                if (cmb_Employee_Name.SelectedText == "Select")
                {
                    dataGridView1.Visible = false;
                }
                else
                {
                    dataGridView1.Visible = true;
                    Bind();
                }
            }
            if (radioButton3.Checked == true)
            {
                if (cmb_Employee_Name.SelectedText == "Select")
                {
                    dataGridView1.Visible = false;
                }
                else
                {
                    dataGridView1.Visible = true;
                    Bind();
                }
            }
        }
        void Bind()
        {
            SqlCommand cmd = new SqlCommand("Select * from tblUpad where EmployeeId=@E_Id Order By Id DESC");
            int E_Id = ((KeyValuePair<int, string>)cmb_Employee_Name.SelectedItem).Key;
            cmd.Parameters.AddWithValue("@E_Id", E_Id);
            cmd.Connection = op.getConnection();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt != null && dt.Rows.Count > 0)
            {
                dataGridView1.Visible = true;
                dataGridView1.DataSource = dt;
                int Amount = Convert.ToInt32((from DataRow dr in dt.Rows where (int)dr["EmployeeId"] == E_Id select dr["Amount"]).FirstOrDefault());
                txt_amount.Text = Amount.ToString();
                DateTime date=(DateTime)(from DataRow dr in dt.Rows where (int)dr["EmployeeId"] == E_Id select dr["Date"]).FirstOrDefault();
                dateTimePicker1.Value = Convert.ToDateTime(date.Date.ToShortDateString());
            }
            else
            {
                dataGridView1.DataSource = null;
                dataGridView1.Visible = false;
                txt_amount.ResetText();
                dateTimePicker1.ResetText();
            }
        }
        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Save_Button.Text = "Save";
            dataGridView1.Visible = false;
            Reset();
        }
        void Reset()
        {
            label2.Visible = true;
            label3.Visible = true;
            txt_amount.Visible = true;
            dateTimePicker1.Visible = true;
            Save_Button.Visible = true;
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = false;
            label3.Visible = false;
            txt_amount.Visible = false;
            dateTimePicker1.Visible = false;
            Save_Button.Visible = false;
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int EmployeeID = ((KeyValuePair<int, string>)cmb_Employee_Name.SelectedItem).Key;
            string EmployeeName = ((KeyValuePair<int, string>)cmb_Employee_Name.SelectedItem).Value;
            DialogResult Result = MessageBox.Show("Are You Sure You Want to Delete Kharchi", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result==DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("Delete from tblUpad where EmployeeId=@E_id and Id=@U_id");
                cmd.Parameters.AddWithValue("@E_id", EmployeeID);
                cmd.Parameters.AddWithValue("@U_id", UpadId);
                cmd.Connection = op.getConnection();
                int result = cmd.ExecuteNonQuery();
                if (result>0)
                {
                    MessageBox.Show("Upad Delete Successfully...");
                }
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
            }
        }
    }
}
