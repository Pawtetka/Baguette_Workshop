using BaguetteUserInterfaceWPF.Interfaces;
using BLL_new.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaguetteUserInterfaceWPF.Classes
{
    public class Model : IModel
    {
        private IShop _shop;
        public Model(IShop shop)
        {
            _shop = shop;
        }
        public double GetPrice(string type, double width, double height)
        {
            return _shop.CountBaguettePrice(type, width, height);
        }
        public List<string> GetBaguetteTypes()
        {
            return _shop.GetBaguettes();
        }
    }
}
