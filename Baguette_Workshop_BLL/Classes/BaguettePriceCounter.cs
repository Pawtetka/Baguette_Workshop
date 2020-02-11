using Baguette_Workshop_BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Baguette_Workshop_BLL.Classes
{
    class BaguettePriceCounter : ICounter
    {
        private Baguette _baguette;
        private double _price;
        public BaguettePriceCounter(Baguette baguette)
        {
            _baguette = baguette;
        }

        public double GetPrice()
        {
            foreach (KeyValuePair<Material, int> material in _baguette.Materials)
            {
                _price += material.Key.price * material.Value;
            }
            _price *= _baguette.Height * _baguette.Width;
            return _price;
        }
    }
}
