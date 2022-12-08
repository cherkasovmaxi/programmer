// Среднее арифметическое

using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Введите четыре числа, и получите среднее арифметическое");

Console.WriteLine("Введите первое число, нажмите Enter");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число, нажмите Enter");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Введите третье число, нажмите Enter");
int c = int.Parse(Console.ReadLine());

Console.WriteLine("Введите четвёртое число, нажмите Enter");
int d = int.Parse(Console.ReadLine());

int sum = 0;
sum = (a + b + c + d) / 4;

Console.WriteLine("Среднее арифметическое равно");
Console.WriteLine(sum);
