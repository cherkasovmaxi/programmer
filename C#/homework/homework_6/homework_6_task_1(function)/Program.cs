//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3


using System;
using System.Net.NetworkInformation;
using static System.Net.Mime.MediaTypeNames;

Console.WriteLine("Введите последовательность чисел через пробел и узнайте сколько чисел больше нуля Вы ввели");

int PositiveNumbersInString()
{
    string text = Console.ReadLine();
    int[] array = GetNumbers(text);
    return GetCount(array);
}

Console.WriteLine(PositiveNumbersInString());

int[] GetNumbers(string input) //функция перевода строки в массив из целых чисел (если есть пробелы)
{
    int[] array = input.Split(' ').
              Where(x => !string.IsNullOrWhiteSpace(x)).
              Select(x => int.Parse(x)).ToArray();
    return array;
}


int GetCount(int[] array) // функция на простой цикл
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            count++;
    }
    return count;
}