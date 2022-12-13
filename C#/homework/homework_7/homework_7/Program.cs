bool isWork = true;

    while (isWork)
    {
        string command = Console.ReadLine();

        switch (command)
        {
            case "task47": Task47(); break;
            case "task50": Task50(); break;
            case "task52": Task52(); break;
            case "exit": isWork = false; break;
        }
    }


void Task47()
{  
    Console.WriteLine("Задайте двумерный массив размером m*n, " +
                      "заполненный случайными вещественными числами");
    int[,] InputTwoDimensionArray(int length, int secondLength)
    {
        int[,] mass = new int[length, secondLength];
        for (int i = 0; i < mass.GetLength(0); i++)
        {
            FillDimension(i, massive);
        }
        return mass;
    }

    int Readint()
    {
        Console.WriteLine("input number");
        int a = int.Parse(Console.ReadLine()!);
        return a;
    }

    void FillDimension(int index, double[,] massive)
    {
        double[,] a = new double[5, 10];

        Random random = new Random();
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                a[i, j] = random.NextDouble() * 100; // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
                Console.Write("{0,6:F2}", a[i, j]);
            }
            Console.WriteLine();
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
        int[,] array = InputTwoDimensionArray(Readint(), Readint());
        GetArrayAsString(array);
    }

}

void Task50()
{
    Console.WriteLine("Напишите программу, которая на вход принимает позиции элемента" +
        " в двумерном массиве, и возвращает значение этого элемента или же указание, " +
        "что такого элемента нет");
                          
}

void Task52()
{
    Console.WriteLine("Задайте двумерный массив из целых чисел. " +
        "Найдите среднее арифметическое элементов в каждом столбце");

    int[,] InputTwoDimensionArray(int length, int secondLength)
    {
        int[,] mass = new int[length, secondLength];
        for (int i = 0; i < mass.GetLength(0); i++)
        {
            FillDimension(i, mass);
        }
        return mass;
    }

    int Readint()
    {
        Console.WriteLine("input number");
        int a = int.Parse(Console.ReadLine()!);
        return a; //так как надо ввети одно число - сразу делаем return a
    }

    void FillDimension(int index, double[,] massive)
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
        int[,] array = InputTwoDimensionArray(Readint(), Readint());
        GetArrayAsString(array);
    }
}


