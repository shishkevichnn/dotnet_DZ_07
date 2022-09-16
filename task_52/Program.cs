/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

Console.Write("Введите количество строк= ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов= ");
int col = int.Parse(Console.ReadLine());

int[,] GetArray(int rows, int column, int minValue, int maxValue)
{
    int[,] matrix = new int[rows, column];
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}

void MeanArithmetic(int[,] MyMatrix)
{
    double sum = 0;
    double count = 0;
    double sumcol = 0;
    Console.Write($"Среднее арифметическое по столбцам: ");
    for (int j = 0; j < MyMatrix.GetLength(1); j++)
    {
        for (int i = 0; i < MyMatrix.GetLength(0); i++) 
            {
                sum += MyMatrix[i,j];
                count++;
                sumcol = sum / count;
            }
        Console.Write($"{sumcol}; ");
        sum = 0;
        count = 0;
    }   
}

int[,] myArray = GetArray(row, col, 0, 10);
PrintArray(myArray);
MeanArithmetic(myArray);