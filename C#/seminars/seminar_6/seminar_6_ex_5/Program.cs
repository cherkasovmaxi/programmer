// Напишите программу, которая будет создавать копию заданного масива с помощью поэлементального копирования

int[] GetArray(int length)
{
    int[] mass = new int[length];
    for (int i = 0; i < length; i++)
    {
        mass[i] = i;
    }
    return mass;
}

int[] numbers = GetArray(10);

Console.WriteLine(PrintArray(numbers));

int[] array_new = new int[numbers.Length];
for (int i = 0; i < numbers.Length; i++)
{
    array_new[i] = numbers[i];
}

string PrintArray(int[] array)
{
    string result = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        result += $"{array[i]},  ";
    }
    return result;
}

Console.WriteLine(PrintArray(array_new));