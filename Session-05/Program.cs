//==================================== Part 01 ====================================

#region Problem 1
Console.WriteLine("Enter the first number: ");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the second number: ");
int number2 = int.Parse(Console.ReadLine());
try
{
    int result = number1 / number2;
    Console.WriteLine($"The result of {number1} divided by {number2} is: {result}");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Error: Division by zero is not allowed.");
}
finally
{
    Console.WriteLine("Operation completed.");
}
#endregion

#region Question 1
// The Purpose of finally block is to ensure that a specific section of code is executed regardless of whether an exception occurs or not. It is typically used for cleanup operations, such as releasing resources, closing files, or performing any necessary finalization tasks.
// The code within the finally block will always run, even if an exception is thrown in the try block or if a catch block is executed. This guarantees that important cleanup actions are performed, helping to maintain the stability and integrity of the program.
#endregion

#region Problem 2
Console.WriteLine("Enter X value: ");
if (!int.TryParse(Console.ReadLine(), out int x))
{
    Console.WriteLine("Invalid input for X. Please enter a valid integer.");
    return;
}
if (int.TryParse(Console.ReadLine(), out int y))
{
    Console.WriteLine("Invalid input for Y. Please enter a valid integer.");
}
TestDefensiveCode(x, y);

static void TestDefensiveCode(int x, int y)
{
    if (x < 0)
    {
        Console.WriteLine("X must be positive number");
        return;
    }
    if (y < 0)
    {
        Console.WriteLine("Y must be positive number");
        return;
    }
    if (y <= 1)
    {
        Console.WriteLine("Y must be greater than 1");
        return;
    }
    Console.WriteLine($"X = {x} , Y = {y}");
}
#endregion

#region Question 2
// int.TryParse() safely handles invalid input by returning false instead of throwing an exception.
#endregion

#region Problem 3
int? number = null;
int result = number ?? 10;

Console.WriteLine($"Default value used: {result}");

if (number.HasValue)
{
    Console.WriteLine($"Value of number: {number.Value}");
}
else
{
    Console.WriteLine("number is null, using default value.");
}

#endregion

#region Question 3
// InvalidOperationException is thrown when an operation is performed on an object that is not in a valid state for that operation.
#endregion

#region Problem 4
int[] arr = new int[5];
try
{
    arr[10] = 100;
}
catch (IndexOutOfRangeException)
{
    Console.WriteLine("Error: Index is out of range.");

}
#endregion

#region Question 4
//Checking array bounds prevents accessing invalid indexes and avoids an IndexOutOfRangeException.
#endregion

#region Problem 5
int[,] matrix = new int[3, 3];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.WriteLine($"Enter value for matrix[{i},{j}]: ");
        matrix[i, j] = int.Parse(Console.ReadLine());
    }
}

// sum rows
for (int i = 0; i < matrix.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum += matrix[i, j];
    }
    Console.WriteLine($"Sum of row {i}: {sum}");
}

// sum columns
for (int i = 0; i < matrix.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum += matrix[j, i];
    }
    Console.WriteLine($"Sum of column {i}: {sum}");
}

#endregion

#region Question 5
// The GetLength method is used to retrieve the number of elements in a specific dimension of an array. 
#endregion

#region Problem 6
int[][] jaggedArray = new int[3][];
jaggedArray[0] = new int[2];
jaggedArray[1] = new int[3];
jaggedArray[2] = new int[4];

for (int i = 0; i < jaggedArray.Length; i++)
{
    for (int j = 0; j < jaggedArray[i].Length; j++)
    {
        Console.WriteLine($"Enter value for jaggedArray[{i}][{j}]: ");
        jaggedArray[i][j] = int.Parse(Console.ReadLine());
    }
}

for (int i = 0; i < jaggedArray.Length; i++)
{
    for (int j = 0; j < jaggedArray[i].Length; j++)
    {
        Console.WriteLine($"Value at jaggedArray[{i}][{j}]: {jaggedArray[i][j]}");
    }
}
#endregion

#region Question 6
//A jagged array consists of separate arrays, so each row can have a different size, while a rectangular array has a fixed size for all rows and column
#endregion

#region Problem 7
Console.WriteLine("Enter your Name: ");
string? name = Console.ReadLine();
if (string.IsNullOrWhiteSpace(name))
{
    Console.WriteLine("Name cannot be empty or whitespace.");

}
else
{
    Console.WriteLine($"Hello, {name}!");
}

#endregion

#region Question 7
//Nullable reference types help developers identify possible null values at compile time and reduce the risk of NullReferenceException.
#endregion

#region Problem 8
double number = 10;
object obj = number; // Boxing
Console.WriteLine("Boxing: " + obj);

int result = (int)obj; // Unboxing
Console.WriteLine("Unboxing: " + result);
try
{
    double invalidResult = (double)obj; // Invalid unboxing
}
catch (InvalidCastException)
{
    Console.WriteLine("Error: Invalid unboxing operation.");
}
#endregion

#region Question 8
//Boxing and unboxing can reduce performance because boxing requires memory allocation and unboxing requires type conversion.
#endregion

#region Problem 9

Console.WriteLine("Enter first number: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Enter second number: ");
int b = int.Parse(Console.ReadLine());

SumAndMultiply(a, b, out int sum, out int product);
Console.WriteLine($"Sum: {sum}, Product: {product}");
static void SumAndMultiply(int a, int b, out int sum, out int product)
{
    sum = a + b;
    product = a * b;
}

#endregion

#region Question 9
// Out parameters initialize variables inside the method, allowing the method to return multiple values
// They are useful when you want to return more than one result from a method without using a tuple or a custom class.
#endregion

#region Problem 10
PrintMessage(repeatCount: 3, message: "Hello, World!");

void PrintMessage(string message, int repeatCount = 5)
{
    for (int i = 0; i < repeatCount; i++)
    {
        Console.WriteLine(message);
    }
}
#endregion

#region Question 10
//Optional parameters must appear at the end so the compiler can correctly identify the required and optional arguments.
#endregion

#region Problem 11
int[]? arr = null;
Console.WriteLine($"Length of array: {arr?.Length ?? 0}");
#endregion

#region Question 11
// The null propagation operator ?. safely accesses a member and returns null if the object is null instead of throwing a NullReferenceException.
#endregion

#region Problem 12
Console.WriteLine("Enter a day of the week ");
string day = Console.ReadLine() ?? string.Empty;

int dayNumber = day.ToLower() switch
{
    "monday" => 1,
    "tuesday" => 2,
    "wednesday" => 3,
    "thursday" => 4,
    "friday" => 5,
    "saturday" => 6,
    "sunday" => 7,
    _ => throw new ArgumentException("Invalid day of the week")
};

Console.WriteLine($"Day number for {day} is: {dayNumber}");
#endregion

#region Question 12
//A switch expression is preferred when there are multiple possible values and each value needs a specific result.
#endregion

#region Pronlem 13

static int SumArray(params int[] numbers)
{
    int sum = 0;
    foreach (int number in numbers)
    {
        sum += number;
    }
    return sum;
}
Console.WriteLine("Individual parameters: " + SumArray(1, 2, 3, 4, 5));

int[] numbers = { 10, 20, 30 };
Console.WriteLine("Array parameter: " + SumArray(numbers));
#endregion

#region Question 13
// Limitations of params keyword is that it can only be used for the last parameter in a method signature,
// and it can only accept a single array of the specified type.
#endregion



//==================================== Part 02 ====================================

#region Problem 14
Console.WriteLine("Enter a number: ");
int number = int.Parse(Console.ReadLine());

for (int i = 1; i <= number; i++)
{
    Console.Write(i);
    if(i < number)
    {
        Console.Write(", ");
    }
}
#endregion

#region Problem 15 
Console.WriteLine("Enter a number: ");
int number = int.Parse(Console.ReadLine());

for (int i = 1; i <= 12; i++)
{
    Console.WriteLine($"{number} * {i} = {i * number}");
}
#endregion 

#region Problem 16
Console.WriteLine("Enter a number");
int number = int.Parse(Console.ReadLine());

for (int i = 1; i <= number; i++)
{
    if(i%2 == 0 )
    {
        Console.Write(i + " ");
    }
}
#endregion

#region Problem 17 
Console.WriteLine("Enter first number");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter second number");
int num2 = int.Parse(Console.ReadLine());

int p = 1;
for (int i = 0; i < num2; i++)
{
    p *= num1;
}
Console.WriteLine($"Result Is: {p} ");

#endregion

#region Problem 18
Console.WriteLine("Enter a string");
string text = Console.ReadLine();
for (int i = text.Length - 1; i >= 0; i--)
{
    Console.Write(text[i]);
}

#endregion

#region Problem 19
Console.WriteLine("Enter a number");
int number = int.Parse(Console.ReadLine());
int reversed = 0;

while (number != 0)
{
    int digit = number % 10;
    reversed = reversed * 10 + digit;
    number /= 10;
}
Console.WriteLine($"Reversed Number: {reversed}");

#endregion

#region Problem 20

#endregion

#region Problem 21
Console.WriteLine("Enter a sentence");
string sentence = Console.ReadLine();

string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
Array.Reverse(words);
Console.WriteLine(string.Join(" ", words));

#endregion

