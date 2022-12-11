//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и
//возводит число A в натуральную степень B.
//примеры для проверки:
//3, 5 -> 243 (3⁵)
//2, 4-> 16




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
 
    int result = 1;

    for (int i = 0; i < b; i++)

    {
        result = result * a;
    }
    return result;
}


Console.WriteLine(GetPower(ReadInt(), ReadInt()));