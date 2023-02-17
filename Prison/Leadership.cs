using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prison
{
    internal class Leadership : Employee
    {
        public Leadership(
            string education,
            int officeNumber,
            string name,
            string middleName,
            string surname,
            int age,
            Gender gender,
            string position,
            string duties,
            int salary)
            : base(name, middleName, surname, age, gender, position, duties, salary)
        {
            this.Education = education;
            this.OfficeNumber = officeNumber;
            this.Name = name;
            this.MiddleName = middleName;
            this.Surname = surname;
            this.Age = age;
            this.Gender = gender;
            this.Position = position;
            this.Duties = duties;
            this.Salary = salary;
        }

        protected string Education { get; set; }

        protected int OfficeNumber { get; set; }
    }
}
