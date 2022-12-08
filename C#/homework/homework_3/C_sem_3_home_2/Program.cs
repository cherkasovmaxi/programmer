//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите X первого числа:");
double x1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите Y первого числа:");
double y1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите Z певрого числа:");
double z1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите X второго числа:");
double x2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите Y второго числа:");
double y2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите Z второго числа:");
double z2 = double.Parse(Console.ReadLine());

double ABC = Math.Round(Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)), 2); // Math.Round - округление, Math.Sqrt(ab) - квадратный корень из ab

Console.WriteLine(ABC);