namespace SalaryManagement
{
    partial class frmDepartmentWiseKharchi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_Employee_Name = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_Dept_Name = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Pending_Amount_Label = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Amount_Label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cmb_Employee_Name);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmb_Dept_Name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(862, 74);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // cmb_Employee_Name
            // 
            this.cmb_Employee_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Employee_Name.FormattingEnabled = true;
            this.cmb_Employee_Name.Location = new System.Drawing.Point(629, 32);
            this.cmb_Employee_Name.Name = "cmb_Employee_Name";
            this.cmb_Employee_Name.Size = new System.Drawing.Size(143, 21);
            this.cmb_Employee_Name.TabIndex = 4;
            this.cmb_Employee_Name.SelectedIndexChanged += new System.EventHandler(this.Cmb_Employee_Name_SelectedIndexChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(490, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Employee Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(408, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Or";
            // 
            // cmb_Dept_Name
            // 
            this.cmb_Dept_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Dept_Name.FormattingEnabled = true;
            this.cmb_Dept_Name.Location = new System.Drawing.Point(174, 32);
            this.cmb_Dept_Name.Name = "cmb_Dept_Name";
            this.cmb_Dept_Name.Size = new System.Drawing.Size(167, 21);
            this.cmb_Dept_Name.TabIndex = 1;
            this.cmb_Dept_Name.SelectedIndexChanged += new System.EventHandler(this.Cmb_Dept_Name_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Department";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Pending_Amount_Label);
            this.panel1.Controls.Add(this.Label5);
            this.panel1.Controls.Add(this.Amount_Label);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 415);
            this.panel1.TabIndex = 1;
            // 
            // Pending_Amount_Label
            // 
            this.Pending_Amount_Label.AutoSize = true;
            this.Pending_Amount_Label.Location = new System.Drawing.Point(568, 387);
            this.Pending_Amount_Label.Name = "Pending_Amount_Label";
            this.Pending_Amount_Label.Size = new System.Drawing.Size(35, 13);
            this.Pending_Amount_Label.TabIndex = 4;
            this.Pending_Amount_Label.Text = "label6";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(463, 388);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(88, 13);
            this.Label5.TabIndex = 3;
            this.Label5.Text = "Pending Amount:";
            // 
            // Amount_Label
            // 
            this.Amount_Label.AutoSize = true;
            this.Amount_Label.Location = new System.Drawing.Point(101, 388);
            this.Amount_Label.Name = "Amount_Label";
            this.Amount_Label.Size = new System.Drawing.Size(35, 13);
            this.Amount_Label.TabIndex = 2;
            this.Amount_Label.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Total Amount :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(862, 376);
            this.dataGridView1.TabIndex = 0;
            // 
            // frmDepartmentWiseKharchi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 519);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDepartmentWiseKharchi";
            this.Text = "Dept_Wise_Kharchi";
            this.Load += new System.EventHandler(this.Dept_Wise_Kharchi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_Dept_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Amount_Label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Label Pending_Amount_Label;
        private System.Windows.Forms.ComboBox cmb_Employee_Name;
    }
}