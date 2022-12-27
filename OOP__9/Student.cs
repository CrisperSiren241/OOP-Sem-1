using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__9
{
    public class Student<T> : Queue<T>, IEnumerable<T>
    {
        public T item;
        public static Queue<T> queue = new Queue<T>();
        public Student(T item)
        {
            this.item = item;
            queue.Enqueue(item);
        }
        public void Print()
        {
            foreach(T item in queue)
            {
                Console.WriteLine(item);
            }
        }

        public bool Find(T item)
        {
            return Contains(item);
        }

        public static void Changes(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    Student<T> new_student = e.NewItems[0] as Student<T>;
                    Console.WriteLine("Добавлен новый студент");
                    break;
                case NotifyCollectionChangedAction.Remove:
                    Student<T> old_student = e.NewItems[0] as Student<T>;
                    Console.WriteLine("Студент исключен");
                    break;
                case NotifyCollectionChangedAction.Move:
                    Student<T> moved_student = e.NewItems[0] as Student<T>;
                    Console.WriteLine("Студент переведен");
                    break;

            }
        }
    }
}
