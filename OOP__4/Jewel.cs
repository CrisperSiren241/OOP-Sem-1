using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__4
{
    public class Jewel : Rock
    {
        Rock rock;
        public int value;
        public string feature;
        public Jewel(string name, string description, string feature, int value) : base(name, description)
        {
            this.rock = new Rock(name, description);
            this.value = value;
            this.feature = feature;
        }
        public override string ToString()
        {
            return "Название товара: " + name + "\n" + "Описание товара: " + description + "\n" + "Карат: " + value + "\n" + "Cтатус: " + status;
        }

        enum JewelTypes
        {
            Ruby,
            Diamond,
            Emerald,
            SemiJewel
        }

        struct JewelStruct
        {
            public JewelTypes Type;
            public void TypeRock()
            {
                Type = JewelTypes.Diamond;
            }
        }
    }
}
