namespace SalaryManagement
{
    partial class frmInsert_Department_Designation_Contractor
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
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.Department_groupbox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Dept_Name_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Designation_groupbox = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Desg_Name_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Contractor_groupbox = new System.Windows.Forms.GroupBox();
            this.contract_price_text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.Contract_Name_Text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.Department_groupbox.SuspendLayout();
            this.Designation_groupbox.SuspendLayout();
            this.Contractor_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1010, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(509, 28);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(74, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Contractor";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.RadioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(277, 28);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(81, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Designation";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(83, 28);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(80, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Department";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // Department_groupbox
            // 
            this.Department_groupbox.Controls.Add(this.button1);
            this.Department_groupbox.Controls.Add(this.Dept_Name_text);
            this.Department_groupbox.Controls.Add(this.label1);
            this.Department_groupbox.Location = new System.Drawing.Point(13, 111);
            this.Department_groupbox.Name = "Department_groupbox";
            this.Department_groupbox.Size = new System.Drawing.Size(1009, 100);
            this.Department_groupbox.TabIndex = 1;
            this.Department_groupbox.TabStop = false;
            this.Department_groupbox.Text = "Department";
            this.Department_groupbox.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(587, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Dept_Name_text
            // 
            this.Dept_Name_text.Location = new System.Drawing.Point(178, 43);
            this.Dept_Name_text.Name = "Dept_Name_text";
            this.Dept_Name_text.Size = new System.Drawing.Size(283, 20);
            this.Dept_Name_text.TabIndex = 1;
            this.Dept_Name_text.TextChanged += new System.EventHandler(this.Dept_Name_text_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // Designation_groupbox
            // 
            this.Designation_groupbox.Controls.Add(this.button2);
            this.Designation_groupbox.Controls.Add(this.Desg_Name_text);
            this.Designation_groupbox.Controls.Add(this.label2);
            this.Designation_groupbox.Location = new System.Drawing.Point(12, 105);
            this.Designation_groupbox.Name = "Designation_groupbox";
            this.Designation_groupbox.Size = new System.Drawing.Size(1009, 100);
            this.Designation_groupbox.TabIndex = 2;
            this.Designation_groupbox.TabStop = false;
            this.Designation_groupbox.Text = "Designation";
            this.Designation_groupbox.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(587, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Submit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Desg_Name_text
            // 
            this.Desg_Name_text.Location = new System.Drawing.Point(178, 52);
            this.Desg_Name_text.Name = "Desg_Name_text";
            this.Desg_Name_text.Size = new System.Drawing.Size(283, 20);
            this.Desg_Name_text.TabIndex = 4;
            this.Desg_Name_text.TextChanged += new System.EventHandler(this.Desg_Name_text_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // Contractor_groupbox
            // 
            this.Contractor_groupbox.Controls.Add(this.contract_price_text);
            this.Contractor_groupbox.Controls.Add(this.label4);
            this.Contractor_groupbox.Controls.Add(this.button3);
            this.Contractor_groupbox.Controls.Add(this.Contract_Name_Text);
            this.Contractor_groupbox.Controls.Add(this.label3);
            this.Contractor_groupbox.Location = new System.Drawing.Point(12, 111);
            this.Contractor_groupbox.Name = "Contractor_groupbox";
            this.Contractor_groupbox.Size = new System.Drawing.Size(1009, 100);
            this.Contractor_groupbox.TabIndex = 3;
            this.Contractor_groupbox.TabStop = false;
            this.Contractor_groupbox.Text = "Contractor";
            this.Contractor_groupbox.Visible = false;
            // 
            // contract_price_text
            // 
            this.contract_price_text.Location = new System.Drawing.Point(587, 35);
            this.contract_price_text.MaxLength = 7;
            this.contract_price_text.Name = "contract_price_text";
            this.contract_price_text.Size = new System.Drawing.Size(200, 20);
            this.contract_price_text.TabIndex = 10;
            this.contract_price_text.TextChanged += new System.EventHandler(this.Contract_price_text_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(469, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Price";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(846, 33);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Submit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Contract_Name_Text
            // 
            this.Contract_Name_Text.Location = new System.Drawing.Point(178, 35);
            this.Contract_Name_Text.Name = "Contract_Name_Text";
            this.Contract_Name_Text.Size = new System.Drawing.Size(200, 20);
            this.Contract_Name_Text.TabIndex = 7;
            this.Contract_Name_Text.TextChanged += new System.EventHandler(this.Contract_Name_Text_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name";
            // 
            // Insert_Value
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 741);
            this.Controls.Add(this.Contractor_groupbox);
            this.Controls.Add(this.Designation_groupbox);
            this.Controls.Add(this.Department_groupbox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Insert_Value";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Department_groupbox.ResumeLayout(false);
            this.Department_groupbox.PerformLayout();
            this.Designation_groupbox.ResumeLayout(false);
            this.Designation_groupbox.PerformLayout();
            this.Contractor_groupbox.ResumeLayout(false);
            this.Contractor_groupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox Department_groupbox;
        private System.Windows.Forms.GroupBox Designation_groupbox;
        private System.Windows.Forms.GroupBox Contractor_groupbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Dept_Name_text;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Desg_Name_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox Contract_Name_Text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox contract_price_text;
        private System.Windows.Forms.Label label4;
    }
}