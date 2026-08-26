

#region Problem 1
// Declare two integer variables,
int x = 10;
int y = 20;
/*
    Calculate the sum of these two 
    variables and print the result to the console. 
*/
int sum = x + y;
Console.WriteLine(sum);
#endregion

#region Question 1
// Comment Selected => Ctrl + K + C
// Uncomment Selected => Ctrl + K + U
#endregion 

#region Problem 2
// First Problem: Declare integar variable x and assign it a string value "10".
// Correct => int x = 10;
int x = "10";
/*
 Second Problem: console written in lowercase, it should be Console with uppercase C.
 and y is not declared, it should be declared as an integer variable before using it in the addition operation.
*/
console.WriteLine(x + y);
/*
 Corrected Code:
 int x = 10;
 int y = 20;
 Console.WriteLine(x + y);  // 30
*/
#endregion 

#region Question 2
// Runtime Error: The code will throw a runtime error because the variable y is not declared before it is used in the addition operation. To fix this, we need to declare y as an integer variable and assign it a value before using it in the addition operation.
int x = 10;
int y = 0;
Console.WriteLine(x / y);

// Logic Error: The code will not throw a runtime error, but it will produce an incorrect result because the addition operation is performed on the variables x and y, which are both initialized to 0. To fix this, we need to assign a value to y before performing the addition operation.
int x = 10;
int y = 20;
int sum = x - y;
Console.WriteLine(sum);

#endregion

#region Problem 3
string fullName = "Mohamed Reda Shalaby";
int age = 21;
decimal salary = 7000;
bool isStudent = true;
#endregion

#region Question 3
// camelCase => used for local variables and method parameters. The first letter of the first word is lowercase, and the first letter of each subsequent word is uppercase. For example: fullName, age, salary, isStudent.
// PascalCase => used for class names, method names, and properties. The first letter of each word is uppercase. For example: FullName, Age, Salary, IsStudent.
#endregion

#region Problem 4
class Person
{
    public string Name { get; set; }
}
Person p1 = new Person();
p1.Name = "Mohamed";
Person p2 = p1
p2.Name = "Reda";
Console.WriteLine(p1.Name); // Reda
Console.WriteLine(p2.Name); // Reda
#endregion

#region Question 4
/*
Value Type: A value type is a type that holds the data directly. When a value type is assigned to another variable, a copy of the value is made. 
Examples of value types in C# include int, float, double, bool, and struct.
int x = 10;
int y = x;
 */
/*
 Reference Type: A reference type is a type that holds a reference to the data, rather than the data itself. 
 When a reference type is assigned to another variable, both variables refer to the same object in memory.
 Person person1 = new Person();
 Person person2 = person1;
 */
#endregion

#region Problem 5
int x = 15;
int y = 4;
int sum = x + y;
int deference = x - y;
int product = x * y;
int quotient = x / y;
int remainder = x % y;
Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Difference: {deference}");
Console.WriteLine($"Product: {product}");
Console.WriteLine($"Quotient: {quotient}");
Console.WriteLine($"Remainder: {remainder}");
#endregion

#region Question 5
int a = 2, b = 7;
Console.WriteLine(a % b); // 2
#endregion

#region Problem 6
int number = 14;
bool result = number % 2 == 0 && number > 10 ? true : false;
Console.WriteLine(result); // True
#endregion

#region Question 6
// && (Logical AND) operator is used to combine two boolean expressions and returns true only if both expressions are true.
// & (Bitwise AND) operator is used to perform a bitwise AND operation on two integer values and returns an integer value.
#endregion

#region Problem 7
Console.WriteLine("Enter a double value: ");
double input = Convert.ToDouble(Console.ReadLine());

double ImplicitConversion = input; // Implicit conversion from double to double
int ExplicitConversion = (int)input; // Explicit conversion from double to int
Console.WriteLine($"Input Value: {input}");
Console.WriteLine($"Implicit Conversion: {ImplicitConversion}");
Console.WriteLine($"Explicit Conversion: {ExplicitConversion}");
#endregion

#region Question 7
// to convert a double to an int, you can use explicit conversion (casting) or the Convert.ToInt32() method. Explicit conversion is done by placing the target type in parentheses before the value to be converted, while Convert.ToInt32() is a method that takes a double as an argument and returns an int.
#endregion

#region Problem 8
Console.WriteLine("Enter your age: ");
string ageInput = Console.ReadLine();
int age = int.Parse(ageInput);
string check = age > 0 ? "Valid age" : "Invalid age";
Console.WriteLine(check);
#endregion

#region Question 8
/*
 The exception that can be thrown when parsing a string to an integer is FormatException.
 This exception occurs when the input string is not in a valid format for conversion to an integer. For example,
 if the user enters a non-numeric string or a string that contains invalid characters, a FormatException will be thrown.
 */
#endregion

#region Problem 9
// Prefix Increment:
int x = 2;
int y = ++x; 
Console.WriteLine($"Prefix Increment: x = {x}, y = {y}"); // x = 3, y = 3
// Postfix Increment:
int a = 2;
int b = a++;
Console.WriteLine($"Postfix Increment: a = {a}, b = {b}"); // a = 3, b = 2
#endregion

#region Question 9
int x = 5;
int y = ++x + x++; 
Console.WriteLine($"x = {x}, y = {y}"); // x = 7, y = 12
#endregion