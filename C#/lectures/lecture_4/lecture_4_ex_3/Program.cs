int[,] pic = new int[,];

void PrintImage(int[,] image)
{

    for (int i = 0; i < image.GetLength(0); i++) // 3 (кол-во строк можно записать так matrix.GetLength(0)
    {
        for (int j = 0; j < image.GetLength(1); j++) // 4 (кол-во столбцов можно записать так matrix.GetLength(1)
        {
            //Console.Write($"{matrix[i, j]} ");
            if (image[i, j] == 0) Console.Write($" ");
            else Console.WriteLine($"+");
        }
        Console.WriteLine();
    } 
}

PrintImage(pic);