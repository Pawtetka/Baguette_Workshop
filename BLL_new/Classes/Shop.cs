﻿using BLL_new.Interfaces;
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
        public IPriceCounter PriceCounter { get; set; }
        public IChooser<Baguette> Chooser { get; set; }
        public IContainerSer<Shop> Container { get; }

        public Shop() { }
        public Shop(IPriceCounter counter, IChooser<Baguette> chooser, string path)
        {
            PriceCounter = counter;
            Chooser = chooser;
            Container = new SerContainer<Shop>(path);
        }

        public double CountBaguettePrice(string type, double width, double height)
        {
            return PriceCounter.CountPrice(new Order(ChooseBaguette(type), width, height));
        }
        private Baguette ChooseBaguette(string type)
        {
            return Chooser.ChooseObject(baguettes, type);
        }
    }
}
