public abstract class BankAccount
{
    public string AccountNumber { get; set; }
    protected decimal Balance;

    public void Deposit(decimal amount)
    {
        Balance += amount;
        LogTransaction("Deposit", amount);
    }

    public abstract void Withdraw(decimal amount); // Each account type will implement this

    public decimal GetBalance() => Balance;

    protected void LogTransaction(string type, decimal amount)
    {
        Console.WriteLine($"{type} of {amount} for {AccountNumber}");
    }
}

public abstract class BankAccount2
{
    public int UpiNo { get; set; }

    public string UpiNumber { get; set; }
}


public class CurrentAccount : BankAccount
{
    public override void Withdraw(decimal amount)
    {
        Console.WriteLine($"Withdrawing {amount} from Current Account {AccountNumber}");
    }
}

class Program
{
    static void Main(string[] args)
    {
       CurrentAccount myAccount = new CurrentAccount();
        myAccount.Withdraw(1000); // This will call the Withdraw method from CurrentAccount
        myAccount.AccountNumber = "1";
        myAccount.Deposit(1000); // This will call the Deposit method from BankAccount
        Console.ReadLine();
    }
}