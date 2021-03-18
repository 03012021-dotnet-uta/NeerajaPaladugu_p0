using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using PizzaBox.Storing;

namespace PizzaBox.Domain.Singletons
{
  /// <summary>
  /// 
  /// </summary>
  public class StoreSingleton
  {
    private static StoreSingleton _storeSingleton;
    public List<AStore> Stores { get; set; } // print job
    private readonly string _path = @"store.xml";
    public static StoreSingleton Instance
    {
      get
      {
        if (_storeSingleton == null)
        {
          _storeSingleton = new StoreSingleton(); // printer
        }

        return _storeSingleton;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    private StoreSingleton()
    {
       var fs = new FileStorage();

       if (Stores == null)
      {
        Stores = fs.ReadFromXml<AStore>(_path).ToList();
     }
    }

    public void Seeding()
    {
      var stores = new List<AStore>
      {
        new ChicagoStore(),
        new NewYorkStore()
      };

      var fs = new FileStorage();

      fs.WriteToXml<AStore>(stores, _path);
      Stores = fs.ReadFromXml<AStore>(_path).ToList();
    }

    /* SINGLETON METHOD WORKFLOW */

    // public static StoreSingleton GetInstance()
    // {
    //   if (_storeSingleton == null)
    //   {
    //     _storeSingleton = new StoreSingleton(); // printer
    //   }

    //   return _storeSingleton;
    // }
  }
}
