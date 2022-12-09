//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]


//int[] arr = {1,2,5,7,19,6,1,33};

//void PrintArray(int[] array)
//{
//    int count = array.Length;

//    for (int i=0; i<count; i++)
//    {
//        Console.Write($"{array[i]}  ");
//    }
//    Console.WriteLine();
//}

//PrintArray(arr);

int[] array = GetArray(ReadInt());

Console.WriteLine(GetArrayAsString(array));



int[] GetArray(int length)
{
    int[] array = new int[length];

    Random random = new Random();

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
