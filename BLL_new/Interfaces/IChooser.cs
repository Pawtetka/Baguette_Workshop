using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_new.Interfaces
{
    interface IChooser<T>
    {
        T ChooseObject(List<T> objects, string param);
    }
}
