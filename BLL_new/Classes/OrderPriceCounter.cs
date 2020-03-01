using BLL_new.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_new.Classes
{
    class OrderPriceCounter : IPriceCounter
    {
        private double price;
        private Order _order;
        public double CountPrice(Object order)
        {
            price = 0;
            _order = order as Order;
            CountMaterialsPrice(_order.baguette);
            price *= _order.width * _order.height;
            return price;
        }
        private void CountMaterialsPrice(Baguette baguette)
        {
            foreach(KeyValuePair<Material, int> mat in baguette.materials)
            {
                price += mat.Key.Price * mat.Value;
            }
        }
    }
}
