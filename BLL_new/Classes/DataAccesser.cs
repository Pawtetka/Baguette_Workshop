using Baguette_Workshop_DAL.Classes;
using Baguette_Workshop_DAL.Interfaces;
using BLL_new.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_new.Classes
{
    class DataAccesser<IShop>
    {
        private IContainerSer<IShop> ser;
        DataAccesser(string path, IContainerSer<IShop> ser)
        {
            this.ser = ser;
        }
        public void SetData(IShop shop)
        {
            ser.GetSerializeController().Serialize(shop);
        }
        public IShop GetData()
        {
            return ser.GetSerializeController().Deserialize();
        }
    }   
}
