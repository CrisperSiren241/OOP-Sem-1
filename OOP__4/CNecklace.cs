using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__4
{
    internal class CNecklace : Necklace
    {
        string rubyName;
        string diamondName;
        string emeraldName;
        int rubyValue;
        int diamondValue;
        int emeraldValue;
        double rubyPrice = 14.4;
        double diamondPrice = 21.2;
        double emeraldPrice = 45.6;

        public CNecklace(string rubyName, string diamondName, string emeraldName, int rubyValue, int diamondValue, int emeraldValue)
        {
            this.rubyName = rubyName;
            this.diamondName = diamondName;
            this.emeraldName = emeraldName;
            this.rubyValue = rubyValue;
            this.diamondValue = diamondValue;
            this.emeraldValue = emeraldValue;
        }

        public void Task()
        {
            Console.Write("Name of Ruby: ");
            rubyName = Console.ReadLine();
            Debug.Assert(rubyName != "", "Вы не ввели название камня!");
            Console.Write("Name of Diamond: ");
            diamondName = Console.ReadLine();
            Debug.Assert(diamondName != "", "Вы не ввели название камня!");
            Console.Write("Name of Emerald: ");
            emeraldName = Console.ReadLine();
            Debug.Assert(emeraldName != "", "Вы не ввели название камня!");
            Console.Write("Amount of Ruby: ");
            rubyValue = int.Parse(Console.ReadLine());
            if(rubyValue < 0)
            {
                throw new UserException("Введено неверное значение");
            }
            Console.Write("Amount of Diamond: ");
            try
            {
                diamondValue = int.Parse(Console.ReadLine());
            }
            catch(FormatException)
            {
                throw new FormatException("Введено неверное значение");
            }
            finally
            {
                Console.WriteLine("Ошибка!");
            }
            Console.Write("Amount of Emerald: ");
            emeraldValue = int.Parse(Console.ReadLine());
        }

        public double KaratAmount()
        {
            double sum=0;
            sum = rubyValue * rubyPrice + diamondValue * diamondValue + emeraldValue * emeraldValue;
            if(sum < 0)
            {
                throw new ProductsException("LOL");
            }
            return sum;
        }

        public void SortJewel()
        {
            double[] PriceArray = { rubyPrice, diamondPrice, emeraldPrice };
            Array.Sort(PriceArray);

            if(PriceArray.Length == 0)
            {
                throw new IndexOutOfRangeException("Список пуст");
            }

            foreach(int n in PriceArray)
            {
                Console.WriteLine(n);
            }
        }

        public override string ToString()
        {
            return "Состав: " + rubyName+", " + diamondName + ", " + emeraldName + ", " + "\n" + "Цена: "+KaratAmount();
        }
    }
}
