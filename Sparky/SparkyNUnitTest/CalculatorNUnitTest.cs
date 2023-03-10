using NUnit.Framework;

namespace Sparky
{
  [TestFixture]
  public class CalculatorNUnitTest
  {
    [Test]
    public void AddNumbers_InputTwoInt_GetCorrectAddition()
    {
      //Arrange
      Calculator calc = new();

      //Act
      int result = calc.AddNumber(10, 20);

      //Assert
      Assert.AreEqual(30, result);
    }

    [Test]
    public void IsOddNumber_InputEvenNumber_ReturnFalse()
    {
      Calculator calc = new();

      bool isOdd = calc.IsOddNumber(10);

      Assert.That(isOdd, Is.False);
    }

    [Test]
    public void IsOddNumber_InputOffNumber_ReturnTrue()
    {
      Calculator calc = new();

      bool isOdd = calc.IsOddNumber(11);

      Assert.That(isOdd, Is.True);
    }

    [Test]
    [TestCase(11)]
    [TestCase(13)]
    [TestCase(15)]
    public void IsOddNumber_InputOffNumber_ReturnTrue_wParam(int numberA)
    {
      Calculator calc = new();

      bool isOdd = calc.IsOddNumber(11);

      Assert.That(isOdd, Is.True);
    }

    [Test]
    [TestCase(10, ExpectedResult = false)]
    [TestCase(11, ExpectedResult = true)]
    public bool IsOddChecker_InputNumber_ReturnTrueIfOdd(int a)
    {
      Calculator calc = new();
      return calc.IsOddNumber(a);
    }

    [Test]
    [TestCase(5.4, 10.5)] //15.9
    [TestCase(5.43, 10.53)] //15.96
    [TestCase(5.49, 10.59)] //16.08
    public void AddNumbersDoubles_InputTwoDouble_GetCorrectAddition(Double a, double b)
    {
      //Arrange
      Calculator calc = new();

      //Act
      double result = calc.AddNumbersDouble(a, b);

      //Assert
      Assert.AreEqual(15.9, result, 1);
    }

    [Test]
    public void OddRanger_InputMinAndMaxRange_ReturnsValidIddNumberRange()
    {
      Calculator calc = new();

      List<int> numbers = new() { 5, 7, 9 }; // 5-10

      //Act
      List<int> result = calc.getOddRange(5, 10);

      //Assert
      Assert.That(result, Is.EquivalentTo(numbers));
      Assert.AreEqual(numbers, result);
      Assert.Contains(7, result);
      Assert.That(result, Does.Contain(7));
      Assert.That(result, Is.Not.Empty);
      Assert.That(result.Count, Is.EqualTo(3));
      Assert.That(result, Has.No.Member(6));
      Assert.That(result, Is.Ordered);
      Assert.That(result, Is.Unique);
    }
  }
}