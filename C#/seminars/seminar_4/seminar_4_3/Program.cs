//Решение факторила через функцию

int to =int.Parse(Console.ReadLine());
Console.WriteLine(Calculate(to));

int Calculate(int to)
{
    int result = 1;

    for (int i = 1; i <= to; i++)
    {
        result *= i;
    }

    return result;
}
