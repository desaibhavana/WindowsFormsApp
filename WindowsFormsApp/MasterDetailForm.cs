using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace WindowsFormsApp
{
    public partial class MasterDetailForm : Form
    {
        SqlConnection connection = null;
        SqlCommand command = null;

        public MasterDetailForm()
        {
            InitializeComponent();

            string connectionstring = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;

            connection = new SqlConnection(connectionstring);
        }

        private void MasterDetailForm_Load(object sender, EventArgs e)
        {
            command = new SqlCommand("select * from dept", connection);
           
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            SqlDataReader reader = command.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);

            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }

            lstDept.DisplayMember = "dname";
            lstDept.ValueMember = "deptno";
            lstDept.DataSource = table;
        }

        private void lstDept_SelectedIndexChanged(object sender, EventArgs e)
        {
           // MessageBox.Show(lstDept.Text + " " +   lstDept.SelectedValue.ToString());

            //pass deptno to you query and select emps working for that deptno
            //display emps in datagridview

            //use connected architecture only
            int dno = (int)lstDept.SelectedValue;
            //command = new SqlCommand($"select * from emp where deptno ={dno}; ", connection);

            //parameterized query
            command = new SqlCommand("select * from emp where deptno = @dno", connection);

            command.Parameters.AddWithValue("dno", dno);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            SqlDataReader reader = command.ExecuteReader();
          
            DataTable table = new DataTable();
            table.Load(reader);

            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }

            dataEmps.DataSource = table;
        }
    }
}
