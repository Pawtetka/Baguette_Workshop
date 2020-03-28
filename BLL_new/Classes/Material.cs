using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_new.Classes
{
    public class Material
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
        public Material() { }
        public Material(double price, string name)
        {
            Price = price;
            Name = name;
        }
    }
}
