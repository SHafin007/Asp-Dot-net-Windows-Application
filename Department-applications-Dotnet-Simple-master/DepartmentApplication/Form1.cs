using DepartmentApplication.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepartmentApplication
{
    public partial class StudentEntryForm : Form
    {

        private Department aDepartment;
        public StudentEntryForm()
        {
            InitializeComponent();
        }

        private void DepartmentSavebutton_Click(object sender, EventArgs e)
        {
           aDepartment = new Department(DepartmentCodeTextBox.Text,DepartmentNameTextBox.Text);

            MessageBox.Show("Department Created");
        }

        private void StudentSaveButton_Click(object sender, EventArgs e)
        {
            Student aStudent = new Student(StudentRegNoTextBox.Text,StudentNameTextBox.Text,StudentEmailTextBox.Text);
           string msgOut = aDepartment.Add(aStudent);
            MessageBox.Show(msgOut);
        }

        private void ShowDetailsbutton_Click(object sender, EventArgs e)
        {
            string information = "Department Code :" + aDepartment.Department_code + " Name : " + aDepartment.Department_name + Environment.NewLine;
            information += "Name \t" + "RegNo\t" + "Email"+Environment.NewLine;
            foreach (Student astudent in aDepartment.Students)
            {
                information += astudent.Student_name + "\t" + astudent.Student_regNo + "\t" + astudent.Student_email + Environment.NewLine;
            }
            MessageBox.Show(information);
        }
    }
} 
