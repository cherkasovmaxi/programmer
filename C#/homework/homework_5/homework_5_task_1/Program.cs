//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2



using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;


int[] CreateArray (int length) // передаем переменную, но не присваиваю
{
    int[] array = new int[length]; // создаем пустой массив длиной length
    var random= new Random();
    
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(100,1000);
    }
    return array;
}

int CountIfEven (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length;i++) 
    {
        if (array[i] % 2 == 0)
            count+= 1;
    }
    return count;
}

string GetArrayAsString(int[] array)
{
    string s = string.Empty;

    foreach (var item in array)
    {
        s += $"{item} ";
    }

    return s;
}

Console.WriteLine("Введите длину массива и получите количество четных чисел в нем");
int[] array = CreateArray(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine(GetArrayAsString(array));
Console.WriteLine(CountIfEven(array));