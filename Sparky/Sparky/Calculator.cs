namespace Sparky;

public class Calculator
{
  public List<int> NumberRange = new();

  public int AddNumber(int numberA, int numberB)
  {
    return numberA + numberB;
  }

  public double AddNumbersDouble(double numberA, double numberB)
  {
    return numberA + numberB;
  }

  public bool IsOddNumber(int numberA) // OddNumber --> NumeroImpar
  {
    return numberA % 2 != 0;
  }

  public List<int> getOddRange(int min, int max)
  {
    NumberRange.Clear();
    for (int Incrementator = min; Incrementator <= max; Incrementator++)
    {
      if (Incrementator % 2 != 0)
      {
        NumberRange.Add(Incrementator);
      }
    }
    return NumberRange;
  }
}