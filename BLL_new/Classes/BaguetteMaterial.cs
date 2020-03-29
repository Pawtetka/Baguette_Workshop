using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_new.Classes
{
    public class BaguetteMaterial
    {
        public int Id { get; set; }
        public int BaguetteId { get; set; }
        public int MaterialId { get; set; }
        public Baguette Baguette { get; set; }
        public Material Material { get; set; }
        public int Quantity { get; set; }

        public BaguetteMaterial(Baguette baguette, Material material, int quantity)
        {
            Baguette = baguette;
            Material = material;
            Quantity = quantity;
        }

    }
}
