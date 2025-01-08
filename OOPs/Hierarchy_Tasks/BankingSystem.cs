namespace OOPs.BankingSystem;



public class BankAccount
{
    protected string _Account_Number {  get; set; }
    protected decimal _balance { get; set; }


    public BankAccount(string accountNumber, decimal balance)
    {
        _Account_Number = accountNumber;
        _balance = balance;
    }

    public void Deposit(decimal amount)
    {
        _balance = _balance + amount;
        Console.WriteLine($"\n {amount} Deposited.\nCurrent Balance = {_balance} ");
    }

    public virtual void WithDraw(decimal amount) {
        if (amount > _balance) 
        {
            Console.WriteLine("Insufficient Funds in Account");
        }
        else 
        {
            _balance -= amount;
            Console.WriteLine($"\n{amount} WithDrawn.\nCurrent Balance = {_balance}");
        }
     }

}

public class SavingsAccount : BankAccount
{
    private const int Minimum_Balance = 5000;
    public SavingsAccount(string accountNumber, decimal balance) : base(accountNumber, balance) { }

    public override void WithDraw(decimal amount) {
    
        if (amount > _balance) 
        {
            Console.WriteLine("Insufficient Funds in Account");
        }
        else if(_balance - amount < Minimum_Balance)
        {
            Console.WriteLine($"Cannot Withdraw {amount}.\nMinimum Balance of {Minimum_Balance} must be maintained. \n Current Balance = {_balance}.");
        }
        else 
        {
            _balance = _balance - amount;
            Console.WriteLine($"\n{amount} WithDrawn.\nCurrent Balance = {_balance}");
        }
    }
}

public class CheckingAccount : BankAccount
{
    public CheckingAccount(string accountNumber, decimal balance) : base(accountNumber, balance) { }

    public override void WithDraw(decimal amount) { 
    
        _balance -= amount;
    }
}