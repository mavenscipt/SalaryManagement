using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SalaryManagement
{
    public partial class frmEditDeleteView : Form
    {
        Operations Op = new Operations();
        public int Id;
        public frmEditDeleteView()
        {
            InitializeComponent();
        }
        private void Delete_Data_Load(object sender, EventArgs e)
        {
            ComboboxBind();
        }
        void DisplayData()
        {
            int EmployeeID = ((KeyValuePair<int, string>)cmbEmployeeName.SelectedItem).Key;
            string Name = ((KeyValuePair<int, string>)cmbEmployeeName.SelectedItem).Value;
            Op.getConnection();
            string query = "Select Id,Name,Photo from tblEmployeeDetails where Id=" + EmployeeID + " AND Name='" + Name + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Op.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dt.Columns.Add("Pic", Type.GetType("System.Byte[]"));
            foreach (DataRow draw in dt.Rows)
            {
                draw["Pic"] = File.ReadAllBytes(draw["Photo"].ToString());
            }
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dt;
        }
        public void ComboboxBind()
        {
            cmbEmployeeName.DataSource = new BindingSource(Op.GetDataForCombo("select Id,Name from tblEmployeeDetails"), null);
            cmbEmployeeName.DisplayMember = "Value";
            cmbEmployeeName.ValueMember = "Key";
        }
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.CurrentRow.Selected = true;
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                Id = int.Parse(row.Cells[0].Value.ToString());
            }
            else
            {
                contextMenuStrip1.Visible = false;
            }
        }
        private void cmbEmployeeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayData();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                contextMenuStrip1.Visible = false;
            }
            else
            {
                contextMenuStrip1.Enabled = false;
            }
        }
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                contextMenuStrip1.Enabled = true;
            }
            else
            {
                contextMenuStrip1.Enabled = false;
            }
            if (e.Button == MouseButtons.Right)
            {
                // here we do not come although the contextmenustrip shows up under the mouse pointer
                //this.dataGridView1.CurrentCell = this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            }
        }
        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                contextMenuStrip1.Enabled = true;
            }
            else
            {
                contextMenuStrip1.Enabled = false;
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
            }
        }
        private void dataGridView1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    contextMenuStrip1.Enabled = true;
                }
                else
                {
                    contextMenuStrip1.Enabled = false;
                }
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Id = dataGridView1.CurrentCell.RowIndex;
            //MessageBox.Show();
            int EmployeeId = Convert.ToInt32(dataGridView1.Rows[Id].Cells[0].Value.ToString());
            //MessageBox.Show(Op.UpdateId.ToString());
            frmUpdate up = new frmUpdate();
            up.UpdateId = EmployeeId;
            up.Show();
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string confirm = (MessageBox.Show("Are You Sure You want to Permanently Delete the Data.?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)).ToString();
            if (confirm == "Yes")
            {
                Id = dataGridView1.CurrentCell.RowIndex;
                int EmployeeId = Convert.ToInt32(dataGridView1.Rows[Id].Cells[0].Value.ToString());
                string result = Op.DeleteData(EmployeeId);

                if (result == "Success")
                {
                    MessageBox.Show("Success", "Data Deleted Permanently.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // DisplayData(); 
                }

            }
        }
        private void cmbEmployeeName_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string Name = ((KeyValuePair<int, string>)cmbEmployeeName.SelectedItem).Value;
            if (Name != "Select")
            {
                dataGridView1.Show();
                DisplayData();
            }
            else
            {
                dataGridView1.Hide();
            }
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Id = dataGridView1.CurrentCell.RowIndex;
            int EmployeeId = Convert.ToInt32(dataGridView1.Rows[Id].Cells[0].Value.ToString());
            View_Details VD = new View_Details();
            VD.ViewId = EmployeeId;
            VD.Show();
        }
    }
}
