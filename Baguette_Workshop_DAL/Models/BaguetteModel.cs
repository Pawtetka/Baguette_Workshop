using Baguette_Workshop_DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Baguette_Workshop_DAL.Models
{
    public class BaguetteModel : IEntity
    {
        public int Id { get; set; }
        //public Dictionary<Material, int> Materials { get; set; }
        public string BaguetteType { get; set; }
    }
}
