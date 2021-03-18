using System.Collections.Generic;

namespace PizzaBox.Domain.Models


{
  /// <summary>
  /// 
  /// </summary>
  public class Customer
  {
    public string Name {get; set;}
    public string Email {get; set;}
    public List<Order> orders {get; set;}

  }
}
