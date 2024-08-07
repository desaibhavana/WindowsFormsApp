using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNumberSquare_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == string.Empty)
            {
                txtNumber.Focus();
                MessageBox.Show("Please enter integer","Error",MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;
            }
            int number = Convert.ToInt32(txtNumber.Text);
            lblResult.Text = (number * number).ToString();
        }

        //private void Form1_Load(object sender, EventArgs e)
        //{

        //}

    
        //private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        //{
            
        //}

        private void btnExit_Click(object sender, EventArgs e)
        {

          DialogResult result =    MessageBox.Show("Are you sure you want to exit application?", "Exit Window", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                // this.Close();
                Application.Exit();
            }
          
        }

        private void btnDemo_Click(object sender, EventArgs e)
        {

        }
    }
}
