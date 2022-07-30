namespace EmployeeManagement1
{
    partial class Department_Edit_New
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txt_dept_code = new System.Windows.Forms.TextBox();
            this.txt_dept_location = new System.Windows.Forms.TextBox();
            this.txt_dept_name = new System.Windows.Forms.TextBox();
            this.lb_deptname = new System.Windows.Forms.Label();
            this.lb_deptcode = new System.Windows.Forms.Label();
            this.lb_location = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(89, 232);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 33);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(194, 232);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 33);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // txt_dept_code
            // 
            this.txt_dept_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dept_code.Location = new System.Drawing.Point(150, 68);
            this.txt_dept_code.Name = "txt_dept_code";
            this.txt_dept_code.Size = new System.Drawing.Size(194, 22);
            this.txt_dept_code.TabIndex = 0;
            // 
            // txt_dept_location
            // 
            this.txt_dept_location.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dept_location.Location = new System.Drawing.Point(150, 120);
            this.txt_dept_location.Name = "txt_dept_location";
            this.txt_dept_location.Size = new System.Drawing.Size(194, 22);
            this.txt_dept_location.TabIndex = 2;
            // 
            // txt_dept_name
            // 
            this.txt_dept_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dept_name.Location = new System.Drawing.Point(150, 94);
            this.txt_dept_name.Name = "txt_dept_name";
            this.txt_dept_name.Size = new System.Drawing.Size(194, 22);
            this.txt_dept_name.TabIndex = 1;
            // 
            // lb_deptname
            // 
            this.lb_deptname.AutoSize = true;
            this.lb_deptname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_deptname.Location = new System.Drawing.Point(21, 97);
            this.lb_deptname.Name = "lb_deptname";
            this.lb_deptname.Size = new System.Drawing.Size(123, 16);
            this.lb_deptname.TabIndex = 3;
            this.lb_deptname.Text = "Department Name :";
            // 
            // lb_deptcode
            // 
            this.lb_deptcode.AutoSize = true;
            this.lb_deptcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_deptcode.Location = new System.Drawing.Point(25, 71);
            this.lb_deptcode.Name = "lb_deptcode";
            this.lb_deptcode.Size = new System.Drawing.Size(119, 16);
            this.lb_deptcode.TabIndex = 3;
            this.lb_deptcode.Text = "Department Code :";
            // 
            // lb_location
            // 
            this.lb_location.AutoSize = true;
            this.lb_location.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_location.Location = new System.Drawing.Point(53, 123);
            this.lb_location.Name = "lb_location";
            this.lb_location.Size = new System.Drawing.Size(91, 16);
            this.lb_location.TabIndex = 3;
            this.lb_location.Text = "Location          :";
            // 
            // Department_Edit_New
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(380, 325);
            this.Controls.Add(this.lb_deptcode);
            this.Controls.Add(this.lb_location);
            this.Controls.Add(this.lb_deptname);
            this.Controls.Add(this.txt_dept_name);
            this.Controls.Add(this.txt_dept_location);
            this.Controls.Add(this.txt_dept_code);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Department_Edit_New";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Department";
            this.Load += new System.EventHandler(this.Department_Edit_New_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lb_deptname;
        private System.Windows.Forms.Label lb_deptcode;
        private System.Windows.Forms.Label lb_location;
        public System.Windows.Forms.TextBox txt_dept_code;
        public System.Windows.Forms.TextBox txt_dept_location;
        public System.Windows.Forms.TextBox txt_dept_name;
    }
}