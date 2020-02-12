using Baguette_Workshop_BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Baguette_Workshop_BLL.Classes
{
    [DataContract]
    class Baguette
    {
        [DataMember]
        public readonly string baguetteType;
        [DataMember]
        public Dictionary<Material, int> Materials { get; }
        [DataMember]
        public double TimeToDo { get; }
        [DataMember]
        public double Width { get; }
        [DataMember]
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
