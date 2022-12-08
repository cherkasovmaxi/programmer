// Смена знаков элементов массива на противоположный
int[] arr = {-4,-8,8,2};

void PrintArray(int[] array)
{
    int count = array.Length;
    
    for (int i=0; i<count; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();
}

void Change (int[] array)
{
    for (int i=0; i<array.Length; i++)
    {
       arr[i]=arr[i]*-1;
    }
}

PrintArray(arr);

Change(arr);

PrintArray(arr);