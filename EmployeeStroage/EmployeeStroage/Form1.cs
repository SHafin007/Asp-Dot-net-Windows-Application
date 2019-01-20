using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeStroage
{
    public partial class EmployeeInformationForm : Form
    {
        public EmployeeInformationForm()
        {
            InitializeComponent();
        }
        Employee anEmployee = new Employee();

        private void Showbutton_Click(object sender, EventArgs e)
        {
            anEmployee.id = EmployeeIDtextBox.Text;
            anEmployee.name = EmployeeNametextBox.Text;
            anEmployee.salary = EmployeeSalarytextBox.Text;

            EmployeeIDtextBox.Clear();
            EmployeeNametextBox.Clear();
            EmployeeSalarytextBox.Clear();

            string msgOut = "Employee Information " + Environment.NewLine +
                            "Employee ID : " + anEmployee.id + Environment.NewLine +
                            "Employee Name : " + anEmployee.name + Environment.NewLine +
                            "Employee Salary : " + anEmployee.salary + Environment.NewLine;
            MessageBox.Show(msgOut);

        }

        private void Retrivebutton_Click(object sender, EventArgs e)
        {
            EmployeeIDtextBox.Text = anEmployee.id;
            EmployeeNametextBox.Text = anEmployee.name;
            EmployeeSalarytextBox.Text = anEmployee.salary;
        }
    }
}
