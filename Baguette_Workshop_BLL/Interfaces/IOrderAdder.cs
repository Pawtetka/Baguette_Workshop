using System;
using System.Collections.Generic;
using System.Text;

namespace Baguette_Workshop_BLL.Interfaces
{
    interface IOrderAdder
    {
        void AddNewOrder(Dictionary<string, string> orderInfo);
    }
}
