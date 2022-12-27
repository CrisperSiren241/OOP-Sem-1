using OOP__9;
using System;
using System.Collections.ObjectModel;

namespace OOP__4
{
    class Program
    {
        static void Main()
        {
            Queue<string> list = new Queue<string>();
            Student<string> student1 = new Student<string>("Алексей Алексеевич");
            Student<string> student2 = new Student<string>("Иван Иванов");
            Student<string> student3 = new Student<string>("Влад Владимирович");
            Student<string> student4 = new Student<string>("Роман Романович");
            Student<string> student5 = new Student<string>("Дмитрий Дмитриевич");
            Student<string> student6 = new Student<string>("Антон Антонович");
            Student<string> student7 = new Student<string>("Александр Александрович");
            foreach (var item in Student<string>.queue)
            {
                Console.WriteLine(item);
            }

            ObservableCollection<Student<string>> sub = new ObservableCollection<Student<string>>() {
                new Student<string>("STUDENT"),
                new Student<string>("SURNAME"),
                new Student<string>("PATRONOMYC")
            };

            sub.CollectionChanged += Student<string>.Changes;
            sub.Add(new Student<string>(""));
            sub.RemoveAt(0);
        }
    }
}