using NUnit.Framework;

namespace Sparky
{
  [TestFixture]
  public class CustomerNUnitTests
  {
    [Test]
    public void CombineName_InputFirstAndLastName_ReturnFullName()
    {
      //Arrange
      var customer = new Customer();

      //Act
      string fullName = customer.GreetAndCombineNames("Ben", "Spark");

      //Assert
      Assert.AreEqual(fullName, "Hello, Ben Spark");
      Assert.That(fullName, Is.EqualTo("Hello, Ben Spark"));
      Assert.That(fullName, Does.Contain("ben spark").IgnoreCase);
      Assert.That(fullName, Does.Contain(","));
      Assert.That(fullName, Does.StartWith("Hello,"));
      Assert.That(fullName, Does.EndWith("Spark"));
    }
  }
}