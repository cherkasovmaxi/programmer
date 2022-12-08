Console.WriteLine(Calculate(1, 5));
Console.WriteLine(CalculateWithFor(1, 5));
Console.WriteLine(CalculateByRecursion(1, 5));

int Calculate(int from, int to)
{
    int result = 0;
    while (from <= to)
    {
        result += from;
        from++;
    }

    return result;
}

int CalculateWithFor(int from, int to)
{
    int result = 0;

    for (int i = from; i <= to; i++)
    {
        result += i;
    }

    return result;
}


int CalculateByRecursion(int from, int to)
{
    if (from == to)
        return from;

    return from + CalculateByRecursion(from + 1, to);
}
