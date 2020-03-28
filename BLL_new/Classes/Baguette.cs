using BLL_new.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_new.Classes
{
    public class Baguette
    {
        public int Id { get; set; }
        public Dictionary<Material, int> Materials { get; set; } = new Dictionary<Material, int>();
        public string BaguetteType { get; set; }
        public Baguette() { }
        public Baguette(string type)
        {
            BaguetteType = type;
        }
    }
}
