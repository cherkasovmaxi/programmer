bool homeWork = true;

while (homeWork)
{
    Console.WriteLine("Введите номер задачи, например task47 и нажмите Enter");
    string command = Console.ReadLine();

    switch (command)
    {
        case "task47": Task47(); break;
        case "task50": Task50(); break;
        case "task52": Task52(); break;
        case "exit": homeWork = false; break;
    }
}


void Task47()
{
    Console.WriteLine("Введите размер двумерного массива и получите двумерный " +
                      "массив из вещественных чисел");
    int Readint()
    {
        Console.WriteLine("input number");
        int a = int.Parse(Console.ReadLine()!);
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
    double[,] array = TwoDementionArray(Readint(),Readint());
}






void Task50()
{

}


void Task52()
{

}
