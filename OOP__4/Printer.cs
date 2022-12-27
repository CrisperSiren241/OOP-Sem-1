using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__4
{
    public class Printer : AbstractMethods
    {
        public override string ToString()
        {
            return "Тип данных: ";
        }
        public void Print(object obj)
        {
            Console.WriteLine(obj);
        }

        public override void DoClone()
        {
            Console.WriteLine("Abstract class method");
        }

        public override void Describe()
        {
            Console.WriteLine("Использован абстрактный метод");
        }
    }
}
