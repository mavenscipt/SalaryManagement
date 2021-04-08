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
    public partial class Upad : Form
    {
        int UpadId=0;
        Operations op = new Operations();
        public Upad()
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
                SqlCommand cmd = new SqlCommand("Insert into tblUpad(EmployeeId,Amount,PendingAmount,Date) values(@employeeid,@amount,@P_Amount,@date)");
                cmd.Parameters.AddWithValue("@employeeid", Convert.ToInt32(cmb_Employee_Name.SelectedValue));
                cmd.Parameters.AddWithValue("@amount", Convert.ToInt32(txt_amount.Text));
                cmd.Parameters.AddWithValue("@P_Amount", Convert.ToInt32(txt_amount.Text));
                cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value.ToString());
                cmd.Connection = op.getConnection();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Success");
            }
            else if (Save_Button.Text == "Update")
            {
                SqlCommand cmd = new SqlCommand("Update tblUpad set Amount=@Amount,PendingAmount=@P_Amount,Date=@date where EmployeeId=@E_Id");
                cmd.Parameters.AddWithValue("@Amount", Convert.ToInt32(txt_amount.Text));
                cmd.Parameters.AddWithValue("@P_Amount",Convert.ToInt32(txt_amount.Text));
                cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value.ToString());
                cmd.Parameters.AddWithValue("@E_Id", cmb_Employee_Name.SelectedValue);
                cmd.Connection = op.getConnection();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Success");
                Bind();
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
                dateTimePicker1.Value = (DateTime)(from DataRow dr in dt.Rows where (int)dr["EmployeeId"] == E_Id select dr["Date"]).FirstOrDefault();
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
