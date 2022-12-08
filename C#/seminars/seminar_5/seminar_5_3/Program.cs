
int a = int.Parse(Console.ReadLine());

int[] arr = new int[]  {6,7,19,345,3};

void PrintArray(int[] array)
{
    int count = array.Length;
    
    for (int i=0; i<count; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();
}

bool Check (int[] array)
{
    for (int i=0; i<array.Length; i++)
    {
       if (arr[i]==a)
    {
       Console.WriteLine("Заданное число присутствует в массиве");
       return true;
    }
    else
    {
        Console.WriteLine("Заданное число не присутствует в массиве");
        return false;
    }
    }
    return false;
}



Check(arr);

PrintArray(arr);