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
    public partial class LoginForm : Form
    {
        SqlConnection connection;
        DataSet dataset;

        public LoginForm()
        {
            InitializeComponent();

            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            string sql = "Select * from Userdata";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            dataset = new DataSet();
            adapter.Fill(dataset, "userdata");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String sql = "Select count(*) from UserData where UserName=@name and password=@pwd";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("name", txtUserName.Text);
            command.Parameters.AddWithValue("pwd", txtPassword.Text);
            connection.Open();
            object count = command.ExecuteScalar();
            connection.Close();
            if ((int)count == 1)
            {
                MessageBox.Show("Valid user");
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }


        }

        private void btnLoginDisconnect_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == string.Empty || txtPassword.Text == string.Empty)
            {
                return;
            }

            string filter = $"username  = '{txtUserName.Text}' and password = '{txtPassword.Text}'";

            //DataRow[] rows = dataset.Tables["userdata"].Select(filter);

            //if (rows.Length > 0)
            //{
            //    MessageBox.Show("valid user");
            //}
            //else
            //{
            //    MessageBox.Show("Invalid User");
            //}


            //------------------
            DataView view = dataset.Tables["userdata"].DefaultView;
            view.RowFilter = filter;
            if (view.Count == 1)
            {
                MessageBox.Show("valid user");
            }
            else
            {
                MessageBox.Show("Invalid User");
            }
        }

       
    }
}
