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
        public JoinContainer()
        {
            priceCounter = new OrderPriceCounter();
            shop = new Shop(priceCounter);
        }

        public IShop GetShop()
        {
            return shop;
        }
    }
}
