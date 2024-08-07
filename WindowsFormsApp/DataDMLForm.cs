using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADOLibrary;

namespace WindowsFormsApp
{
    public partial class DataDMLForm : Form
    {
        EmployeeDataStore dataStore;
        public DataDMLForm()
        {
            InitializeComponent();
            string connectionstring = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;

            dataStore = new EmployeeDataStore(connectionstring);
        }

        private void DataDMLForm_Load(object sender, EventArgs e)
        {
            txtEmpNo.Focus();
            EmployeeGridView.DataSource = dataStore.GetEmployees();
        }
        void Clear()
        {
            txtEmpNo.Clear();
            txtEmpName.Clear();
            txtSalary.Clear();
            dtpickerHireDate.Value = DateTime.Now;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int empno = Convert.ToInt32(txtEmpNo.Text);
            Employee employee = dataStore.GetEmpByNo(empno);

            if (employee != null)  //found
            {
                txtEmpNo.Text = employee.EmpNo.ToString();
                txtEmpName.Text = employee.EmpName; ;
                txtSalary.Text = employee.Salary.ToString();
                dtpickerHireDate.Value = employee.HireDate.HasValue ? Convert.ToDateTime( employee.HireDate) : DateTime.Now;
            } 
            else
            {
                MessageBox.Show($"Empno {empno} not found ");
                Clear();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee();
                employee.EmpNo = Convert.ToInt32(txtEmpNo.Text);
                employee.EmpName = txtEmpName.Text;
                employee.HireDate = dtpickerHireDate.Value;
                employee.Salary = null; //Convert.ToDecimal(txtSalary.Text);    


                int count = dataStore.AddEmployee(employee);

                MessageBox.Show($"{count} record inserted");
                DataDMLForm_Load(null, null);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee();
                employee.EmpNo = Convert.ToInt32(txtEmpNo.Text);
                employee.EmpName = txtEmpName.Text;
                employee.HireDate = dtpickerHireDate.Value;
                employee.Salary = Convert.ToDecimal(txtSalary.Text);


                int count = dataStore.UpdateEmployee(employee);

                MessageBox.Show($"{count} record updated");
                DataDMLForm_Load(null, null);
                Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int eno = Convert.ToInt32(txtEmpNo.Text);              

                int count = dataStore.RemoveEmployee(eno);

                MessageBox.Show($"{count} record deleted");
                DataDMLForm_Load(null, null);
                Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnInsertSP_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee();
                employee.EmpNo = Convert.ToInt32(txtEmpNo.Text);
                employee.EmpName = txtEmpName.Text;
                employee.HireDate = dtpickerHireDate.Value;
                employee.Salary = null; //Convert.ToDecimal(txtSalary.Text);    


                int count = dataStore.AddEmployee_sp(employee);

                MessageBox.Show($"{count} record inserted");
                DataDMLForm_Load(null, null);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSPData_Click(object sender, EventArgs e)
        {
            int dno = Convert.ToInt32(txtDeptno.Text);

            EmployeeGridView.DataSource = dataStore.GetEmployeesByDept(dno);
        }
    }
}
