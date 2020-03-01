using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_new.Classes
{
    public static class LoadData
    {
        public static List<Baguette> baguettes = new List<Baguette>();
        public static List<Baguette> LoadBaguettes()
        {
            Baguette baguette = new Baguette("Floor baguette");
            baguette.materials.Add(new Material(15), 2);
            baguettes.Add(baguette);
            baguette = new Baguette("Sale baguette");
            baguette.materials.Add(new Material(10), 2);
            baguettes.Add(baguette);

            return baguettes;
        }
    }
}
