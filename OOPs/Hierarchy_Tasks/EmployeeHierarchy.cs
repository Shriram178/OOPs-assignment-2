namespace OOPs.Hierarchy_Tasks;


public abstract class Employee
{
    public abstract string Name { get; set; }
    public abstract decimal Salary { get; set; }

    public abstract int CalculateBonus();

    public abstract void PrintDisplay();

}

public class Manager : Employee
{
    public override string Name { get; set; }
    public override decimal Salary { get; set; }

    private Random _random;

    public Manager(string name, decimal salary, Random obj) {
        Name = name;
        Salary = salary;
        this._random = obj;
    }

    public override int CalculateBonus()
    {
        var Bonus_multiple = _random.Next(1,6);
        return Bonus_multiple*1000;
    }
    public override void PrintDisplay() {

        Console.WriteLine($"Name : {Name}; Salary : {Salary}; Bonus : {CalculateBonus()}");
    }
}

public class Developer : Employee
{
    public override string Name { get; set; }
    public override decimal Salary { get; set; }

    private Random _random;

    public Developer(string name, decimal salary, Random obj)
    {
        Name = name;
        Salary = salary;
        this._random = obj;
    }

    public override int CalculateBonus() {

        var Bonus_multiple = _random.Next(4, 10);
        return Bonus_multiple * 1000;
    }

    public override void PrintDisplay() {

        Console.WriteLine($"Name : {Name}; Salary : {Salary}; Bonus : {CalculateBonus()}");

    }

}