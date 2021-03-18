using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using PizzaBox.Storing;
using System.Xml.Serialization;
using System.IO;

namespace PizzaBox.Domain.Singletons
{
    public class PizzaSingleton
    {
      private static PizzaSingleton _pizzaSingleton;
    public List<APizza> Pizzas { get; set; } // print job
    private readonly string _path = @"Pizza.xml";
    public static PizzaSingleton Instance
    {
      get
      {
        if (_pizzaSingleton == null)
        {
          _pizzaSingleton = new PizzaSingleton(); // printer
        }

        return  _pizzaSingleton;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    private PizzaSingleton()//reading from file
    {
      // var fs = new FileStorage();

     //  if (Pizzas == null)
     // {
       // Pizzas = fs.ReadFromXml<APizza>(_path).ToList();
     // }
    }

    public void Seeding()//write to xml
    {
      var pizzas = new List<APizza>
      {
        new CustomPizza(),
        new MeatPizza(),
        new VeggiePizza()
      };

      var fs = new FileStorage();

      fs.WriteToXml<APizza>(pizzas, _path);
      Pizzas = fs.ReadFromXml<APizza>(_path).ToList();
    }




    

    }
}