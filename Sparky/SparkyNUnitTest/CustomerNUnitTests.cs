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
      Assert.Multiple(() =>
      {
        Assert.AreEqual(fullName, "Hello, Ben Spark");
        Assert.That(fullName, Is.EqualTo("Hello, Ben Spark"));
        Assert.That(fullName, Does.Contain("ben spark").IgnoreCase);
        Assert.That(fullName, Does.Contain(","));
        Assert.That(fullName, Does.StartWith("Hello,"));
        Assert.That(fullName, Does.EndWith("Spark"));
      });
    }

    [Test]
    public void GreetMessage_NotGreeted_ReturnsNull()
    {
      //Assert
      Assert.IsNull(customer.greetMessage);
    }

    [Test]
    public void DiscountCheck_DefaultCustomer_ReturnsDiscountInRange()
    {
      int result = customer.Discount;

      Assert.That(result, Is.InRange(10, 25));
    }

    [Test]
    public void GreetMessage_GreetedWithoutLastName_ReturnNotNull()
    {
      customer.GreetAndCombineNames("ben", "");

      Assert.IsNotNull(customer.greetMessage);

      Assert.IsFalse(string.IsNullOrWhiteSpace(customer.greetMessage));
    }

    [Test]
    public void GreetChecker_EmptyFirstName_throwsException()
    {
      var exceptionDetails = Assert.Throws<ArgumentException>(() => customer.GreetAndCombineNames("", "Spark"));

      Assert.AreEqual("Empty First Name", exceptionDetails.Message);

      Assert.That(() => customer.GreetAndCombineNames("", "Spark"),
        Throws.ArgumentException.With.Message.EqualTo("Empty First Name"));
    }
  }
}