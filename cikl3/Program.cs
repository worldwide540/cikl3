using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Введите первое число:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if ((num1 >= 0 && num1 <= 10) && (num2 >= 0 && num2 <= 10))
            {
                Console.WriteLine($"Результат умножения: {num1 * num2}");
                break;
            }
            else
            {
                Console.WriteLine("Введенные числа недопустимы. Пожалуйста, введите два числа от 0 до 10.");
            }
        }
    }
}
