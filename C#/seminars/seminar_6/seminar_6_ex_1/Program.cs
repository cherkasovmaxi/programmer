// Переворот одномерного массива


void Revers(int[] mass)// Переворот массива с использованием функции ChengeElement
{
    for (int i = 0; i < mass.Length / 2; i++)
    {
        ChengeElement(mass, i, mass.Length - 1 - i);
    }
}

int[] Massive(int length) //Функция заполнения массива
{
    int[] mass = new int[length];
    for (int i = 0; i < length; i++)
    {
        mass[i] = i;
    }
    return mass;
}

string GetArray(int[] array)// Заполнение массива
{
    string result = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        result += $"{array[i]},  ";
    }
    return result;
}

void ChengeElement(int[] mas, int indexOne, int indexLast)// замена 
{
    int temp = mas[indexOne];
    mas[indexOne] = mas[indexLast];
    mas[indexLast] = temp;
}
int[] massiv = Massive(10);// Запуск массива
Console.WriteLine(GetArray(massiv));
Console.WriteLine();
Revers(massiv);
Console.WriteLine(GetArray(massiv));
