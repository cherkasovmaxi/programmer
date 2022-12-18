using System;

bool homeWork = true;

while (homeWork)
{
    Console.WriteLine("Введите номер задачи, например 47 и нажмите Enter");
    string command = Console.ReadLine();

    switch (command)
    {
        case "47": Task47(); break; //Задать двумерный массив размером m×n, заполненный случайными вещественными числами
        case "50": Task50(); break; //Программа, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет
        case "52": Task52(); break; //Найти среднее арифметическое элементов в каждом столбце двумерного массива
        case "exit": homeWork = false; break;
    }
}


void Task47() ////Задать двумерный массив размером m×n, заполненный случайными вещественными числами
{
    Console.WriteLine("Введите размер двумерного массива и получите двумерный " +
                      "массив из вещественных чисел");
   
    double[,] array = TwoDementionArray(Readint(), Readint());
} ////Задать двумерный массив размером m×n, заполненный случайными вещественными числами

int Readint()
{
    Console.WriteLine("Введите значение размера массива");
    int a = int.Parse(Console.ReadLine());
    return a;
}


int Readint1()
{
    Console.WriteLine("Введите элемент массива");
    int a = int.Parse(Console.ReadLine());
    return a;
}

double[,] TwoDementionArray(int lenght, int secondlenght)
{
    Random random = new Random();
    double[,] array = new double[lenght, secondlenght];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round((random.NextDouble() * 100), 2);
            Console.Write($"{array[i, j]}    ");
        }
        Console.WriteLine();
    }
    return array;
}




void Task50() /*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
    возвращает значение этого элемента или же указание, что такого элемента нет*/
{
    int[,] CreateArray(int firstLength, int secondLength)
    {
        var array = new int[firstLength, secondLength];
        var random = new Random();

        for (int i = 0; i < array.GetLength(0); i++)
        {

            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i,j] = random.Next(100);
            }
        }
        return array;
    }
   
    int GetValue(int[,] array, int x, int y)
    {
        if (x < 0 || x >= array.GetLength(0))
            return -1;
        if (y < 0 || y >= array.GetLength(1))
            return -1;
        return array[x, y];
    }
    Console.WriteLine("Получение значения выбранного элемента массива");
    Console.WriteLine();
    var array = CreateArray(Readint(),Readint());
    var element = GetValue(array, Readint1(), Readint1());
    Console.WriteLine();
    Console.WriteLine($"Значение выбранного элемента массива: {element}");

}/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
  и возвращает значение этого элемента или же указание, что такого элемента нет*/



void Task52() //Найти среднее арифметическое элементов в каждом столбце двумерного массива
{
    Console.WriteLine("Введите размер двумерного массива и получите среднее " +
                     "арифметическое каждого столбца");


    int [,] TwoDementionArray(int lenght, int secondlenght)
    {
        Random random = new Random();
        int[,] array = new int[lenght, secondlenght];

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] =  random.Next(10);
                Console.Write($"{array[i, j]}    ");
               
            }
            Console.WriteLine();
        }
        return array;
    }
    
    int[,] array = TwoDementionArray(Readint(), Readint());


    double GetAvgColumn(int[,] array, int column)
    {
        int amount = 0;

        
        for (int i = 0; i < array.GetLength(0); i++)
            {
              amount = amount + array[i, column];
            }

        return Math.Round(amount / (double) array.GetLength(0), 2);
       
    }

    for (int i = 0; i < array.GetLength(1); i++)
    {
    Console.WriteLine($"{i} --- {GetAvgColumn(array, i)}");
    }




} //Найти среднее арифметическое элементов в каждом столбце двумерного массива
