﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaguetteUserInterfaceWPF.Interfaces
{
    public interface IModel
    {
        double GetPrice(string type, double width, double height);
        List<string> GetBaguetteTypes();
    }
}
