using System;
using System.Collections.Generic;
using System.Text;

namespace Baguette_Workshop_DAL.Interfaces
{
    public interface IContainerSer<T>
    {
        ISerializeController<T> GetSerializeController();
    }
}
