Console.Clear();
Console.Write("В 2D массиве  ");

int n = new Random().Next(2, 5);
int m = new Random().Next(2, 5);

Console.WriteLine($"колво столбцов {n} колво строк {m}");

// int n = 2;
// int m = 3;

int[,] array2D = FillingArray(n, m);

for (int i = 0; i < n; i++)
{
    double averageValue = 0;
    double count = 0;
    System.Console.WriteLine();

    for (int j = 0; j < m; j++)
    {
        // System.Console.WriteLine($"count на входе = {count}");
        averageValue = array2D[i, j] + averageValue;
        count = j + 1;
        // System.Console.WriteLine($"элемент  array2D[{i}, {j}] = {array2D[i, j]}");
        // System.Console.WriteLine($" сумма = {averageValue}");
    }
    // Console.Write($" среднеариф столбца {i} : {averageValue} / {count} = {averageValue / count}");
    Console.WriteLine(
        $"Среднее арифметическое столбца {i} равно {Math.Round(averageValue / count, 2)} "
    );
    Thread.Sleep(1000);
}
Console.WriteLine();

int[,] FillingArray(int n, int m)
{
    int[,] array2D = new int[n, m];

    for (int j = 0; j < m; j++)
    {
        System.Console.WriteLine();

        for (int i = 0; i < n; i++)
        {
            array2D[i, j] = new Random().Next(0, 10);

            Console.Write(String.Format("{0,6}", array2D[i, j]) + " ");
            // Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
    return array2D;
}

