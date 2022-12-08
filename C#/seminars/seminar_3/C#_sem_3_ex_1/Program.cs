//Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int x = int.Parse(Console.ReadLine()!);
int y = int.Parse(Console.ReadLine()!);

int quarter = -1;
if (x > 0 && y > 0)
    quarter = 1;
    //System.Console.WriteLine("1 четверть");
if (x < 0 && y > 0)
    quarter = 2;
    //System.Console.WriteLine("2 четверть");
if (x < 0 && y < 0)
    quarter = 3;
if (x > 0 && y < 0)
    quarter = 4;

if (quarter == -1)
    System.Console.WriteLine("Error");

else 
    System.Console.WriteLine($"{quarter} четверть");
