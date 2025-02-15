using MyLearningChallenges;

using System;

using System.Runtime.CompilerServices;

#region "Challenge 1:Declare and print different variable types."
int age = 28;
double salary = 52588.67;
char initial = 'C';
bool isMarried = false;
string name = "Bvs Charan";
Console.WriteLine($"My details are:{Environment.NewLine}" +
                  $"Name: {name}{Environment.NewLine}" +
                  $"Age: {age}{Environment.NewLine}" +
                  $"Salary: {salary:F2}{Environment.NewLine}" +
                  $"Initial: {initial}{Environment.NewLine}" +
                  $"Am I married? {isMarried}");
#endregion
#region "Challenge 2: Convert user input (string) to an integer safely."
Console.WriteLine("Please Enter your age:");
string? input = Console.ReadLine();
if (int.TryParse(input, out age))
{
    Console.WriteLine($"Your age is: {age}");
}
else
{
    Console.WriteLine("Invalid input! Please enter a valid number.");
}
#endregion
#region "Challenge 3: Check if a number is positive, negative, or zero using if-else."
Console.WriteLine("enter a number:");
string? inputNum = Console.ReadLine();
if (int.TryParse(inputNum, out int num))
{
    if (num > 0)
    {
        Console.WriteLine("Positive Number.");
    }
    else if (num < 0)
    {
        Console.WriteLine("Negative Number.");
    }
    else
    {
        Console.WriteLine("it's a zero.");
    }
}
else
{
    Console.WriteLine("it's not a valid number.");
}
#endregion
#region "Challenge 4:Print and sum even numbers from 1-100 using a for loop."
Console.WriteLine("Enter a number up to which you want to display and sum even numbers:");
string? input1 = Console.ReadLine();
int sum = 0;
if (int.TryParse(input1, out int range))
{
    Console.WriteLine("\nEven Numbers:");
    for (int i = 1; i <= range; i++)
    {
        if (i % 2 == 0) // Check if even
        {
            Console.WriteLine(i);
            sum += i;
        }
    }
    Console.WriteLine($"\nOverall sum of even numbers is: {sum}");
}
else
{
    Console.WriteLine("Invalid input! Please enter a valid number.");
}
#endregion
#region "Challenge 5: Categorize a number as "small," "medium," or "large" using switch"
Console.WriteLine("Please enter a number");
string? inputNumber = Console.ReadLine();
if (int.TryParse(inputNumber, out int num1))
{
    switch (true)
    {
        case var _ when num1 > 0 && num1 <= 1000:
            Console.WriteLine("small number");
            break;
        case var _ when num1 > 1000 && num1 <= 10000:
            Console.WriteLine("medium number");
            break;
        case var _ when num1 > 10000:
            Console.WriteLine("large number");
            break;
        default:
            Console.WriteLine("invalid number");
            break;
    }
}
else
{
    Console.WriteLine("Enter valid number");
}
#endregion
#region "Challenge 6: Implement a method to add two numbers."
AddTwoNumbers addTwoNumbers = new AddTwoNumbers(10, 20);
int result = addTwoNumbers.AddNumbers();
Console.WriteLine("sum is:" + result);
#endregion
#region "Challenge 7: Write a function to check if a string is a palindrome."
AddTwoNumbers addTwoNumbers1 = new AddTwoNumbers();
bool res = addTwoNumbers1.isPalindrome("madam");
if (res) Console.WriteLine("yes it's a palindrome.");
else Console.WriteLine("nope, it's not a palindrome");
#endregion
#region "Challenge 8: Handle invalid input using try-catch."
try
{
    Console.WriteLine("Please enter any number");
    string? inputNumb = Console.ReadLine();
    if (int.TryParse(inputNumb, out int inp))
    {
        Console.WriteLine("you have entered:" + inp);
    }
    else
    {
        throw new FormatException("Not a valid number.");
    }
}
catch (FormatException ex)
{
    Console.WriteLine(ex.Message);
}
#endregion
#region "Challenge 9:Prevent division by zero errors."
try
{
    string? num2, num3;
    int resultDiv;
    Console.WriteLine("Please enter first number:");
    num2 = Console.ReadLine();
    if (int.TryParse(num2, out int inp))
    {
        Console.WriteLine("your first number is:" + inp);
        Console.WriteLine("enter your second number:");
        num3 = Console.ReadLine();
        if (int.TryParse(num3, out int inp2))
        {
            Console.WriteLine("your second number is: " + inp2);
            if (inp2 == 0)
            {
                throw new DivideByZeroException("You cannot divide a number by 0.");
            }
            resultDiv = inp / inp2;
            Console.WriteLine("The result division is:" + resultDiv);
        }
        else
        {
            throw new FormatException("Please enter numbers only.");
        }
    }
    else
    {
        throw new FormatException("please enter number only");
    }
}
catch (DivideByZeroException ex)
{
    Console.WriteLine(ex.Message);
}
catch (FormatException ex)
{
    Console.WriteLine(ex.Message);
}
#endregion
#region "Challenge 10: Print a multiplication table using a loop."
try
{
    int result1;
    Console.WriteLine("enter a value to get the table of it.");
    string? tableVal = Console.ReadLine();
    if (int.TryParse(tableVal, out int inp3))
    {
        Console.WriteLine("Your table for the value " + inp3 + " is:");
        if (inp3 != 0)
        {
            for (int i = 1; i <= 10; i++)
            {
                result1 = inp3 * i;
                Console.WriteLine($"{inp3} * {i} = {result1}");
            }
        }
        else
        {
            throw new Exception("\"Multiplication table for zero is not meaningful.");
        }
    }
    else
    {
        throw new FormatException("Valid numbers only please.");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
#endregion
#region "Challenge 11: Generate Fibonacci sequence using a while loop."
int val1, val2, val3, j, endVal;
val1 = 0; val2 = 1; j = 2; endVal = 10;
Console.Write(val1 + "," + val2);
while (j < endVal)
{
    val3 = val1 + val2;
    val1 = val2;
    val2 = val3;
    Console.Write("," + val3);
    j++;
}
#endregion
#region "Challenge 12. Find the smallest and largest number in an array. "
int[] numbers = { 5, 12, 3, 19, 8 };
int sNum = numbers[0], lNum = numbers[0];
for (int i = 1; i < numbers.Length; i++)
{
    if (numbers[i] < sNum)
    {
        sNum = numbers[i];
    }
    if (numbers[i] > lNum)
    {
        lNum = numbers[i];
    }
}
Console.WriteLine("Smallest Number is: " + sNum + " Largest Number is: " + lNum);
#endregion
#region " Challenge 13. Calculate sum and average of user-entered numbers."
try
{
    Console.WriteLine("Please mention how many number you want to enter:");
    List<int> values = new List<int>();
    string? numnerEntries = Console.ReadLine();
    if (int.TryParse(numnerEntries, out int val4))
    {
        Console.WriteLine($"Enter the {val1} values: ");
        for (int i = 1; i <= val4; i++)
        {
            string? enteredValue = Console.ReadLine();
            if (int.TryParse(enteredValue, out int val5))
            {
                values.Add(val5);
            }
            else
            {
                throw new Exception("Not a valid input.");
            }
        }
        int afterAdding = values.Sum(x => x);
        Console.WriteLine("Sum is: " + afterAdding);
        int average = afterAdding / values.Count;
        Console.WriteLine("Average is: " + average);
    }
    else
    {
        throw new Exception("Not a valid input.");
    }
}
catch (FormatException ex)
{
    Console.WriteLine(ex.Message);
}
#endregion
#region "Challenge 14 : counting vowels in a string "
List<char> vowels = new List<char>();
vowels.Add('a');
vowels.Add('e');
vowels.Add('i');
vowels.Add('o');
vowels.Add('u');
int vowelCount = 0;
Console.WriteLine("Please input any string:");
string? input2 = Console.ReadLine()?.ToLower();
if (input != null)
{
    vowelCount = (from c in input2
                  where vowels.Contains(c)
                  select c).Count();
    Console.WriteLine("No of vowels in the inputted value are: " + vowelCount);
}
else
{
    Console.WriteLine("please enter valid input.");
}
#endregion
#region "Challenge 15 : Use a Person class to store and print user details. "
Person person = new(101, "Charan", 28, "charan@gmail.com", 8106729895);
Console.WriteLine(person);
#endregion
#region "Challenge 16 : Create a Simple Console Calculator with Error Handling."
try
{
    List<string> arithOps = new List<string>() { "ADD", "SUB", "MUL", "DIV" };
    Console.WriteLine("Enter first number:");
    string? firstNum = Console.ReadLine();
    if (int.TryParse(firstNum, out int fNum))
    {
        Console.WriteLine("Enter second number:");
        string? secondNum = Console.ReadLine();
        if (int.TryParse(secondNum, out int sNum1))
        {
            Console.WriteLine("Please select any of the following operations you want to perform.");
            foreach (var op in arithOps)
            {
                Console.WriteLine(op + "\t");
            }
            string? inputSel = Console.ReadLine()?.ToUpper();
            if (!string.IsNullOrEmpty(inputSel) && arithOps.Contains(inputSel))
            {
                bool validSel = (from ops in arithOps where ops.Contains(inputSel, StringComparison.OrdinalIgnoreCase) select ops).Any();
                switch (inputSel.ToUpper())
                {
                    case "ADD":
                        Console.WriteLine($"Result: {fNum + sNum1}");
                        break;
                    case "SUB":
                        Console.WriteLine($"Result: {fNum - sNum1}");
                        break;
                    case "MUL":
                        Console.WriteLine($"Result: {fNum * sNum1}");
                        break;
                    case "DIV":
                        if (sNum != 0)
                            Console.WriteLine($"Result: {fNum / sNum1}");
                        else
                            Console.WriteLine("Cannot divide by zero!");
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
        }
    }
    else
    {
        Console.WriteLine("Please enter valid input.");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
#endregion