int[,] CreateMatrix(int rowCount, int columnCount)
{
    if (rowCount == columnCount)
    {
        Console.Write("Двумерный массив не прямоугольный");
        Environment.Exit(0);
    }
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

int InputVariable(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] SumElementsRow(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0)];
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int column = 0; column < matrix.GetLength(1); column++)
        {
            array[row] += matrix[row, column];
        }
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1) Console.Write(array[i]);
        else Console.Write(array[i] + " ; ");
    }
    Console.WriteLine(" ]");
}

int FindMinRow(int[] array)
{
    int min = array[0];
    int j = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            j = i;
        }
    }
    return j;
}

int rowCount = InputVariable("Введите количество строк: ");
int columnCount = InputVariable("Введите количество столбцов: ");

int[,] matrix = CreateMatrix(rowCount, columnCount);
PrintMatrix(matrix);
Console.WriteLine();
int[] array = SumElementsRow(matrix);
PrintArray(array);
Console.WriteLine();
Console.Write($"Строка с индексом {FindMinRow(array)} имеет строку с наименьшей суммой элементов");