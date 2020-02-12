using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Baguette_Workshop_BLL.Classes
{
    [DataContract]
    class Material
    {
        [DataMember]
        public readonly string type;
        [DataMember]
        public readonly double price;
        public Material(string type, float price )
        {
            this.type = type;
            this.price = price;
        }
    }
}
