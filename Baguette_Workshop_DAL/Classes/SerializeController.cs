using Baguette_Workshop_DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Baguette_Workshop_DAL.Classes
{
    class SerializeController<T> : ISerializeController<T>
    {
        ISerializator<T> serializator;
        string path;
        public SerializeController(ISerializator<T> ser, string path)
        {
            serializator = ser;
            this.path = path;
        }
        public T Deserialize()
        {
            return serializator.Deserialization(path);
        }

        public void Serialize(T obj)
        {
            serializator.Serialization(obj, path);
        }
    }
}
