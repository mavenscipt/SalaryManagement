using System;
using System.Collections;
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





        }
        public void Bind()
        {
            int EmployeeID = ((KeyValuePair<int, string>)cmbEmployee.SelectedItem).Key;
            string Name = ((KeyValuePair<int, string>)cmbEmployee.SelectedItem).Value;
            //  string today = DateTime.Now.ToString("dd-MM-yyyy");
            SqlCommand cmd; //new SqlCommand("SELECT Name, Mobile, VehicleNumber, InsuranceEndDate, ParsingEndDate, TaxEndDate, PermitEndDate, PucEndDate from HeavyMaster");
              cmd = new SqlCommand("select * from Kharchi where [Employee ID] = '" + EmployeeID + "'  Order By  Id DESC");
              cmd.Connection = op.getConnection();
            // DGV.DataSource = cmd.ExecuteReader();      
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
            if(txt.Text.Length > 0) { return true; }
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
                // dataTable.Load(dr);
                while (dr.Read())
                {
                    KharchiId =  Convert.ToInt32(dr[0]);
                    txtAmount.Text = dr[3].ToString();
                    dtKharchiDate.Text = dr[5].ToString();
                    
                }
                DGV.Visible = true;    }
            else
            {
                if (rtbUpdate.Checked || rtbDelete.Checked) 
                {
                    MessageBox.Show("No Kharchi Found");
                    DGV.Visible = false;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if(NotNullCheck(txtAmount))
            {
                int EmployeeID = ((KeyValuePair<int, string>)cmbEmployee.SelectedItem).Key;
                string Name = ((KeyValuePair<int, string>)cmbEmployee.SelectedItem).Value;
                double Amount = Convert.ToDouble(txtAmount.Text);
                DateTime date = dtKharchiDate.Value;
                date.ToShortDateString();
                date.ToShortDateString();
              //  MessageBox.Show(date.ToShortDateString());

                if (btnSave.Text == "SAVE")
                {
                    int result = op.DataInsert("insert into Kharchi ([Name],[Employee ID],[Amount],[Date]) values ('" + Name + "','" + EmployeeID + "','" + Amount + "','" + date.Date.ToShortDateString() + "')");
                    if (result > 0)
                    {
                        MessageBox.Show("Kharchi Save Successfully");
                        txtAmount.Text = "";
                        cmbEmployee.SelectedIndex = 0;
                        pnlKharchi.Visible = true;
                    }
               }
                else if (btnSave.Text == "UPDATE")
                {
                  
                    int result = op.DataInsert("Update Kharchi set [Name] = '" + Name + "' ,[Employee ID] = '" + EmployeeID + "',[Amount] = '" + Amount + "' ,[Date] = '" + date.Date.ToShortDateString() + "' where [Employee ID] = '"+EmployeeID+ "' and Id = '" + KharchiId + "' ");
                    if (result > 0)
                    {
                        MessageBox.Show("Kharchi Update Successfully");
                        txtAmount.Text = "";
                       // dtKharchiDate.ResetText();
                        // cmbEmployee.SelectedIndex = 0;
                        Bind();
                    }
                }
                else if (btnSave.Text == "DELETE")
                {
                    DialogResult Result = MessageBox.Show("Are You Sure You Want to Delete Kharchi","", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Result == DialogResult.Yes)
                    {
                        int result = op.DataInsert("Delete from  Kharchi where [Employee ID] = '" + EmployeeID + "' and Id = '"+ KharchiId +"' ");
                        if (result > 0)
                        {
                            MessageBox.Show("Kharchi Delete Successfully");
                            txtAmount.Text = "";
                            cmbEmployee.SelectedIndex = 0;
                            ComboboxBind();

                        }
                    }
                }


            }
            else
            {
                MessageBox.Show("Please Enter Amount");

            }
        }

        private void cmbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Value = ((KeyValuePair<int, string>)cmbEmployee.SelectedItem).Value;
            int ID = ((KeyValuePair<int, string>)cmbEmployee.SelectedItem).Key;
            if (Value == "Select")
            {
                pnlKharchi.Visible = false;
                Bind();
                DGV.Visible = false;           }
            else if (Value != "Select" && rtbUpdate.Checked)
            {
                pnlKharchi.Visible = true;
                SelectKharchiData(ID);
                DGV.Visible = true;
                Bind();
            }
            else if(Value != "Select" && rtbDelete.Checked)
            {
               // pnlKharchi.Visible = true;
                SelectKharchiData(ID);
                Bind();
              //  DGV.Visible = false;
            }
            else if (Value != "Select")
            { pnlKharchi.Visible = true; Bind(); }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            btnSave.Text = "UPDATE";
            DGV.Location = new Point(118, 355);
            pnlKharchi.Visible = false;
            txtAmount.Text = "";
            dtKharchiDate.ResetText();
            cmbEmployee.SelectedIndex = 0;
            DGV.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            btnSave.Text = "SAVE";
            pnlKharchi.Visible = true;
            txtAmount.Text = "";
            dtKharchiDate.ResetText();
            DGV.Visible = false;
            cmbEmployee.SelectedIndex = 0;

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            btnSave.Text = "DELETE";
            btnSave.Text = "SAVE";
            pnlKharchi.Visible = false;
            txtAmount.Text = "";
            dtKharchiDate.ResetText();
           
            DGV.Location = new Point(108, 190);
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
            txtAmount.Text = DGV.Rows[e.RowIndex].Cells[3].Value.ToString();
            dtKharchiDate.Text = DGV.Rows[e.RowIndex].Cells[5].Value.ToString();

            //txt_Name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            //txt_State.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
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

        private void pnlEmployeeList_Paint(object sender, PaintEventArgs e)
        {

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
                    txtAmount.Text = "";
                    cmbEmployee.SelectedIndex = 0;
                    ComboboxBind();
                    Bind();
                    DGV.Visible = false;

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
    }
}
