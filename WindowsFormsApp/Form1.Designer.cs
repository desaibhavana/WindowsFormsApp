namespace WindowsFormsApp
{
    partial class Form1
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
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.btnNumberSquare = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDemo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumber
            // 
            this.txtNumber.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtNumber.Location = new System.Drawing.Point(299, 57);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(157, 26);
            this.txtNumber.TabIndex = 0;
            // 
            // btnNumberSquare
            // 
            this.btnNumberSquare.AutoSize = true;
            this.btnNumberSquare.Location = new System.Drawing.Point(299, 163);
            this.btnNumberSquare.Name = "btnNumberSquare";
            this.btnNumberSquare.Size = new System.Drawing.Size(171, 54);
            this.btnNumberSquare.TabIndex = 1;
            this.btnNumberSquare.Text = "Square of number";
            this.btnNumberSquare.UseVisualStyleBackColor = true;
            this.btnNumberSquare.Click += new System.EventHandler(this.btnNumberSquare_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.IndianRed;
            this.lblResult.Location = new System.Drawing.Point(295, 272);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 29);
            this.lblResult.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(300, 318);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 54);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDemo
            // 
            this.btnDemo.Location = new System.Drawing.Point(599, 179);
            this.btnDemo.Name = "btnDemo";
            this.btnDemo.Size = new System.Drawing.Size(75, 23);
            this.btnDemo.TabIndex = 4;
            this.btnDemo.Text = "button1";
            this.btnDemo.UseVisualStyleBackColor = true;
            this.btnDemo.Click += new System.EventHandler(this.btnDemo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDemo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnNumberSquare);
            this.Controls.Add(this.txtNumber);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "First Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button btnNumberSquare;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDemo;
    }
}

