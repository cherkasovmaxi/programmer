


string GetSum(string s, int index)
{
    if (index > 0)
    {
        string s1 = s[index - 1].ToString();
        string s2 = GetSum(s, index - 1);
        return (int.Parse(s1) + int.Parse(s2)).ToString();

    }
    return "0";
}

string s = "153";
Console.WriteLine(GetSum(s, s.Length));

