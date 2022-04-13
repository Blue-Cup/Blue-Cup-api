using Microsoft.VisualStudio.TestTools.UnitTesting;
using Blue.Cup.Domain.Catalog;
namespace Blue.Cup.Domain.Tests;

[TestClass]
public class RatingTest
{
   [TestMethod]
   public void Can_Create_New_Rating()
   {
       // Arrange
       var rating = new Rating(1, "Mike", "Great fit!");
  
   // Act (empty)
 
   //Assert
   Assert.AreEqual(1, rating.Stars);
   Assert.AreEqual("Mike", rating.UserName);
   Assert.AreEqual("Great fit!", rating.Review);
   }


}