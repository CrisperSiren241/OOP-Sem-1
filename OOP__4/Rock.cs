using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__4
{
    public class Rock : Products
    {
        Products _products;
        public Rock(string name, string description) : base(name, description)
        {
            this._products = new Products(name, description);
        }

        public string status = "Распространенный";       
        public override string ToString()
            {
                return "Название товара: " + name + "\n" + "Описание товара: " + description;
        }

        enum RockSpecies
        {
            Igneous,
            Sedimentary,
            Metamorphic
        }

        struct RockStruct
        {
            public RockSpecies Species;
            public void TypeRock()
            {
                Species = RockSpecies.Igneous;
            }
        }
    }
}
