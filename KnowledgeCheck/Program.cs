
using KnowledgeCheck1_Calculator;

Console.WriteLine("Hello. Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division");

var input = Console.ReadLine();
var calculator = new Calculator();

switch (input)
{
    case "1":
        Console.WriteLine("Enter 2 numbers to add");
        var addNumber1 = Console.ReadLine();
        var addNumber2 = Console.ReadLine();

        if (double.TryParse(addNumber1, out double addNumOne) && double.TryParse(addNumber2, out double addNumTwo))
        {
            Console.Write($"{addNumber1} + {addNumber2} = ");
            Console.Write(calculator.Calculate("add", addNumOne, addNumTwo));
        }
        else
        {
            Console.WriteLine("One or more of the numbers is not an double");
        }
        break;

    case "2":
        Console.WriteLine("Enter 2 numbers to subtract");
        var subtractNumber1 = Console.ReadLine();
        var subtractNumber2 = Console.ReadLine();

        if (double.TryParse(subtractNumber1, out double subNumOne) && double.TryParse(subtractNumber2, out double subNumTwo))
        {
            Console.Write($"{subtractNumber1} - {subtractNumber2} = ");
            Console.Write(calculator.Calculate("subtract", subNumOne, subNumTwo));
        }
        else
        {
            Console.WriteLine("One or more of the numbers is not an double");
        }
        break;

    case "3":
        // Add code here
        Console.WriteLine("Enter 2 numbers to multiply");
        var n1 = Console.ReadLine();
        var n2 = Console.ReadLine();

        if (double.TryParse(n2, out double multiplyN1) && double.TryParse(n2, out double multiplyN2))
        {
            Console.Write($"{multiplyN1} / {multiplyN2} = ");
            Console.Write(calculator.Calculate("multiply", multiplyN1, multiplyN2));
        }
        else
        {
            Console.WriteLine("One or more of the numbers is not an double");
        }
        break;
    case "4":
        Console.WriteLine("Enter 2 numbers to divide");
        var divideNumber1 = Console.ReadLine();
        var divideNumber2 = Console.ReadLine();

        if (double.TryParse(divideNumber1, out double divNumOne) && double.TryParse(divideNumber2, out double divNumTwo))
        {
            Console.Write($"{divideNumber1} / {divideNumber2} = ");
            Console.Write(calculator.Calculate("divide", divNumOne, divNumTwo));
        }
        else
        {
            Console.WriteLine("One or more of the numbers is not an double");
        }
        break;

    default:
        Console.WriteLine("Unknown input");
        break;
}
