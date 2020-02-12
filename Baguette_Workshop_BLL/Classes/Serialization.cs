using Baguette_Workshop_BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Baguette_Workshop_DAL.Interfaces;
using Baguette_Workshop_DAL.Classes;

namespace Baguette_Workshop_BLL.Classes
{
    public class Serialization : ISerialization
    {
        Serializator<Object> serializator = new Serializator<Object>(new JsonSerializator(typeof(Object)));
        public void Serialize(Object obj, string path)
        {
            serializator.Serialize(obj, path);
        }

        public Object Deserialize(string path)
        {
            return serializator.Deserialize(path) as IShop;
        }

    }
}
