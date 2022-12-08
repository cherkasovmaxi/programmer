string from = Console.ReadLine();Console.WriteLine(Calculate(from));int Calculate(string from){    if (int.TryParse(from, out int i))
    {        int result = from.Length;        return result;    }    throw new ArgumentException("Вы ввели не число");}
