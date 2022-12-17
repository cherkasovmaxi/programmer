using System;
using System.Runtime.InteropServices;

bool homework_8 = true;

while (homework_8)
{
    Console.Write("Введите номер задачи: ");
    string chooseTask = Console.ReadLine();

    switch (chooseTask)
    {
        case "54": Task54(); break; 
        case "56": Task56(); break; 
        case "58": Task58(); break;
        case "60": Task60(); break;
        case "62": Task62(); break;
        case "exit": homework_8 = false; break;
    }
}

int Readint()
{
    Console.WriteLine("Введите значение размера массива");
    int a = int.Parse(Console.ReadLine());
    return a;
}

int[,] CreateArray(int firstLength, int secondLength)
{
    var array = new int[firstLength, secondLength];
    var random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(100);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void PrintArrayRow(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {        
        Console.Write(array[i] + " ");
       
        
    }

    Console.WriteLine();
}


int[,] CreateSquareArray(int size)
{
    return CreateArray(size, size);    
}
    



void Task54() /* 54. Задайте двумерный массив. 
 * Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива. */
{
    void SortArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            var row = new int[array.GetLength(1)];
            for (int j = 0; j < array.GetLength(1); j++)
            {
                row[j] = array[i, j];
            }

            Array.Sort(row);

            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = row[j];
            }
        }

    }
        
    
    var array = CreateArray(Readint(), Readint());
    PrintArray(array);
    SortArray(array);
    Console.WriteLine();
    PrintArray(array);
        

}





void Task56() /* Задача 56: Задайте прямоугольный двумерный массив. 
 * Напишите программу, которая будет находить строку с наименьшей суммой элементов. */
{
    int GetSum(int[,] arr, int rowNumber)
    {
        var sum = 0;
        for (int i = 0; i < arr.GetLength(1); i++)
        {
            sum += arr[rowNumber, i];
        }
        return sum;
    }

    var arr = CreateSquareArray(Readint());
    PrintArray(arr);

    var sums = new Dictionary<int, int>();

    for(int i = 0; i < arr.GetLength(0); i++)
    {
        sums[GetSum(arr, i)] = i;
    }

    var summedArray = sums.Keys.ToArray();
    Array.Sort(summedArray);

    var row = new int[arr.GetLength(1)];
    for(int i = 0; i < row.Length; i++)
    {
        row[i] = arr[sums[summedArray[0]], i];
    }

    Console.WriteLine("Строка с минимальной суммой элементов ниже:");
    Console.WriteLine();
    PrintArrayRow(row);
    
}



/*Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц. 
 Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 
 */
void Task58()
{

}


/* .Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2 
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) 
 */

void Task60()
{

}



/* Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

void Task62()
{

}