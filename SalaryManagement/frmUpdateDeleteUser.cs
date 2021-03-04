using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
namespace SalaryManagement
{
    public partial class frmUpdateDeleteUser : Form
    {
        Operations op = new Operations();
        public frmUpdateDeleteUser()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmUpdateDeleteUser_Load(object sender, EventArgs e)
        {
            //   cmbUsers.SelectedIndex = 0;
            cmbUsers.Text = "Role";
            this.cmbUsers.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboboxBind();
            //cmbUsers.DataSource = new BindingSource(op.GetUserName(), null);
            //cmbUsers.DisplayMember = "Value";
            //cmbUsers.ValueMember = "Key";
        }

        private void rtbChangePass_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rtbChangePass_Click(object sender, EventArgs e)
        {
            pnlUpdate.Visible = true;
        }

        private void rtbDeleteUser_CheckedChanged(object sender, EventArgs e)
        {
            pnlUpdate.Visible = false;
        }
        public bool IsCheckBothPass()
        {
            if (txtNew.Text == "")
            {

                MessageBox.Show("Please Enter Password");
                return false;
            }
            else if (txtReEnter.Text == "")
            {

                MessageBox.Show("Please Enter Confirm Password");
                return false;
            }
            else
            {
                if (txtNew.Text != txtReEnter.Text)
                {

                    MessageBox.Show("Please Check Password and Confirm Password Not Match");
                    return false;
                }
            }
            return true;
            //txtReEnter .Text
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int Key = ((KeyValuePair<int, string>)cmbUsers.SelectedItem).Key;
                if (Key == 0)
                {
                    MessageBox.Show("Please Select Any User");
                }
                else
                {
                    bool b = IsCheckBothPass();
                    if (b)
                    {

                        string value = ((KeyValuePair<int, string>)cmbUsers.SelectedItem).Value;
                        int a = op.ChangePassword(value, txtNew.Text);
                        if (a > 0)
                        {
                            MessageBox.Show("Password Change Successfully");
                        }
                        else
                        {
                            MessageBox.Show("Password Not Change Successfully");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }
        public void ComboboxBind()
        {
            cmbUsers.DataSource = new BindingSource(op.GetUserName(), null);
            cmbUsers.DisplayMember = "Value";
            cmbUsers.ValueMember = "Key";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNew.Text = "";
            txtReEnter.Text = "";
            cmbUsers.SelectedIndex = 0;
            cmbUsers.Text = "Users";
            //   MessageBox.Show(value);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string value = ((KeyValuePair<int, string>)cmbUsers.SelectedItem).Value;
                int Key = ((KeyValuePair<int, string>)cmbUsers.SelectedItem).Key;
                if (Key == 0)
                {
                    MessageBox.Show("Please Select Any User");
                }
                else 
                {
                DialogResult Result = MessageBox.Show("Are You Sure You Want to Delete '" + value + "' User", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Result == DialogResult.Yes)
                {
                  
                    int Output = op.DeleteUsers(value);
                    if (Output > 0)
                    {
                        MessageBox.Show("User Delete Successfully");
                        ComboboxBind();
                        cmbUsers.SelectedIndex = 0;
                    }
                    else { MessageBox.Show("User Not Delete Successfully"); }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
