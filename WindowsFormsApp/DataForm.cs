using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace WindowsFormsApp
{
    public partial class DataForm : Form
    {
        SqlConnection connection=null;

        public DataForm()
        {
            InitializeComponent();

            //Project menu --->  Add reference - System.Configuration
            //using System.Configuration

            string connectionstring = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;

             connection = new SqlConnection(connectionstring);
        }

        private void DataForm_Load(object sender, EventArgs e)
        {

        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            //SqlConnection connection = new SqlConnection("server=BHAVANA;database=trainingdb;user id=sa;password=admin@123");

            // SqlConnection connection = new SqlConnection("server=BHAVANA;database=trainingdb;integrated security=true");

            //SqlConnection connection = new SqlConnection("data source=(localdb)\\MSSQLLocalDB; initial catalog=trainingdb;integrated security=true;Trust Server Certificate=true;");

        

            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from dept", connection);

            DataSet dataSet = new DataSet();

            //dataAdapter.Fill(dataset-object, "datatable-name");   
            dataAdapter.Fill(dataSet, "dept");       

            dbData.DataSource = dataSet.Tables["dept"];

            //in same dataset object add multiple table data
            //position 0 - dept table
            //position 1 - emp table
            dataAdapter.SelectCommand.CommandText = "select * from emp";
            dataAdapter.Fill(dataSet, "emp");
        }

        private void btnConnected_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from emp", connection);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

           SqlDataReader reader =  command.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);

            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }

            dbData.DataSource = table;

        }
    }
}
