namespace ObjectOrientedDTSP.Accounts.Abstraction;

public abstract class SavingsTransactions
{
    public abstract string CustomerName { get; set; }
    public abstract string AccountNumber { get; set; }
    public abstract double Balance { get; set; }

    public abstract void DepositCash(double amount);
    public abstract bool WithdrawCash(double amount);
    public abstract void PrintBankStatement();
}