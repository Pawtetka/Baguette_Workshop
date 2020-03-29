using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_new.Classes
{
    public class BaguetteMaterial
    {
        public int Id { get; set; }
        public int BaguetteModelId { get; set; }
        public int MaterialModelId { get; set; }
        public Baguette BaguetteModel { get; set; }
        public Material MaterialModel { get; set; }
        public int Quantity { get; set; }
        public BaguetteMaterial()
        {

        }
        public BaguetteMaterial(Baguette baguette, Material material, int quantity)
        {
            BaguetteModel = baguette;
            MaterialModel = material;
            Quantity = quantity;
        }

    }
}
