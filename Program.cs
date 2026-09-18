
#region Problem 1

#region Program

IVehicle car = new Car();
IVehicle bike = new Bike();

car.StartEngine();
car.StopEngine();

bike.StartEngine();
bike.StopEngine();
#endregion


#region Interface
public interface IVehicle
{
    void StartEngine();
    void StopEngine();
}
#endregion

#region Classes
public class Car : IVehicle
{
    #region Methods
    public void StartEngine()
    {
        Console.WriteLine("Car engine started.");
    }
    public void StopEngine()
    {
        Console.WriteLine("Car engine Stoped.");
    }
    #endregion

}

public class Bike : IVehicle
{
    #region Methods

    public void StartEngine()
    {
        Console.WriteLine("Bike engine started.");
    }

    public void StopEngine()
    {
        Console.WriteLine("Bike engine stopped.");
    }

    #endregion
}

#endregion


#endregion

#region Qestion 1
/*
 Coding against an interface reduces dependency on a specific implementation and makes the code more flexible, maintainable,
 and easier to test. The same variable can work with different classes as long as they implement the interface.
 */
#endregion

#region Problem 2

#region Programe
Shape rectangle = new Rectangle(10, 5);
Shape circle = new Circle(5);

rectangle.Display();
circle.Display();
#endregion
#region Abstract Class

public abstract class Shape
{
    public abstract double GetArea();
    public void Display()
    {
        Console.WriteLine($"Area = {GetArea()}");
    }
}
#endregion

#region Derived  Classes

public class Rectangle : Shape
{
    #region Attributes
    private double width;
    private double height;
    #endregion

    #region Constructors
    public Rectangle(double _height, double _width)
    {
        height = _height;
        width = _width;
    }
    #endregion

    #region Methods
    public override double GetArea()
    {
        return width * height;
    }
    #endregion

}

public class Circle : Shape
{
    #region Attributes
    private double radius;
    #endregion

    #region Constructors
    public Circle(double _radius)
    {
        radius = _radius;
    }
    #endregion

    #region Methods
    public override double GetArea()
    {
        return Math.PI * radius * radius;
    }
    #endregion

}
#endregion
#endregion

#region Qestion 2
/*
 An abstract class should be preferred when related classes share common state, behavior, or implementation, 
 while still requiring derived classes to implement specific abstract members.
*/
#endregion

#region Problem 3

#region Programe
Product[] products =
{
    new Product(1, "Laptop", 1200),
    new Product(2, "Mouse", 25),
    new Product(3, "Keyboard", 80),
    new Product(4, "Monitor", 300)
};
Array.Sort(products);
foreach (Product product in products)
{
    Console.WriteLine(product);
}
#endregion

#region Class
public class Product : IComparable<Product>
{
    #region Properties
    public int Id { get; set; }
    public string? Name { get; set; }
    public double Price { get; set; }
    #endregion

    #region Constructor
    public Product(int id, string? name, double price)
    {
        Id = id;
        Name = name;
        Price = price;
    }

    #endregion
    #region Methods
    public int CompareTo(Product? other)
    {
        if (other is null)
            return 1;

        return Price.CompareTo(other.Price);
    }
    public override string ToString()
    {
        return $"Name: {Name} - Price: {Price}";
    }
    #endregion
}
#endregion

#endregion

#region Qestion 3
/*
 Implementing IComparable allows a class to define its default comparison rule. This enables standard 
 sorting methods such as Array.Sort() to sort objects automatically according to the defined criteria. 
*/
#endregion

#region Problem 4

#region Program

Student student1 = new Student(1, "Mohamed", 95, new Address("Gharbia"));
Student student2 = new Student(student1);

student2.Address.City = "Cairo";

Console.WriteLine(student1.Address.City);
Console.WriteLine(student2.Address.City);

#endregion

#region Classes

public class Address
{
    #region Properties

    public string City { get; set; }

    #endregion

    #region Constructors

    public Address(string city)
    {
        City = city;
    }

    public Address(Address other)
    {
        City = other.City;
    }

    #endregion
}
public class Student
{
    #region Properties
    public int Id { get; set; }
    public string Name { get; set; }
    public double Grade { get; set; }
    public Address Address { get; set; }
    #endregion

    #region Constructors
    public Student(int id, string name, double grade, Address address)
    {
        Id = id;
        Name = name;
        Grade = grade;
        Address = address;
    }

    // Copy Constructor
    public Student(Student student)
    {
        Id = student.Id;
        Name = student.Name;
        Grade = student.Grade;

        // Deep Copy
        Address = new Address(student.Address);
    }
    #endregion

}
#endregion

#endregion

#region Qestion 4
/*
 The primary purpose of a copy constructor is to create a new object based on the state of an existing object. 
 It can also be used to create a deep copy so that referenced objects are duplicated instead of sharing the same references.
*/
#endregion

#region Problem 5
#region Program

Robot robot = new Robot();
robot.Walk();

IWalkable walkable = robot;
walkable.Walk();
#endregion

#region Interface
public interface IWalkable
{
    void Walk();
}
#endregion

#region Class
public class Robot : IWalkable
{
    #region Methods
    public void Walk()
    {
        Console.WriteLine("Robot's normal Walk method.");
    }
    void IWalkable.Walk()
    {
        Console.WriteLine("Robot's IWalkable implementation.");
    }
    #endregion
}
#endregion

#endregion

#region Qestion 5
/*
 Explicit interface implementation allows a class to provide a separate implementation for an interface member without 
 exposing that implementation directly through the class type. This helps resolve naming conflicts when the 
 class and one or more interfaces contain members with the same name. 
*/
#endregion

#region Problem 6

#region Program

Account account = new Account(1, "Mohamed", 5000);
account.AccountHolder = "Shalaby";

Console.WriteLine(account.AccountId);
Console.WriteLine(account.AccountHolder);
Console.WriteLine(account.Balance);

#endregion
public struct Account
{
    #region Attributes

    private int accountId;
    private string accountHolder;
    private decimal balance;

    #endregion

    #region Properties
    public int AccountId
    {
        get { return accountId; }
        set { accountId = value; }
    }
    public string AccountHolder
    {
        get { return accountHolder; }
        set { accountHolder = value; }
    }

    public decimal Balance
    {
        get { return balance; }
        private set { balance = value; }
    }

    #endregion
    #region Constructors
    public Account(int _accountId, string _accountHolder, decimal _balance)
    {
        accountHolder = _accountHolder;
        accountId = _accountId;
        balance = _balance;
    }
    #endregion


}


#endregion

#region Qestion 6
/*
  The encapsulation mechanism is fundamentally the same in structs and classes: both can use private fields and public 
  properties or methods to control access to their data. The main difference is that structs are value types,
  while classes are reference types, which affects how their instances are copied and stored.
*/

/*
 Abstraction is a design guideline that focuses on exposing only the essential behavior 
 of an object while hiding unnecessary implementation details. Encapsulation supports abstraction by
 controlling access to the object's internal state and implementation through well-defined public members. 
*/
#endregion

#region Problem 7

#region Programe
ILogger logger = new ConsoleLogger();
logger.log();

#endregion
#region Interface
public interface ILogger
{
    void log()
    {
        Console.WriteLine("Default logging implementation.");
    }
}
#endregion

#region Class
public class ConsoleLogger : ILogger
{
    #region Methods

    public void Log()
    {
        Console.WriteLine("Console logging implementation.");
    }

    #endregion
}
#endregion

#endregion

#region Qestion 7
/*
 Default interface implementations allow new members to be added to an existing interface without immediately requiring every
 existing implementing class to provide an implementation. This helps maintain backward compatibility when evolving an API. 
*/
#endregion

#region Problem 8

#region Program
Book book1 = new Book();
Book book2 = new Book("Clean Code");
Book book3 = new Book("Clean Code", "Robert C. Martin");
#endregion

#region Class
public class Book
{
    #region Properties
    public string Author { get; set; }
    public string Title { get; set; }

    #endregion

    #region constructor
    public Book()
    {

    }
    public Book(string title)
    {
        Title = title;
        Author = "Unknown";
    }
    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }
    #endregion
}
#endregion

#endregion

#region Qestion 8
/*
 Constructor overloading allows objects to be created in different ways depending on the information available to the caller. 
 It provides flexibility while keeping object initialization clear and strongly typed
*/
#endregion

#region Shape Series  
#region Program
IShapeSeries sqareSeries = new SquareSeries();
PrintTenShapes(sqareSeries);
Console.WriteLine();

IShapeSeries circleSeries = new CircleSeries();
PrintTenShapes(circleSeries);

#endregion
#region Methods
static void PrintTenShapes(IShapeSeries shapeSeries)
{
    shapeSeries.ResetSeries();
    for (int i = 0; i < 10; i++)
    {
        shapeSeries.GetNextArea();
        Console.WriteLine(shapeSeries.CurrentShapeArea);
    }
}
#endregion

#region Interface
public interface IShapeSeries
{
    #region Properties 
    public int CurrentShapeArea { get; set; }
    #endregion
    #region Methods
    void GetNextArea();
    void ResetSeries();
    #endregion
}
#endregion
#region Classes
public class SquareSeries : IShapeSeries
{
    #region Attributes
    private int _side;
    #endregion

    #region Properties
    public int CurrentShapeArea { get; set; }
    #endregion

    #region Constructor
    public SquareSeries()
    {
        ResetSeries();
    }
    #endregion
    #region Methods
    public void GetNextArea()
    {
        _side++;
        CurrentShapeArea = _side * _side;
    }

    public void ResetSeries()
    {
        _side = 0;
        CurrentShapeArea = 0;
    }
    #endregion
}

public class CircleSeries : IShapeSeries
{
    #region Attributes
    private int _radius;
    #endregion

    #region Properties
    public int CurrentShapeArea { get; set; }
    #endregion

    #region Constructor
    public CircleSeries()
    {
        ResetSeries();
    }
    #endregion
    #region Methods
    public void GetNextArea()
    {
        _radius++;
        CurrentShapeArea = (int)Math.Round(Math.PI * _radius * _radius);
    }

    public void ResetSeries()
    {
        _radius = 0;
        CurrentShapeArea = 0;
    }
    #endregion
}

#endregion


#endregion

#region Sorting for Shapes  
#region Programe
Shape[] shapes =
{
    new Shape("Square", 25),
    new Shape("Circle", 12.56),
    new Shape("Rectangle", 40),
    new Shape("Circle", 78.5),
    new Shape("Square", 9)
};

Array.Sort(shapes);
foreach (Shape shape in shapes)
{
    Console.WriteLine(shape);
}
#endregion

#region Classes
public class Shape : IComparable<Shape>
{
    #region Properties
    public string Name { get; set; }
    public double Area { get; set; }
    #endregion

    #region Constructors
    public Shape(string name, double area)
    {
        Name = name;
        Area = area;
    }
    #endregion

    #region Methods
    public int CompareTo(Shape? other)
    {
        if (other is null)
            return 1;
        return Area.CompareTo(other.Area);
    }

    public override string ToString()
    {
        return $"{Name} - Area: {Area:F2}";
    }
    #endregion


}
#endregion
#endregion


#region Shape Hierarchy 

#region Program 
GeometricShape triangle = new Triangle(3, 4);
GeometricShape rectangle = new Rectangle(10, 5);

Console.WriteLine($"Triangle Area: {triangle.CalculateArea()}");
Console.WriteLine($"Triangle Perimeter: {triangle.Perimeter}");

Console.WriteLine($"Rectangle Area: {rectangle.CalculateArea()}");
Console.WriteLine($"Rectangle Perimeter: {rectangle.Perimeter}");

#endregion

#region Abstract Class
public abstract class GeometricShape
{
    #region Properties
    public double Dimension1 { get; set; }
    public double Dimension2 { get; set; }
    public abstract double Perimeter { get; }
    #endregion

    #region Constructors
    protected GeometricShape(double dimension1, double dimension2)
    {
        Dimension1 = dimension1;
        Dimension2 = dimension2;
    }
    #endregion

    #region Methods
    public abstract double CalculateArea();
    #endregion
}
#endregion

#region Derived Classes 
public class Triangle : GeometricShape
{
    #region Constructors
    public Triangle(double baseLength, double height) : base(baseLength, height)
    {
    }
    #endregion

    #region Properties
    public override double Perimeter
    {
        get
        {
            double hypotenuse =
               Math.Sqrt(
                   ( Dimension1 * Dimension1 ) +
                   ( Dimension2 * Dimension2 )
               );
            return Dimension1 + Dimension2 + hypotenuse;
        }
    }
    #endregion
    #region Methods
    public override double CalculateArea()
    {
        return 0.5 * Dimension1 * Dimension2;
    }
    #endregion
}

public class Rectangle : GeometricShape
{
    #region Constructors
    public Rectangle(double width, double height) : base(width, height)
    {
    }
    #endregion

    #region Properties
    public override double Perimeter
    {
        get
        {
            return 2 * ( Dimension1 + Dimension2 );
        }
    }
    #endregion

    #region Methods
    public override double CalculateArea()
    {
        return Dimension1 * Dimension2;
    }
    #endregion
}
#endregion

#endregion


