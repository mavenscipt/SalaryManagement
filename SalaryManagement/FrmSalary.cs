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
    public partial class FrmSalary : Form
    {
        Operations op = new Operations();
        public FrmSalary()
        {
            InitializeComponent();
        }

        private void FrmSalary_Load(object sender, EventArgs e)
        {
            ComboboxBind();
        }
        public void ComboboxBind()
        {
            cmbEmployee.DataSource = new BindingSource(op.GetEmployeeName(), null);
            cmbEmployee.DisplayMember = "Value";
            cmbEmployee.ValueMember = "Key";
        }
    }
}
