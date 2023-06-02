using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataGrid_
{
    public class Student
    {
        public string Name { get; set; }

        public int Grade { get; set; }

        public DateTime Birthday { get; set; }

        public Student() { }
        public Student(string name, int grade, DateTime birthday)
        {
            Name = name;
            Grade = grade;
            Birthday = birthday;
        }
    }
}
