// Работа с массивами
// Сортировка массива от меньшего значения к большему
int[] arr = {1,5,4,3,2,6,7,1,1};

void PrintArray(int[] array)
{
    int count = array.Length;
    
    for (int i=0; i<count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

void SelectionSortMin (int[] array)
{
    for (int i=0; i<array.Length-1; i++)
    {
        int minPosition = i;

        for (int j=i+1; j<array.Length; j ++)
        {
            if (array[j]<array[minPosition]) minPosition=j;
        }

        int temporary = array[i];
        array[i]=array[minPosition];
        array[minPosition]=temporary;
    }
}

PrintArray(arr);

SelectionSortMin(arr);

PrintArray(arr);