int[] array = GetArray(ReadInt(), ReadInt(), ReadInt());

Console.WriteLine(GetArrayAsString(array));

Change(array);

Console.WriteLine(GetArrayAsString(array));

Console.WriteLine(IsExist(ReadInt(), array));



int[] GetArray(int length, int minValue, int maxValue)
{
	int[] array = new int[length];

	Random random = new Random();

	for (int i = 0; i < array.Length; i++)
	{
		array[i] = random.Next(minValue - 1, maxValue);
	}

	return array;
}

int ReadInt()
{
	string s = Console.ReadLine();

	if (int.TryParse(s, out int i))
		return i;

	return -1;
}

string GetArrayAsString(int[] array)
{
	string s = string.Empty;

	foreach (var item in array)
	{
		s += $"{item}, ";
	}

	return s;
}

void Change(int[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		array[i] *= -1;
	}
}

bool IsExist(int i, int[] numbers)
{
	foreach (int number in numbers)
	{
		if (i == number)
			return true;
	}

	return false;
}
