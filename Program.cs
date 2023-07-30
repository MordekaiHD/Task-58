// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void CountTwoMatrix(int[,] massive, int[,] secondMassive, int[,] resultMassive)
{
    
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < secondMassive.GetLength(1); j++)
        {
            resultMassive[i, j] = massive[i, j] * secondMassive[i, j];
        }
    }
    Console.WriteLine();
    Console.WriteLine("Результирующая матрица будет:");
    Print2DMassive(resultMassive);
}

void Print2DMassive(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($"{massive[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] Create2DMassiv(int rows, int columns, int startValue, int finishValue)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(startValue, finishValue + 1);
        }
    }
    return matrix;
}

int[,] massive = Create2DMassiv(2, 2, 2, 4);
int[,] secondMassive = Create2DMassiv(2, 2, 2, 4);
int[,] resultMassive = Create2DMassiv(2, 2, 2, 4);
Console.WriteLine();
Console.WriteLine("Даны 2 матрицы:");
Print2DMassive(massive);
Console.WriteLine("----------");
Print2DMassive(secondMassive);
CountTwoMatrix(massive, secondMassive,resultMassive);