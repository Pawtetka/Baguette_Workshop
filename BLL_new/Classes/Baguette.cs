using BLL_new.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_new.Classes
{
    public class Baguette
    {
        public Dictionary<Material, int> materials { get; set; } = new Dictionary<Material, int>();
        public readonly string baguetteType;
        public Baguette() { }
        public Baguette(string type)
        {
            baguetteType = type;
        }
    }
}
