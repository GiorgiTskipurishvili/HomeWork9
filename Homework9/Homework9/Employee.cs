using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9
{
    internal class Employee
    {
        //name , lastname, age, position, workedOfWeek

        private string name, lastName, position;
        private int age;
        private double workedOfWeek;

        public string Name { get { return name; } }
        public string LastName { get { return lastName; } }
        public string Position { get { return position; } }
        public double Age { get { return age; } }
        public double WorkedOfWeek { get {  return workedOfWeek; } }


        public Employee(string name, string lastName, string position,int age, double workedOfWeek)
        {
            this.name = name;
            this.lastName = lastName;
            this.position = position;
            this.age = age;
            this.workedOfWeek = workedOfWeek;
        }



        /*
        public double salaryOfWeek()
        {
            /*1. დაწერეთ პროგრამა რომელიც დათვლის თანამშრომლის შემოსავალს 1
                კვირის განმავლობაში .
                გაითვალისწინეთ
                a. დღეში თანამშრომელი მუშაობს 8 საათს და არის მენეჯერი საათში იღებს -
                40$,დეველოპერი - 30$,ტესტერი-20$ სხვა ყველა იღებს 10$
                b. ოვერთაიმის შემთხვევაში საათში იღებს დამატებით 5$
                c. შაბათ/კვირას მუშაობის შემთხვევაში იღებს გაორმაგებულ ხელფასს
                d. თუ თანამშრომელმა კვირაში იმუშავა 50 საათზე მეტი ეკუთვნის ბონუსი
                ჯამური ხელფასის 20   /
            double hourlyRate = 8;
            double overtimeRate = 5;
            double weekendRate = 20;
            double weekendOvertimeRate = 30;

            int[] hoursWorked = new int[7];
            Console.WriteLine("enter hours worked for each day with seperated by ',' :");
            string[] hoursOfWeek = Console.ReadLine().Split(',');

            for (int i = 0; i < hoursWorked.Length; i++)
            {
                hoursWorked[i] = int.Parse(hoursOfWeek[i]);
            }

            double totalSalary = 0;

            for (int i = 0; i < hoursWorked.Length; i++)
            {
                if (i < 5) // Monday to Friday
                {
                    if (hoursWorked[i] <= 8)
                    {
                        totalSalary += hoursWorked[i] * hourlyRate;
                    }
                    else
                    {
                        totalSalary += hoursWorked[i] * hourlyRate + ((hoursWorked[i] - 8) * overtimeRate);
                    }
                }
                else if (i == 5 || i == 6) // Saturday and Sunday
                {
                    //totalSalary += hoursWorked[i] * weekendRate;
                    if (hoursWorked[i] <= 8)
                    {
                        totalSalary += hoursWorked[i] * weekendRate;
                    }
                    else
                    {
                        totalSalary += hoursWorked[i] * weekendRate + ((hoursWorked[i] - 8) * weekendOvertimeRate);
                    }
                }
            }

            Console.WriteLine($"Total salary is: {totalSalary}$");
        }
        
         
         */
        
    }
}
