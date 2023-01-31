// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
Console.WriteLine("Задайте две матрицы");
Console.WriteLine("Задайте кол-во строк 1-ой матрицы матрицы: ");
int row1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте кол-во строк 2-ой матрицы матрицы: ");
int row2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте кол-во столбов 1-ой матрицы матрицы: ");
int column1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте кол-во столбов 2-ой матрицы матрицы: ");
int column2 = Convert.ToInt32(Console.ReadLine());

if (column1 != row2) Console.WriteLine("Эти матрицы не перемножить.");
else
{
    Console.WriteLine("Полученные матрицы:");
    int[,] massiveOne = new int[row1, column1];
    int[,] massiveTwo = new int[row2, column2];

    Console.WriteLine("Первая матрица:");
    for (int i = 0; i < row1; i++)
    {
        for (int j = 0; j < column1; j++)
        {
            massiveOne[i, j] = new Random().Next(10, 100);
            Console.Write(massiveOne[i, j] + "  ");
        }
        Console.WriteLine(" ");
    }
    Console.WriteLine("Вторая матрица:");
    for (int i = 0; i < row2; i++)
    {
        for (int j = 0; j < column2; j++)
        {
            massiveTwo[i, j] = new Random().Next(10, 100);
            Console.Write(massiveTwo[i, j] + "  ");
        }
        Console.WriteLine(" ");
    }

    Console.WriteLine("Произведение этих двух матриц: ");
    int[,] resultMatrix = new int[row2, column1];

    for (int i = 0; i < row1; i++)
    {
        for (int k = 0; k < column2; k++)
        {
            int result = 0;
            for (int j = 0; j < column1; j++)
            {
                result = result + (massiveOne[i, j] * massiveTwo[j, k]);
            }
            resultMatrix[i, k] = result;
            Console.Write($"{resultMatrix[i, k]}  ");
        }
        Console.WriteLine();
    }
}