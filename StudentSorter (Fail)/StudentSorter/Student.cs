using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StudentSorter
{
    internal class Student
    {
        public string Name;
        public double Grade;

        public Student(string name, double grade)
        {
            name = Name;
            grade = Grade;
        }

        public override string ToString()
        {
            return $"{Name} {Grade:f2}";
        }
    }
}
