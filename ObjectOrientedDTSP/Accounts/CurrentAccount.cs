using ObjectOrientedDTSP.Accounts.Abstraction;

namespace ObjectOrientedDTSP.Accounts;

public class CurrentAccount(
    string customerName,
    string customerAddress,
    string accountType,
    string debitCardNumber,
    string accountPin,
    double deposit = 0)
    : Account(customerName, customerAddress, accountType, deposit), ITransactions
{
    public string DebitCardNumber { get; set; } = debitCardNumber;
    private string AccountPin { get; set; } = accountPin;
    private double Overdraft { get; set; }

    public void PrintBankStatement()
    {
        Console.WriteLine("");
        Console.WriteLine("Customer Name: {0}", CustomerName);
        Console.WriteLine("Customer Address: {0}", CustomerAddress);
        Console.WriteLine(IsBalanceNegative() ? "Your account is overdrawn." : $"Balance: {Balance}");
    }

    public bool WithdrawCash(double amount)
    {
        Console.WriteLine("Enter your PIN: ");

        if (Console.ReadLine() != AccountPin)
        {
            Console.WriteLine("Your PIN was incorrect.");
            return false;
        }

        if (Balance + Overdraft - amount < 0)
        {
            Console.WriteLine("Withdraw failed, balance too low.");
            return false;
        }

        Balance -= amount;

        if (Balance < 0)
        {
            Overdraft += Balance;
            Balance = 0;
        }
        
        Console.WriteLine("You withdrew {0}.", amount);
        return true;
    }

    public bool DepositCash(double amount)
    {
        Console.WriteLine("Enter your PIN: ");

        if (Console.ReadLine() != AccountPin)
        {
            Console.WriteLine("Your PIN was incorrect.");
            return false;
        }

        Balance += amount;
        return true;
    }

    public bool IsBalanceNegative()
    {
        return Balance + Overdraft < 0;
    }
}