namespace EmployeeManagement1
{
    partial class Department_validation
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
            this.lb_warningmessage = new System.Windows.Forms.Label();
            this.cmb_dept_name = new System.Windows.Forms.ComboBox();
            this.btnok = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_warningmessage
            // 
            this.lb_warningmessage.AutoSize = true;
            this.lb_warningmessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_warningmessage.Location = new System.Drawing.Point(12, 31);
            this.lb_warningmessage.Name = "lb_warningmessage";
            this.lb_warningmessage.Size = new System.Drawing.Size(0, 16);
            this.lb_warningmessage.TabIndex = 0;
            // 
            // cmb_dept_name
            // 
            this.cmb_dept_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_dept_name.FormattingEnabled = true;
            this.cmb_dept_name.Location = new System.Drawing.Point(214, 79);
            this.cmb_dept_name.Name = "cmb_dept_name";
            this.cmb_dept_name.Size = new System.Drawing.Size(162, 21);
            this.cmb_dept_name.TabIndex = 0;
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(188, 132);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(75, 23);
            this.btnok.TabIndex = 1;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btncancel
            // 
            this.btncancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancel.Location = new System.Drawing.Point(301, 132);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 2;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // Department_validation
            // 
            this.AcceptButton = this.btnok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btncancel;
            this.ClientSize = new System.Drawing.Size(613, 187);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.cmb_dept_name);
            this.Controls.Add(this.lb_warningmessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Department_validation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Department Validation";
            this.Load += new System.EventHandler(this.Department_validation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_warningmessage;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Button btncancel;
        public System.Windows.Forms.ComboBox cmb_dept_name;
    }
}