using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace PizzaBox.Storing
{
  public class FileStorage
  {
      

    public void WriteToXml<T>(List<T> data,string _path) where T : class
    {
      using (var writer = new StreamWriter(_path))
      {
        var serializer = new XmlSerializer(typeof(List<T>));

        serializer.Serialize(writer, data);
      }
    }

    public IEnumerable<T> ReadFromXml<T>(string _path) where T : class
    {
      using (var reader = new StreamReader(_path))
      {
        var serializer = new XmlSerializer(typeof(List<T>));

        return serializer.Deserialize(reader) as IEnumerable<T>;
      }
    }

       
    }
}
