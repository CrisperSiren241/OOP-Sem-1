using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__4
{
    public class Diamond : Jewel
    {
        Jewel jewel;
        public Diamond(string name, string description, string feature,int value) : base(name, description, feature, value)
        {
            this.jewel = new Jewel(name, description, feature, value);   
        }
        public override string ToString()
        {
            return "Название товара: " + name + "\n" + "Описание товара: " + description + "\n" + "Карат: " + value + "\n"
                 + "Особенность: " + feature + "\n" + "Cтатус: " + status;
        }
        enum TypeOfDiamond
        {
            Ia,
            Ib,
            IaB,
            IIa,
            IIb
        }

        struct DiamondStruct
        {
            public TypeOfDiamond Species;
            public void TypeRock()
            {
                Species = TypeOfDiamond.Ia;
            }
        }
    }
}
