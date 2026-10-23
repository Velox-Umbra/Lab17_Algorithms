using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        bool playAgain = true;

        while (playAgain)
        {
            Console.Clear();
            Console.WriteLine("=== Игра «Угадай число» ===");
            Console.WriteLine("Компьютер загадал число от 1 до 100.\n");

            int secretNumber = random.Next(1, 101);
            int attempts = 0;
            int guess = 0;
            bool isGuessed = false;

            while (!isGuessed)
            {
                Console.Write("Ваша попытка: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out guess))
                {
                    Console.WriteLine("Ошибка: введите целое число!\n");
                    continue;
                }

                if (guess < 1 || guess > 100)
                {
                    Console.WriteLine("Число должно быть от 1 до 100!\n");
                    continue;
                }

                attempts++;

                if (guess < secretNumber)
                {
                    Console.WriteLine("Загаданное число больше!\n");
                }
                else if (guess > secretNumber)
                {
                    Console.WriteLine("Загаданное число меньше!\n");
                }
                else
                {
                    isGuessed = true;
                    Console.WriteLine($"\nПоздравляем! Вы угадали число {secretNumber}!");
                    Console.WriteLine($"Количество попыток: {attempts}");
                }
            }
            Console.Write("\nХотите сыграть ещё раз? (да/нет): ");
            string answer = Console.ReadLine()?.ToLower();

            playAgain = (answer == "да" || answer == "д" || answer == "yes" || answer == "y");
        }

        Console.WriteLine("\nСпасибо за игру! До свидания!");
    }
}