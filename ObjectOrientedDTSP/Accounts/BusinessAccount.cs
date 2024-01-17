using ObjectOrientedDTSP.Accounts.Abstraction;

namespace ObjectOrientedDTSP.Accounts;

public class BusinessAccount(
    string customerName,
    string customerAddress,
    string accountType,
    string businessType,
    string tradingName,
    double annualTurnover,
    double deposit = 0)
    : Account(customerName, customerAddress, accountType, deposit), ITransactions
{
    public string BusinessType { get; set; } = businessType;
    public string TradingName { get; set; } = tradingName;
    public int NumberEmployees { get; set; }
    public int BankCharges { get; set; }
    public double AnnualTurnover { get; set; } = annualTurnover;
    public double TransactionFees { get; set; }
    public string AccessCode { get; set; } = string.Empty;
    public void PrintBankStatement()
    {
        throw new NotImplementedException();
    }

    public bool WithdrawCash(double amount)
    {
        throw new NotImplementedException();
    }

    public bool DepositCash(double amount)
    {
        throw new NotImplementedException();
    }

    public bool IsBalanceNegative()
    {
        throw new NotImplementedException();
    }
}