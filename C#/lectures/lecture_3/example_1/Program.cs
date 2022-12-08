//Вид 1 - ничего не возврвщает и не принимает аргументы
void Method1()
{
    Console.WriteLine("Автор...")
}

Method1(); // вызов метода


//Вид 2 - ничего не возвращают, но принимают аргументы

void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "Текст сообщения");

void Method21 (string msg, int count)
{
    int i=0;
    while(i<count)
    {
        Console.WriteLine(msg);
        i++;
    
    }
}
Method21(msg: "Текст",count:4);
Method21(msg: "Текст",count:4);

//Вид 3 - Что-то возвращают, но ничего не принимают

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);


//Вид 4 - методы, которые что-то принимают и что-то возвращают

int Method4(int count, string c)
{
    int i =0;
    string result = string.Empty;
    
    while (i<count)
    {
            result = result + c:
            i++;
    }
    return result;
}

string res = Method4(10, "z");
Console.WriteLine(res);

//Вид 4 c "for"  методы, которые что-то принимают и что-то возвращают

int Method4(int count, string c)
{
    int i =0;
    string result = string.Empty;
    for (int i= 0; i<count; i++)
    {
            result = result + c;
    }
    return result;
}

string res = Method4(10, "z");
Console.WriteLine(res);