using BLL_new.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Baguette_Workshop_DAL.Interfaces;
using Baguette_Workshop_DAL.Classes;


namespace BLL_new.Classes
{
    public class Shop : IShop
    {
        private List<Baguette> baguettes;
        private IPriceCounter priceCounter;
        private IChooser<Baguette> chooser;

        public Shop() { }
        public Shop(IPriceCounter counter, IChooser<Baguette> chooser)
        {
            priceCounter = counter;
            this.chooser = chooser;
            baguettes = /*new MackAllBaguettes().baguettes*/LoadData.LoadBaguettes();
        }

        public double CountBaguettePrice(string type, double width, double height)
        {
            return priceCounter.CountPrice(new Order(ChooseBaguette(type), width, height));
        }
        private Baguette ChooseBaguette(string type)
        {
            return chooser.ChooseObject(baguettes, type);
        }

        public List<string> GetBaguettes()
        {
            var types = new List<string>();
            foreach (Baguette baguette in baguettes)
            {
                types.Add(baguette.BaguetteType);
            }
            return types;
        }
    }
}
