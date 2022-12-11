//Задача 36: Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6]-> 0

int[] CreateArray(int length) // передаем переменную, но не присваиваю
{
    int[] array = new int[length]; // создаем пустой массив длиной length
    var random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-10, 11);
    }
    return array;
}

int SumOddIndex(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1 )
        {
            result += array[i];
        }
        
    }
    return result;
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

Console.WriteLine("Введите длину массива и получите сумму нечетных значений нечетных индексов в нем");
int[] array = CreateArray(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine(GetArrayAsString(array));
Console.WriteLine(SumOddIndex(array));