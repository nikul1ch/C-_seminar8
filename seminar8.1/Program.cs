int[,] CreateMatrix(int rowCount, int columnCount)
{
    int[,] matrix = new int[rowCount, columnCount];
    for (int row = 0; row < rowCount; row++)
    {
        for (int column = 0; column < columnCount; column++)
        {
            matrix[row, column] = new Random().Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        Console.Write($"|\t");
        for (int column = 0; column < matrix.GetLength(1); column++)
        {
            Console.Write($"{matrix[row, column]}\t");
        }
        Console.Write("|");
        Console.WriteLine();
    }

}

int[,] DescendingSortRow(int[,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int column = 0; column < matrix.GetLength(1); column++)
        {

            for (int i = column + 1; i < matrix.GetLength(1); i++)
                if (matrix[row, i] > matrix[row, column])
                {
                    int temp = matrix[row, column];
                    matrix[row, column] = matrix[row, i];
                    matrix[row, i] = temp;
                }
        }
    }
    return matrix;
}

int InputVariable(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int rowCount = InputVariable("Введите количество строк: ");
int columnCount = InputVariable("Введите количество столбцов: ");

int[,] matrix = CreateMatrix(rowCount, columnCount);
PrintMatrix(matrix);
Console.WriteLine();
DescendingSortRow(matrix);
PrintMatrix(matrix);