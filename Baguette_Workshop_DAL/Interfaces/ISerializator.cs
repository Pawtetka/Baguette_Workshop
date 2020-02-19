using System;
using System.Collections.Generic;
using System.Text;

namespace Baguette_Workshop_DAL.Interfaces
{
    public interface ISerializator<T>
    {
        void Serialization(T obj, string path);
        T Deserialization(string path);
    }
}
