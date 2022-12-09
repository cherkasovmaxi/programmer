//Треуголник

Console.WriteLine("Input number A");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Input number B");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Input number C");
int c = int.Parse(Console.ReadLine());

if (a < b + c && b < a + c && c < a + b)
{
    Console.WriteLine("Profit");
}
else
{
    Console.WriteLine("No Profit");
}
