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

int[,] matrixMultiplication(int[,] matrixFirst, int[,] matrixSecond)
{
        if (matrixFirst.GetLength(0) != matrixSecond.GetLength(1))
    {
        Console.Write("Количество строк первой матрицы не равно количеству столбцов второй матрицы");
        Environment.Exit(0);
    }

    int[,] matrix = new int[matrixFirst.GetLength(0), matrixSecond.GetLength(1)];
    
    for (int i = 0; i < matrixFirst.GetLength(0); i++)
    {
        for (int j = 0; j < matrixSecond.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matrixFirst.GetLength(0); k++)
            {
                sum += matrixFirst[i, k] * matrixSecond[k, j];
            }
            matrix[i, j] = sum;
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

int InputVariable(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int rowCount = InputVariable("Введите количество строк матрицы 1: ");
int columnCount = InputVariable("Введите количество столбцов матрицы 1: ");
Console.WriteLine();

int[,] matrixFirst = CreateMatrix(rowCount, columnCount);
PrintMatrix(matrixFirst);
Console.WriteLine();

rowCount = InputVariable("Введите количество строк матрицы 2: ");
columnCount = InputVariable("Введите количество столбцов матрицы 2: ");
Console.WriteLine();

int[,] matrixSecond = CreateMatrix(rowCount, columnCount);
PrintMatrix(matrixSecond);
Console.WriteLine();

Console.WriteLine("Произведение матриц равно:");
Console.WriteLine();
PrintMatrix(matrixMultiplication(matrixFirst, matrixSecond));
