using Baguette_Workshop_BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Baguette_Workshop_BLL.Classes
{
    public class Shop : IShop
    {
        private IOrderAdder _Adder { get; set; }
        private IPrinter _Printer { get; set; }

        public Shop()
        {

        }
        public Shop(IOrderAdder adder, IPrinter printer)
        {
            _Adder = adder;
            _Printer = printer;
        }
        public void AddNewOrder(Dictionary<string, string> orderInfo)
        {
            _Adder.AddNewOrder(orderInfo);
        }

        public List<string> ReturnOrders(string id)
        {
            return _Printer.ReturnOrders(id);
        }
    }
}
