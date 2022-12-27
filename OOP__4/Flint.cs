using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace OOP__4
{
    [Serializable]
    public class Flint : Rock
    {
        Rock rock;
        string Object;
        [NonSerialized]
        string info;
        public Flint(string name, string description, string Object) : base(name, description)
        {
            this.rock = new Rock(name, description);
            this.Object = Object;
        }
        public override string ToString()
        {
            return "Название товара: " + name + "\n" + "Описание товара: " + description + "\n" + "Назначение: " + Object;
        }

        enum TypesOfFlint
        {
            Concretion,
            Chert,
            Siliceous
        }

        struct FlintStruct
        {
            public TypesOfFlint Species;
            public void TypeRock()
            {
                Species = TypesOfFlint.Siliceous;
            }
        }
    }
}
