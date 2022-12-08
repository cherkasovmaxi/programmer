
//Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09 A (7,-5); B (1,-1) -> 7,21


Console.WriteLine("Введите X первого числа:");
double x1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите Y первого числа:");
double y1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите X второго числа:");
double x2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите Y второго числа:");
double y2 = double.Parse(Console.ReadLine());

double ab = Math.Pow(x2-x1, 2) + Math.Pow(y2 - y1, 2); //Math.Pow(x, 2) возведение числа x во 2-ю степень
double AB = Math.Round(Math.Sqrt(ab), 3); // Math.Round - округление, Math.Sqrt(ab) - квадратный корень из ab

Console.WriteLine(AB);
