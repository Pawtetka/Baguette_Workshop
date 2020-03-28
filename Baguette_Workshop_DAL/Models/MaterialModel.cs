using Baguette_Workshop_DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Baguette_Workshop_DAL.Models
{
    public class MaterialModel : IEntity
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
    }
}
