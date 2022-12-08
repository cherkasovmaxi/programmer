Console.WriteLine("Введите число и получите таблицу квадратов числе от 1 до введеного числа");

int n = int.Parse(Console.ReadLine());

Console.WriteLine("Ниже указана требуемая последовательность");

double result = 0;

for (int i=1; i<=n; i++)
{
     result=Math.Pow(i,2);
               Console.WriteLine(result);
}
