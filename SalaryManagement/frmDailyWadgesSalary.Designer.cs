
namespace SalaryManagement
{
    partial class frmDailyWadgesSalary
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPresent = new System.Windows.Forms.TextBox();
            this.txtUpad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKharchi = new System.Windows.Forms.TextBox();
            this.txtOverTime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRoomRent = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNetSalary = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(26, 118);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(122, 21);
            this.cmbEmployee.TabIndex = 0;
            this.cmbEmployee.SelectedIndexChanged += new System.EventHandler(this.cmbEmployee_SelectedIndexChanged);
            this.cmbEmployee.SelectionChangeCommitted += new System.EventHandler(this.cmbEmployee_SelectionChangeCommitted);
            this.cmbEmployee.SelectedValueChanged += new System.EventHandler(this.cmbEmployee_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "EmployeeName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Present";
            // 
            // txtPresent
            // 
            this.txtPresent.Location = new System.Drawing.Point(272, 118);
            this.txtPresent.Name = "txtPresent";
            this.txtPresent.Size = new System.Drawing.Size(101, 20);
            this.txtPresent.TabIndex = 1;
            this.txtPresent.TextChanged += new System.EventHandler(this.txtPresent_TextChanged);
            // 
            // txtUpad
            // 
            this.txtUpad.Location = new System.Drawing.Point(602, 118);
            this.txtUpad.Name = "txtUpad";
            this.txtUpad.ReadOnly = true;
            this.txtUpad.Size = new System.Drawing.Size(101, 20);
            this.txtUpad.TabIndex = 3;
            this.txtUpad.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(599, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Upad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(707, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kharchi";
            // 
            // txtKharchi
            // 
            this.txtKharchi.Location = new System.Drawing.Point(710, 118);
            this.txtKharchi.Name = "txtKharchi";
            this.txtKharchi.ReadOnly = true;
            this.txtKharchi.Size = new System.Drawing.Size(100, 20);
            this.txtKharchi.TabIndex = 4;
            this.txtKharchi.TabStop = false;
            // 
            // txtOverTime
            // 
            this.txtOverTime.Location = new System.Drawing.Point(380, 118);
            this.txtOverTime.Name = "txtOverTime";
            this.txtOverTime.Size = new System.Drawing.Size(100, 20);
            this.txtOverTime.TabIndex = 2;
            this.txtOverTime.TextChanged += new System.EventHandler(this.txtOverTime_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(377, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Over Time";
            // 
            // txtRoomRent
            // 
            this.txtRoomRent.Location = new System.Drawing.Point(493, 118);
            this.txtRoomRent.Name = "txtRoomRent";
            this.txtRoomRent.Size = new System.Drawing.Size(100, 20);
            this.txtRoomRent.TabIndex = 3;
            this.txtRoomRent.TextChanged += new System.EventHandler(this.txtRoomRent_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(490, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Room Rent";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(813, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Net Salary";
            // 
            // txtNetSalary
            // 
            this.txtNetSalary.Location = new System.Drawing.Point(816, 118);
            this.txtNetSalary.Name = "txtNetSalary";
            this.txtNetSalary.ReadOnly = true;
            this.txtNetSalary.Size = new System.Drawing.Size(100, 20);
            this.txtNetSalary.TabIndex = 7;
            this.txtNetSalary.TabStop = false;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(161, 118);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.ReadOnly = true;
            this.txtSalary.Size = new System.Drawing.Size(102, 20);
            this.txtSalary.TabIndex = 1;
            this.txtSalary.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(173, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Salary";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(438, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Save Salary";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmDailyWadgesSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNetSalary);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRoomRent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOverTime);
            this.Controls.Add(this.txtKharchi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUpad);
            this.Controls.Add(this.txtPresent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbEmployee);
            this.Name = "frmDailyWadgesSalary";
            this.Text = "frmDailyWadgesSalary";
            this.Load += new System.EventHandler(this.frmDailyWadgesSalary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPresent;
        private System.Windows.Forms.TextBox txtUpad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKharchi;
        private System.Windows.Forms.TextBox txtOverTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRoomRent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNetSalary;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}