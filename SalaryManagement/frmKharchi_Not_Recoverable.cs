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
    public partial class frmKharchi_Not_Recoverable : Form
    {
        Operations Op = new Operations();
        public frmKharchi_Not_Recoverable()
        {
            InitializeComponent();
        }

        private void frmKharchi_Not_Recoverable_Load(object sender, EventArgs e)
        {
            Op.getConnection();
            string query = "Select * from Kharchi ";
            SqlDataAdapter sda = new SqlDataAdapter(query, Op.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dt;
            UpdateBalance();
        }
        private void UpdateBalance()
        {
            int Amount = 0;
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                Amount = Amount + int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
            }
            Amount_Textbox.Text = Amount.ToString();
        }
    }
}
