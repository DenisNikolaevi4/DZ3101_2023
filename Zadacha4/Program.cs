// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
int row = 2;
int column = 2;
int deep = 2;

bool CompareAllElements(int[,,] array, int element)
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            for (int k = 0; k < deep; k++)
            {
                if (array[i, j, k] == element) return true;
            }
        }
    }
    return false;
}

Console.WriteLine("Полученный массив: ");
int[,,] FillMassive(int[] array)
{
    int[,,] fillMassive = new int[row, column, deep];
    int massiveElement;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            for (int k = 0; k < deep; k++)
            {
                do
                {
                    massiveElement = new Random().Next(10, 40);
                } while (CompareAllElements(fillMassive, massiveElement));


                fillMassive[i, j, k] = massiveElement;
            }
        }
    }
    return fillMassive;
}

int[,,] massive = FillMassive(new int[] { row, column, deep });
for (int k = 0; k < deep; k++)
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Console.Write($"{massive[i, j, k]}({i},{j},{k}) ");

        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


