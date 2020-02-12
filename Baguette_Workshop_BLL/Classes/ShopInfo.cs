using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Baguette_Workshop_BLL.Classes
{
    [DataContract]
    static class ShopInfo
    {
        [DataMember]
        public static Dictionary<string, double> materialAvailability = new Dictionary<string, double>();
        [DataMember]
        public static List<Order> orders = new List<Order>();
        [DataMember]
        public static List<Baguette> baguettes = new List<Baguette>();
    }
}
