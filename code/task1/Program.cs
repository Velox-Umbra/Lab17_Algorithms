using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Калькулятор ИМТ (Индекс Массы Тела) ===\n");

        Console.Write("Введите вес (кг): ");
        double weight = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите рост (м): ");
        double height = Convert.ToDouble(Console.ReadLine());

        double imt = weight / (height * height);

        Console.WriteLine($"\nВаш ИМТ: {imt:F1}");

        string category;
        string recommendation;

        if (imt < 18.5)
        {
            category = "Недостаточный вес";
            recommendation = "Рекомендуется увеличить калорийность питания и проконсультироваться с врачом.";
        }
        else if (imt < 25.0)
        {
            category = "Нормальный вес";
            recommendation = "Отличный результат! Поддерживайте текущий образ жизни.";
        }
        else if (imt < 30.0)
        {
            category = "Избыточный вес";
            recommendation = "Рекомендуется скорректировать питание и добавить физическую активность.";
        }
        else
        {
            category = "Ожирение";
            recommendation = "Настоятельно рекомендуется обратиться к врачу и пересмотреть образ жизни.";
        }

        Console.WriteLine($"Категория: {category}");
        Console.WriteLine($"Рекомендация: {recommendation}");
    }
}