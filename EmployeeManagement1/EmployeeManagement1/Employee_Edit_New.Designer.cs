namespace EmployeeManagement1
{
    partial class Employee_Edit_New
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtp_hiredate = new System.Windows.Forms.DateTimePicker();
            this.cmb_job = new System.Windows.Forms.ComboBox();
            this.cmb_gender = new System.Windows.Forms.ComboBox();
            this.lb_deptcode = new System.Windows.Forms.Label();
            this.txt_salary = new System.Windows.Forms.TextBox();
            this.lb_manager = new System.Windows.Forms.Label();
            this.txt_lname = new System.Windows.Forms.TextBox();
            this.lb_salary = new System.Windows.Forms.Label();
            this.txt_fname = new System.Windows.Forms.TextBox();
            this.lb_hdate = new System.Windows.Forms.Label();
            this.lb_job = new System.Windows.Forms.Label();
            this.lb_gender = new System.Windows.Forms.Label();
            this.lb_lname = new System.Windows.Forms.Label();
            this.txt_empno = new System.Windows.Forms.TextBox();
            this.lb_fname = new System.Windows.Forms.Label();
            this.lb_employeeno = new System.Windows.Forms.Label();
            this.cmb_manager = new System.Windows.Forms.ComboBox();
            this.cmb_deptcode = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(408, 232);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 29);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(267, 232);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 29);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtp_hiredate
            // 
            this.dtp_hiredate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_hiredate.Location = new System.Drawing.Point(167, 126);
            this.dtp_hiredate.Name = "dtp_hiredate";
            this.dtp_hiredate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtp_hiredate.Size = new System.Drawing.Size(238, 22);
            this.dtp_hiredate.TabIndex = 5;
            // 
            // cmb_job
            // 
            this.cmb_job.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_job.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_job.FormattingEnabled = true;
            this.cmb_job.Items.AddRange(new object[] {
            ".Net Developer ",
            "Angular Developer",
            "UX/UI Developer",
            "Project Manager",
            "Software Testing ",
            "Software Support"});
            this.cmb_job.Location = new System.Drawing.Point(543, 96);
            this.cmb_job.Name = "cmb_job";
            this.cmb_job.Size = new System.Drawing.Size(238, 24);
            this.cmb_job.TabIndex = 4;
            // 
            // cmb_gender
            // 
            this.cmb_gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_gender.FormattingEnabled = true;
            this.cmb_gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cmb_gender.Location = new System.Drawing.Point(167, 96);
            this.cmb_gender.Name = "cmb_gender";
            this.cmb_gender.Size = new System.Drawing.Size(238, 24);
            this.cmb_gender.TabIndex = 3;
            // 
            // lb_deptcode
            // 
            this.lb_deptcode.AutoSize = true;
            this.lb_deptcode.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lb_deptcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_deptcode.Location = new System.Drawing.Point(417, 158);
            this.lb_deptcode.Name = "lb_deptcode";
            this.lb_deptcode.Size = new System.Drawing.Size(119, 16);
            this.lb_deptcode.TabIndex = 20;
            this.lb_deptcode.Text = "Department Code :";
            // 
            // txt_salary
            // 
            this.txt_salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_salary.Location = new System.Drawing.Point(543, 125);
            this.txt_salary.MaxLength = 6;
            this.txt_salary.Name = "txt_salary";
            this.txt_salary.Size = new System.Drawing.Size(238, 22);
            this.txt_salary.TabIndex = 6;
            this.txt_salary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_salary_KeyPress);
            // 
            // lb_manager
            // 
            this.lb_manager.AutoSize = true;
            this.lb_manager.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lb_manager.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_manager.Location = new System.Drawing.Point(41, 157);
            this.lb_manager.Name = "lb_manager";
            this.lb_manager.Size = new System.Drawing.Size(67, 16);
            this.lb_manager.TabIndex = 11;
            this.lb_manager.Text = "Manager :";
            // 
            // txt_lname
            // 
            this.txt_lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lname.Location = new System.Drawing.Point(543, 68);
            this.txt_lname.MaxLength = 25;
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(238, 22);
            this.txt_lname.TabIndex = 2;
            // 
            // lb_salary
            // 
            this.lb_salary.AutoSize = true;
            this.lb_salary.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lb_salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_salary.Location = new System.Drawing.Point(417, 128);
            this.lb_salary.Name = "lb_salary";
            this.lb_salary.Size = new System.Drawing.Size(52, 16);
            this.lb_salary.TabIndex = 17;
            this.lb_salary.Text = "Salary :";
            // 
            // txt_fname
            // 
            this.txt_fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fname.Location = new System.Drawing.Point(167, 68);
            this.txt_fname.MaxLength = 25;
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(238, 22);
            this.txt_fname.TabIndex = 1;
            // 
            // lb_hdate
            // 
            this.lb_hdate.AutoSize = true;
            this.lb_hdate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lb_hdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hdate.Location = new System.Drawing.Point(41, 131);
            this.lb_hdate.Name = "lb_hdate";
            this.lb_hdate.Size = new System.Drawing.Size(70, 16);
            this.lb_hdate.TabIndex = 16;
            this.lb_hdate.Text = "Hire Date :";
            // 
            // lb_job
            // 
            this.lb_job.AutoSize = true;
            this.lb_job.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lb_job.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_job.Location = new System.Drawing.Point(417, 97);
            this.lb_job.Name = "lb_job";
            this.lb_job.Size = new System.Drawing.Size(36, 16);
            this.lb_job.TabIndex = 15;
            this.lb_job.Text = "Job :";
            // 
            // lb_gender
            // 
            this.lb_gender.AutoSize = true;
            this.lb_gender.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lb_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_gender.Location = new System.Drawing.Point(41, 99);
            this.lb_gender.Name = "lb_gender";
            this.lb_gender.Size = new System.Drawing.Size(58, 16);
            this.lb_gender.TabIndex = 14;
            this.lb_gender.Text = "Gender :";
            // 
            // lb_lname
            // 
            this.lb_lname.AutoSize = true;
            this.lb_lname.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lb_lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_lname.Location = new System.Drawing.Point(421, 71);
            this.lb_lname.Name = "lb_lname";
            this.lb_lname.Size = new System.Drawing.Size(78, 16);
            this.lb_lname.TabIndex = 13;
            this.lb_lname.Text = "Last Name :";
            // 
            // txt_empno
            // 
            this.txt_empno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_empno.Location = new System.Drawing.Point(167, 39);
            this.txt_empno.MaxLength = 5;
            this.txt_empno.Name = "txt_empno";
            this.txt_empno.Size = new System.Drawing.Size(69, 22);
            this.txt_empno.TabIndex = 0;
            // 
            // lb_fname
            // 
            this.lb_fname.AutoSize = true;
            this.lb_fname.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lb_fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fname.Location = new System.Drawing.Point(41, 68);
            this.lb_fname.Name = "lb_fname";
            this.lb_fname.Size = new System.Drawing.Size(78, 16);
            this.lb_fname.TabIndex = 18;
            this.lb_fname.Text = "First Name :";
            // 
            // lb_employeeno
            // 
            this.lb_employeeno.AutoSize = true;
            this.lb_employeeno.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lb_employeeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_employeeno.Location = new System.Drawing.Point(41, 39);
            this.lb_employeeno.Name = "lb_employeeno";
            this.lb_employeeno.Size = new System.Drawing.Size(96, 16);
            this.lb_employeeno.TabIndex = 19;
            this.lb_employeeno.Text = "Employee No :";
            // 
            // cmb_manager
            // 
            this.cmb_manager.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_manager.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_manager.FormattingEnabled = true;
            this.cmb_manager.Location = new System.Drawing.Point(167, 154);
            this.cmb_manager.Name = "cmb_manager";
            this.cmb_manager.Size = new System.Drawing.Size(238, 24);
            this.cmb_manager.TabIndex = 7;
            // 
            // cmb_deptcode
            // 
            this.cmb_deptcode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_deptcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_deptcode.FormattingEnabled = true;
            this.cmb_deptcode.Location = new System.Drawing.Point(543, 156);
            this.cmb_deptcode.Name = "cmb_deptcode";
            this.cmb_deptcode.Size = new System.Drawing.Size(182, 24);
            this.cmb_deptcode.TabIndex = 8;
            // 
            // Employee_Edit_New
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(803, 319);
            this.Controls.Add(this.cmb_deptcode);
            this.Controls.Add(this.cmb_manager);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtp_hiredate);
            this.Controls.Add(this.cmb_job);
            this.Controls.Add(this.cmb_gender);
            this.Controls.Add(this.lb_deptcode);
            this.Controls.Add(this.txt_salary);
            this.Controls.Add(this.lb_manager);
            this.Controls.Add(this.txt_lname);
            this.Controls.Add(this.lb_salary);
            this.Controls.Add(this.txt_fname);
            this.Controls.Add(this.lb_hdate);
            this.Controls.Add(this.lb_job);
            this.Controls.Add(this.lb_gender);
            this.Controls.Add(this.lb_lname);
            this.Controls.Add(this.txt_empno);
            this.Controls.Add(this.lb_fname);
            this.Controls.Add(this.lb_employeeno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Employee_Edit_New";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Edit_New_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.DateTimePicker dtp_hiredate;
        public System.Windows.Forms.ComboBox cmb_job;
        public System.Windows.Forms.ComboBox cmb_gender;
        private System.Windows.Forms.Label lb_deptcode;
        public System.Windows.Forms.TextBox txt_salary;
        private System.Windows.Forms.Label lb_manager;
        public System.Windows.Forms.TextBox txt_lname;
        private System.Windows.Forms.Label lb_salary;
        public System.Windows.Forms.TextBox txt_fname;
        private System.Windows.Forms.Label lb_hdate;
        private System.Windows.Forms.Label lb_job;
        private System.Windows.Forms.Label lb_gender;
        private System.Windows.Forms.Label lb_lname;
        public System.Windows.Forms.TextBox txt_empno;
        private System.Windows.Forms.Label lb_fname;
        private System.Windows.Forms.Label lb_employeeno;
        public System.Windows.Forms.ComboBox cmb_manager;
        public System.Windows.Forms.ComboBox cmb_deptcode;
    }
}