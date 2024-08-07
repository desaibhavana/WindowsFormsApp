namespace WindowsFormsApp
{
    partial class DataForm
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
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnected = new System.Windows.Forms.Button();
            this.dbData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dbData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.AutoSize = true;
            this.btnDisconnect.Location = new System.Drawing.Point(151, 54);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(99, 30);
            this.btnDisconnect.TabIndex = 0;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnected
            // 
            this.btnConnected.AutoSize = true;
            this.btnConnected.Location = new System.Drawing.Point(576, 54);
            this.btnConnected.Name = "btnConnected";
            this.btnConnected.Size = new System.Drawing.Size(97, 30);
            this.btnConnected.TabIndex = 1;
            this.btnConnected.Text = "Connected";
            this.btnConnected.UseVisualStyleBackColor = true;
            this.btnConnected.Click += new System.EventHandler(this.btnConnected_Click);
            // 
            // dbData
            // 
            this.dbData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dbData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbData.Location = new System.Drawing.Point(151, 153);
            this.dbData.Name = "dbData";
            this.dbData.RowHeadersWidth = 62;
            this.dbData.RowTemplate.Height = 28;
            this.dbData.Size = new System.Drawing.Size(622, 274);
            this.dbData.TabIndex = 2;
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dbData);
            this.Controls.Add(this.btnConnected);
            this.Controls.Add(this.btnDisconnect);
            this.Name = "DataForm";
            this.Text = "DataForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnected;
        private System.Windows.Forms.DataGridView dbData;
    }
}