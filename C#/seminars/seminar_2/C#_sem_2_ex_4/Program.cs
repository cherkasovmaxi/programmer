Console.WriteLine("Введите число и проверьте кратно ли оно 7 и 23 одновременно");

int i = int.Parse(Console.ReadLine());

if (i%7==0 && i%23==0) 
{
Console.WriteLine("Число кратно 7 и 23 одновременно");
}
else Console.WriteLine("Число не кратно 7 и 23 одновременно");
