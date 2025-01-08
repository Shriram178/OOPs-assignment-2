using OOPs.EmployeeHierarchy;
using OOPs.ShapeHierarchy;
using OOPs.BankingSystem;

Rectangle rectangle = new Rectangle("Blue", 4, 7);
Circle circle = new Circle("Yellow", 5.3);
rectangle.PrintDetails();
circle.PrintDetails();


Random rand = new Random();
Developer developer = new Developer("Shriram",100000.123m,rand);
Manager manager = new Manager("Bala",200000.345m,rand);
developer.PrintDisplay();
manager.PrintDisplay();

BankAccount savingsAccount = new SavingsAccount("12345", 20000);
savingsAccount.WithDraw(10000);
savingsAccount.WithDraw(10000);
savingsAccount.Deposit(5000);

BankAccount checkingAccount = new CheckingAccount("123456", 20000);
checkingAccount.WithDraw(25000);
checkingAccount.Deposit(4000);


