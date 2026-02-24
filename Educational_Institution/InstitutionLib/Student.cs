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
        public string FirstName
        {
            get { return firstName_; }
        }
        public string LastName
        {
            get { return lastName_; }
        }
        public int Age
        {
            get { return age_; }
        }
        public string GetFullName()
        {
            return $"{firstName_} {lastName_}";
        }
    }
}
