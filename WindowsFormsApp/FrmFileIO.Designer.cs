namespace WindowsFormsApp
{
    partial class FrmFileIO
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
            this.btnWriteFile = new System.Windows.Forms.Button();
            this.btnReadFile = new System.Windows.Forms.Button();
            this.txtArea = new System.Windows.Forms.RichTextBox();
            this.btnReadWrite = new System.Windows.Forms.Button();
            this.btnWriteObject = new System.Windows.Forms.Button();
            this.btnWriteBinary = new System.Windows.Forms.Button();
            this.btnReadBinary = new System.Windows.Forms.Button();
            this.btnWriteJSON = new System.Windows.Forms.Button();
            this.btnReadJson = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWriteFile
            // 
            this.btnWriteFile.AutoSize = true;
            this.btnWriteFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWriteFile.Location = new System.Drawing.Point(41, 51);
            this.btnWriteFile.Name = "btnWriteFile";
            this.btnWriteFile.Size = new System.Drawing.Size(152, 39);
            this.btnWriteFile.TabIndex = 0;
            this.btnWriteFile.Text = "Write to File";
            this.btnWriteFile.UseVisualStyleBackColor = true;
            this.btnWriteFile.Click += new System.EventHandler(this.btnWriteFile_Click);
            // 
            // btnReadFile
            // 
            this.btnReadFile.AutoSize = true;
            this.btnReadFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadFile.Location = new System.Drawing.Point(266, 51);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(182, 39);
            this.btnReadFile.TabIndex = 1;
            this.btnReadFile.Text = "Read from File";
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // txtArea
            // 
            this.txtArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArea.Location = new System.Drawing.Point(52, 192);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(1340, 388);
            this.txtArea.TabIndex = 2;
            this.txtArea.Text = "";
            // 
            // btnReadWrite
            // 
            this.btnReadWrite.AutoSize = true;
            this.btnReadWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadWrite.Location = new System.Drawing.Point(536, 51);
            this.btnReadWrite.Name = "btnReadWrite";
            this.btnReadWrite.Size = new System.Drawing.Size(182, 39);
            this.btnReadWrite.TabIndex = 3;
            this.btnReadWrite.Text = "Write & Read ";
            this.btnReadWrite.UseVisualStyleBackColor = true;
            this.btnReadWrite.Click += new System.EventHandler(this.btnReadWrite_Click);
            // 
            // btnWriteObject
            // 
            this.btnWriteObject.AutoSize = true;
            this.btnWriteObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWriteObject.Location = new System.Drawing.Point(773, 51);
            this.btnWriteObject.Name = "btnWriteObject";
            this.btnWriteObject.Size = new System.Drawing.Size(239, 39);
            this.btnWriteObject.TabIndex = 4;
            this.btnWriteObject.Text = "Write Object To File";
            this.btnWriteObject.UseVisualStyleBackColor = true;
            this.btnWriteObject.Click += new System.EventHandler(this.btnWriteObject_Click);
            // 
            // btnWriteBinary
            // 
            this.btnWriteBinary.AutoSize = true;
            this.btnWriteBinary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWriteBinary.Location = new System.Drawing.Point(52, 119);
            this.btnWriteBinary.Name = "btnWriteBinary";
            this.btnWriteBinary.Size = new System.Drawing.Size(290, 39);
            this.btnWriteBinary.TabIndex = 5;
            this.btnWriteBinary.Text = "Write Binary Serialization";
            this.btnWriteBinary.UseVisualStyleBackColor = true;
            this.btnWriteBinary.Click += new System.EventHandler(this.btnWriteBinary_Click);
            // 
            // btnReadBinary
            // 
            this.btnReadBinary.AutoSize = true;
            this.btnReadBinary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadBinary.Location = new System.Drawing.Point(376, 119);
            this.btnReadBinary.Name = "btnReadBinary";
            this.btnReadBinary.Size = new System.Drawing.Size(292, 39);
            this.btnReadBinary.TabIndex = 6;
            this.btnReadBinary.Text = "Read Binary Serialization";
            this.btnReadBinary.UseVisualStyleBackColor = true;
            this.btnReadBinary.Click += new System.EventHandler(this.btnReadBinary_Click);
            // 
            // btnWriteJSON
            // 
            this.btnWriteJSON.AutoSize = true;
            this.btnWriteJSON.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWriteJSON.Location = new System.Drawing.Point(697, 119);
            this.btnWriteJSON.Name = "btnWriteJSON";
            this.btnWriteJSON.Size = new System.Drawing.Size(292, 39);
            this.btnWriteJSON.TabIndex = 7;
            this.btnWriteJSON.Text = "Write JSON Serialization";
            this.btnWriteJSON.UseVisualStyleBackColor = true;
            this.btnWriteJSON.Click += new System.EventHandler(this.btnWriteJSON_Click);
            // 
            // btnReadJson
            // 
            this.btnReadJson.AutoSize = true;
            this.btnReadJson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadJson.Location = new System.Drawing.Point(1046, 119);
            this.btnReadJson.Name = "btnReadJson";
            this.btnReadJson.Size = new System.Drawing.Size(292, 39);
            this.btnReadJson.TabIndex = 8;
            this.btnReadJson.Text = "Read JSON Serialization";
            this.btnReadJson.UseVisualStyleBackColor = true;
            this.btnReadJson.Click += new System.EventHandler(this.btnReadJson_Click);
            // 
            // FrmFileIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1441, 629);
            this.Controls.Add(this.btnReadJson);
            this.Controls.Add(this.btnWriteJSON);
            this.Controls.Add(this.btnReadBinary);
            this.Controls.Add(this.btnWriteBinary);
            this.Controls.Add(this.btnWriteObject);
            this.Controls.Add(this.btnReadWrite);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.btnReadFile);
            this.Controls.Add(this.btnWriteFile);
            this.Name = "FrmFileIO";
            this.Text = "FrmFileIO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWriteFile;
        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.RichTextBox txtArea;
        private System.Windows.Forms.Button btnReadWrite;
        private System.Windows.Forms.Button btnWriteObject;
        private System.Windows.Forms.Button btnWriteBinary;
        private System.Windows.Forms.Button btnReadBinary;
        private System.Windows.Forms.Button btnWriteJSON;
        private System.Windows.Forms.Button btnReadJson;
    }
}