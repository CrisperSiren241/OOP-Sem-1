using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__4
{
    partial class Thread : Products
    {
        public override string ToString()
        {
            return "Название товара: " + name + "\n" + "Описание товара: " + description + "\n" + "Статус: " + ThreadDescription;
        }

        public override int GetHashCode()
        {
            return name.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (obj is Thread thread) return true;
            return false;
        }
    }
}
