using System;

public class ConsoleCalculator
{
    // Define generic methods for basic arithmetic operations
    public T Add<T>(T a, T b)
    {
        dynamic operand1 = a;
        dynamic operand2 = b;
        return operand1 + operand2;
    }

    public T Subtract<T>(T a, T b)
    {
        dynamic operand1 = a;
        dynamic operand2 = b;
        return operand1 - operand2;
    }

    public T Multiply<T>(T a, T b)
    {
        dynamic operand1 = a;
        dynamic operand2 = b;
        return operand1 * operand2;
    }

    public T Divide<T>(T a, T b)
    {
        dynamic operand1 = a;
        dynamic operand2 = b;

        if (operand2 == 0)
        {
            Console.WriteLine("Error: Division by zero.");
            return default(T);
        }

        return operand1 / operand2;
    }

    // Implement trigonometric functions
    public double Sin(double angle)
    {
        return Math.Sin(angle);
    }

    public double Cos(double angle)
    {
        return Math.Cos(angle);
    }

    public double Tan(double angle)
    {
        return Math.Tan(angle);
    }

    public double ArcSin(double value)
    {
        return Math.Asin(value);
    }

    public double ArcCos(double value)
    {
        return Math.Acos(value);
    }

    public double ArcTan(double value)
    {
        return Math.Atan(value);
    }

    public double Sinh(double angle)
    {
        return Math.Sinh(angle);
    }

    public double Cosh(double angle)
    {
        return Math.Cosh(angle);
    }

    public double Tanh(double angle)
    {
        return Math.Tanh(angle);
    }

    // Implement logarithmic functions
    public double Ln(double x)
    {
        return Math.Log(x);
    }

    public double Log(double x)
    {
        return Math.Log10(x);
    }

    // Implement additional mathematical functions
    public double Sqrt(double x)
    {
        return Math.Sqrt(x);
    }

    public double Power(double x, double exponent)
    {
        return Math.Pow(x, exponent);
    }

    public int Factorial(int n)
    {
        if (n == 0 || n == 1)
            return 1;

        return n * Factorial(n - 1);
    }

    // Additional string manipulation function
    public string Append(string str1, string str2)
    {
        return str1 + str2;
    }

    // Main method for testing
    public static void Main()
    {
        ConsoleCalculator calculator = new ConsoleCalculator();

        Console.WriteLine("Console Scientific Calculator");
        Console.WriteLine("------------------------------");
        while (true)
        {
            Console.WriteLine("Enter the key for the operation:");
            Console.WriteLine("A - Addition, S - Subtraction, M - Multiplication, D - Division");
            Console.WriteLine("N - Sine, C - Cosine, T - Tangent, H - ArcSine, X - ArcCos, G - ArcTan");
            Console.WriteLine("J - Sinh, K - Cosh, L - Tanh, LN - Ln, O - Log");
            Console.WriteLine("R - Square Root, P - Power, F - Factorial, U - Append");
            Console.WriteLine("V - Absolute Value, E - Exponential, I - Inverse, N - Negation");
            Console.WriteLine("Y - Ceiling, Z - Floor, Q - Quit");

            char operation = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine(); // Move to the next line after reading the key

            if (operation == 'Q')
            {
                Console.WriteLine("Exiting the calculator. Goodbye!");
                break;
            }

            switch (operation)
            {
                case 'A':
                    PerformBinaryOperation(calculator.Add);
                    break;
                case 'S':
                    PerformBinaryOperation(calculator.Subtract);
                    break;
                case 'M':
                    PerformBinaryOperation(calculator.Multiply);
                    break;
                case 'D':
                    PerformBinaryOperation(calculator.Divide);
                    break;
                case 'N':
                    PerformUnaryOperation<double>(calculator.Sin);
                    break;
                case 'C':
                    PerformUnaryOperation<double>(calculator.Cos);
                    break;
                case 'T':
                    PerformUnaryOperation<double>(calculator.Tan);
                    break;
                case 'H':
                    PerformUnaryOperation<double>(calculator.ArcSin);
                    break;
                case 'X':
                    PerformUnaryOperation<double>(calculator.ArcCos);
                    break;
                case 'G':
                    PerformUnaryOperation<double>(calculator.ArcTan);
                    break;
                case 'J':
                    PerformUnaryOperation<double>(calculator.Sinh);
                    break;
                case 'K':
                    PerformUnaryOperation<double>(calculator.Cosh);
                    break;
                case 'L':
                    PerformUnaryOperation<double>(calculator.Tanh);
                    break;
                case 'O':
                    PerformUnaryOperation<double>(calculator.Log);
                    break;
                case 'R':
                    PerformUnaryOperation<double>(calculator.Sqrt);
                    break;
                case 'P':
                    PerformBinaryOperation(calculator.Power);
                    break;
                case 'V':
                    PerformUnaryOperation<double>(Math.Abs);
                    break;
                case 'E':
                    PerformUnaryOperation<double>(Math.Exp);
                    break;
                case 'I':
                    PerformUnaryOperation<double>(x => 1 / x);
                    break;
                case 'Y':
                    PerformUnaryOperation<double>(Math.Ceiling);
                    break;
                case 'Z':
                    PerformUnaryOperation<double>(Math.Floor);
                    break;
                default:
                    Console.WriteLine("Invalid operation. Please enter a valid key.");
                    break;
            }
        }
    }

    private static void PerformBinaryOperation(Func<double, double, double> operation)
    {
        Console.WriteLine("Enter the first operand:");
        if (double.TryParse(Console.ReadLine(), out double operand1))
        {
            Console.WriteLine("Enter the second operand:");
            if (double.TryParse(Console.ReadLine(), out double operand2))
            {
                Console.WriteLine("Result: " + operation.Invoke(operand1, operand2));
            }
            else
            {
                Console.WriteLine("Invalid input for the second operand.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input for the first operand.");
        }
    }



    private static void PerformUnaryOperation<T>(Func<double, T> operation)
    {
        Console.WriteLine("Enter the operand:");
        if (double.TryParse(Console.ReadLine(), out double operand))
        {
            Console.WriteLine("Result: " + operation.Invoke(operand));
        }
        else
        {
            Console.WriteLine("Invalid input for the operand.");
        }
    }
}
