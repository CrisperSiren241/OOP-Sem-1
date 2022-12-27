using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            int n;
            Console.WriteLine("Введите лину строки : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Строки из {n} символов:");
            var strleng = from mon in Months
                          where mon.Length == n
                          select mon;
            foreach (string m in strleng)
                Console.WriteLine(m);

            Console.WriteLine();

            Console.WriteLine("Летние месяцы:");
            var summermonth = from mon in Months
                              where mon == "June" || mon == "July" || mon == "August"
                              select mon;
            foreach (string m in summermonth)
                Console.WriteLine(m);

            Console.WriteLine();

            Console.WriteLine("Зимние месяцы:");
            var wintermonth = from mon in Months
                              where mon == "January" || mon == "February" || mon == "December"
                              select mon;
            foreach (string m in wintermonth)
                Console.WriteLine(m);

            Console.WriteLine();

            Console.WriteLine("Месяцы в алфавитном порядке:");
            var sortmonth = from mon in Months
                            orderby mon
                            select mon;
            foreach (string m in sortmonth)
                Console.WriteLine(m);

            Console.WriteLine();

            Console.WriteLine("Месяцы, содержащие букву \"u\" и размером не менее 4-х символов:");
            var mont = from mon in Months
                       where mon.Contains('u') && mon.Length >= 4
                       select mon;
            foreach (var a in mont)
                Console.WriteLine(a);
            Console.WriteLine();

            Console.WriteLine("Запрос, в котором 5 операторов разных категорий:");
            List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 50, 100 };
            Console.WriteLine(Numbers.Where(x => x > 1).Select(x => x).OrderBy(x => x).Aggregate((x, y) => x + y));
            Console.WriteLine(Numbers.GroupBy(x => x).Any());
            Console.WriteLine(Numbers.Take(5));

            Console.WriteLine();

            Console.WriteLine("Запрос с оператором Join:");
            Person[] people = { new Person("Елисей", 1), new Person("Юля", 2) };
            Group[] groups = { new Group(1, "Группа1"), new Group(2, "Группа2") };
            var members = from p in people
                          join g in groups on p.GroupNumber equals g.Number
                          select new { Name = p.Name, GroupNumber = g.Number, GroupName = g.GroupName };
            foreach (var member in members)
            {
                Console.WriteLine($"{member.Name} - {member.GroupNumber} - {member.GroupName}");
            }

            
        }
        static void GetInfo()
        {
            Type myType = typeof(Person);
            Console.WriteLine($"Тип объекта Book: {typeof(Person)}");
            Console.WriteLine($"Имя: {myType.Name}");
            Console.WriteLine($"Полное имя: {myType.FullName}");
            Console.WriteLine($"Пространство имён: {myType.Namespace}");
            Console.WriteLine($"Является ли структурой: {myType.IsValueType}");
            Console.WriteLine($"Является ли классом: {myType.IsClass}");
            Console.WriteLine($"Имя сборки: {myType.Assembly}");
            Console.WriteLine($"Реализованные интерфейсы: {myType.GetInterfaces().ToString}");
        }
    }
}