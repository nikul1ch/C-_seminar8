//Очень сложная задача, решение загуглил

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

int[,] CreateMatrix(int rowCount, int columnCount)
{
    int[,] matrix = new int[rowCount, columnCount];

    int row = 0;
    int col = 0;
    int dx = 1;
    int dy = 0;
    int dirChanges = 0;
    int visits = columnCount;

    for (int i = 0; i < matrix.Length; i++) 
    {
        matrix[row, col] = i + 1;
        if (--visits == 0) 
        {
            visits = columnCount * (dirChanges %2) + rowCount * ((dirChanges + 1) %2) - (dirChanges/2 - 1) - 2;
            int temp = dx;
            dx = -dy;
            dy = temp;
            dirChanges++;
        }

        col += dx;
        row += dy;
    }
    return matrix;
}

PrintMatrix(CreateMatrix(4,4));