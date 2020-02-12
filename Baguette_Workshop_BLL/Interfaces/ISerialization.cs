using System;
using System.Collections.Generic;
using System.Text;

namespace Baguette_Workshop_BLL.Interfaces
{
    public interface ISerialization
    {
        void Serialize(Object obj, string path);
        Object Deserialize(string path);
    }
}
