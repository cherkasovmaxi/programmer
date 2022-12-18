using System;

bool homework_9 = true;

while (homework_9)
{
    Console.Write("Введите номер задачи: ");
    string chooseTask = Console.ReadLine();

    switch (chooseTask)
    {
        case "64": Task64(); break; //собрать строку рекурсией от n до 1
        case "66": Task66(); break; //сумма чисел в промежутке от m до n рекурсией  
        case "68": Task68(); break; //Функция Аккермана рекурсией
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


void Task66() //сумма чисел в промежутке от m до n рекурсией
{
    Console.WriteLine("Введите по порядку два целых числа и узнайте сумму всех чисел в промежетке");

    int m = Convert.ToInt32(Console.ReadLine());
    int n = Convert.ToInt32(Console.ReadLine());
    int SumRange(int m, int n)
    {
        if (n > m)
        {
            return n + SumRange(m, n - 1);
        }
        if (n < m)
        {
            return m + SumRange(n, m - 1);
        }
        return n;

    }
    Console.WriteLine(SumRange(m,n));
}//сумма чисел в промежутке от m до n рекурсией  


void Task68() //Функция Аккермана рекурсией
{
    Console.WriteLine("Введите по порядку два целых неотрицательных числа и узнайте сумму всех чисел в промежетке");

    int m = Convert.ToInt32(Console.ReadLine());
    int n = Convert.ToInt32(Console.ReadLine());
    

    int Akkerman(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        if (m != 0 && n == 0)
        {
            return Akkerman(m - 1, 1);
        }
        if (m > 0 && n > 0)
        {
            return Akkerman(m - 1, Akkerman(m, n - 1));
        }
        return Akkerman(m, n);

    }
    Console.WriteLine(Akkerman(m, n));
}//Функция Аккермана рекурсией 

