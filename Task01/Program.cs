// Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();
Console.Write("Задайте n - колличество строк. n =  ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Задайте m - колличество столбцов. m =  ");
int m = Convert.ToInt32(Console.ReadLine());

double[,] array2D = new double[n, m];

for (int i = 0; i < array2D.GetLength(0); i++)
{
    System.Console.WriteLine();

    for (int j = 0; j < array2D.GetLength(1); j++)
    {
        array2D[i, j] = Math.Round((new Random().Next(-10, 10) + new Random().NextDouble()), 2);

        Console.Write(String.Format("{0,6}", array2D[i, j]) + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
