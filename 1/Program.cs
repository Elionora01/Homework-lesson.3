// Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// Найдите количество элементов массива, 
// значения которых лежат в отрезке [20,90].
//Переходите сразу в конец - в начале мои размышления.

/*
 short [] numbers = new short [10];  // создание массива и его размера
 Random random = new Random();       // вынесли рандом за цикл, чтоыб не повторять 10 раз 
 for (byte i = 0; i < numbers.Length; i++)  // создали цикл для перебооа каждого числа 
 {
    numbers [i] = Convert.ToInt16(random.Next(1, 101));  // конвертировали шорт + задали "фильтр от 1 до 100"
    Console.WriteLine("Элемент: " + numbers [i]);        // вывод в консоль
 }
            // ВЫВОДИМ РАНДОМНЫЕ 10 ЧИСЕЛ */

 // short[] array = new array [10]; // опять создали массив, зачем? 
    // Console.WriteLine(); 
    // Console.Write("Элементы массива, значения которых лежат в отрезке [20, 90]: "); */
    /*
    void Filter(int[] num); 
    int[] num = new int[num.Length];
     for (int i = 0; i < num.Length; i++) 
    { 
        if (num[i] >= 20 && num[i] <= 90); 
         Console.WriteLine(); 
         Console.Write("Элементы массива, значения которых лежат в отрезке [20, 90]: "); 
    } */



/*
        int[] array = new int[10] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
        int count = 0;

        foreach (int num in array)
        {
            if (num >= 20 && num <= 90)
            {
                count++;
            }
        }

        Console.WriteLine($"Количество элементов массива, значения которых лежат в отрезке [20,90]: {count}");*/
    

    
        
   
    Console.Clear();
       
      int[] numbers = new int[10];  // Создание массива
        Random random = new Random(); // создание рандом

        for (int i = 0; i < numbers.Length; i++)   // Заполнение массива рандом числами от 1 до 100
        {
            numbers[i] = random.Next(1, 101);
        }
        
        foreach (int number in numbers)
        {
            Console.WriteLine("Элемент: " + number);
        }

        int count = 0;

        foreach (int number in numbers)// Подсчет количества элементов массива в отрезке [20, 90]
        {
            if (number >= 20 && number <= 90)
            {
                count++;
            }
        }

        Console.WriteLine($"Количество элементов массива, значение которых находится в отрезке [20, 90]: {count}");
  

    
