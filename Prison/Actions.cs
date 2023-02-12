using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prison
{
    internal static class Actions
    {
        private static int cash = 0;

        public static void AgeInPrison(Introduce[] persons, int age)
        {
            for (int i = 0; i < persons.Length; i++)
            {
                Human person = persons[i] as Human;
                if (person.GetAge() == age)
                {
                    person.Introduce();
                }
            }
        }

        public static void Introduce(Introduce[] persons)
        {
            for (int i = 0; i < persons.Length; i++)
            {
                persons[i].Introduce();
            }
        }

        public static void Salary(Introduce[] persons)
        {
            int cash = 0;

            for (int i = 0; i < persons.Length; i++)
            {
               Employee person = persons[i] as Employee;

               if (person != null)
               {
                    cash += person.MySalary();
               }
            }

            Console.WriteLine("Общая зарплата: " + cash + " гривен.");
            Console.WriteLine();
        }

        public static void Shift(Introduce[] persons)
        {
            int employeesIndex = 0;
            int officersIndex = 0;
            int leadershipsIndex = 0;

            for (int i = 0; i < persons.Length; i++)
            {
                if (persons[i].GetType().Name == "Employee")
                {
                    employeesIndex++;
                }

                if (persons[i].GetType().Name == "Officer")
                {
                    officersIndex++;
                }

                if (persons[i].GetType().Name == "Leadership")
                {
                    leadershipsIndex++;
                }
            }

            int randomEmployees = new Random().Next(employeesIndex);
            int randomOfficers = new Random().Next(officersIndex);
            int randomLeaderships = new Random().Next(leadershipsIndex);
            Employee[] employees = new Employee[employeesIndex];
            Officer[] officers = new Officer[officersIndex];
            Leadership[] leaderships = new Leadership[leadershipsIndex];
            employeesIndex = 0;
            officersIndex = 0;
            leadershipsIndex = 0;

            for (int i = 0; i < persons.Length; i++)
            {
                if (persons[i].GetType().Name == "Employee")
                {
                    employees[employeesIndex] = (Employee)persons[i];
                    employeesIndex++;
                }

                if (persons[i].GetType().Name == "Officer")
                {
                    officers[officersIndex] = (Officer)persons[i];
                    officersIndex++;
                }

                if (persons[i].GetType().Name == "Leadership")
                {
                    leaderships[leadershipsIndex] = (Leadership)persons[i];
                    leadershipsIndex++;
                }
            }

            Console.WriteLine("\t Сегодня выйдут на смену \t");
            Console.WriteLine();
            Introduce(employees[randomEmployees]);
            Introduce(leaderships[randomLeaderships]);
            Introduce(officers[randomOfficers]);
        }

        private static void Introduce(Introduce persons)
        {
            persons.Introduce();
            SalaryForOneShift(persons);
        }

        private static void SalaryForOneShift(Introduce persons)
        {
            Employee person = persons as Employee;

            if (person != null)
            {
                cash += person.MySalary();
            }

            Console.WriteLine("Сегодня зарплата за смену: " + cash + " гривен.");
            Console.WriteLine();
        }
    }
}
