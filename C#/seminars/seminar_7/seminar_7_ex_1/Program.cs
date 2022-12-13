// Задача 46
//Задайте двумерный массив размером m*n,
//заполненный случайными целыми числами


int[,] InputTwoDimensionArray(int length, int secondLength)
{
    int[,] mass = new int[length, secondLength];
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        FillDimension(i,mass);
    }
    return mass;
}

int Readint()
{
    Console.WriteLine("input number");
    int a = int.Parse(Console.ReadLine()!);
    return a; //так как надо ввети одно число - сразу делаем return a
}

void FillDimension(int index, int [,] massive)
{
    for (int i = 0; i < massive.GetLength(1); i++)
    {
        massive[index, i] = new Random().Next(1, 10);
    }
}

void GetArrayAsString(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($"{massive[i, j]}  ");
        }
        Console.WriteLine();
    }
}

Task();
void Task()
{
    int[,] array = InputTwoDimensionArray(Readint(),Readint());
    GetArrayAsString(array);
}