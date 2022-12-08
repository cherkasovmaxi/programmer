//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Определение наибольшего из двух чисел");
Console.WriteLine("Введите первое число и нажмите Enter");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число и нажмите Enter");
int b = int.Parse(Console.ReadLine());
if (a<b)
{
    Console.WriteLine("Второе число больше первого");
}
else
{
    Console.WriteLine("Первое число больше первого");
}
