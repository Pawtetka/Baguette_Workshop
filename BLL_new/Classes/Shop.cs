using BLL_new.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Baguette_Workshop_DAL.Interfaces;
using Baguette_Workshop_DAL.Classes;
using AutoMapper;
using BLL_new.Services;

namespace BLL_new.Classes
{
    public class Shop : IShop
    {
        //private List<Baguette> baguettes;
        private IPriceCounter priceCounter;
        private IChooser<Baguette> chooser;
        private BaguetteService _baguetteService;

        public Shop() { }
        public Shop(IPriceCounter counter, IChooser<Baguette> chooser, BaguetteService baguetteService)
        {
            priceCounter = counter;
            this.chooser = chooser;
            _baguetteService = baguetteService;
            //baguettes = /*new MackAllBaguettes().baguettes*/LoadData.LoadBaguettes();

        }

        public double CountBaguettePrice(string type, double width, double height)
        {
            return priceCounter.CountPrice(new Order(ChooseBaguette(type), width, height));
        }
        private Baguette ChooseBaguette(string type)
        {
            return chooser.ChooseObject(_baguetteService.GetAllBaguettes(), type);
        }

        public List<string> GetBaguettes()
        {
            /*var types = new List<string>();
            foreach (Baguette baguette in baguettes)
            {
                types.Add(baguette.BaguetteType);
            }
            return types;*/
            var types = new List<string>();
            foreach (Baguette baguette in _baguetteService.GetAllBaguettes())
            {
                types.Add(baguette.BaguetteType);
            }
            return types;
        }
    }
}
