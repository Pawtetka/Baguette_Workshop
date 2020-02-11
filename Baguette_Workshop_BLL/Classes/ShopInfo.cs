using System;
using System.Collections.Generic;
using System.Text;

namespace Baguette_Workshop_BLL.Classes
{
    static class ShopInfo
    {
        public static Dictionary<string, double> materialAvailability = new Dictionary<string, double>();

        public static List<Order> orders = new List<Order>();

        public static List<Baguette> baguettes = new List<Baguette>();
    }
}
