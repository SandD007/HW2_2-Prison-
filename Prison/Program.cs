namespace Prison
{
    using System;

    internal class Program
    {
        public static void Main(string[] args)
        {
            Introduce dima = new Officer("майор", "пистолет", "Дмитрий", "Анатольевич", "Кулинич", 30, Gender.Мужчина, "охраник", "бить зеков", 17000);
            Introduce vania = new Officer("лейтенант", "дубинка", "Иван", "Сергеевич", "Бейпозубам", 25, Gender.Мужчина, "смотрилеь", "охранять зеков", 16500);
            Introduce vadim = new Officer("капитан", "дубинка", "Вадим", "Петрович", "Купилжигуль", 27, Gender.Мужчина, "смотрилеь", "охранять зеков", 16500);
            Introduce vika = new Officer("генерал", "автомат", "Виктория", "Павловна", "Салогуб", 25, Gender.Женщина, "начальник караула", "следить за секцией", 165000);
            Introduce maksim = new Employee("Максим", "Петрович", "Нисанов", 16, Gender.Мужчина, "уборщик", "мыть полы", 8600);
            Introduce nastia = new Employee("Анастасия", "Денисовна", "Большойнос", 38, Gender.Женщина, "бухгалтер", "считать зарплату", 9200);
            Introduce petro = new Employee("Петр", "Валентинович", "Хочукурить", 45, Gender.Мужчина, "строитель", "строить забор", 20000);
            Introduce sergey = new Leadership("юрист", 125, "Сергей", "Иванович", "Главный", 40, Gender.Мужчина, "начальник тюрмы", "управлять тюрмой", 200000);
            Introduce valera = new Leadership("экономист", 121, "Валений", "Валентиноивч", "Лысый", 45, Gender.Мужчина, "начальник склада", "управлять скалдом", 100000);
            Introduce vera = new Leadership("экономист", 120, "Вера", "Иллинична", "Климишина", 58, Gender.Женщина, "начальник РСО", "следить за РСО", 150000);
            Introduce petya = new Prisoner("ч.3 ст. 185 УК Украины", 6, "Петр", "Петрович", "Укралкаструля", Gender.Мужчина, 25, new Cell(Floor.Третий, 256));
            Introduce vasia = new Prisoner("ч.3 ст. 190 УК Украины", 7, "Василий", "Иванович", "Надурилчела", Gender.Мужчина, 30, new Cell(Floor.Первый, 15));
            Introduce egor = new Prisoner("ч.1 ст. 125 УК Украины", 9, "Эгор", "Васильевич", "Далвголову", Gender.Мужчина, 35, new Cell(Floor.Второй, 300));
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