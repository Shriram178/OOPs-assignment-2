using OOPs.Hierarchy_Tasks;
using OOPs.ShapeHierarchy;

Rectangle rectangle = new Rectangle("Blue", 4, 7);
Circle circle = new Circle("Yellow", 5.3);
rectangle.PrintDetails();
circle.PrintDetails();


Random rand = new Random();
Developer developer = new Developer("Shriram",100000.123m,rand);
Manager manager = new Manager("Bala",200000.345m,rand);
developer.PrintDisplay();
manager.PrintDisplay();
