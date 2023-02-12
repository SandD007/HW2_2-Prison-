using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Prison
{
    internal class Employee : Human, Introduce
    {
        private string gender = " и я должен ";

        public Employee(
            string name,
            string middleName,
            string surname,
            int age,
            string gender,
            string position,
            string duties,
            int salary)
            : base(name, middleName, surname, gender, age)
        {
            this.Name = name;
            this.MiddleName = middleName;
            this.Surname = surname;
            this.Age = age;
            this.Gender = gender;
            this.Position = position;
            this.Duties = duties;
            this.Salary = salary;
        }

        protected string Position { get; set; }

        protected string Duties { get; set; }

        protected int Salary { get; set; }

        public new void Introduce()
        {
            if (this.Gender == "женщина")
            {
                this.gender = " и я должна ";
            }

            Console.WriteLine("Привет, меня зовут " + this.Surname + " " + this.Name + " " + this.MiddleName + ". \n" +
                "Я " + this.Gender + " и мне " + this.Age + " лет.\n" +
                "Я работаю на должности " + this.Position + " c зарплатой " + this.Salary + " гривен" + this.gender + this.Duties);
            Console.WriteLine();
        }

        public int MySalary()
        {
            int salary = this.Salary;
            return salary;
        }
    }
}
