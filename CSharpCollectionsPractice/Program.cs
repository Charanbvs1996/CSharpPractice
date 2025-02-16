using System.Runtime.Serialization.Formatters;

List<int> numbers = new List<int>();

Console.Write("Please tell us how many numbers you want to enter: ");
string? input = Console.ReadLine();

if (int.TryParse(input, out int num) && num > 0)
{
    for (int i = 1; i <= num; i++)
    {
        while (true)
        {
            Console.Write($"Enter number {i}: ");
            string? nextNum = Console.ReadLine();
            if (int.TryParse(nextNum, out int number))
            {
                numbers.Add(number);
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }

    Console.WriteLine($"The numbers you entered are: {string.Join(", ", numbers)}");

    // Remove even numbers
    numbers.RemoveAll(x => x % 2 == 0);
    Console.WriteLine($"The numbers after removing even numbers: {string.Join(", ", numbers)}");

    // Sort in descending order
    numbers.Sort();
    numbers.Reverse();
    Console.WriteLine($"The numbers after sorting in descending order: {string.Join(", ", numbers)}");
}
else
{
    Console.WriteLine("Please enter a valid positive number for the count.");
}
