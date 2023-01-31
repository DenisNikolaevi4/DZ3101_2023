// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int row = new Random().Next(2, 5);
int column = new Random().Next(2, 5);

Random randomNumber = new Random();
int[,] massive = new int[row, column];
Console.WriteLine("Задан массив: ");

for (int i = 0; i < row; i++)
{
    for (int j = 0; j < column; j++)
    {
        massive[i, j] = new Random().Next(0, 100);
        Console.Write(massive[i, j] + "  ");
    }
    Console.WriteLine();
}
Console.WriteLine("Отсортированный массив: ");
int max;

for (int i = 0; i < row; i++)
{
    for (int j = 0; j < column; j++)
    {
        for (int k = j + 1; k < column; k++)
        {
            if (massive[i, k] > massive[i, j])
            {
                max = massive[i, j];
                massive[i, j] = massive[i, k];
                massive[i, k] = max;
            }
        }
        Console.Write(massive[i, j] + "  ");
    }
    Console.WriteLine();
}