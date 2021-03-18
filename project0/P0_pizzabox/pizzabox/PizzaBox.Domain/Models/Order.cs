using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  /// <summary>
  /// 
  /// </summary>
  public class Order
  {
    public List<APizza> Pizzas { get; set; }
   private double total;
   public string StoreName {get; set;}
   public string customerEmail {get; set;}
   public Order(List<APizza> p){
     Pizzas = p;

   }
   public Order(){

   }

   public double calcTotal(){

     foreach(var pizza in Pizzas){
       total += pizza.Crust.Price;
       total += pizza.Size.Price;
       foreach(var t in pizza.Toppings){
         total += t.Price;
       }

     }
     return total;
   }

  }
}
