namespace ObjectOrientedDTSP.Accounts;

public class Account(string customerName, string customerAddress, string accountType)
{
    public string CustomerName { get; private set; } = customerName;
    public string CustomerAddress { get; set; } = customerAddress;
    public string AccountType { get; private set; } = accountType;
    public string AccountNumber { get; private set; } = string.Empty;
    public double Balance { get; protected set; }
    public double Deposit { get; set; }

    protected Account(string customerName, string customerAddress, string accountType, double deposit)
        : this(customerName, customerAddress, accountType)
    {
        Deposit = deposit;
    }
}