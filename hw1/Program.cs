/*  Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9   */


//получения числа с консоли
int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

double[,] InitMatrix(int m, int n)
{
    double[,] resultMatrix = new double[m, n];
    Random rnd = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            resultMatrix[i, j] = rnd.NextDouble() * 10;
        }
    }

    return resultMatrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("{0,6:F1}", matrix[i, j]);
        }
        Console.WriteLine();
    }
}

int m = GetNumber("Введите число m:");
int n = GetNumber("Введите число n:");
Console.WriteLine();
double[,] matrix = InitMatrix(m, n);
PrintMatrix(matrix);

