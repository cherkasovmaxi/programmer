
void Max()
{
    int[] array = {};
    int index = array.Length;
    int max = array[array.Length-1];

    if (index < array.Length)
    {
        if (array[array.Length-index]>array[array.Length-index-1])
            {
                max = array[array.Length-index];
            }
    }
    index=index-1;
}

int[] array = {11,21,31,41,15,61,17,18,19};

int result = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);
Console.WriteLine(result);