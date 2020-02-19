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
        public IChooser<Baguette> Chooser { get; set; }

        public Shop() { }
        public Shop(IPriceCounter counter, IChooser<Baguette> chooser)
        {
            PriceCounter = counter;
            Chooser = chooser;
        }

        public double CountBaguettePrice(string type, double width, double height)
        {
            return PriceCounter.CountPrice(new Order(ChooseBaguette(type), width, height));
        }
        private Baguette ChooseBaguette(string type)
        {
            return Chooser.ChooseObject(baguettes, type);
        }
    }
}
