namespace Sparky;

public class Calculator
{
  public int AddNumber(int numberA, int numberB)
  { 
    return numberA+ numberB;
  }

  public bool IsOddNumber(int numberA) // OddNumber --> NumeroImpar
  {
    return numberA % 2 != 0;
  }
}