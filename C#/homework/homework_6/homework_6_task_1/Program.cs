//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите последовательность чисел через пробел и узнайте сколько чисел больше нуля Вы ввели");
string text = Console.ReadLine();

int[] array = text.Split(' ').
          Where(x => !string.IsNullOrWhiteSpace(x)).
          Select(x => int.Parse(x)).ToArray();

int count = 0;
for (int i = 0; i< array.Length; i++)
{
    if (array[i] > 0) 
        count++;
}
Console.WriteLine($"Чисел больше нуля:  {count}");