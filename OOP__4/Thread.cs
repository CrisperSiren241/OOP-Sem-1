using System;

namespace OOP__4
{
    public partial class Thread : Products
    {
        Products products;

        string ThreadDescription;
        public Thread(string name, string description, string ThreadDescription) : base(name, description)
        {
            this.products = new Products(name, description);
            this.ThreadDescription = ThreadDescription;
        }
    }
}
