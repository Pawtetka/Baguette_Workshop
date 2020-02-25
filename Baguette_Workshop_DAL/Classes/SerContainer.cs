using Baguette_Workshop_DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Baguette_Workshop_DAL.Classes
{
    public class SerContainer<T> : IContainerSer<T>
    {
        private ISerializeController<T> serializeController;
        private ISerializator<T> serializator;
        public SerContainer(string path)
        {
            serializator = new JsonSerializator<T>(typeof(T));
            serializeController = new SerializeController<T>(serializator, path);
        }
        public ISerializeController<T> GetSerializeController()
        {
            return serializeController;
        }
    }
}
