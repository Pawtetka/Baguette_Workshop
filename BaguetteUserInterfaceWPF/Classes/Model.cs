using BaguetteUserInterfaceWPF.Interfaces;
using BLL_new.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaguetteUserInterfaceWPF.Classes
{
    class Model : IModel
    {
        private IJoinContainer _joinContainer;
        public Model(IJoinContainer joinContainer)
        {
            _joinContainer = joinContainer;
        }
        public double GetPrice(string type, double width, double height)
        {
            return _joinContainer.GetShop().CountBaguettePrice(type, width, height);
        }
        public List<string> GetBaguetteTypes()
        {
            return _joinContainer.GetShop().GetBaguettes();
        }
    }
}
