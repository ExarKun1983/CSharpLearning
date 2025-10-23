string operation = null;
do
{
    // See https://aka.ms/new-console-template for more information
    Console.WriteLine("Enter the first number:");
    string input1 = Console.ReadLine();
    if (input1 == "exit")
    {
        break;
    }

    Console.WriteLine("Enter the second number:");
    string input2 = Console.ReadLine();

    if (input2 == "exit")
    {
        break;
    }

    Console.WriteLine("Enter operation (+, -, *, /):");
    operation = Console.ReadLine();

    int result = 0;

    if (int.TryParse(input1, out int result1))
    {
        //Console.WriteLine("Invalid input for the first number!");
        if (int.TryParse(input2, out int result2))
        {
            if (result2 == 0 && operation == "/")
            {
                Console.WriteLine("Can not divide by 0");
            }
            else
            {
                switch (operation)
                {
                    case "+": result = result1 + result2; break;
                    case "-": result = result1 - result2; break;
                    case "*": result = result1 * result2; break;
                    case "/": result = result1 / result2; break;
                    default:
                        Console.WriteLine("Invalid operation! Try again.");
                        continue;
                }
            }            
        }
        else
        {
            Console.WriteLine("Invalid input for the second number!");
            continue;
        }
    }
    else
    {
        Console.WriteLine("Invalid input for the first number!");
        continue;
    }
    Console.WriteLine($"Result: {result}");

} while (operation != "exit");
