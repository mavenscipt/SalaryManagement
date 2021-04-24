
namespace SalaryManagement
{
    partial class frmAllKharchi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rtbAll = new System.Windows.Forms.RadioButton();
            this.rtbEmployeeWise = new System.Windows.Forms.RadioButton();
            this.rtbDepartmentWise = new System.Windows.Forms.RadioButton();
            this.pnlEmployee = new System.Windows.Forms.Panel();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.pnlDepartment = new System.Windows.Forms.Panel();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlEmployee.SuspendLayout();
            this.pnlDepartment.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 211);
            this.dataGridView1.TabIndex = 0;
            // 
            // rtbAll
            // 
            this.rtbAll.AutoSize = true;
            this.rtbAll.Location = new System.Drawing.Point(59, 42);
            this.rtbAll.Name = "rtbAll";
            this.rtbAll.Size = new System.Drawing.Size(75, 17);
            this.rtbAll.TabIndex = 1;
            this.rtbAll.TabStop = true;
            this.rtbAll.Text = "All Kharchi";
            this.rtbAll.UseVisualStyleBackColor = true;
            this.rtbAll.CheckedChanged += new System.EventHandler(this.rtbAll_CheckedChanged);
            // 
            // rtbEmployeeWise
            // 
            this.rtbEmployeeWise.AutoSize = true;
            this.rtbEmployeeWise.Location = new System.Drawing.Point(181, 42);
            this.rtbEmployeeWise.Name = "rtbEmployeeWise";
            this.rtbEmployeeWise.Size = new System.Drawing.Size(98, 17);
            this.rtbEmployeeWise.TabIndex = 2;
            this.rtbEmployeeWise.TabStop = true;
            this.rtbEmployeeWise.Text = "Employee Wise";
            this.rtbEmployeeWise.UseVisualStyleBackColor = true;
            this.rtbEmployeeWise.CheckedChanged += new System.EventHandler(this.rtbEmployeeWise_CheckedChanged);
            // 
            // rtbDepartmentWise
            // 
            this.rtbDepartmentWise.AutoSize = true;
            this.rtbDepartmentWise.Location = new System.Drawing.Point(313, 42);
            this.rtbDepartmentWise.Name = "rtbDepartmentWise";
            this.rtbDepartmentWise.Size = new System.Drawing.Size(107, 17);
            this.rtbDepartmentWise.TabIndex = 3;
            this.rtbDepartmentWise.TabStop = true;
            this.rtbDepartmentWise.Text = "Department Wise";
            this.rtbDepartmentWise.UseVisualStyleBackColor = true;
            this.rtbDepartmentWise.CheckedChanged += new System.EventHandler(this.rtbDepartmentWise_CheckedChanged);
            // 
            // pnlEmployee
            // 
            this.pnlEmployee.Controls.Add(this.cmbEmployee);
            this.pnlEmployee.Controls.Add(this.lblEmployeeName);
            this.pnlEmployee.Location = new System.Drawing.Point(464, 24);
            this.pnlEmployee.Name = "pnlEmployee";
            this.pnlEmployee.Size = new System.Drawing.Size(295, 100);
            this.pnlEmployee.TabIndex = 5;
            this.pnlEmployee.Visible = false;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(19, 12);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(84, 13);
            this.lblEmployeeName.TabIndex = 0;
            this.lblEmployeeName.Text = "Employee Name";
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(22, 41);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(208, 21);
            this.cmbEmployee.TabIndex = 1;
            this.cmbEmployee.SelectionChangeCommitted += new System.EventHandler(this.cmbEmployee_SelectionChangeCommitted);
            this.cmbEmployee.SelectedValueChanged += new System.EventHandler(this.cmbEmployee_SelectedValueChanged);
            // 
            // pnlDepartment
            // 
            this.pnlDepartment.Controls.Add(this.cmbDepartment);
            this.pnlDepartment.Controls.Add(this.label1);
            this.pnlDepartment.Location = new System.Drawing.Point(467, 24);
            this.pnlDepartment.Name = "pnlDepartment";
            this.pnlDepartment.Size = new System.Drawing.Size(295, 100);
            this.pnlDepartment.TabIndex = 6;
            this.pnlDepartment.Visible = false;
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(22, 41);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(208, 21);
            this.cmbDepartment.TabIndex = 1;
            this.cmbDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbDepartment_SelectedIndexChanged);
            this.cmbDepartment.SelectionChangeCommitted += new System.EventHandler(this.cmbDepartment_SelectionChangeCommitted);
            this.cmbDepartment.SelectedValueChanged += new System.EventHandler(this.cmbDepartment_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Department Name";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(613, 418);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(175, 20);
            this.txtTotal.TabIndex = 7;
            // 
            // frmAllKharchi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.pnlDepartment);
            this.Controls.Add(this.pnlEmployee);
            this.Controls.Add(this.rtbDepartmentWise);
            this.Controls.Add(this.rtbEmployeeWise);
            this.Controls.Add(this.rtbAll);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmAllKharchi";
            this.Text = "AllKharchi";
            this.Load += new System.EventHandler(this.frmAllKharchi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlEmployee.ResumeLayout(false);
            this.pnlEmployee.PerformLayout();
            this.pnlDepartment.ResumeLayout(false);
            this.pnlDepartment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rtbAll;
        private System.Windows.Forms.RadioButton rtbEmployeeWise;
        private System.Windows.Forms.RadioButton rtbDepartmentWise;
        private System.Windows.Forms.Panel pnlEmployee;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Panel pnlDepartment;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotal;
    }
}