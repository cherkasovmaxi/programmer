Console.WriteLine("Задайте двумерный массив размером m*n, " +
                     "заполненный случайными вещественными числами");
double[,] a = new double[,];

Random random = new Random();
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        a[i, j] = double Random.NextDouble(10, 2);
        Console.Write("{0,4}", a[i, j]);
    }
    Console.WriteLine();
}
