using ObjectOrientedDTSP.Accounts.Abstraction;

namespace ObjectOrientedDTSP.Accounts;

public class SavingsAccount(double interestRate, double interest, double deposit) : SavingsTransactions
{
    public override string CustomerName { get; set; }
    public override string AccountNumber { get; set; }
    public override double Balance { get; set; }
    public double InterestRate { get; set; } = interestRate;
    public double Interest { get; set; } = interest;
    public double Deposit { get; set; } = deposit;

    public double ApplyInterest()
    {
        Balance *= 1 + interest;
        return Balance;
    }
    
    public override void DepositCash(double amount)
    {
        Balance += amount;
    }

    public override bool WithdrawCash(double amount)
    {
        if (Balance - amount < 0)
        {
            Console.WriteLine("Withdraw failed, balance too low.");
            return false;
        }

        Balance -= amount;
        
        Console.WriteLine("You withdrew {0}.", amount);
        return true;
    }

    public override void PrintBankStatement()
    {
        Console.WriteLine("");
        Console.WriteLine("Customer Name: {0}", CustomerName);
        Console.WriteLine("Account Number: {0}", AccountNumber);
        Console.WriteLine("Balance: {0}", Balance);
    }
}