const string startText = "start";
const string exitText = "exit";
const string generateText = "generate";
const string helloText = "hello";

bool _isWork = true;

while (_isWork);
{
    string command = Console.ReadLine();

    switch (command)
    {
        case _startText: Console.WriteLine("The app is started"); break;
        case _exitText: Console.WriteLine("exit"); _isWork=false;
        break;
        case _generateText: Console.WriteLine("Badum"); break;
        case helloText: Console.WriteLine("hell0"); break;
        default:
        Console.WriteLine(); break;
    }
}