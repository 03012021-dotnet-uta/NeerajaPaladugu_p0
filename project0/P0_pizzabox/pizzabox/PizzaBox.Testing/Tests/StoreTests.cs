using PizzaBox.Domain.Models;
using Xunit;

namespace PizzaBox.Testing.Tests
{
  public class StoreTests
  {
    [Fact]
    public void Test_ChicagoStore_Fact()
    {
      // arrange
      var sut = new ChicagoStore();
      var expected = "Chicago Store";

      // act
      var actual = sut.Name;

      // assert
      Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("Chicago Store")]
    [InlineData("")]
    public void Test_ChicagoStore_Theory(string expected)
    {
      // arrange
      var sut = new ChicagoStore();

      // act
      var actual = sut.Name;

      // assert
      Assert.Equal(expected, actual);
    }
    //Newyork store Test
    [Fact]
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