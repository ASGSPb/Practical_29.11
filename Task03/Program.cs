// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.Clear();
Console.WriteLine("В 2D массиве  ");

int n = new Random().Next(2, 5);
int m = new Random().Next(2, 5);

int[,] array2D = FillingArray2D(n, m);

for (int i = 0; i < n; i++)
{
    double averageValue = 0;
    double count = 1;
    System.Console.WriteLine();

    for (int j = 0; j < m; j++)
    {
        averageValue = (array2D[i, j] + averageValue) / count;
        count++;
    }
    Console.WriteLine($"Среднее арифметическое столбца {i} равно {Math.Round(averageValue, 2)} ");
}
Console.WriteLine();

int[,] FillingArray2D(int n, int m)
{
    int[,] array2D = new int[n, m];

    for (int j = 0; j < array2D.GetLength(1); j++)
    {
        System.Console.WriteLine();

        for (int i = 0; i < array2D.GetLength(0); i++)
        {
            array2D[i, j] = new Random().Next(0, 10);

            Console.Write(String.Format("{0,6}", array2D[i, j]) + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return array2D;
}
