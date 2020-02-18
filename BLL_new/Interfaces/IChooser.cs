using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_new.Interfaces
{
    interface IChooser
    {
        Object ChooseObject(List<Object> objects, string param);
    }
}
