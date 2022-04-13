using Microsoft.VisualStudio.TestTools.UnitTesting;
using Blue.Cup.Domain.Catalog;
namespace Blue.Cup.Domain.Tests;

[TestClass]
public class ItemTest
{
[TestMethod]
   public void Can_Create_New_Item()
   {
    var item = new Item("Name", "Description", "Brand", 10.00m);

      Assert.AreEqual("Name", item.Name);
      Assert.AreEqual("Description", item.Description);
      Assert.AreEqual("Brand", item.Brand);
      Assert.AreEqual(10.00m, item.Price);
   }

[TestMethod]
public void Can_Create_Add_Rating()
{
    //Arrange
    var item = new Item("Name", "Description", "Brand", 10.00m);
    var rating = new Rating(5, "Name", "Review");

    //Act
    item.AddRating(rating);

    //Assert
    Assert.AreEqual(rating, item.Ratings[0]);
}
}