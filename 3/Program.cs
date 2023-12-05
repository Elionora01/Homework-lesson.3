// Задайте массив из вещественных чисел 
// с ненулевой дробной частью. Найдите разницу между 
// максимальным и минимальным элементов массива.


Console.Clear();


        double[] numbers = { 2.5, 3.7, 1.2, 4.8, 5.3, 2.1 }; // Пример массива

        double min = numbers[0]; // Предполагаем, что первый элемент минимальный
        double max = numbers[0]; // Предполагаем, что первый элемент максимальный

        foreach (double number in numbers)
        {
            if (number < min)
                min = number;
            if (number > max)
                max = number;
        }

        double difference = max - min; // Находим разницу м/у мин и макс

        Console.WriteLine($"Минимальное значение: {min}");
        Console.WriteLine($"Максимальное значение: {max}");
        Console.WriteLine($"Разница между минимальным и максимальным значением: {difference}");
 
