namespace WindowsFormsApp
{
    partial class DataDMLForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.EmployeeGridView = new System.Windows.Forms.DataGridView();
            this.dtpickerHireDate = new System.Windows.Forms.DateTimePicker();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblHireDate = new System.Windows.Forms.Label();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.lblEmpno = new System.Windows.Forms.Label();
            this.txtEmpNo = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnInsertSP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDeptno = new System.Windows.Forms.TextBox();
            this.btnSPData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.Location = new System.Drawing.Point(107, 345);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 30);
            this.btnClear.TabIndex = 26;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.Location = new System.Drawing.Point(521, 345);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 30);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.Location = new System.Drawing.Point(385, 345);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 30);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "UpDate";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.AutoSize = true;
            this.btnInsert.Location = new System.Drawing.Point(248, 345);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 30);
            this.btnInsert.TabIndex = 23;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // EmployeeGridView
            // 
            this.EmployeeGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeGridView.Location = new System.Drawing.Point(63, 427);
            this.EmployeeGridView.Name = "EmployeeGridView";
            this.EmployeeGridView.RowHeadersWidth = 62;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.EmployeeGridView.RowTemplate.Height = 28;
            this.EmployeeGridView.Size = new System.Drawing.Size(1426, 296);
            this.EmployeeGridView.TabIndex = 22;
            // 
            // dtpickerHireDate
            // 
            this.dtpickerHireDate.Location = new System.Drawing.Point(234, 199);
            this.dtpickerHireDate.Name = "dtpickerHireDate";
            this.dtpickerHireDate.Size = new System.Drawing.Size(222, 26);
            this.dtpickerHireDate.TabIndex = 21;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(234, 267);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(222, 26);
            this.txtSalary.TabIndex = 20;
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(234, 128);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(222, 26);
            this.txtEmpName.TabIndex = 19;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(59, 267);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(53, 20);
            this.lblSalary.TabIndex = 18;
            this.lblSalary.Text = "Salary";
            // 
            // lblHireDate
            // 
            this.lblHireDate.AutoSize = true;
            this.lblHireDate.Location = new System.Drawing.Point(59, 205);
            this.lblHireDate.Name = "lblHireDate";
            this.lblHireDate.Size = new System.Drawing.Size(73, 20);
            this.lblHireDate.TabIndex = 17;
            this.lblHireDate.Text = "HireDate";
            // 
            // lblEmpName
            // 
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.Location = new System.Drawing.Point(59, 128);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(84, 20);
            this.lblEmpName.TabIndex = 16;
            this.lblEmpName.Text = "EmpName";
            // 
            // lblEmpno
            // 
            this.lblEmpno.AutoSize = true;
            this.lblEmpno.Location = new System.Drawing.Point(59, 67);
            this.lblEmpno.Name = "lblEmpno";
            this.lblEmpno.Size = new System.Drawing.Size(62, 20);
            this.lblEmpno.TabIndex = 14;
            this.lblEmpno.Text = "EmpNo";
            // 
            // txtEmpNo
            // 
            this.txtEmpNo.Location = new System.Drawing.Point(234, 64);
            this.txtEmpNo.Name = "txtEmpNo";
            this.txtEmpNo.Size = new System.Drawing.Size(226, 26);
            this.txtEmpNo.TabIndex = 27;
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.Location = new System.Drawing.Point(532, 64);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(144, 30);
            this.btnSearch.TabIndex = 28;
            this.btnSearch.Text = "Search Employee";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnInsertSP
            // 
            this.btnInsertSP.AutoSize = true;
            this.btnInsertSP.Location = new System.Drawing.Point(649, 345);
            this.btnInsertSP.Name = "btnInsertSP";
            this.btnInsertSP.Size = new System.Drawing.Size(85, 30);
            this.btnInsertSP.TabIndex = 29;
            this.btnInsertSP.Text = "Insert SP";
            this.btnInsertSP.UseVisualStyleBackColor = true;
            this.btnInsertSP.Click += new System.EventHandler(this.btnInsertSP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(772, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Deptno";
            // 
            // txtDeptno
            // 
            this.txtDeptno.Location = new System.Drawing.Point(869, 67);
            this.txtDeptno.Name = "txtDeptno";
            this.txtDeptno.Size = new System.Drawing.Size(143, 26);
            this.txtDeptno.TabIndex = 31;
            // 
            // btnSPData
            // 
            this.btnSPData.AutoSize = true;
            this.btnSPData.Location = new System.Drawing.Point(1043, 67);
            this.btnSPData.Name = "btnSPData";
            this.btnSPData.Size = new System.Drawing.Size(86, 30);
            this.btnSPData.TabIndex = 32;
            this.btnSPData.Text = "SP DEPT";
            this.btnSPData.UseVisualStyleBackColor = true;
            this.btnSPData.Click += new System.EventHandler(this.btnSPData_Click);
            // 
            // DataDMLForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1549, 783);
            this.Controls.Add(this.btnSPData);
            this.Controls.Add(this.txtDeptno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInsertSP);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtEmpNo);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.EmployeeGridView);
            this.Controls.Add(this.dtpickerHireDate);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblHireDate);
            this.Controls.Add(this.lblEmpName);
            this.Controls.Add(this.lblEmpno);
            this.Name = "DataDMLForm";
            this.Text = "DataDMLForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DataDMLForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DataGridView EmployeeGridView;
        private System.Windows.Forms.DateTimePicker dtpickerHireDate;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblHireDate;
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.Label lblEmpno;
        private System.Windows.Forms.TextBox txtEmpNo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnInsertSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDeptno;
        private System.Windows.Forms.Button btnSPData;
    }
}