//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

//int a = int.Parse(Console.ReadLine());



//int SumNumber (int a)
//{
//    int result = 0;

//    for (int i = 0; i < a; i++)
//    {
//        result = result + a % 10;
//        a = a / 10;
//    }
//    Console.WriteLine(result);
//}

Console.WriteLine("Введите число и получите сумму цифр");
int a = int.Parse(Console.ReadLine());
Console.WriteLine(SumNumber(a));

int SumNumber(int a)
{
    var aStr = a.ToString();
    int result = 0;
    
    for (int i = 0; i < aStr.Length; i++)
    {
        result += Convert.ToInt32(aStr[i].ToString());
    }
    return result;

}





