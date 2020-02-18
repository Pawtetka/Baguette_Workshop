using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_new.Classes
{
    class Order
    {
        public Baguette baguette { get; }
        public readonly double width;
        public readonly double height;
        public Order() { }
        public Order(Baguette baguette, double width, double height)
        {
            this.baguette = baguette;
            this.width = width;
            this.height = height;
        }
    }
}
