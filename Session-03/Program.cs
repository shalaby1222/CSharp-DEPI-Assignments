
#region Problem 1
Console.WriteLine("Enter a string:");
string input = Console.ReadLine();
try
{
    int number1 = int.Parse(input);
    Console.WriteLine("Parsed using int.Parse: " + number1);
    int number2 = Convert.ToInt32(input);
    Console.WriteLine("Parsed using Convert.ToInt32: " + number2);
}
catch (Exception ex)
{
    Console.WriteLine("Error: " + ex.Message);
}
#endregion

#region Question 1
// int.Parse with input null => throws ArgumentNullException
//Convert.ToInt32 with input null => returns 0
#endregion

#region Problem 2
Console.WriteLine("Enter a number:");
string input = Console.ReadLine();
bool isValid = int.TryParse(input, out int result);
if (isValid)
{
    Console.WriteLine("Number is valid: " + result);
}
else
{
    Console.WriteLine("Invalid number.");
}
#endregion

#region Question 2
/*
  TryParse Is Reccommended over Parse => Because TryParse does not throw an exception for invalid input,
  making it more efficient and safer to use in scenarios where input may not be valid.
 */
#endregion

#region Problem 3
object obj = new object();
obj = 500;
Console.WriteLine("Int HashCode: " + obj.GetHashCode());
obj = "Hello";
Console.WriteLine("String HashCode: " + obj.GetHashCode());
obj = 50.5;
Console.WriteLine("Double HashCode: " + obj.GetHashCode());
#endregion

#region Question 3
// GetHashCode() method returns a unique identifier for the object based on its value and type. 
#endregion

#region Problem 4
Person person1 = new Person();
person1.Name = "Mohamed";
Person person2 = person1;
person1.Name = "Shalaby";
Console.WriteLine("Person 1 Name: " + person1.Name);
Console.WriteLine("Person 2 Name: " + person2.Name);
class Person
{
    public string Name { get; set; }
}
#endregion

#region Question 4
/*
  Person 1 And Person 2  reference the same object in memory, 
  so when the Name property of person1 is changed, it also affects person2.
 */
#endregion

#region Problem 5
string str1 = "Hello";
Console.WriteLine("HashCode of str1: " + str1.GetHashCode());
str1 += "Hi Willy";
Console.WriteLine("HashCode of str1 after modification: " + str1.GetHashCode());
#endregion

#region Question 5
/*
 string is immutable in C# Because once a string is created, its value cannot be changed. 
 When you modify a string, a new string object is created in memory, and the original string remains unchanged
 */
#endregion

#region Problem 6
using System.Text;

StringBuilder sb = new StringBuilder("Hello");
Console.WriteLine("HashCode of StringBuilder: " + sb.GetHashCode());
sb.Append(" Hi Willy");
Console.WriteLine("HashCode of StringBuilder after modification: " + sb.GetHashCode());
#endregion

#region Question 6
/*
 StringBuilder is mutable in C# because it allows you to modify 
 the contents of the string without creating a new object.
 StringBuilder is faster for Large-scale string manipulations because it reduces memory 
 overhead and avoids creating multiple string objects.
 */
#endregion

#region Problem 7
Console.WriteLine("Enter a number1:");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter a number2:");
int number2 = int.Parse(Console.ReadLine());
int sum = number1 + number2;
Console.WriteLine("Sum is: " + sum);
Console.WriteLine(String.Format("Sum is: {0}", ( sum )));
Console.WriteLine($"Sum is {sum}");

#endregion

#region Question 7
/*
 String interpolation ($"") is more readable and concise than String.Format() because
 it allows you to embed expressions directly within the string, making it easier to understand and maintain.
 */
#endregion

#region Problem 8
using System.Text;

StringBuilder sb = new StringBuilder("Hello");
sb.AppendLine(" World");
sb.Replace("World", "Shalaby");
sb.Insert(0, "Hi ");
sb.Remove(0, 3);
Console.WriteLine(sb);
#endregion

#region Question 8
/*
 stringBuilder is designed for frequent modifications Because it allows you to efficiently 
 append, insert, remove, and replace characters without creating new string objects.
*/
#endregion