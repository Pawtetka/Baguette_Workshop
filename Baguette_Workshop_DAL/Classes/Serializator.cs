using Baguette_Workshop_DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Baguette_Workshop_DAL.Classes
{
    public class Serializator<T>
    {
        private ISerializator ser;
        public Serializator(ISerializator serial)
        {
            ser = serial;
        }
        public void Serialize(T obj, string path)
        {
            ser.Serialization(obj, path);
        }

        public T Deserialize(string path)
        {
            return (T)ser.Deserialization(path);
        }
    }
}
