using System;
using System.Collections.Generic;
using System.Text;

namespace Baguette_Workshop_BLL.Interfaces
{
    interface IPrinter
    {
        List<string> ReturnOrders(string id);
    }
}
