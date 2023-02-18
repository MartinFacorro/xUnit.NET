using NUnit.Framework;

namespace Sparky
{
  [TestFixture]
  public class CustomerNUnitTests
  {
    private Customer customer;

    [SetUp]
    public void setup()
    {
      customer = new Customer();
    }

    [Test]
    public void CombineName_InputFirstAndLastName_ReturnFullName()
    {
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

    [Test]
    public void GreetMessage_NotGreeted_ReturnsNull()
    {
      //Assert
      Assert.IsNull(customer.greetMessage);
    }
  }
}