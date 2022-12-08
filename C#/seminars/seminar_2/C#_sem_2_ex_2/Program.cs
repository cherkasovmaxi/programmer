Console.WriteLine ("Первая и последняя цифра случайного трехзначного числа");

Random rnd = new Random(); //генератор случ. чисел
int number = rnd.Next(100, 1000); // случ. число от 100 до 1000

Console.WriteLine(number);

int firstPart = number/100;
int secondPart = number%10;

int result =(firstPart*10+secondPart);

Console.WriteLine(result);