using BLL_new.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_new.Classes
{
    public class JoinContainer : IJoinContainer
    {
        private IShop shop;
        private IPriceCounter priceCounter;
        private IChooser<Baguette> chooser;
        public JoinContainer()
        {
            priceCounter = new OrderPriceCounter();
            shop = new Shop(priceCounter, chooser);
        }

        public IShop GetShop()
        {
            return shop;
        }
    }
}
