int enterNumber(string text) // функция для ввода числового значения пользователем
{
    Console.Write($"{text}: ");
    int result;
    while (true)
    {
        string Number = Console.ReadLine();
        if (int.TryParse(Number, out result))
            return result;

        System.Console.WriteLine($"Error. {text}");
    }
    return 0;
}


void Calculator (int a, int b)
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
                    System.Console.WriteLine($"{a} {Operator} {b} = {a + b}");
                    done = true;
                    break;

                case "-":
                    System.Console.WriteLine($"{a} {Operator} {b} = {a - b}");
                    done = true;
                    break;

                case "*":
                    System.Console.WriteLine($"{a} {Operator} {b} = {a * b}");
                    done = true;
                    break;

                case "/":
                    System.Console.WriteLine($"{a} {Operator} {b} = {a / b}");
                    done = true;
                    break;
                
                default:
                    System.Console.WriteLine("Input invalid operator");
                    break;
        }
    }
}



int a = enterNumber("Please enter first number: ");

int b = enterNumber("Please enter second number: ");

Calculator(a, b);