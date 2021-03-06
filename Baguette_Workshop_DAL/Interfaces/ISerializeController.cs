﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Baguette_Workshop_DAL.Interfaces
{
    public interface ISerializeController<T>
    {
        T Deserialize();
        void Serialize(T obj);
    }
}
