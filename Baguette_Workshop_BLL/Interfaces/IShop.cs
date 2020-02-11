using System;
using System.Collections.Generic;
using System.Text;

namespace Baguette_Workshop_BLL.Interfaces
{
    interface IShop
    {
        void AddNewOrder(Dictionary<string, string> orderInfo);
        List<string> ReturnOrders(string id);
    }
}
