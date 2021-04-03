
namespace SalaryManagement
{
    partial class frmFixSalary
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
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.PanelSalary = new System.Windows.Forms.Panel();
            this.txtPayableSalary = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRoomRent = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPresent = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKharchi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUpad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PanelSalary.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(360, 32);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(121, 21);
            this.cmbEmployee.TabIndex = 0;
            this.cmbEmployee.SelectedIndexChanged += new System.EventHandler(this.cmbEmployee_SelectedIndexChanged);
            this.cmbEmployee.SelectedValueChanged += new System.EventHandler(this.cmbEmployee_SelectedValueChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(336, 102);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save Salary";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // PanelSalary
            // 
            this.PanelSalary.Controls.Add(this.txtPayableSalary);
            this.PanelSalary.Controls.Add(this.btnSave);
            this.PanelSalary.Controls.Add(this.label6);
            this.PanelSalary.Controls.Add(this.txtRoomRent);
            this.PanelSalary.Controls.Add(this.label5);
            this.PanelSalary.Controls.Add(this.txtPresent);
            this.PanelSalary.Controls.Add(this.label4);
            this.PanelSalary.Controls.Add(this.txtKharchi);
            this.PanelSalary.Controls.Add(this.label3);
            this.PanelSalary.Controls.Add(this.txtUpad);
            this.PanelSalary.Controls.Add(this.label2);
            this.PanelSalary.Controls.Add(this.txtSalary);
            this.PanelSalary.Controls.Add(this.label1);
            this.PanelSalary.Location = new System.Drawing.Point(12, 74);
            this.PanelSalary.Name = "PanelSalary";
            this.PanelSalary.Size = new System.Drawing.Size(824, 163);
            this.PanelSalary.TabIndex = 14;
            this.PanelSalary.Visible = false;
            this.PanelSalary.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelSalary_Paint);
            // 
            // txtPayableSalary
            // 
            this.txtPayableSalary.Enabled = false;
            this.txtPayableSalary.Location = new System.Drawing.Point(721, 76);
            this.txtPayableSalary.Name = "txtPayableSalary";
            this.txtPayableSalary.Size = new System.Drawing.Size(100, 20);
            this.txtPayableSalary.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(641, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "PayableSalary";
            // 
            // txtRoomRent
            // 
            this.txtRoomRent.Location = new System.Drawing.Point(721, 34);
            this.txtRoomRent.Name = "txtRoomRent";
            this.txtRoomRent.Size = new System.Drawing.Size(100, 20);
            this.txtRoomRent.TabIndex = 23;
            this.txtRoomRent.TextChanged += new System.EventHandler(this.txtRoomRent_TextChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(657, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Room Rent";
            // 
            // txtPresent
            // 
            this.txtPresent.Location = new System.Drawing.Point(553, 34);
            this.txtPresent.Name = "txtPresent";
            this.txtPresent.Size = new System.Drawing.Size(100, 20);
            this.txtPresent.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(504, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Present";
            // 
            // txtKharchi
            // 
            this.txtKharchi.Enabled = false;
            this.txtKharchi.Location = new System.Drawing.Point(382, 34);
            this.txtKharchi.Name = "txtKharchi";
            this.txtKharchi.Size = new System.Drawing.Size(100, 20);
            this.txtKharchi.TabIndex = 19;
            this.txtKharchi.TextChanged += new System.EventHandler(this.txtKharchi_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Kharchi";
            // 
            // txtUpad
            // 
            this.txtUpad.Enabled = false;
            this.txtUpad.Location = new System.Drawing.Point(211, 34);
            this.txtUpad.Name = "txtUpad";
            this.txtUpad.Size = new System.Drawing.Size(100, 20);
            this.txtUpad.TabIndex = 17;
            this.txtUpad.TextChanged += new System.EventHandler(this.txtUpad_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "UPAD";
            // 
            // txtSalary
            // 
            this.txtSalary.Enabled = false;
            this.txtSalary.Location = new System.Drawing.Point(53, 34);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(100, 20);
            this.txtSalary.TabIndex = 15;
            this.txtSalary.TextChanged += new System.EventHandler(this.txtSalary_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Salary";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(293, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Select ";
            // 
            // frmFixSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PanelSalary);
            this.Controls.Add(this.cmbEmployee);
            this.Name = "frmFixSalary";
            this.Text = "frmFixSalary";
            this.Load += new System.EventHandler(this.frmFixSalary_Load);
            this.PanelSalary.ResumeLayout(false);
            this.PanelSalary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel PanelSalary;
        private System.Windows.Forms.TextBox txtPayableSalary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRoomRent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPresent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKharchi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUpad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
    }
}