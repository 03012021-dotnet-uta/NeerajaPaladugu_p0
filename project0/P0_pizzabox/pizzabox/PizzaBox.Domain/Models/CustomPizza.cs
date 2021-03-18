using PizzaBox.Domain.Abstracts;
using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
  /// <summary>
  /// 
  /// </summary>
  public class CustomPizza : APizza
  {
       // public object Serialize { get; set; }

        protected override void AddCrust()
    {
    Crust= new Crust();
      //throw new System.NotImplementedException();
    }

    protected override void AddSize()
    {
      Size = new Size();
      //throw new System.NotImplementedException();
    }

    protected override void AddToppings()
    {

      Toppings = new List<Topping>{

        new Topping (),
        new Topping()
      };
      //throw new System.NotImplementedException();
    }
    public CustomPizza(){

      Name = "Custom Pizza";
    }
  }
}
