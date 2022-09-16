/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    double[,] matrix = new double[m, n];
    var rnd = new Random();
    {
         for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = rnd.Next(minValue, maxValue) / 10.0;
        }
    }
    return matrix;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) 
    {
        for (int j = 0; j < array.GetLength(1); j++)
        Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк (m)= ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов (n)= ");
int n = int.Parse(Console.ReadLine());

double[,] myArray = GetArray(m, n, -100, 100);
PrintArray(myArray);
