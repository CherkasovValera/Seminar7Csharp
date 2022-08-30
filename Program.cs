//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.Clear();
int Prompt(string message)
{
    System.Console.Write(message);                    // Вывести сообщение
    int result = Convert.ToInt32(Console.ReadLine()); // Считывает значение
    return result;                                    // Возвращает результат
}
double[,] FillArray(int numLine, int numColumns, int maxRand, int minRand )         // Функция создания и заполнения двумерного массива случайными числами  
{
    double[,] matrix = new double[numLine, numColumns];
    for (int i = 0; i < matrix.GetLength(0); i++)   
    {
        for (int j = 0; j < matrix.GetLength(1); j++)     
        {
            matrix[i, j] = new Random().NextDouble()*2*maxRand-(maxRand- minRand)/2;      
        }
    }
    return matrix;
}
void PrintArray(double[,] matrix)              // Функция печати массива 
{
    for (int i = 0; i < matrix.GetLength(0); i++)  
    {
        for (int j = 0; j < matrix.GetLength(1); j++)   
        {
            Console.Write($"{matrix[i, j],7:f2}\t");
        }
        Console.WriteLine();
    }
}
int numLine = Prompt("Введите количество строк массива ");
int numColumns = Prompt("Введите количество столбцов массива ");
int maxRand = Prompt("Введите верхнюю границу диапазона ");     
int minRand = Prompt("Введите нижнюю границу диапазона ");         
double[,] matrix = FillArray(numLine, numColumns, maxRand, minRand); 
PrintArray(matrix);

