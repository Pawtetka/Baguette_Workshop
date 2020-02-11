using Baguette_Workshop_BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Baguette_Workshop_BLL.Classes
{
    class Baguette
    {
        public readonly string baguetteType;
        public Dictionary<Material, int> Materials { get; }
        public double TimeToDo { get; }
        public double Width { get; }
        public double Height { get; }

        public Baguette(string baguetteType, double timeToDo, double width, double height, Dictionary<Material, int> materials)
        {
            this.baguetteType = baguetteType;
            TimeToDo = timeToDo;
            Width = width;
            Height = height;
            Materials = materials;
        }

        public Baguette(string baguetteType, double width, double height)
        {
            this.baguetteType = baguetteType;
            Width = width;
            Height = height;
        }
    }
}
