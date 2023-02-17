namespace Sparky
{
  public class Customer
  {
    public string greetMessage { get; set; }

    public string GreetAndCombineNames(string? firstName, string? lastName)
    {
      greetMessage = $"Hello, {firstName} {lastName}";
      return greetMessage;
    }
  }
}