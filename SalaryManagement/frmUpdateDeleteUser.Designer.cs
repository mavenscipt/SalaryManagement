namespace SalaryManagement
{
    partial class frmUpdateDeleteUser
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
            this.rtbChangePass = new System.Windows.Forms.RadioButton();
            this.rtbDeleteUser = new System.Windows.Forms.RadioButton();
            this.cmbUsers = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlUpdate = new System.Windows.Forms.Panel();
            this.txtReEnter = new System.Windows.Forms.TextBox();
            this.txtNew = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbChangePass
            // 
            this.rtbChangePass.AutoSize = true;
            this.rtbChangePass.Location = new System.Drawing.Point(24, 39);
            this.rtbChangePass.Name = "rtbChangePass";
            this.rtbChangePass.Size = new System.Drawing.Size(111, 17);
            this.rtbChangePass.TabIndex = 1;
            this.rtbChangePass.TabStop = true;
            this.rtbChangePass.Text = "Change Password";
            this.rtbChangePass.UseVisualStyleBackColor = true;
            this.rtbChangePass.CheckedChanged += new System.EventHandler(this.rtbChangePass_CheckedChanged);
            this.rtbChangePass.Click += new System.EventHandler(this.rtbChangePass_Click);
            // 
            // rtbDeleteUser
            // 
            this.rtbDeleteUser.AutoSize = true;
            this.rtbDeleteUser.Location = new System.Drawing.Point(151, 39);
            this.rtbDeleteUser.Name = "rtbDeleteUser";
            this.rtbDeleteUser.Size = new System.Drawing.Size(86, 17);
            this.rtbDeleteUser.TabIndex = 2;
            this.rtbDeleteUser.TabStop = true;
            this.rtbDeleteUser.Text = "Delete Users";
            this.rtbDeleteUser.UseVisualStyleBackColor = true;
            this.rtbDeleteUser.CheckedChanged += new System.EventHandler(this.rtbDeleteUser_CheckedChanged);
            // 
            // cmbUsers
            // 
            this.cmbUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbUsers.FormattingEnabled = true;
            this.cmbUsers.Location = new System.Drawing.Point(119, 74);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.Size = new System.Drawing.Size(177, 21);
            this.cmbUsers.TabIndex = 3;
            this.cmbUsers.Text = "Users";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(59, 79);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(162, 110);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(152, 79);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Controls.Add(this.label3);
            this.pnlUpdate.Controls.Add(this.btnClear);
            this.pnlUpdate.Controls.Add(this.label2);
            this.pnlUpdate.Controls.Add(this.btnUpdate);
            this.pnlUpdate.Controls.Add(this.txtReEnter);
            this.pnlUpdate.Controls.Add(this.txtNew);
            this.pnlUpdate.Location = new System.Drawing.Point(12, 101);
            this.pnlUpdate.Name = "pnlUpdate";
            this.pnlUpdate.Size = new System.Drawing.Size(298, 130);
            this.pnlUpdate.TabIndex = 10;
            // 
            // txtReEnter
            // 
            this.txtReEnter.Location = new System.Drawing.Point(109, 42);
            this.txtReEnter.Name = "txtReEnter";
            this.txtReEnter.PasswordChar = '*';
            this.txtReEnter.Size = new System.Drawing.Size(178, 20);
            this.txtReEnter.TabIndex = 9;
            this.txtReEnter.UseSystemPasswordChar = true;
            // 
            // txtNew
            // 
            this.txtNew.Location = new System.Drawing.Point(109, 16);
            this.txtNew.Name = "txtNew";
            this.txtNew.PasswordChar = '*';
            this.txtNew.Size = new System.Drawing.Size(177, 20);
            this.txtNew.TabIndex = 8;
            this.txtNew.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "New Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Confirm Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Users";
            // 
            // frmUpdateDeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 323);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cmbUsers);
            this.Controls.Add(this.rtbDeleteUser);
            this.Controls.Add(this.rtbChangePass);
            this.Name = "frmUpdateDeleteUser";
            this.Text = "UpdateDeleteUser";
            this.Load += new System.EventHandler(this.frmUpdateDeleteUser_Load);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlUpdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rtbChangePass;
        private System.Windows.Forms.RadioButton rtbDeleteUser;
        private System.Windows.Forms.ComboBox cmbUsers;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel pnlUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtReEnter;
        private System.Windows.Forms.TextBox txtNew;
        private System.Windows.Forms.Label label1;

    }
}