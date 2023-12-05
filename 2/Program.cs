//  Задайте массив на 10 целых чисел. 
//  Напишите программу, которая определяет 
//  количество чётных чисел в массиве.


Console.Clear();

int[] numbers = new int[10];
Random random = new Random();

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = random.Next(1, 50);
}


foreach (int number in numbers)
{
    Console.WriteLine("Элемент: " + number);
}

int count = 0;

foreach (int number in numbers)
{
    if (number % 2 == 0) // Проверка на четность
    {
        count++;
    }
}

Console.WriteLine("Количество четных элементов массива: " + count);
