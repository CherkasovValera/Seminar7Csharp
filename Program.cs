//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// Console.Clear();
// int Prompt(string message)
// {
//     System.Console.Write(message);                    // Вывести сообщение
//     int result = Convert.ToInt32(Console.ReadLine()); // Считывает значение
//     return result;                                    // Возвращает результат
// }
// double[,] FillArray(int numLine, int numColumns, int maxRand, int minRand )         // Функция создания и заполнения двумерного массива случайными числами  
// {
//     double[,] matrix = new double[numLine, numColumns];
//     for (int i = 0; i < matrix.GetLength(0); i++)   
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)     
//         {
//             matrix[i, j] = new Random().NextDouble()*2*maxRand-(maxRand- minRand)/2;      
//         }
//     }
//     return matrix;
// }
// void PrintArray(double[,] matrix)              // Функция печати массива 
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)  
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)   
//         {
//             Console.Write($"{matrix[i, j],7:f2}\t");
//         }
//         Console.WriteLine();
//     }
// }
// int numLine = Prompt("Введите количество строк массива ");
// int numColumns = Prompt("Введите количество столбцов массива ");
// int maxRand = Prompt("Введите верхнюю границу диапазона ");     
// int minRand = Prompt("Введите нижнюю границу диапазона ");         
// double[,] matrix = FillArray(numLine, numColumns, maxRand, minRand); 
// PrintArray(matrix);

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет
//


// Console.Clear();
// int Prompt(string message)
// {
//     System.Console.Write(message);
//     int result = Convert.ToInt32(Console.ReadLine());
//     return result;
// }
// int[,] FillArray(int numLine, int numColumns, int maxRand, int minRand)
// {
//     int[,] matrix = new int[numLine, numColumns];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(minRand, maxRand);
//         }
//     }
//     return matrix;
// }
// void PrintArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j],6}");
//         }
//         Console.WriteLine();
//     }
// }
// int numLine = Prompt("Введите количество строк массива ");
// int numColumns = Prompt("Введите количество столбцов массива ");
// int maxRand = Prompt("Введите верхнюю границу диапазона ");
// int minRand = Prompt("Введите нижнюю границу диапазона ");
// int[,] matrix = FillArray(numLine, numColumns, maxRand, minRand);
// PrintArray(matrix);

// int stroka = 0;
// int stolbec = 0;
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//     }
//     stolbec++;
//     stroka++;
// }
// Console.WriteLine("Введите строку: ");
// int horizont = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите столбец: ");
// int vertikal = Convert.ToInt32(Console.ReadLine());
// if (horizont <= stroka && vertikal <= stolbec)
// {
//     Console.WriteLine($"Выбранный элемент: {matrix[horizont - 1, vertikal - 1]}");
// }
// else
// {
//     Console.WriteLine("В данном массиве не такого элемента!!!");
// }
//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Console.Clear();
// int Prompt(string message)
// {
//     System.Console.Write(message);
//     int result = Convert.ToInt32(Console.ReadLine());
//     return result;
// }
// int[,] FillArray(int numLine, int numColumns, int maxRand, int minRand)
// {
//     int[,] matrix = new int[numLine, numColumns];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(minRand, maxRand);
//         }
//     }
//     return matrix;
// }
// void PrintArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"\t{matrix[i, j],6}");
//         }
//         Console.WriteLine();
//     }
// }
// int numLine = Prompt("Введите количество строк массива ");
// int numColumns = Prompt("Введите количество столбцов массива ");
// int maxRand = Prompt("Введите верхнюю границу диапазона ");
// int minRand = Prompt("Введите нижнюю границу диапазона ");
// int[,] matrix = FillArray(numLine, numColumns, maxRand, minRand);
// PrintArray(matrix);

//     Console.WriteLine($"Среднее арифметическое по столбцу:");
//     int summa = 0;
//     double sredarif = 0;
//     for (int i = 0; i < matrix.GetLength(1); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(0); j++)
//         {
//             summa += matrix[j, i];
//         }
//         sredarif = (double)summa / matrix.GetLength(0);
//         Console.Write($"\t  {sredarif:f2}");
//         summa = 0;
//     }

