using Baguette_Workshop_BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Baguette_Workshop_BLL.Classes
{
    class OrderPriceCounter : ICounter
    {
        private Order _order;
        private double _price;

        public OrderPriceCounter(Order order)
        {
            _order = order;
        }
        public double GetPrice()
        {
            CountBaguettePrice();
            return _price * _order.Count;
        }
        private void CountBaguettePrice()
        {
            foreach (KeyValuePair<Material, int> material in _order.Baguette.Materials)
            {
                _price += material.Key.price * material.Value;
            }
            _price *= _order.Baguette.Height * _order.Baguette.Width;
        }
    }
}
