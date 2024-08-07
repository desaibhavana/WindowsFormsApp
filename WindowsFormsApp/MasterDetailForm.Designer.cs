namespace WindowsFormsApp
{
    partial class MasterDetailForm
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
            this.lstDept = new System.Windows.Forms.ListBox();
            this.dataEmps = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataEmps)).BeginInit();
            this.SuspendLayout();
            // 
            // lstDept
            // 
            this.lstDept.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstDept.FormattingEnabled = true;
            this.lstDept.ItemHeight = 20;
            this.lstDept.Location = new System.Drawing.Point(12, 56);
            this.lstDept.Name = "lstDept";
            this.lstDept.Size = new System.Drawing.Size(228, 424);
            this.lstDept.TabIndex = 0;
            this.lstDept.SelectedIndexChanged += new System.EventHandler(this.lstDept_SelectedIndexChanged);
            // 
            // dataEmps
            // 
            this.dataEmps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataEmps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEmps.Location = new System.Drawing.Point(364, 56);
            this.dataEmps.Name = "dataEmps";
            this.dataEmps.RowHeadersWidth = 62;
            this.dataEmps.RowTemplate.Height = 28;
            this.dataEmps.Size = new System.Drawing.Size(501, 417);
            this.dataEmps.TabIndex = 1;
            // 
            // MasterDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 532);
            this.Controls.Add(this.dataEmps);
            this.Controls.Add(this.lstDept);
            this.Name = "MasterDetailForm";
            this.Text = "MasterDetailForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MasterDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataEmps)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstDept;
        private System.Windows.Forms.DataGridView dataEmps;
    }
}