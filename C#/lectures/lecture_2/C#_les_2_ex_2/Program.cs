int[] array = {11,21,31,4,15,61,17,18,4};
int n = array.Length;
int find =4;
int index =0;

while (index<n)
{
    if (array[index]==find)
    {
        Console.WriteLine(index);
        break;// команда останавливает поиск так же элементов в массиве и останавливается на первом
    }
    index++;
}