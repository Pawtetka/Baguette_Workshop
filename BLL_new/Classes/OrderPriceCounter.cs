using BLL_new.Interfaces;
using BLL_new.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_new.Classes
{
    public class OrderPriceCounter : IPriceCounter
    {
        private double _price;
        private Order _order;
        private BaguetteMaterialService _baguetteMaterialService;
        public OrderPriceCounter(BaguetteMaterialService baguetteMaterialService)
        {
            _baguetteMaterialService = baguetteMaterialService;
        }
        public double CountPrice(Object order)
        {
            _price = 0;
            _order = order as Order;
            CountMaterialsPrice(_order.baguette);
            _price *= _order.width * _order.height;
            return _price;
        }
        private void CountMaterialsPrice(Baguette baguette)
        {
            foreach(KeyValuePair<Material, int> mat in _baguetteMaterialService.GetMaterialsByBaguette(baguette.Id))
            {
                _price += mat.Key.Price * mat.Value;
            }
        }
    }
}
