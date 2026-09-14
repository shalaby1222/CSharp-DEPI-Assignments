// =============================== Part-01 ===========================

#region Problem 1

Car car1 = new Car();
Car car2 = new Car(1);
Car car3 = new Car(2, "BMW");
Car car4 = new Car(3, "Mercedes", 50000);
Console.WriteLine(car1);
Console.WriteLine(car2);
Console.WriteLine(car3);
Console.WriteLine(car4);

public class Car
{
    #region Attributes
    public int Id { get; set; }
    public string? Brand { get; set; }
    public decimal Price { get; set; }
    #endregion

    #region Properties
    public Car()
    {

    }
    public Car(int id)
    {
        Id = id;
    }
    public Car(int id, string brand)
    {
        Id = id;
        Brand = brand;
    }
    public Car(int id, string brand, decimal price)
    {
        Id = id;
        Brand = brand;
        Price = price;
    }
    #endregion

    #region Methods
    public override string ToString()
    {
        return $"Id: {Id} | Brand: {Brand} | Proce: {Price} ";
    }
    #endregion

}

#endregion

#region Question 1  
// When a custom constructor is defined, C# assumes that the programmer wants to control object initialization,
// so it does not automatically generate the parameterless constructor.
#endregion

#region Problem 2
Calculator c = new Calculator();
Console.WriteLine(c.Sum(10, 20));
Console.WriteLine(c.Sum(10, 20, 30));
Console.WriteLine(c.Sum(10.5, 20.5));

public class Calculator
{
    public int Sum(int a, int b)
    {
        return a + b;
    }
    public int Sum(int a, int b, int c)
    {
        return a + b + c;
    }
    public double Sum(double a, double b)
    {
        return a + b;
    }
}

#endregion

#region Question 2
// Method overloading allows different operations to use the same meaningful method name,
// which makes the code easier to read and reuse.
#endregion

#region Problem 3
Child child = new Child(10, 20, 30);

Console.WriteLine($"X = {child.X}");
Console.WriteLine($"Y = {child.Y}");
Console.WriteLine($"Z = {child.Z}");

public class Parent
{
    #region Attributes
    public int X { get; set; }
    public int Y { get; set; }
    #endregion
    #region Properties
    public Parent(int x, int y)
    {
        X = x;
        Y = y;
    }
    #endregion
}

public class Child : Parent
{
    #region Attributes
    public int Z { get; set; }
    #endregion

    #region Properties
    public Child(int x, int y, int z) : base(x, y)
    {
        Z = z;
    }
    #endregion
}
#endregion

#region Question 3
// Constructor chaining ensures that the base class is properly initialized before the derived class is initialized.
#endregion

#region Problem 4
Child child = new Child
{
    X = 2,
    Y = 3,
    Z = 4
};

Parent parentReference = child;

Console.WriteLine(child.Product());
Console.WriteLine(parentReference.Product());
public class Parent
{
    #region Attributes
    public int X { get; set; }
    public int Y { get; set; }
    #endregion
    public virtual int Product()
    {
        return X * Y;
    }
}
public class Child : Parent
{
    #region Attributes
    public int Z { get; set; }
    #endregion
    // new
    //public new int Product()
    //{
    //    return X * Y * Z;
    //}
    // override
    public override int Product()
    {
        return X * Y * Z;
    }
}
#endregion

#region Question 4
// The new keyword hides the base class method, while override
// replaces a virtual base method and supports runtime polymorphism.
#endregion

#region Problem 5
Parent parent = new Parent
{
    X = 10,
    Y = 20
};

Child child = new Child
{
    X = 10,
    Y = 20,
    Z = 30
};

Console.WriteLine(parent);
Console.WriteLine(child);

Parent polyChild = child;
Console.WriteLine(polyChild);
public class Parent
{
    #region Attributes
    public int X { get; set; }
    public int Y { get; set; }
    #endregion

    #region Methods
    public override string ToString()
    {
        return $"X: {X}, Y: {Y}";
    }
    #endregion
}
public class Child : Parent
{
    #region Attributes
    public int Z { get; set; }
    #endregion

    #region Methods
    public override string ToString()
    {
        return $"X: {X}, Y: {Y}, Z: {Z}";
    }
    #endregion

}

#endregion

#region Question 5
//ToString() is often overridden to provide a meaningful string representation
//of an object instead of the default class name.
#endregion

#region Problem 6

Rectangle rectangle = new Rectangle();
rectangle.Height = 10;
rectangle.Width = 15;

Console.WriteLine($"Area = {rectangle.Area}");
rectangle.Draw();
public interface IShape
{
    #region Properties
    public double Area { get; }
    #endregion

    #region Methods
    public void Draw();
    #endregion
}

public class Rectangle : IShape
{
    #region Attributes
    public double Width { get; set; }
    public double Height { get; set; }
    #endregion

    #region Properties
    public double Area
    {
        get { return Width * Height; }
    }
    #endregion

    #region Methods
    public void Draw()
    {
        Console.WriteLine("Drawing Rectangle");
    }
    #endregion
}
#endregion

#region Question 6
// An interface defines a contract but does not provide a complete implementation, so it cannot be instantiated directly.
#endregion

#region Problem 7
Circle circle = new Circle();
circle.Radius = 5;
circle.Draw();

IShape shape = circle;
shape.PrintDetails();

public interface IShape
{
    #region Attributes
    public double Area { get; }
    #endregion

    #region Methods
    public void Draw();
    void PrintDetails()
    {
        Console.WriteLine($"Area = {Area}");
    }
    #endregion
}

public class Circle
{
    #region Attributes
    public double Radius { get; set; }
    #endregion

    #region Methods
    public double Area
    {
        get { return Math.PI * Radius * Radius; }
    }
    public void Draw()
    {
        Console.WriteLine("Drawing Circle");
    }

    #endregion
}
#endregion

#region Question 7
// Default interface implementations allow developers to add new methods to
// an interface without forcing every existing implementing class to implement them.
#endregion

#region Problem 8
IMovable movable = new Car();
movable.Move();
public interface IMovable
{
    #region Methods
    void Move();
    #endregion
}
public class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("Car is moving");
    }
}
#endregion

#region Question 8
//Using an interface reference promotes loose coupling and allows the same code
//to work with different classes that implement the interface.
#endregion


#region Problem 9
File file = new File();

file.Read();
file.Write();
public interface IReadable
{
    void Read();
}
public interface IWritable
{
    void Write();
}

public class File : IReadable, IWritable
{
    public void Read()
    {
        Console.WriteLine("Reading file...");
    }

    public void Write()
    {
        Console.WriteLine("Writing file...");
    }
}
#endregion

#region Question 9
//C# allows a class to implement multiple interfaces, so a class can inherit behavior
//contracts from multiple sources even though it can inherit from only one class.

#endregion

#region Problem 10
Rectangle rectangle = new Rectangle();
rectangle.Width = 20;
rectangle.Height = 15;
rectangle.Draw();

Console.WriteLine($"Area = {rectangle.CalculateArea()}");
public abstract class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing Shape");
    }
    public abstract double CalculateArea();
}
public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }
    public override void Draw()
    {
        Console.WriteLine("Drawing Rectangle");
    }
    public override double CalculateArea()
    {
        return Width * Height;
    }
}

#endregion

#region Question 10
//A virtual method has a default implementation that can be overridden, while an abstract method
//has no implementation and must be implemented by a derived class.
#endregion


// =============================== Part-02 ===========================
#region Question 1
//A class is a reference type that is suitable for complex objects and supports inheritance, while a struct is a value type that is usually used for small data structures.
#endregion

#region Question 2
/*
 There are several important relationships between classes in OOP:
 1. Inheritance — IS-A:
 Inheritance represents an IS-A relationship where a derived class inherits members from a base class.
 
 2. Association — USES / KNOWS:
 Association represents a general relationship where one class uses or interacts with another class.

 3. Aggregation — HAS-A (weak relationship)
 Aggregation represents a HAS-A relationship where the contained object can exist independently of the container
 
 4. Composition — HAS-A (strong relationship)
 Composition represents a strong HAS-A relationship where the contained object's lifetime is dependent on the containing object.
 
 */
#endregion

