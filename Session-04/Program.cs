// ================================= Part01 =================================

#region Probem 1
int[] arr1 = new int[3];
arr1[0] = 10;
arr1[1] = 20;
arr1[2] = 30;

int[] arr2 = new int[] { 40, 50, 60 };

int[] arr3 = { 70, 80, 90 };
Console.WriteLine("Array 1: ");
foreach (int num in arr1)
{
    Console.Write(num + " ");
}
Console.WriteLine("\nArray 2: ");
foreach (int num in arr2)
{
    Console.Write(num + " ");
}
Console.WriteLine("\nArray 3: ");
foreach (int num in arr3)
{
    Console.Write(num + " ");
}

//IndexOutOfRangeException
Console.WriteLine(arr1[3]);
#endregion

#region Question 1
/*
For int array, the default value of each element is 0
For string array, the default value of each element is null
*/
#endregion

#region Problem 2
int[] arr1 = { 10, 20, 30 };
int[] arr2 = arr1;

// Shallow copy
arr2[0] = 40;
Console.WriteLine(arr1[0]);
Console.WriteLine(arr2[0]);

//Deep copy
int[] arr3 = (int[])arr1.Clone();
arr3[0] = 100;
Console.WriteLine(arr1[0]);
Console.WriteLine(arr3[0]);
#endregion

#region Question 2
/*
 Array.Clone => Create new array and copy the elements of the original array to the new array. It creates a shallow copy of the array, 
 meaning that if the elements are reference types, only the references are copied, not the actual objects they point to.

 Array.Copy => Copies a range of elements from one array to another array. It can be used to copy elements from one array to another,
 */
#endregion

#region Problem 3
int[,] Grades = new int[3, 3];

for (int i = 0; i < Grades.GetLength(0); i++)
{
    Console.WriteLine($"Enter grades for student {i + 1}:");
    for (int j = 0; j < Grades.GetLength(1);)
    {
        bool flag = int.TryParse(Console.ReadLine(), out Grades[i, j]);
        if (Grades[i, j] > 0 && flag)
        {
            j++;

        }
        else
        {
            Console.WriteLine("Please enter a valid grade (greater than 0):");
        }
    }
}

for (int i = 0; i < Grades.GetLength(0); i++)
{
    Console.WriteLine($"Grades for student {i + 1}:");
    for (int j = 0; j < Grades.GetLength(1); j++)
    {
        Console.Write(Grades[i, j] + " ");
    }
    Console.WriteLine();
}
#endregion

#region Question 3
// Difference between GetLength and Length for multidimensional is that GetLength returns the number of elements in a specific dimension of the array, while Length returns the total number of elements in all dimensions of the array.
#endregion

#region Problem 4
int[] Numbers = { 15, 50, 8, 10, 7, 1 };

Console.WriteLine("Original array: ");
foreach (int i in Numbers) { Console.Write(i + " "); }

Array.Sort(Numbers);
Console.WriteLine("\nAfter sorting: ");
foreach (int i in Numbers) { Console.Write(i + " "); }

Array.Reverse(Numbers);
Console.WriteLine("\nAfter reversing: ");
foreach (int i in Numbers) { Console.Write(i + " "); }

int index = Array.IndexOf(Numbers, 10);
Console.WriteLine("\nIndex of 10: " + index);

int[] arr2 = new int[Numbers.Length];
Array.Copy(Numbers, arr2, Numbers.Length);
Console.WriteLine("After copying to arr2: ");
foreach (int i in arr2) { Console.Write(i + " "); }

Array.Clear(Numbers, 0, Numbers.Length);
Console.WriteLine("\nAfter  Clear: ");
foreach (int i in Numbers) { Console.Write(i + " "); }
#endregion

#region Question 4
// Array.Copy() => copies elements and may leave the destination array partially modified if an exception occurs.
// Array.ConstrainedCopy() => guarantees that if the copy cannot be completed, the destination array remains unchanged.
#endregion

#region Problem 5 
int[] arr = { 20, 30, 10, 40, 70 };

Console.WriteLine("Using For Loop: ");
for (int i = 0; i < arr.Length; i++) { Console.Write(arr[i] + " "); }

Console.WriteLine("\nUsing Foreach: ");
foreach (int i in arr) { Console.Write(i + " "); }

Console.WriteLine("\nUsing While in Reverse: ");
int index = arr.Length - 1;
while (index >= 0)
{
    Console.Write(arr[index] + " ");
    index--;
}
#endregion

#region Quesion 5
// Foreach is Perfered for read only Because it`s Simpler and more readabl ,Does not require managing indexes and Clearly expresses
#endregion

#region Problem 6 
int number;
bool isValid;
do
{
    Console.WriteLine("Enter a positive odd number: ");
    string input = Console.ReadLine();
    isValid = int.TryParse(input, out number) && number > 0 && number % 2 != 0;
    if (!isValid)
        Console.WriteLine("Invalid input. Try again.");
}
while (!isValid);
Console.WriteLine($"Valid input received: {number}");
#endregion

#region Quesion 6
// Input validation prevents invalid data from causing Exceptions - Unexpected program behavior - Incorrect calculations - Application crashe
#endregion

#region Problem 7
int[,] Matrix =
{
    {1,2,3},
    {4,5,6 },
    {7,8,9 },
};
for (int row = 0; row < Matrix.GetLength(0); row++)
{
    for (int col = 0; col < Matrix.GetLength(1); col++)
    {
        Console.Write(Matrix[row, col] + "\t");
    }
    Console.WriteLine();
}
#endregion

#region Quesion 7
// We can format output of 2D array\t for tabs - PadLeft() / PadRight() for aligned columns - Console.WriteLine() after each row.
#endregion

#region Problem 8 
Console.WriteLine("Enter month number:");
int month = int.Parse(Console.ReadLine());
string monthName;
if (month == 1)
    monthName = "January";
else if (month == 2)
    monthName = "February";
else if (month == 3)
    monthName = "March";
else if (month == 4)
    monthName = "April";
else if (month == 5)
    monthName = "May";
else if (month == 6)
    monthName = "June";
else if (month == 7)
    monthName = "July";
else if (month == 8)
    monthName = "August";
else if (month == 9)
    monthName = "September";
else if (month == 10)
    monthName = "October";
else if (month == 11)
    monthName = "November";
else if (month == 12)
    monthName = "December";
else
    monthName = "Invalid month";
Console.WriteLine($"Using if-else: {monthName}");

string switchMonth;
switch (month)
{
    case 1:
        switchMonth = "January";
        break;
    case 2:
        switchMonth = "February";
        break;
    case 3:
        switchMonth = "March";
        break;
    case 4:
        switchMonth = "April";
        break;
    case 5:
        switchMonth = "May";
        break;
    case 6:
        switchMonth = "June";
        break;
    case 7:
        switchMonth = "July";
        break;
    case 8:
        switchMonth = "August";
        break;
    case 9:
        switchMonth = "September";
        break;
    case 10:
        switchMonth = "October";
        break;
    case 11:
        switchMonth = "November";
        break;
    case 12:
        switchMonth = "December";
        break;
    default:
        switchMonth = "Invalid month";
        break;
}
Console.WriteLine($"Using Switch: {switchMonth}");
#endregion

#region Quesion 8
/*
 we prefer a switch statement over if-else
 Use switch when you are comparing one value against multiple specific cases
 if-else is usually better when conditions involve ranges or complex logical expressions
*/
#endregion

#region Problem 9
int[] numbers = { 5, 8, 7, 9, 4, 1 };

Array.Sort(numbers);
Console.WriteLine("Array After Sorted: ");
foreach (int number in numbers) { Console.Write(number + " "); }

int firstIndex = Array.IndexOf(numbers, 7);
int lastIndex = Array.LastIndexOf(numbers, 7);

Console.WriteLine($"\nFirst index of 7: {firstIndex}");
Console.WriteLine($"Last index of 7: {lastIndex}");

#endregion

#region Quesion 9
// Time complexity of Array.sort is O(n log n)
#endregion

#region Problem 10 
int[] numbers = { 10, 50, 20, 40, 80 };

int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    sum += numbers[i];
}
Console.WriteLine($"Sum using for: {sum}");

int summ = 0;
foreach (int number in numbers)
{
    summ += number;
}
Console.WriteLine($"Sum using foreach: {summ}");
#endregion

#region Quesion 10
/*
 For a normal C# array, both are O(n) and their performance is generally very similar.
foreach is often preferred here because:
We only need to read the values.
We don't need the index.
The code is cleaner and easier to understand.
for becomes more useful when we need the index or need more control over iteration.
 */
#endregion


// ================================= Part02 =================================
Console.WriteLine("Enter number between 1 and 7 to get the corresponding day of the week:");
int input = int.Parse(Console.ReadLine());
DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), input.ToString());
Console.WriteLine($"The day of the week is: {day}");
enum DaysOfWeek
{
    Monday = 1,
    Tuesday = 2,
    Wednesday = 3,
    Thursday = 4,
    Friday = 5,
    Saturday = 6,
    Sunday = 7,
}

/*
 Enum.Parse() does not automatically check whether the integer is a defined enum value.
 For example, if the user enters 8:  output: The day is: 8
 If the input isn't a valid integer, int.Parse() throws a FormatException.
*/
