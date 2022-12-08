// Метод заполнения массива и передачи его на экран (консоль) и поиск нужного элемента в массиве


void FillArray(int[] collection)
{
    int Length = collection.Length;
    int index = 0;
    while (index< Length)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    
    while (position<count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;// значение -1 показывает, что позиция с искомым значением не найдена в массиве

    while(index<count)
    {
        if (collection[index] == find)
        {
            position=index;
            break; // команда останавливает поиск так же элементов в массиве и останавливается на первом
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);
