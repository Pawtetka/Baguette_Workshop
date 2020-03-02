using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_new.Interfaces
{
    public interface IShop
    {
        double CountBaguettePrice(string type, double width, double height);
        List<string> GetBaguettes();
    }
}
