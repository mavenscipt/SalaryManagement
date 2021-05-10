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
    public partial class frmTemporary_Deleted_Employee : Form
    {
        Operations op = new Operations();
        int Id;
        public frmTemporary_Deleted_Employee()
        {
            InitializeComponent();
        }

        private void frmTemporary_Deleted_Employee_Load(object sender, EventArgs e)
        {
            DisplayData();
        }
        private void DisplayData()
        {
            op.getConnection();
            string query = "Select Id,Name,Photo from tblEmployeeDetails where Active='False'";
            SqlDataAdapter sda = new SqlDataAdapter(query, op.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dt.Columns.Add("Pic", Type.GetType("System.Byte[]"));
            if (dt.Rows.Count > 0)
            {
                dataGridView1.Show();
                foreach (DataRow draw in dt.Rows)
                {
                    if (File.Exists(draw["Photo"].ToString()))
                    {
                        draw["Pic"] = File.ReadAllBytes(draw["Photo"].ToString());
                    }
                    else
                    {
                        draw["Pic"] = null;
                    }
                }
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dt;
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

        private void activateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string confirm = (MessageBox.Show("Are You Sure You want Re-Activate the Employee.?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)).ToString();
            if (confirm == "Yes")
            {
                Id = dataGridView1.CurrentCell.RowIndex;
                int EmployeeId = Convert.ToInt32(dataGridView1.Rows[Id].Cells[0].Value.ToString());
                SqlCommand cmd = new SqlCommand("Update tblEmployeeDetails set Active='True' where Id=" + EmployeeId);
                cmd.Connection = op.getConnection();
                cmd.ExecuteNonQuery();
                DisplayData();
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
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
    }
}