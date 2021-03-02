using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SalaryManagement
{
    public partial class frmCreate : Form
    {
        Operations op = new Operations();
        public frmCreate()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public bool IsNotNullCheck()
        {
            if (txtUsername.Text == "" && txtPassword.Text == "" && cmbRole.SelectedIndex == -1)
            {
                MessageBox.Show("Please Enter All Field"); return false;
                
            }
            if (txtUsername.Text == "")
            {
                txtUsername.Focus();
                MessageBox.Show("Please Enter Username"); return false;
                
            }
            if (txtPassword.Text == "") { txtPassword.Focus(); MessageBox.Show("Please Enter Password"); return false; }
            if (cmbRole.SelectedIndex == -1) { cmbRole.Focus(); MessageBox.Show("Please Select User Role"); return false; }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            try
            {
              bool validation =  IsNotNullCheck();
              if (validation)
              {
                  
                  int UserCount = op.UserExisting(txtUsername.Text);
                  if (UserCount > 0)
                  {
                      MessageBox.Show("this '" + txtUsername.Text + "' Username is Already Exist Enter Different");

                  }
                  else
                  {
                      int result = op.CreateUsers(txtUsername.Text.ToString(), txtPassword.Text.ToString(), Convert.ToInt32(cmbRole.SelectedItem));
                      if (result > 0)
                      {
                          MessageBox.Show("Data Save Successfully");
                          clearAll();
                      }
                      else
                      {
                          MessageBox.Show("Something Went Wrong");
                      }
                  }
              }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
            
        }
        public void clearAll()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            cmbRole.SelectedIndex = -1;
            cmbRole.Text = "Role";
            
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbRole_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
    }
}
