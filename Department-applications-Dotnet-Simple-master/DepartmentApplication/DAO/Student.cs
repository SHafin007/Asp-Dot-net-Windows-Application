using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentApplication.DAO
{
   public class Student
    {
        private string student_regNo;
        private string student_name;
        private string student_email;

        public Student(string student_regNo, string student_name, string student_email)
        {
            this.Student_regNo = student_regNo;
            this.Student_name = student_name;
            this.Student_email = student_email;
        }

        public string Student_regNo { get => student_regNo; set => student_regNo = value; }
        public string Student_name { get => student_name; set => student_name = value; }
        public string Student_email { get => student_email; set => student_email = value; }
    }

   
}
