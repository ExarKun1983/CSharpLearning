// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter the first number:");
string input1 = Console.ReadLine();

Console.WriteLine("Enter the second number:");
string input2 = Console.ReadLine();

if (!int.TryParse(input1, out int result1))
{
    Console.WriteLine("Invalid input for the first number!");
    return;
}

if (!int.TryParse(input2, out int result2))
{
    Console.WriteLine("Invalid input for the second number!");
    return;
}

int sum = result1 + result2;

Console.WriteLine($"The sum of two number {result1} and {result2} is {sum}.");
