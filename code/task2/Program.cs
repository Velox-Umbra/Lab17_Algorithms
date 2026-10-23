using System;

class Program
{
    static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;

        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }

    static void Main()
    {
        Console.WriteLine("=== Проверка простого числа ===\n");

        Console.Write("Введите целое число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (IsPrime(number))
        {
            Console.WriteLine($"{number} — простое число.");
        }
        else
        {
            Console.WriteLine($"{number} — не является простым числом.");
        }
    }
}