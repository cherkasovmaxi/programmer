//Задача 35. Задайте одномерный масссив из 123 случайных чисел. 
//Найти количество элементов массива, значения которых лежат в отрезке [10,99]


int[] array = GetArray(ReadInt(), ReadInt(), ReadInt());

Console.WriteLine(GetArrayAsString(array));
Console.WriteLine(Search(array));


int[] GetArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];

    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(minValue - 1, maxValue);
    }
    
    return array;
}



int ReadInt()
{
    string s = Console.ReadLine();

    if (int.TryParse(s, out int i))
        return i;

    return -1;
}



string GetArrayAsString(int[] array)
{
    string s = string.Empty;

    foreach (var item in array)
    {
        s += $"{item}, ";
    }

    return s;
}


int Search (int[] array)
    
    {
        int count = 0;
       for (int i = 0; i < array.Length; i++)
    {

        if (array[i] > 9 && array[i] < 100)

        {
            count++;    
        }

    }
    return count;
    
}
