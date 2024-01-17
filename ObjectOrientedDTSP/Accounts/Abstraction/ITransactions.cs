namespace ObjectOrientedDTSP.Accounts.Abstraction;

public interface ITransactions
{
    public void PrintBankStatement();
    public bool WithdrawCash(double amount);
    public bool DepositCash(double amount);
    public bool IsBalanceNegative();
}