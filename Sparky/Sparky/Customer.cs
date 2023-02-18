namespace Sparky
{
  public class Customer
  {
    public int Discount = 15;

    public string greetMessage { get; set; }

    public string GreetAndCombineNames(string firstName, string lastName)
    {
      if (String.IsNullOrWhiteSpace(firstName))
      {
        throw new ArgumentException("Empty First Name");
      }
      greetMessage = $"Hello, {firstName} {lastName}";
      Discount = 20;
      return greetMessage;
    }
  }
}