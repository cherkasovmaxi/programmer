//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Определение наибольшего из трёх чисел");
Console.WriteLine("Введите первое число и нажмите Enter");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число и нажмите Enter");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число и нажмите Enter");
int c = int.Parse(Console.ReadLine());

int max=a;

if (a<b) max=b;

if (max<c) max=c;

Console.WriteLine("Максимальное число:  ");
Console.WriteLine(max);