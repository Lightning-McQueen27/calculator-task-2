using System;

namespace calculator_task_2
{
    class Program
    {
        static void Main(string[] args)
        { while (true)
            {

                Console.WriteLine("Введите число, операцию и второе число через Enter");
                try
                {
                    Console.WriteLine("Ответ: " + Calculate(Convert.ToDouble(Console.ReadLine()), Convert.ToChar(Console.ReadLine()), Convert.ToDouble(Console.ReadLine())));

                }
                catch (FormatException)
                {
                    Console.WriteLine("Введены неправильные аргументы");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        static double Calculate(double x, char operation, double y)
        {
            try
            {
                switch (operation)
                {
                    case '+':
                        return Add(x, y);
                    case '-':
                        return Subtract(x, y);
                    case '*':
                        return Multiply(x, y);
                    case '/':
                        return Divide(x, y);
                    case '^':
                        return Power(x, y);
                    default:
                        throw new ArgumentException("Введено не действие!");
                }
            }
            catch
            {
                throw;
            }
        }
        static double Add(double x, double y)
        {
            return x + y;
        }
        static double Subtract(double x, double y)
        {
            return x - y;
        }

        static double Power(double x, double y)
        {
            return Math.Pow(x, y);
        }

        static double Divide(double x, double y)
        {
            double r = x / y;
            if (y == 0);
            {
                throw new DivideByZeroException("Деление на ноль");
            }
            return x / y;
        }
        static double Multiply(double x, double y)
        {
            return x * y;
        }
    }
}
