Console.WriteLine("Hello!");
Console.WriteLine("Input the first number:");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Input the second number:");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("What do you want to do with those numbers?");
Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubtract");
Console.WriteLine("[M]ultiply");
string operation = Console.ReadLine().ToUpper().Trim();

switch(operation)
{
    case "A":
        Console.WriteLine($"{num1} + {num2} = " + Add(num1, num2));
        Exit();
        break;
    case "S":
        Console.WriteLine($"{num1} - {num2} = " + Subrtact(num1, num2));
        Exit();
        break;
    case "M":
        Console.WriteLine($"{num1} * {num2} = " + Multiply(num1, num2));
        Exit();
        break;
    default:
        Console.WriteLine("Invalid operation");
        break;
}

int Add(int num1, int num2)
{
    int result = num1 + num2;
    return result;
}

int Subrtact(int num1, int num2)
{
    int result = num1 - num2;
    return result;
}

int Multiply(int num1, int num2)
{
    int result = num1 * num2;
    return result;
}

void Exit()
{
    Console.WriteLine("Press any button to exit");
    Console.ReadKey();
}