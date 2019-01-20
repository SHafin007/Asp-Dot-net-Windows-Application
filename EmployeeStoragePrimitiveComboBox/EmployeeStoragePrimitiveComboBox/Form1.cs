using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeStoragePrimitiveComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Employee anEmployee = new Employee();
        List<Employee> employee = new List<Employee>();
        private void Showbutton_Click(object sender, EventArgs e)
        {
            Employee anEmployee = new Employee();
            anEmployee.id = EmployeeIDtextBox.Text;
            anEmployee.name = EmployeeNametextBox.Text;
            anEmployee.salary = EmployeeSalarytextBox.Text;

            employee.Add(anEmployee);

            EmployeeIDtextBox.Clear();
            EmployeeNametextBox.Clear();
            EmployeeSalarytextBox.Clear();

            EmployeecomboBox.DataSource = null;
            EmployeecomboBox.DataSource = employee;

            EmployeecomboBox.ValueMember = "id";
            EmployeecomboBox.DisplayMember = "name";

            string msgOut = "Employee Information " + Environment.NewLine +
                            "Employee ID : " + anEmployee.id + Environment.NewLine +
                            "Employee Name : " + anEmployee.name + Environment.NewLine +
                            "Employee Salary : " + anEmployee.salary + Environment.NewLine;

            MessageBox.Show(msgOut);

        }

        private void Retrivebutton_Click(object sender, EventArgs e)
        {
            Employee selectEmployee = (Employee)EmployeecomboBox.SelectedItem;

            EmployeeIDtextBox.Text = selectEmployee.id;
            EmployeeNametextBox.Text = selectEmployee.name;
            EmployeeSalarytextBox.Text = selectEmployee.salary;

        }
    }
}
