using PizzaBox.Domain.Models;
using PizzaBox.Domain.Abstracts;
using Xunit;
using System.Collections.Generic;



namespace PizzaBox.Testing.Tests


{
    public class OrderTests
    {
        [Fact]
        public void Test_pizzaOrder_Fact(){
            List<APizza> Pizza = new List<APizza>{
                new CustomPizza()
            };
            var myOrder = new Order(Pizza);
            //arrange
            var expected = 1;
            //act
            var actual = myOrder.Pizzas.Count;
            //assert
            Assert.Equal(expected,actual);

            }

                   

          [Fact]
            public void Test_OrderEmail_Fact(){
            List<APizza> Pizza = new List<APizza>{
                new CustomPizza()
            };
            var myOrder = new Order(Pizza);
            //arrange
            var customer = new Customer();
            customer.Email = "example@hotmail.com";
            myOrder.customerEmail = customer.Email;
            var expected = "example@gmail.com";
            //act
            var actual = myOrder.customerEmail;
            //assert
            Assert.Equal(expected,actual);
                
            }     
          [Theory]
             [InlineData("Custom Pizza")]
             [InlineData("")]

    public void Test_CustomPizza_Theory(string expected)

    {
      // arrange
      var sut = new CustomPizza();

      // act
      var actual = sut.Name;

      // assert
      Assert.Equal(expected, actual);
    }
    public void Test_NewyorkStore_Fact(){
      //arrange
      var sut = new NewYorkStore();
      var expected = "NewYork Store";
      //act
      var actual = sut.Name;
      //assert
      Assert.Equal(expected,actual);
    }
            

    }
}