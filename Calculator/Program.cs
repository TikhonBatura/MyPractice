double enterNumber(string text) // функция для ввода числового значения пользователем
{
    Console.Write($"{text}: ");
    double result;
    while (true)
    {
        string Number = Console.ReadLine();
        if (double.TryParse(Number, out result))
            return result;

        System.Console.WriteLine($"Error. {text}");
    }
    return 0;
}


void Calculator (double a, double b)
{
    bool done = false;
    while(!done)
    {
        Console.WriteLine("Please chouse which operation would you like to do?");
        System.Console.WriteLine("+, -, *, /");
        string Operator = Console.ReadLine();

            switch (Operator)
            {
                case "+":
                    Console.Clear();
                    System.Console.WriteLine($"{a} {Operator} {b} = {a + b}");
                    done = true;
                    break;

                case "-":
                    Console.Clear();
                    System.Console.WriteLine($"{a} {Operator} {b} = {a - b}");
                    done = true;
                    break;

                case "*":
                    Console.Clear();
                    System.Console.WriteLine($"{a} {Operator} {b} = {a * b}");
                    done = true;
                    break;

                case "/":
                    Console.Clear();
                    System.Console.WriteLine($"{a} {Operator} {b} = {a / b}");
                    done = true;
                    break;
                
                default:
                    Console.Clear();
                    System.Console.WriteLine("Input invalid operator");
                    break;
        }
    }
}


Console.Clear();
double a = enterNumber("Please enter first number: ");
double b = enterNumber("Please enter second number: ");

Calculator(a, b);