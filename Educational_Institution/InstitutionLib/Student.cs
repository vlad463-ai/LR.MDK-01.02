using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitutionLib
{
    public class Student
    {
        private string firstName_;
        private string lastName_;
        private int age_;

        public Student(string firstName, string lastName, int age)
        {
            firstName_ = firstName;
            lastName_ = lastName;
            age_ = age;
        }
        
    }
}
