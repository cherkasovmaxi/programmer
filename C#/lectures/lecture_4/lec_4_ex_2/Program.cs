
void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10); //
        }
}

int[,] matrix = new int[3, 4];

void PrintArray(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++) // 3 (кол-во строк можно записать так matrix.GetLength(0)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // 4 (кол-во столбцов можно записать так matrix.GetLength(1)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

PrintArray(matrix);
FillArray(matrix); 
Console.WriteLine();
PrintArray(matrix); 