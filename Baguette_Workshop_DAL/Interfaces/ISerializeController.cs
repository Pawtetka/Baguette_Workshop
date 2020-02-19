using System;
using System.Collections.Generic;
using System.Text;

namespace Baguette_Workshop_DAL.Interfaces
{
    interface ISerializeController<T>
    {
        T Deserialize();
        void Serialize(T obj);
    }
}
