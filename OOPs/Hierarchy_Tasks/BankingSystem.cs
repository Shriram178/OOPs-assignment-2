namespace OOPs.Hierarchy_Tasks;

public abstract class BankAccount
{
    private string _Account_Number {  get; set; }
    private decimal _balance { get; set; }


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

    public void WithDraw(decimal amount) {
        if (amount > _balance) 
        {
            Console.WriteLine("Insufficient Funds in Account");
        }
        else 
        {
            _balance = _balance - amount;
            Console.WriteLine($"\n{amount} WithDrawn.\nCurrent Balance = {_balance}");
        }
     }

}