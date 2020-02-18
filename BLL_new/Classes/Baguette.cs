using BLL_new.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_new.Classes
{
    class Baguette
    {
        public Dictionary<Material, int> materials { get; }
        public readonly string baguetteType;
        public Baguette() { }
        public Baguette(string type)
        {
            baguetteType = type;
        }
    }
}
