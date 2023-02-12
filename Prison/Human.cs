using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prison
{
    internal abstract class Human
    {
        public Human(
            string name,
            string middleName,
            string surname,
            string gender,
            int age)
        {
            this.Name = name;
            this.MiddleName = middleName;
            this.Surname = surname;
            this.Gender = gender;
            this.Age = age;
        }

        protected string Name { get; set; }

        protected string MiddleName { get; set; }

        protected string Surname { get; set; }

        protected string Gender { get; set; }

        protected int Age { get; set; }

        public void Introduce()
        {
            Console.WriteLine("Привет, меня зовут " + this.Surname + " " + this.Name + " " + this.MiddleName + ". \n" +
                "Я " + this.Gender + " и мне " + this.Age + " лет.");
            Console.WriteLine();
        }

        public int GetAge()
        {
            int age = this.Age;
            return age;
        }
    }
}
