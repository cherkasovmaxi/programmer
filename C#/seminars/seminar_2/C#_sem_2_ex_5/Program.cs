Console.WriteLine("Введите два числа и проверьте является ли первое число квадратом второго");
Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());


if (b*b==a || a*a==b) // и
{
Console.WriteLine("Является");
}
else Console.WriteLine("Не является");
