//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и
//возводит число A в натуральную степень B.
//примеры для проверки:
//3, 5 -> 243 (3⁵)
//2, 4-> 16

//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());


//void Task25 ()
//{
//    int a = ReadInt();
//    int b = ReadInt();
//    int result = 1;
//    for (int i = 0; i < b; i++)
//    {
//        result = result * a;
//    }
//    Console.WriteLine(result);
//}


int ReadInt()
{
    Console.WriteLine("enter the number");
    string a = Console.ReadLine();

    if (int.TryParse(a, out int i))
        return i;

    return -1;
}


int GetPower(int a, int b)
{
    //int a = ReadInt();
    //int b = ReadInt();
    int result = 1;

    for (int i = 0; i < b; i++)

    {
        result = result * a;
    }
    return result;
}
//Console.WriteLine(result);

Console.WriteLine(GetPower(ReadInt(), ReadInt()));