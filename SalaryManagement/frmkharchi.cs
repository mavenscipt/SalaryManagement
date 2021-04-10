using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace SalaryManagement
{
    public partial class frmkharchi : Form
    {
        Operations op = new Operations();
        int KharchiId;
        public frmkharchi()
        {
            InitializeComponent();
        }

        private void frmkharchi_Load(object sender, EventArgs e)
        {
            ComboboxBind();
            Bind();
            HideShowPanel(false, btnSave.Text, false);




        }
        public void Bind()
        {
            int EmployeeID = ((KeyValuePair<int, string>)cmbEmployee.SelectedItem).Key;
            string Name = ((KeyValuePair<int, string>)cmbEmployee.SelectedItem).Value;
            SqlCommand cmd;
            cmd = new SqlCommand("select * from Kharchi where [Employee ID] = '" + EmployeeID + "'  Order By  Id DESC");
            cmd.Connection = op.getConnection();
           SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt != null && dt.Rows.Count > 0)
            {

                DGV.DataSource = dt;
            }
            else
            {
                DGV.DataSource = null;
            }


        }

        public void ComboboxBind()
        {
            cmbEmployee.DataSource = new BindingSource(op.GetDataForCombo("select Id,Name from tblEmployeeDetails"), null);
            cmbEmployee.DisplayMember = "Value";
            cmbEmployee.ValueMember = "Key";
        }

        public bool NotNullCheck(TextBox txt)
        {
            if (txt.Text.Length > 0) { return true; }
            txt.Focus();
            return false;

        }
        public void SelectKharchiData(int Id)
        {
            SqlCommand cmd = new SqlCommand("select  TOP (1) * from Kharchi where [Employee ID] = '" + Id + "'  Order By  Id DESC");
            cmd.Connection = op.getConnection();
            SqlDataReader dr = cmd.ExecuteReader();



            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    txtAmount.Text = dr[3].ToString();
                    dtKharchiDate.Text = dr[5].ToString();

                }
                DGV.Visible = true;
            }
            else
            {
                if (rtbUpdate.Checked || rtbDelete.Checked)
                {
                    MessageBox.Show("No Kharchi Found");
                }
            }
        }



        private void btnSave_Click(object sender, EventArgs e)
        {

            if (NotNullCheck(txtAmount))
            {
                int EmployeeID = ((KeyValuePair<int, string>)cmbEmployee.SelectedItem).Key;
                string Name = ((KeyValuePair<int, string>)cmbEmployee.SelectedItem).Value;
                double Amount = Convert.ToDouble(txtAmount.Text);
                DateTime date = dtKharchiDate.Value;

                if (btnSave.Text == "SAVE")
                {

                    int result = op.DataInsert("insert into Kharchi ([Name],[Employee ID],[Amount],[PendingAmount],[Date]) values ('" + Name + "'," + EmployeeID + "," + Amount + "," + Amount + ",'" + date.Date.ToShortDateString() + "')");
                    if (result > 0)
                    {
                        MessageBox.Show("Kharchi Save Successfully");
                        cmbEmployee.SelectedIndex = 0;
                        HideShowPanel(true, btnSave.Text, false);
                    }
                }
                else if (btnSave.Text == "UPDATE")
                {
                    int result = op.DataInsert("Update Kharchi set [Amount] = '" + Amount + "',[PendingAmount] = '" + Amount + "',[Date] = '" + date.Date.ToShortDateString() + "' where [Employee ID] = '" + EmployeeID + "' and Id = '" + KharchiId + "' ");
                    if (result > 0)
                    {
                        MessageBox.Show("Kharchi Update Successfully");
                        Bind();
                    }
                }
                
               


            }
            else
            {
                MessageBox.Show("Please Enter Amount");

            }
        }


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            // HideShowPanel(false, "UPDATE", false);
            DGV.Location = new Point(118, 355);
            cmbEmployee.SelectedIndex = 0;
        }
        public void HideShowPanel(bool kharchi, string btnText, bool dataGrid)
        {
            pnlKharchi.Visible = kharchi;
            btnSave.Text = btnText;
            DGV.Visible = dataGrid;
            txtAmount.Text = "";
            dtKharchiDate.ResetText();
            // cmbEmployee.SelectedIndex = 0;

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            HideShowPanel(false, "SAVE", false);
            cmbEmployee.SelectedIndex = 0;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            HideShowPanel(false, "DELETE", false);
            cmbEmployee.SelectedIndex = 0;

        }



        private void DGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            KharchiId = Convert.ToInt32(DGV.Rows[e.RowIndex].Cells[0].Value);
            txtAmount.Text = DGV.Rows[e.RowIndex].Cells[3].Value.ToString();
            dtKharchiDate.Text = DGV.Rows[e.RowIndex].Cells[5].Value.ToString();

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {


            int Id = DGV.CurrentCell.RowIndex;
            int EmployeeId = Convert.ToInt32(DGV.Rows[Id].Cells[0].Value.ToString());
            txtAmount.Text = DGV.Rows[Id].Cells[3].Value.ToString();


        }



        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int EmployeeID = ((KeyValuePair<int, string>)cmbEmployee.SelectedItem).Key;
            string Name = ((KeyValuePair<int, string>)cmbEmployee.SelectedItem).Value;

            DialogResult Result = MessageBox.Show("Are You Sure You Want to Delete Kharchi", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (Result == DialogResult.Yes)
            {
                int result = op.DataInsert("Delete from  Kharchi where [Employee ID] = '" + EmployeeID + "' and Id = '" + KharchiId + "' ");
                if (result > 0)
                {
                    MessageBox.Show("Kharchi Delete Successfully");
                    cmbEmployee.SelectedIndex = 0;
                    ComboboxBind();
                    Bind();
                   }
            }
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void DGV_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (rtbDelete.Checked)
                {
                    if (DGV.Rows.Count > 0)
                    {
                        contextMenuStrip1.Visible = true;
                    }
                    else
                    {
                        contextMenuStrip1.Visible = false;
                    }
                }

            }
        }
        public void RadioToggle()
        {
            if (rtbAdd.Checked)
            {
                rtbUpdate.Checked = false;
                rtbDelete.Checked = false;
            }
            else if (rtbUpdate.Checked)
            {
                rtbAdd.Checked = false;
                rtbDelete.Checked = false;
            }
            else if (rtbDelete.Checked)
            {
                rtbAdd.Checked = false;
                rtbUpdate.Checked = false;
            }
        }
        private void cmbEmployee_SelectedValueChanged(object sender, EventArgs e)
        {

            string Value = ((KeyValuePair<int, string>)cmbEmployee.SelectedItem).Value;
            int ID = ((KeyValuePair<int, string>)cmbEmployee.SelectedItem).Key;
            RadioToggle();

            if (Value != "Select")
            {
                if (rtbAdd.Checked)
                {

                    HideShowPanel(true, "SAVE", false);
                }
                else if (rtbUpdate.Checked)
                {
                    HideShowPanel(true, "UPDATE", true);
                    Bind();
                }
                else if (rtbDelete.Checked)
                {
                    HideShowPanel(true, "DELETE", true);
                    Bind();
                    DGV.Location = new Point(108, 190);
                }
            }
            else
            {
                HideShowPanel(false, btnSave.Text, false);
            }

        }

        private void cmbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
