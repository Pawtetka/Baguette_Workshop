using System;
using System.Collections.Generic;
using System.Text;

namespace Baguette_Workshop_BLL.Interfaces
{
    public interface IPrinter
    {
        List<string> ReturnOrders(string id);
    }
}
