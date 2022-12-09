//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и
//возводит число A в натуральную степень B.
//примеры для проверки:
//3, 5 -> 243 (3⁵)
//2, 4-> 16


int a = Task25(ReadInt());
int b = Task25(ReadInt());

void Task25 (int a, int b)
{
    int n = ReadInt();
    int result = 1;

    for (int i = 0; i < n; i++)
    {
        result = result * n;
    }
    Console.WriteLine(result);
}


int ReadInt()
{
    Console.WriteLine("Enter the number");
    string n = Console.ReadLine();

    if (int.TryParse(n, out int i))
        return i;

    return -1;
}