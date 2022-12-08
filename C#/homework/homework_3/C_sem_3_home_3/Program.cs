//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125


Console.WriteLine("Введите число и получите таблицу кубов чисел от 1 до введеного числа");

int n = int.Parse(Console.ReadLine());

Console.WriteLine("Ниже указана требуемая последовательность");

double result = 0;

for (int i=1; i<=n; i++)
{
     result=Math.Pow(i,3);
               Console.WriteLine(result);
}
