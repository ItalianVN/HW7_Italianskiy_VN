/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет   */

//получения числа с консоли
int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

//Формирование массива
int[,] InitMatrix(int m, int n)
{
    int[,] resultMatrix = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            resultMatrix[i, j] = rnd.Next(-10, 10);
        }
    }
    return resultMatrix;
}

//Вывод массива на экран
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

//Поиск элемента по заданным позициям
void GetZnachenie(int m, int n, int i, int j, int[,] matrix)
{

    if (i < m && j < n)
        Console.WriteLine($"Число на запрашиваемых позициях {matrix[i, j]}");
    else
        Console.WriteLine($"Такого числа в массиве нет");

}


int[,] matrix = InitMatrix(5, 5);
PrintMatrix(matrix);
int pozition = GetNumber("Введите позицию элемента");
int i = pozition / 10;
int j = pozition % 10;
GetZnachenie(m, n, i, j, matrix);
