using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_Student_management_CRUD_
{
    public class Student
    {
            public string Name { get; set; }
            public int Age { get; set; }
            public string ClassName { get; set; }
            // Static list to store all students
            public static List<Student> StudentList = new List<Student>();

        }
}
