using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9
{
    internal class Teacher
    {
        private string name;
        public bool certified;

        public string Name {  get { return name; } }
        public bool Certified { get { return certified; } }

        public Teacher(string name, bool certified) 
        {
            this.name = name;
            this.certified = certified;
        }

        public string getFromStudent(Student student, string subject)
        {
            if (!certified == true)
            {
                return "I am not certified";
            }



            switch(subject)
            {
                case "math":
                    Random random = new Random();
                    int number1 = random.Next(0, 100);
                    int number2 = random.Next(0, 100);
                    return $"{number1} + {number2} = {number1 + number2}";

                case "chemistry":
                    return "Fe2O3";

                case "english":
                    return "Hello World, This is English words.";

                default:
                    return "need only subjects!!! mathematics, chemistry and  english";
            }


        }


    }
}
