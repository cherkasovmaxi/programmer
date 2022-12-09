string BineryNumber(int n)
{
    string result = string.Empty;
    while (n > 0)
    {
        result += n % 2;

        n /= 2;
    }
    return result;
}
Console.WriteLine($"введите число:  {BineryNumber(int.Parse(Console.ReadLine()))}");
