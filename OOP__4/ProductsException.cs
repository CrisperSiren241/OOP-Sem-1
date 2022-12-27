using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__4
{
    
        class ProductsException : ArgumentException
        {
            public ProductsException(string Emessage) : base(Emessage) { }
        }
}
