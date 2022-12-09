//Факториал через рексурсию

double Factorial (double n)
{
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}


Console.WriteLine(Factorial (4));