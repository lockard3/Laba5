using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1, num2, result;
            string operation;

            Console.WriteLine("Введите первое число:");
            num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Введите операцию (+, -, *, /):");
            operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine("Результат: {0}", result);
                    break;
                case "-":
                    result = num1 - num2;
                    Console.WriteLine("Результат: {0}", result);
                    break;
                case "*":
                    result = num1 * num2;
                    Console.WriteLine("Результат: {0}", result);
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Ошибка: деление на ноль");
                    }
                    else
                    {
                        result = num1 / num2;
                        Console.WriteLine("Результат: {0}", result);
                    }
                    break;
                default:
                    Console.WriteLine("Ошибка: неверная операция");
                    break;
            }

            Console.ReadLine();
        }
    }
}
