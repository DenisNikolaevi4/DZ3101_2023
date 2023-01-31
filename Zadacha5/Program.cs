// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07   
void FillSpiralArray(int[,] array)
{
    int left = 0, right = array.GetLength(1) - 1, top = 0, bottom = array.GetLength(0) - 1, count = 1, direction = 1;
    while (count <= array.Length)
    {
        if (direction == 1)
        {
            for (int i = left; i <= right; i++)
                array[top, i] = count++;
            top++;
            direction = 2;
        }
        else if (direction == 2)
        {
            for (int i = top; i <= bottom; i++)
                array[i, right] = count++;
            right--;
            direction = 3;
        }
        else if (direction == 3)
        {
            for (int i = right; i >= left; i--)
                array[bottom, i] = count++;
            bottom--;
            direction = 4;
        }
        else if (direction == 4)
        {
            for (int i = bottom; i >= top; i--)
                array[i, left] = count++;
            left++;
            direction = 1;
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}\t");
        Console.WriteLine();
    }
}
int rows = 7;
int columns = 5;
int[,] massive = new int[rows, columns];
FillSpiralArray(massive);
PrintArray(massive);