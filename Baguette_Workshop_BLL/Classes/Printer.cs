using Baguette_Workshop_BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Baguette_Workshop_BLL.Classes
{
    class Printer : IPrinter
    {
        private List<string> printText;
        public Printer() { }
        private void Print(Order order)
        {
            printText.Add("Next Order:\n" + order.Baguette.baguetteType + "\n");
            printText.Add("Count: " + Convert.ToString(order.Count) + "\n");
            printText.Add("Price: " + Convert.ToString(order.GetPrice(new OrderPriceCounter(order))) + "\n"); //So bad with order.Method(Class(order));
            if (order.ready)
            {
                printText.Add("This order is ready\n\n");
            }
            else
            {
                printText.Add("Be ready on " + Convert.ToString(order.ReadyBy) + "\n\n");
            }
        }

        public List<string> ReturnOrders(string id)
        {
            printText = new List<string>();
            foreach (Order order in ShopInfo.orders)
            {
                if (id.Equals("White_Horse")) Print(order);
                else { if (order.Surname.Equals(id)) Print(order); }
            }
            return printText;
        }
    }
}
