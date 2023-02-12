namespace Prison
{
    using System;

    internal class Program
    {
        public static void Main(string[] args)
        {
            Introduce dima = new Officer("майор", "пистолет", "Дмитрий", "Анатольевич", "Кулинич", 30, "мужчина", "охраник", "бить зеков", 17000);
            Introduce vania = new Officer("лейтенант", "дубинка", "Иван", "Сергеевич", "Бейпозубам", 25, "мужчина", "смотрилеь", "охранять зеков", 16500);
            Introduce vadim = new Officer("капитан", "дубинка", "Вадим", "Петрович", "Купилжигуль", 27, "мужчина", "смотрилеь", "охранять зеков", 16500);
            Introduce vika = new Officer("генерал", "автомат", "Виктория", "Павловна", "Салогуб", 25, "женщина", "начальник караула", "следить за секцией", 165000);
            Introduce maksim = new Employee("Максим", "Петрович", "Нисанов", 16, "мужчина", "уборщик", "мыть полы", 8600);
            Introduce nastia = new Employee("Анастасия", "Денисовна", "Большойнос", 38, "женщина", "бухгалтер", "считать зарплату", 9200);
            Introduce petro = new Employee("Петр", "Валентинович", "Хочукурить", 45, "мужчина", "строитель", "строить забор", 20000);
            Introduce sergey = new Leadership("юрист", 125, "Сергей", "Иванович", "Главный", 40, "мужчина", "начальник тюрмы", "управлять тюрмой", 200000);
            Introduce valera = new Leadership("экономист", 121, "Валений", "Валентиноивч", "Лысый", 45, "мужчина", "начальник склада", "управлять скалдом", 100000);
            Introduce vera = new Leadership("экономист", 120, "Вера", "Иллинична", "Климишина", 58, "женщина", "начальник РСО", "следить за РСО", 150000);
            Introduce petya = new Prisoner("ч.3 ст. 185 УК Украины", 6, "Петр", "Петрович", "Укралкаструля", "мужчина", 25);
            Introduce vasia = new Prisoner("ч.3 ст. 190 УК Украины", 7, "Василий", "Иванович", "Надурилчела", "мужчина", 30);
            Introduce egor = new Prisoner("ч.1 ст. 125 УК Украины", 9, "Эгор", "Васильевич", "Далвголову", "мужчина", 35);
            Introduce[] prisonPersons = new Introduce[]
            {
               dima, vania, vadim, vika, maksim, nastia, petro, sergey, valera, vera, petya, vasia, egor,
            };
            Actions.Introduce(prisonPersons);
            Actions.Salary(prisonPersons);
            Actions.Shift(prisonPersons);
            Actions.AgeInPrison(prisonPersons, 16);
        }
    }
}