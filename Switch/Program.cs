// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter the first number:");
string input1 = Console.ReadLine();

Console.WriteLine("Enter the second number:");
string input2 = Console.ReadLine();

Console.WriteLine("Enter operation (+, -, *, /):");
string operation = Console.ReadLine();

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

if (result2 == 0 && operation == "/")
{
    Console.WriteLine("Can not divide by 0");
}

int result=0;
switch (operation)
{
    case "+": result = result1 + result2; break;
    case "-": result = result1 - result2; break;
    case "*": result = result1 * result2; break;
    case "/": result = result1 / result2; break;
    default:
        break;
}

Console.WriteLine($"Result: {result}");