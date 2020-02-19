using BLL_new.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_new.Classes
{
    class BaguetteChooser : IChooser<Baguette>
    {
        public Baguette ChooseObject(List<Baguette> baguettes, string param)
        {
            foreach (Baguette bag in baguettes)
            {
                if (bag.baguetteType.Equals(param))
                {
                    return bag;
                }
            }
            return null;
        }
    }
}
