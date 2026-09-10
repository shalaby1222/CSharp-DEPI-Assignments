
#region Problem 1

Point p1 = new Point(8, 10);
Console.WriteLine(p1);

public struct Point
{
    public int x;
    public int y;
    public Point()
    {

    }
    public Point(int _x, int _y)
    {
        x = _x;
        y = _y;
    }
    public override string ToString()
    {
        return $"X: {x} | Y:{y} ";
    }
}
#endregion

#region Question 1
//A struct is a value type in C#. Structs cannot inherit from another struct or class because
//C# does not support multiple inheritance for value types. However, a struct can implement one or more interfaces.
#endregion

#region Problem 2 
using System.Security.Cryptography.X509Certificates;

TypeA t1 = new TypeA();
Console.WriteLine($"F: {t1.H}");
Console.WriteLine($"G: {t1.G}");
//Console.WriteLine($"H: {t1.F}");  // Not allowed , F is private

public class TypeA
{
    private int F = 30;
    internal int G = 20;
    public int H = 10;
    public void DisplayInsideClass()
    {
        Console.WriteLine($"F = {F}");
        Console.WriteLine($"G = {G}");
        Console.WriteLine($"H = {H}");
    }
}

#endregion

#region Question 2
/*
 Access modifiers control where a class member can be accessed. They help protect data and control how other parts of
 the application interact with the class. For example, private members can only be accessed inside the same class,
 while public members can be accessed from anywhere.
 */
#endregion

#region Problem 3
Employee employee = new Employee(1, "Mohamed", 15000);

Console.WriteLine($"Name: {employee.GetName()}");
Console.WriteLine($"Salary: {employee.EmployeeSalary}");

employee.SetName("Ahmed");
employee.EmployeeSalary = 18000;

Console.WriteLine($"Updated Name: {employee.GetName()}");
Console.WriteLine($"Updated Salary: {employee.EmployeeSalary}");

public struct Employee
{
    private int EmpId { get; set; }
    private string Name { get; set; }
    public decimal Salary { get; set; }

    public Employee(int id, string name, decimal salary)
    {
        EmpId = id;
        Salary = salary;
        Name = name;
    }
    public void SetName(string name)
    {
        Name = name;
    }
    public string GetName()
    {
        return Name;
    }

    // Encapsulation
    public int EmployeeId
    {
        get { return EmpId; }
        set
        {
            EmpId = value;
        }
    }
    public decimal EmployeeSalary
    {
        get { return Salary; }
        set { Salary = value; }
    }

}

#endregion

#region Question 3
/*
 Encapsulation is important because it protects the internal data of an object and controls how that data can be accessed
 or modified. It also makes the code easier to maintain and reduces unwanted changes
 from other parts of the application.
 */
#endregion

#region Problem 4
Point p1 = new Point(10);
Point p2 = new Point(20, 30);

Console.WriteLine(p1);
Console.WriteLine(p2);

public struct Point
{
    public int X;
    public int Y;

    public Point(int x = 10)
    {
        X = x;
        Y = 0;
    }
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public override string ToString()
    {
        return $"X:{X} Y: {Y} ";
    }
}
#endregion

#region Question 4
// A constructor in a struct is used to initialize the fields of the struct when an object is created.
// Structs can have parameterized constructors, and constructors can be overloaded with different parameter lists.

#endregion

#region Problem 5
Point p1 = new Point(10, 20);
Point p2 = new Point(50, 100);
Point p3 = new Point(-5, 15);

Console.WriteLine(p1);
Console.WriteLine(p2);
Console.WriteLine(p3);

public struct Point
{
    public int X;
    public int Y;
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
    public override string ToString()
    {
        return $"Point: X = {X}, Y = {Y}";
    }
}
#endregion

#region Question 5
//Overriding ToString() provides a meaningful text representation of an object.
//It makes debugging, logging, and displaying objects easier to understand.
#endregion

#region Problem 6

Point point = new Point();
point.X = 10;
point.Y = 20;

ChangePoint(point);
Console.WriteLine($"Point X = {point.X}");
Console.WriteLine($"Point Y = {point.Y}");

Empoloyee empoloyee = new Empoloyee();
empoloyee.Name = "Mohamed";

ChaangeEmployee(empoloyee);
Console.WriteLine($"Employee Name: {empoloyee.Name}");
static void ChangePoint(Point point)
{
    point.X = 100;
}
static void ChaangeEmployee(Empoloyee empoloyee)
{
    empoloyee.Name = "Shalaby";
}
public struct Point
{
    public int X;
    public int Y;
}

public class Empoloyee
{
    public string Name { get; set; }
}
#endregion

#region Question 6
/*
 Structs are value types, while classes are reference types. A struct value is stored directly wherever the value is allocated, 
while a class object is normally allocated on the managed heap and accessed through a reference. 
The exact memory behavior can depend on how the value is used, so it is better to focus onvalue-type versus reference-type semantics rather than simply saying "structs are always on the stack." 
 */
#endregion



#region Question 1
// A copy constructor is a constructor that creates a new object by copying the values from another object of the same type.
//Example: 

Employee emp1 = new Employee(1, "Mohamed");

Employee emp2 = new Employee(emp1);

Console.WriteLine(emp2.EmpId);
Console.WriteLine(emp2.Name);

public class Employee
{
    public int EmpId { get; set; }
    public string Name { get; set; }

    public Employee(int id, string name)
    {
        EmpId = id;
        Name = name;
    }
    public Employee(Employee employee)
    {
        EmpId = employee.EmpId;
        Name = employee.Name;
    }

}
#endregion

#region Question 2
// An indexer allows an object to be accessed using array-like syntax with square brackets.
// An indexer is used when we want an object to provide array-like access to its internal data.
// It is useful for collections, custom containers, data tables, and objects that manage multiple values.
// Example: 

StudentCollection collection = new StudentCollection();

collection[0] = "Mohamed";
collection[1] = "Ahmed";
collection[2] = "Omar";

Console.WriteLine(collection[0]);
Console.WriteLine(collection[1]);
Console.WriteLine(collection[2]);
public class StudentCollection
{
    private string[] students = new string[3];


    public string this[int index]
    {
        get
        {
            return students[index];
        }
        set
        {
            students[index] = value;
        }
    }
}
#endregion

