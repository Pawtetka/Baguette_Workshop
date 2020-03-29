using BLL_new.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_new.Classes
{
    public class LoadData
    {
        /*public static List<Baguette> baguettes = new List<Baguette>();
        public static List<Baguette> LoadBaguettes()
        {
            Baguette baguette = new Baguette("Floor baguette");
            baguette.Materials.Add(new Material(15, "Wood"), 2);
            baguettes.Add(baguette);
            baguette = new Baguette("Sale baguette");
            baguette.Materials.Add(new Material(10, "Wood"), 2);
            baguettes.Add(baguette);

            return baguettes;
        }*/
        private BaguetteService _baguetteService;
        private BaguetteMaterialService _baguetteMaterialService;
        private MaterialService _materialService;
        public LoadData(BaguetteService baguetteService, BaguetteMaterialService baguetteMaterialService, MaterialService materialService)
        {
            _baguetteService = baguetteService;
            _baguetteMaterialService = baguetteMaterialService;
            _materialService = materialService;
        }
        public void LoadStartDataToBd()
        {
            Baguette baguette1 = new Baguette("Floor baguette");
            Baguette baguette2 = new Baguette("Sale baguette");
            Baguette baguette3 = new Baguette("Ukrainian baguette");
            Material material1 = new Material(15, "Wood");
            Material material2 = new Material(10, "Polish");
            Material material3 = new Material(20, "Paint");
            Material material4 = new Material(100, "Ukrainian salo");
            BaguetteMaterial baguetteMaterial1 = new BaguetteMaterial(baguette1, material1, 3);
            BaguetteMaterial baguetteMaterial2 = new BaguetteMaterial(baguette1, material2, 5);
            BaguetteMaterial baguetteMaterial3 = new BaguetteMaterial(baguette2, material1, 5);
            BaguetteMaterial baguetteMaterial4 = new BaguetteMaterial(baguette2, material3, 5);
            BaguetteMaterial baguetteMaterial5 = new BaguetteMaterial(baguette3, material4, 100);
            _baguetteService.AddBaguette(baguette1);
            _baguetteService.AddBaguette(baguette2);
            _baguetteService.AddBaguette(baguette3);
            _baguetteMaterialService.AddBaguetteMaterial(baguetteMaterial1);
            _baguetteMaterialService.AddBaguetteMaterial(baguetteMaterial2);
            _baguetteMaterialService.AddBaguetteMaterial(baguetteMaterial3);
            _baguetteMaterialService.AddBaguetteMaterial(baguetteMaterial4);
            _baguetteMaterialService.AddBaguetteMaterial(baguetteMaterial5);
            _materialService.AddMaterial(material1);
            _materialService.AddMaterial(material2);
            _materialService.AddMaterial(material3);
        }
    }
}
