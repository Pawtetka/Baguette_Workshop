using BLL_new.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Baguette_Workshop_DAL.Interfaces;
using Baguette_Workshop_DAL.Classes;


namespace BLL_new.Classes
{
    class Shop : IShop
    {
        private List<Baguette> baguettes;
        public IPriceCounter PriceCounter { get; }
        public IChooser<Baguette> Chooser { get; }
        public IContainerSer<Shop> Container { get; }
        public DataAccesser<IShop> Accessor { get; }

        public Shop() { }
        public Shop(IPriceCounter counter, IChooser<Baguette> chooser, string path)
        {
            PriceCounter = counter;
            Chooser = chooser;
            Container = new SerContainer<Shop>(path);
            baguettes = new MackAllBaguettes().baguettes/*LoadData.LoadBaguettes()*/;
        }

        public double CountBaguettePrice(string type, double width, double height)
        {
            return PriceCounter.CountPrice(new Order(ChooseBaguette(type), width, height));
        }
        private Baguette ChooseBaguette(string type)
        {
            return Chooser.ChooseObject(baguettes, type);
        }

        public List<string> GetBaguettes()
        {
            var types = new List<string>();
            foreach (Baguette baguette in baguettes)
            {
                types.Add(baguette.baguetteType);
            }
            return types;
        }
    }
}
