using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  /// <summary>
  /// 
  /// </summary>
  public class VeggiePizza : APizza
  {
    protected override void AddCrust()
    {
      Crust = new Crust();
    }

    protected override void AddSize()
    {
      Size = new Size();
    }

    protected override void AddToppings()
    {
      Toppings = new List<Topping>
      {
        new Topping{
          Name = "Bell pepper",
          Price = 0.25
        },
        new Topping{

          Name = "Mushrooms",
         Price = 0.25
        }
      };
    }
    public VeggiePizza()
    {
      Name = "Veggie Pizza";
    }
  }
}
