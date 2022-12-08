Console.WriteLine("Ввод N, а на выходе от -N до N");

int i = int.Parse(Console.ReadLine());

for (int j = -i; j<=i; j++)
{
    Console.WriteLine(j);
}