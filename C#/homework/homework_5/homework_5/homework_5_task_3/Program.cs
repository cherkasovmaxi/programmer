//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

int[] CreateArray(int length) // передаем переменную, но не присваиваю
{
    int[] array = new int[length]; // создаем пустой массив длиной length
    var random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(1, 10);
    }
    return array;
}

int DiffMaxMin(int[] array)
{
    int max = 0;
       for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }

    }
    int min = int.MaxValue;
    for (int i = 0; i < array.Length; i++)
    {
        if  (array[i] < min)
        {
            min = array[i];
        }

    }
    return max - min;


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
Console.WriteLine(DiffMaxMin(array));