// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// // Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
int row = new Random().Next(2, 8);
int column = new Random().Next(2, 8);

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

Console.WriteLine();
int[] rowSum = new int[row];
for (int i = 0; i < row; i++)
{
    int sum = 0;
    for (int j = 0; j < column; j++)
    {
        sum = sum + massive[i, j];
    }
    rowSum[i] = sum;
    Console.WriteLine($"Сумма {i + 1}-ой строки = {rowSum[i]}");
}

Console.WriteLine();
int minRow = rowSum[0];
int minRowIndex = 1;
for (int i = 0; i < row; i++)
{
    if (minRow > rowSum[i])
    {
        minRow = rowSum[i];
        minRowIndex = i + 1;
    }
}
Console.WriteLine("Строка с наименьшей суммой элементов: " + minRowIndex);