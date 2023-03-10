using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prison
{
    internal class Prisoner : Human, Introduce
    {
        public Prisoner(
            string article,
            int termOfImprisonment,
            string name,
            string middleName,
            string surname,
            Gender gender,
            int age,
            Cell cell)
        : base(name, middleName, surname, gender, age)
        {
            this.Article = article;
            this.TermOfImprisonment = termOfImprisonment;
            this.Name = name;
            this.MiddleName = middleName;
            this.Surname = surname;
            this.Gender = gender;
            this.Age = age;
            this.Cell = cell;
        }

        protected string Article { get; set; }

        protected int TermOfImprisonment { get; set; }

        protected Cell Cell { get; set; }

        public new void Introduce()
        {
            Console.WriteLine("Привет, меня зовут " + this.Surname + " " + this.Name + " " + this.MiddleName + "." + Environment.NewLine +
                "Я " + this.Gender + " и мне " + this.Age + " лет. " + Environment.NewLine +
                "Меня посадили на " + this.TermOfImprisonment + " лет за " + this.Article + ".");
            Console.WriteLine();
        }
    }
}
