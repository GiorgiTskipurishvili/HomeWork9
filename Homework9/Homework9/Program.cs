using System;

namespace Homework9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Student student = new Student("Leonardo",19,2022);
            Teacher teacher = new Teacher("Ciala",true);

            object randomObject = student.getRandom();
            Console.WriteLine($"Random object from student {randomObject}");

            int y = student.endGraduation();
            Console.WriteLine($"graduate will end {y}");

            string subject = "math";
            string returnResponse = teacher.getFromStudent(student, subject);
            Console.WriteLine($"response is {subject} and random sum is {returnResponse}");

            string subject2 = "chemistry";
            string returnResponse2 = teacher.getFromStudent(student, subject2);
            Console.WriteLine($"response is {subject2} and formula is {returnResponse2}");

            string subject3 = "english";
            string returnResponse3 = teacher.getFromStudent(student, subject3);
            Console.WriteLine($"response is {subject3}: {returnResponse3}");

        }
    }
}
