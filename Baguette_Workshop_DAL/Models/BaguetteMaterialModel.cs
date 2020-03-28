using Baguette_Workshop_DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Baguette_Workshop_DAL.Models
{
    public class BaguetteMaterialModel : IEntity
    {
        public int Id { get; set; }
        public int BaguetteModelId { get; set; }
        public int MaterialModelId { get; set; }
        public BaguetteModel BaguetteModel { get; set; }
        public MaterialModel MaterialModel { get; set; }
    }
}
