// Задача 48
// Задайте двумерный массив размера m*n,
// каждый элемент в массиве находится по формуле: Аmn = m+n.
//Выведите полученный массив на экран
//m=3, n=4
//0123
//1234
//2345

int[,] inputTwoDimenstions(int length, int secondLength)
{
    int[,] mass = new int[length, secondLength];
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        FillDimenstion(i, mass);
    }
    return mass;
}

int ReadInt()
{
    Console.WriteLine("Input number");
    int a = int.Parse(Console.ReadLine());
    return a;
}

void FillDimenstion(int index, int[,] massiv)
{
    for (int i = 0; i < massiv.GetLength(1); i++)
    {
        massiv[index, i] = index + i;
    }
}

void GetArrayAsString(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($"{massive[i, j]} ");
        }
        Console.WriteLine();
    }
}


Task();
void Task()
{
    int[,] array = inputTwoDimenstions(ReadInt(), ReadInt());
    GetArrayAsString(array);
}
