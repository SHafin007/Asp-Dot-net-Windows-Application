using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentApplication.DAO
{
    class Department
    {
        private string department_code;
        private string department_name;
        private List<Student> students = new List<Student>();
        private const int MAX_NUMBER_OF_STUDENTS = 10;

        public Department (string department_code, string department_name)
        {
            this.Department_code = department_code;
            this.Department_name = department_name;
        }

        public string Department_name { get => department_name; set => department_name = value; }
        public string Department_code { get => department_code; set => department_code = value; }
        public List<Student> Students { get => students; set => students = value; }

        public string Add ( Student aStudent)
        {
            if(students.Count< MAX_NUMBER_OF_STUDENTS)
            {
                if(!DoesExist(aStudent.Student_regNo))
                {
                    Students.Add(aStudent);
                    return "Studen has been saved";
                }
                else
                {
                    return "You have already exist";
                }
                
            }
            else
            {
                return " Student not Add ";
            }
            
        }

        private bool DoesExist(string student_regNo)
        {
            foreach(Student aStudent in students)
            {
                if (aStudent.Student_regNo == student_regNo)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
