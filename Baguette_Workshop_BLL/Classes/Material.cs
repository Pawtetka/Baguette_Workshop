using System;
using System.Collections.Generic;
using System.Text;

namespace Baguette_Workshop_BLL.Classes
{
    class Material
    {
        public readonly string type;
        public readonly double price;
        public Material(string type, float price )
        {
            this.type = type;
            this.price = price;
        }
    }
}
