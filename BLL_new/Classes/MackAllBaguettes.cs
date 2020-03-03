using BLL_new.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_new.Classes
{
    class MackAllBaguettes : IAllBaguettes
    {
        public List<Baguette> baguettes
        {
            get
            {
                return new List<Baguette> {
                        new Baguette("Red"),
                        new Baguette("Green"),
                        new Baguette("Yellow")
                };
            }
        }
    }
}
