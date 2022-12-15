using System;

bool homework_9 = true;

while (homework_9)
{
    Console.Write("Введите номер задачи: ");
    string chooseTask = Console.ReadLine();

    switch (chooseTask)
    {
        case "64": Task64(); break;
        case "66": Task66(); break;
        case "exit": homework_9 = false; break;
    }
}



void Task64() //собрать строку рекурсией от n до 1
{
        Console.WriteLine("Введите число и получите строку чисел до единицы");
        int a = 1;
        int b = Convert.ToInt32(Console.ReadLine());

        string NumbersRec(int a, int b)

        {
            if (a <= b) return NumbersRec(a + 1, b) + $"{a}  ";
            else return string.Empty;
        }
        Console.WriteLine(NumbersRec(a, b));
}//собрать строку рекурсией от n до 1

void Task66() //сумма чисел от m до n рекурсией
{
    Console.WriteLine("Введите два целых числа и узнайте сумму всех чисел в промежетке");

    int m = Convert.ToInt32(Console.ReadLine());
    int n = Convert.ToInt32(Console.ReadLine());
    int SumRec(int n, int m)
    {
        if (n == m) return 0;
        else return n + SumRec(m, n-1);

    }
    Console.WriteLine(SumRec(n,m));
}//сумма чисел от m до n рекурсией  

