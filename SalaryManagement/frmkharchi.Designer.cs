
namespace SalaryManagement
{
    partial class frmkharchi
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
            this.components = new System.ComponentModel.Container();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.pnlKharchi = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtKharchiDate = new System.Windows.Forms.DateTimePicker();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtbDelete = new System.Windows.Forms.RadioButton();
            this.rtbUpdate = new System.Windows.Forms.RadioButton();
            this.rtbAdd = new System.Windows.Forms.RadioButton();
            this.pnlEmployeeList = new System.Windows.Forms.Panel();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlKharchi.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlEmployeeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Employee Name";
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbEmployee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(183, 13);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(200, 21);
            this.cmbEmployee.TabIndex = 20;
            this.cmbEmployee.SelectedIndexChanged += new System.EventHandler(this.cmbEmployee_SelectedIndexChanged);
            this.cmbEmployee.SelectedValueChanged += new System.EventHandler(this.cmbEmployee_SelectedValueChanged);
            // 
            // pnlKharchi
            // 
            this.pnlKharchi.Controls.Add(this.btnSave);
            this.pnlKharchi.Controls.Add(this.dtKharchiDate);
            this.pnlKharchi.Controls.Add(this.txtAmount);
            this.pnlKharchi.Controls.Add(this.label2);
            this.pnlKharchi.Controls.Add(this.label1);
            this.pnlKharchi.Location = new System.Drawing.Point(72, 180);
            this.pnlKharchi.Name = "pnlKharchi";
            this.pnlKharchi.Size = new System.Drawing.Size(447, 144);
            this.pnlKharchi.TabIndex = 22;
            this.pnlKharchi.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(194, 113);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtKharchiDate
            // 
            this.dtKharchiDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtKharchiDate.Location = new System.Drawing.Point(183, 68);
            this.dtKharchiDate.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dtKharchiDate.Name = "dtKharchiDate";
            this.dtKharchiDate.Size = new System.Drawing.Size(200, 20);
            this.dtKharchiDate.TabIndex = 3;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(183, 28);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(200, 20);
            this.txtAmount.TabIndex = 2;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rtbDelete);
            this.panel1.Controls.Add(this.rtbUpdate);
            this.panel1.Controls.Add(this.rtbAdd);
            this.panel1.Location = new System.Drawing.Point(72, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 36);
            this.panel1.TabIndex = 26;
            // 
            // rtbDelete
            // 
            this.rtbDelete.AutoSize = true;
            this.rtbDelete.Location = new System.Drawing.Point(327, 10);
            this.rtbDelete.Name = "rtbDelete";
            this.rtbDelete.Size = new System.Drawing.Size(95, 17);
            this.rtbDelete.TabIndex = 28;
            this.rtbDelete.TabStop = true;
            this.rtbDelete.Text = "Delete Kharchi";
            this.rtbDelete.UseVisualStyleBackColor = true;
            this.rtbDelete.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rtbUpdate
            // 
            this.rtbUpdate.AutoSize = true;
            this.rtbUpdate.Location = new System.Drawing.Point(174, 10);
            this.rtbUpdate.Name = "rtbUpdate";
            this.rtbUpdate.Size = new System.Drawing.Size(95, 17);
            this.rtbUpdate.TabIndex = 27;
            this.rtbUpdate.TabStop = true;
            this.rtbUpdate.Text = "Modify Kharchi";
            this.rtbUpdate.UseVisualStyleBackColor = true;
            this.rtbUpdate.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rtbAdd
            // 
            this.rtbAdd.AutoSize = true;
            this.rtbAdd.Location = new System.Drawing.Point(23, 10);
            this.rtbAdd.Name = "rtbAdd";
            this.rtbAdd.Size = new System.Drawing.Size(108, 17);
            this.rtbAdd.TabIndex = 26;
            this.rtbAdd.TabStop = true;
            this.rtbAdd.Text = "Add New Kharchi";
            this.rtbAdd.UseVisualStyleBackColor = true;
            this.rtbAdd.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // pnlEmployeeList
            // 
            this.pnlEmployeeList.Controls.Add(this.cmbEmployee);
            this.pnlEmployeeList.Controls.Add(this.label7);
            this.pnlEmployeeList.Location = new System.Drawing.Point(72, 133);
            this.pnlEmployeeList.Name = "pnlEmployeeList";
            this.pnlEmployeeList.Size = new System.Drawing.Size(447, 41);
            this.pnlEmployeeList.TabIndex = 27;
            // 
            // DGV
            // 
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.ContextMenuStrip = this.contextMenuStrip1;
            this.DGV.Location = new System.Drawing.Point(12, 340);
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(643, 150);
            this.DGV.TabIndex = 28;
            this.DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellContentClick);
            this.DGV.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_RowHeaderMouseClick);
            this.DGV.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DGV_MouseUp);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 26);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // frmkharchi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 624);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.pnlEmployeeList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlKharchi);
            this.Name = "frmkharchi";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "frmkharchi";
            this.Load += new System.EventHandler(this.frmkharchi_Load);
            this.pnlKharchi.ResumeLayout(false);
            this.pnlKharchi.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlEmployeeList.ResumeLayout(false);
            this.pnlEmployeeList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.Panel pnlKharchi;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dtKharchiDate;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rtbDelete;
        private System.Windows.Forms.RadioButton rtbUpdate;
        private System.Windows.Forms.RadioButton rtbAdd;
        private System.Windows.Forms.Panel pnlEmployeeList;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}