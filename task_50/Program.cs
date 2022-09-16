/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
m = 1, n =7 -> такого числа в массиве нет*/

Console.Write("Введите позицию элемента, строка (m)= ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите позицию элемента, столбец (n)= ");
int n = int.Parse(Console.ReadLine());
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

int FindElement(int[,] MyMatrix)
{
    int element = 0;
    for (int i = 0; i < MyMatrix.GetLength(0); i++) 
    {
        for (int j = 0; j < MyMatrix.GetLength(1); j++)
            {
                if (i == m - 1 && j == n - 1) 
                element = MyMatrix[i, j];
            }
    }
    return element;
}

int[,] myArray = GetArray(row, col, 0, 10);
PrintArray(myArray);
Console.WriteLine();

if (FindElement(myArray) > 0)
    {
    Console.WriteLine("Значение выбранного элемента: " + FindElement(myArray));
    }
else
    {
    Console.WriteLine("Элемента с указанными позициями нет в этом массиве");
    }