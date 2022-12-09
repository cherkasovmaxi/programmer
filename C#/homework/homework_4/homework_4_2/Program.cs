//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int a = int.Parse(Console.ReadLine());

int result = 0;

for (int i = 0; i< a; i++)
{
    result = result + a % 10;
    a = a / 10;
}
Console.WriteLine(result);