public class ArrayWorker
{
    /// <summary>
    /// Получение строки из двумерного массива как одномерный массива
    /// </summary>
    /// <param name="rowNumber">Номер строки, которую, я хочу получить</param>
    /// <param name="array">Массив из которого я хочу получить строку</param>
    /// <returns>Строку под номером rowNumber</returns>
    int[] GetRow(int rowNumber, int[,] array)
    {
        int[] row = new int[array.GetLength(0)];

        for (int i = 0; i < array.GetLength(1); i++)
        {
            row[i] = array[rowNumber, i];
        }

        return row;
    }

    /// <summary>
    /// Изменение массива (меняем местами первую и последнюю строки)
    /// </summary>
    /// <param name="array">Массив в котором мы меняем строки местами</param>
    public void Update(int[,] array)
    {
        int[] first = GetRow(0, array);
        int[] last = GetRow(array.GetLength(0) - 1, array);

        UpdateRow(0, last, array);
        UpdateRow(array.GetLength(0) - 1, first, array);
    }

    /// <summary>
    /// Изменение значений строки на новые
    /// </summary>
    /// <param name="rowNumber">номер строки, которую мы обновляем</param>
    /// <param name="newValue">Значения, которые будут храниться в новом массиве</param>
    /// <param name="array">Массив, в котором мы проводим обновления</param>
    void UpdateRow(int rowNumber, int[] newValue, int[,] array)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            array[rowNumber, i] = newValue[i];
        }
    }

    /// <summary>
    /// Вывод массива на экран
    /// </summary>
    /// <param name="array">Массив который мы хотим вывести</param>
    public void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    /// <summary>
    /// Получение нового двумерного массива, заполненого случайными числами [1;10]
    /// </summary>
    /// <param name="length">Длина первого измерения</param>
    /// <param name="secondLLength">Длина второго измерения</param>
    /// <returns>Новый двумерный массива</returns>
    public int[,] GetArray(int length, int secondLLength) // Создание двумерного массива
    {
        int[,] array = new int[length, secondLLength];

        var rnd = new Random();

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = rnd.Next(10);
            }
        }

        return array;
    }

    /// <summary>
    /// Метод получающий словарь (Ключ: число элемент массива. Значение: Количество вхождений этого числа в массив
    /// </summary>
    /// <param name="array">Двумерный массив</param>
    /// <returns>Словарь</returns>
    public Dictionary<int, int> GetMappingNumbers(int[,] array)
    {
        // Словарь: Хранит данные в виде ключ - значение
        // Пример: {1, 5}, {2,3} Dictionary<int, int>
        // {1, "Красный"}, {2, "Зелённый"} Dictionary <int,string>
        Dictionary<int, int> mappingNumbers = new Dictionary<int, int>();

        foreach (var item in array)
        {

            if (mappingNumbers.ContainsKey(item)) // Проверка есть ли данный ключ в словаре
            {
                mappingNumbers[item]++;
            }
            else
            {
                mappingNumbers.Add(item, 1); // Добавление нового ключ-значения в словарь
            }
        }

        return mappingNumbers;
    }

    /// <summary>
    /// Вывод словаря на эран
    /// </summary>
    /// <param name="dict"></param>
    public void PrintDict(Dictionary<int, int> dict)
    {
        foreach (var item in dict)
        {
            Console.WriteLine($"{item.Key} --- {item.Value}");
        }
    }

}


ArrayWorker worker = new ArrayWorker();


int[,] array = worker.GetArray(5, 5);


worker.PrintArray(array);

var mapNumbers = worker.GetMappingNumbers(array);
worker.PrintDict(mapNumbers);
