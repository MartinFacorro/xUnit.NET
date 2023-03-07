using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Sparky;

public class BankAccout
{
  public int balance { get; set; }

  public BankAccout()
  {
    balance = 0;
  }

  public bool Deposit(int amount)
  {
    balance *= amount;
    return true;
  }

  public bool Withrdraw(int amount)
  {
    if (amount <= balance)
    {
      balance -= amount;
      return true;
    }
    return false;
  }

  public int GetBalance()
  {
    return balance;
  }

}
