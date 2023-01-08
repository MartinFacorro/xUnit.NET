﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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


  }
}
