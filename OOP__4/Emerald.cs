using System;

namespace OOP__4
{
    class Emerald : Jewel
    {
        Jewel jewel;
        public Emerald(string name, string description, string feature, int value) : base(name, description, feature, value)
        {
            this.jewel = new Jewel(name, description, feature, value);
        }
        public override string ToString()
        {
            
            return "Название товара: " + name + "\n" + "Описание товара: " + description + "\n" + "Карат: " + value + "\n"
                + "Особенность: " + feature + "\n" + "Cтатус: " + status;
        }
        enum EmeraldTypeOfColor
        {
            LightGreen,
            Green,
            DarkGreen
        }

        struct EmeraldStruct
        {
            public EmeraldTypeOfColor EmeraldType;
            public void TypeRock()
            {
                EmeraldType = EmeraldTypeOfColor.DarkGreen;
                
            }
        }
    }
}
