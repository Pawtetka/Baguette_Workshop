using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_new.Interfaces
{
    public interface IChooser<T>
    {
        T ChooseObject(List<T> objects, string param);
    }
}
