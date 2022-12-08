Console.WriteLine("Введите 3-х значное число и получите последнюю цифру этого числа");

int i = int.Parse(Console.ReadLine());

if (i>99 && i < 1000)
{
    Console.WriteLine(i%10);
}