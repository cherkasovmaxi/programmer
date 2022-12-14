bool seminar_9 = true;

while (seminar_9)
{
    Console.Write("Введите номер примера: ");
    string chooseExamle = Console.ReadLine();

    switch (chooseExamle)
    {
        case "1": Example1(); break;
        case "2": Example2(); break;
        case "3": Example3(); break;
        case "4": Example4(); break;    
        case "exit": seminar_9 = false; break;
    }
}


void Example1() //собрать строку рекурсией от меньшего к большему
{
    Console.WriteLine("Собрать строку с числами от 1 до b");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(NumbersRec(a : 1, b: b)); // явно указано значение
}//собрать строку рекурсией от меньшего к большему


void Example2() //собрать строку рекурсией от меньшего к большему
{
    Console.WriteLine("Собрать строку с числами от a до b, a < b");
    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());

 
    Console.WriteLine(NumbersRec(a, b));
}//собрать строку рекурсией от меньшего к большему

string NumbersRec(int a, int b)

{
    if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
    else return string.Empty;

}

void Example3() //сумма чисел от 1 до n рекурсией
{
    Console.WriteLine("Введите целое число и узнайте сумму от 1 до это числа");
    int n = Convert.ToInt32(Console.ReadLine());
    int SumRec(int n)
    {
        if (n == 0) return 0;
        else return n + SumRec(n - 1);

    }
    Console.WriteLine(SumRec(n));
}//сумма чисел от 1 до n рекурсией  


void Example4() //два числа а это - число, b - это степень
{
    Console.WriteLine("два числа а это - число, b - это степень");
    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());

    int NumbersStep(int a, int b)

    {
        if (b > 1) return a * NumbersStep(a, b - 1);
        else return a;
    }
    Console.WriteLine(NumbersStep(a, b));
}//два числа а это - число, b - это степень
