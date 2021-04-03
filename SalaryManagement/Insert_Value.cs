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
    public partial class Insert_Value : Form
    {
        Operations Op = new Operations();
        public Insert_Value()
        {
            InitializeComponent();
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                Department_groupbox.Visible = true;
            }
            else
            {
                Department_groupbox.Visible = false;
            }
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                Designation_groupbox.Visible = true;
            }
            else
            {
                Designation_groupbox.Visible = false;
            }
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                Contractor_groupbox.Visible = true;
            }
            else
            {
                Contractor_groupbox.Visible = false;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Department(Name) Values(@name)",Op.con);
            cmd.Parameters.AddWithValue("@name",Dept_Name_text.Text);
            cmd.Connection = Op.getConnection();
            cmd.ExecuteNonQuery();
            Dept_Name_text.Clear();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Designation(Name) Values(@name)", Op.con);
            cmd.Parameters.AddWithValue("@name",Desg_Name_text.Text);
            cmd.Connection = Op.getConnection();
            cmd.ExecuteNonQuery();
            Desg_Name_text.Clear();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Contractor(Name,Price) Values(@name,@price)",Op.con);
            cmd.Parameters.AddWithValue("@name",Contract_Name_Text.Text);
            cmd.Parameters.AddWithValue("@price",int.Parse(contract_price_text.Text));
            cmd.Connection = Op.getConnection();
            cmd.ExecuteNonQuery();
            contract_price_text.Clear();
            Contract_Name_Text.Clear();
        }

        private void Contract_price_text_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(contract_price_text.Text, "[^0-9\\s]"))
            {
                contract_price_text.Text = contract_price_text.Text.Remove(contract_price_text.Text.Length - 1);
            }
        }

        private void Contract_Name_Text_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Contract_Name_Text.Text, "[^a-zA-Z\\s]"))
            {
                Contract_Name_Text.Text = Contract_Name_Text.Text.Remove(Contract_Name_Text.Text.Length - 1);
            }
        }

        private void Desg_Name_text_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Desg_Name_text.Text, "[^a-zA-Z\\s]"))
            {
                Desg_Name_text.Text = Desg_Name_text.Text.Remove(Desg_Name_text.Text.Length - 1);
            }
        }

        private void Dept_Name_text_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Dept_Name_text.Text, "[^a-zA-Z\\s]"))
            {
                Dept_Name_text.Text = Dept_Name_text.Text.Remove(Dept_Name_text.Text.Length - 1);
            }
        }
    }
}
