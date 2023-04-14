using System;
using System.IO;
using System.Xml.Serialization;
using testFlight.Services.SerializerService.Interfaces;

namespace testFlight.Services.SerializerService.Implementations
{
    internal class XmlSerializerService : ISerializerService
    {
        public T Deserialize<T>(string fileName) where T : class, new()
        {
            XmlSerializer xmlSerializer = new(typeof(T));

            T desirializedObject;
            using FileStream fileStream = new(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            desirializedObject = xmlSerializer.Deserialize(fileStream) as T;

            return desirializedObject;
        }

        public void Serialize<T>(T objectToSerialize, string fileName)
        {
            XmlSerializer xmlSerializer = new(typeof(T));

            using FileStream fileStream = new(fileName, FileMode.OpenOrCreate);
            xmlSerializer.Serialize(fileStream, objectToSerialize);            
        }        
    }
}
