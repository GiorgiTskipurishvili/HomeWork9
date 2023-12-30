using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9
{
    internal class Student
    {
        private string name;
        private int age;
        private int enrollmentYear;

        public string Name {  get { return name; } }
        public int Age { get { return age; } }
        public int EnrollmentYear { get {  return enrollmentYear; } }


        public Student(string name, int age, int enrollmentYear) 
        {
            this.name = name;
            this.age = age;
            this.enrollmentYear = enrollmentYear;

        }

        // 2 method for return
        public object getRandom()
        {
            return new object();
        }


        public int endGraduation()
        {
            // Assuming a 4-year study period
            int currentYear = DateTime.Now.Year;
            int yearsLeft = enrollmentYear + 4 - currentYear;
            return Math.Max(0, yearsLeft);
        }

    }
}
