// Напишите программу,
// которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет



Console.Clear();
Console.WriteLine("Задайте позицию интересующего Вас элемента массива N [x, y]   ");

Console.Write("x =  ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("y =  ");
int y = Convert.ToInt32(Console.ReadLine());

int n = new Random().Next(2, 7);
Console.WriteLine($"n = {n}");
int m = new Random().Next(2, 7);
Console.WriteLine($"m= {m}");

int[,] array2D = FillingArray2D(n, m);

if (x < n && y < m)
{
    Console.WriteLine($"На позиции элемента N [{x}, {y}] находится элемент {array2D[x, y]} ");
}
else
{
    Console.WriteLine($"Массив не содержит элемент с указанной позицией N [{x}, {y}]");
    Console.WriteLine();
}

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
