using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prison
{
    internal class Officer : Employee, Introduce
    {
        private string gender = " и я должен ";

        public Officer(
            string rank,
            string weapon,
            string name,
            string middleName,
            string surname,
            int age,
            string gender,
            string position,
            string duties,
            int salary)
            : base(name, middleName, surname, age, gender, position, duties, salary)
        {
            this.Rank = rank;
            this.Weapon = weapon;
            this.Name = name;
            this.MiddleName = middleName;
            this.Surname = surname;
            this.Age = age;
            this.Gender = gender;
            this.Position = position;
            this.Duties = duties;
            this.Salary = salary;
        }

        protected string Rank { get; set; }

        protected string Weapon { get; set; }

        public new void Introduce()
        {
            if (this.Gender == "женщина")
            {
                this.gender = " и я должна ";
            }

            Console.WriteLine("Привет, меня зовут " + this.Surname + " " + this.Name + " " + this.MiddleName + ". \n" +
                "Я " + this.Gender + " и мне " + this.Age + " лет.\n" +
                "Я " + this.Rank + " на должности " + this.Position + " c зарплатой " + this.Salary + " гривен, у меня есть " + this.Weapon + this.gender + this.Duties + ".");
            Console.WriteLine();
        }
    }
}
