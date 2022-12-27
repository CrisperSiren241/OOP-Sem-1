using System;

namespace OOP__4
{
    public class Products : AbstractMethods, IProducts
    {
        public string name;
        public string description;
        
        public Products(string name, string description)
        {
            this.name = name;
            this.description = description;
        }
        public string Name { 
            get
            {
                return name = "Имя товара: ";
            } 
            set
            {
                name = value;
            } 
        }
        public string Description { 
            get
            {
                return description = "Описание товара: ";
            } 
            set
            {
                description = value;
            } 
        }
        public override string ToString()
        {
            return name + "и " + description;
        }
        public virtual void Print()
        {
            Console.WriteLine(name + "и " + description);
        }

        public override void Describe()
        {
            Console.WriteLine("Использован абстрактный метод");
        }

        void IProducts.DoClone()
        {
            Console.WriteLine("Interface method");
        }

        public override void DoClone()
        {
            Console.WriteLine("Abstract class method");
        }
        enum Price
        {
            Cheap,
            Average,
            Expensive
        }

        struct ProductsStruct
        {
            public Price Price;
            public void TypeProduct()
            {
                Price = Price.Cheap;
            }
        }
    }


    
    
   

    

    

    

    

    

    
}
