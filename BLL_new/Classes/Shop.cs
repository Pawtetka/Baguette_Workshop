using BLL_new.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_new.Classes
{
    class Shop : IShop
    {
        private List<Baguette> baguettes;
        public IPriceCounter PriceCounter { get; set; }
        public IChooser Chooser { get; set; }

        public Shop() { }
        public Shop(IPriceCounter counter)
        {
            PriceCounter = counter;
            //Chooser = chooser;
        }

        public double CountBaguettePrice(string type, double width, double height)
        {
            return PriceCounter.CountPrice(new Order(ChooseBaguette(type), width, height));
        }
        private Baguette ChooseBaguette(string type)
        {
            foreach (Baguette bag in baguettes)
            {
                if (bag.baguetteType.Equals(type)) 
                {
                    return bag;
                }
            }
            return null;
        }
    }
}
