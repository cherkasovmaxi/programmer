bool lecture_7 = true;

while (lecture_7)
{
    Console.Write("Введите номер примера: ");
    string chooseExamle = Console.ReadLine();

    switch (chooseExamle)
    {
        case "1": Example1(); break;
        case "2": Example2(); break;
            case "3": Example3(); break;
            case "4": Example4(); break;
            case "5": Example5(); break;
            case "6": Example6(); break;
            case "7": Example7(); break;
        case "exit": lecture_7 = false; break;
    }
}

void Example1() //собрать строку обычным циклом от меньшего к большему
{
   
    Console.WriteLine("Собрать строку с числами от a до b, a < b");
    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());
    
    string NumbersFor(int a, int b)
        
    {
        string result = string.Empty;
        for (int i = a; i <= b; i++)
        {
            result += $"{i}  ";
        }
        return result;

    }
    Console.WriteLine(NumbersFor(a,b));
}//собрать строку обычным циклом от меньшего к большему

void Example2() //собрать строку рекурсией от меньшего к большему
{
    Console.WriteLine("Собрать строку с числами от a до b, a < b");
    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());

    string NumbersRec(int a, int b)

    {
        if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
        else return string.Empty;
    }
    Console.WriteLine(NumbersRec(a, b));
}//собрать строку рекурсией от меньшего к большему

void Example3() //собрать строку обычным циклом от большего к меньшему
{

    Console.WriteLine("Собрать строку с числами от a до b, a < b");
    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());

    string NumbersFor(int a, int b)

    {
        string result = string.Empty;
        for (int i = b; i >= a; i--)
        {
            result += $"{i}  ";
        }
        return result;

    }
    Console.WriteLine(NumbersFor(a, b));
}//собрать строку обычным циклом от большего к меньшему

void Example4() //собрать строку рекурсией от большего к меньшему
{
    Console.WriteLine("Собрать строку с числами от a до b, a < b");
    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());

    string NumbersRec(int a, int b)

    {
        if (a <= b) return NumbersRec(a + 1, b) + $"{a}  ";
        else return string.Empty;
    }
    Console.WriteLine(NumbersRec(a, b));
}//собрать строку рекурсией от большего к меньшему

void Example5() //сумма чисел от 1 до n
{
    Console.WriteLine("Введите целое число и узнайте сумму от 1 до это числа");
    int n = Convert.ToInt32(Console.ReadLine());
    int SumFor(int n)
    {       
            int result = 0;
            for (int i = 0; i <= n; i++) result += i;
            return result;        
        
    }
    Console.WriteLine(SumFor(n));
}//сумма чисел от 1 до n

void Example6() //сумма чисел от 1 до n рекурсией
{
    Console.WriteLine("Введите целое число и узнайте сумму от 1 до это числа");
    int n = Convert.ToInt32(Console.ReadLine());
    int SumRec(int n)
    {
        if (n == 0) return 0;
        else return n + SumRec(n - 1);

    }
    Console.WriteLine(SumRec(n));
}//сумма чисел от 1 до n рекурсией  

void Example7()//перебор всех слов с буквами при помощи рекурсии
{
    int n = 1;
    Console.WriteLine("Введите буквы подряд и узнайте сколько машинных слов можно их них собрать");
    string alphabet = Console.ReadLine();
    char[] word = alphabet.ToCharArray();
    void FindWords(string alphabet, char[] word, int length = 0)
    {
        if (length == word.Length)
        {
            Console.WriteLine($"{n++} {new String(word)}"); return;

        }

        for (int i = 0; i < alphabet.Length; i++)
        {
            word[length] = alphabet[i];
            FindWords(alphabet, word, length + 1);
        }
    }
    FindWords(alphabet, word);
}//перебор всех слов с буквами при помощи рекурсии