using System.Data;
using System.Net.Mail;

bool my_examles = true;

while (my_examles)
{
    Console.Write("Enter number of task: ");
    string chooseTask = Console.ReadLine();
    
    switch (chooseTask)
    {
        case "1": Task1(); break;
        case "2": Task2(); break;
        case "exit": my_examles = false; break;
    }
}






void Task1()
{
    Main(args);
    static void Main(string[] args)
    {
        string yourName;
        Console.WriteLine("What is your name?");
        yourName = Console.ReadLine();
        Console.WriteLine("Hello, {0}!", yourName);
    }
    
}

void Task2()
{
    Main(args);
    static void Main(string[] args)
    {
        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("You are {0} years old", age);
    }
}