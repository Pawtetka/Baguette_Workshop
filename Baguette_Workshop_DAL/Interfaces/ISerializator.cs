using System;
using System.Collections.Generic;
using System.Text;

namespace Baguette_Workshop_DAL.Interfaces
{
    interface ISerializator
    {
        void Serialization(Object obj, string path);
        Object Deserialization(string path);
    }
}
