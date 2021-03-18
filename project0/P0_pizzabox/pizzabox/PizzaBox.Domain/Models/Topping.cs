namespace PizzaBox.Domain.Models
{
  public class Topping : AComponent
  {
     public Topping()
  {
    Name = "";
    
    Price = 0;
  }
  public Topping(string name, double price){

    Name = name;
    Price = Price;

  }

  }
}