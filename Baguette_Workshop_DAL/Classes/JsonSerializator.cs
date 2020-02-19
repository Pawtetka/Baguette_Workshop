using Baguette_Workshop_DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Configuration;
using System.Collections.Specialized;

namespace Baguette_Workshop_DAL.Classes
{
    public class JsonSerializator : ISerializator
    {
        DataContractJsonSerializer jsonSerializer;
        public JsonSerializator(Type type)
        {
            jsonSerializer = new DataContractJsonSerializer(type);
        }
        public void Serialization(Object obj, string path)
        {
            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                jsonSerializer.WriteObject(stream, obj);
            }
        }
        public Object Deserialization(string path)
        {
            using (FileStream stream = new FileStream(path, FileMode.OpenOrCreate))
            {
                return jsonSerializer.ReadObject(stream);
            }
        }

    }
}
