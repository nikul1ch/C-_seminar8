int[] CreateMatrix(int rowCount)
{
    int[] matrix = new int[rowCount];
    for (int row = 0; row < rowCount; row++)
    {
        matrix[row] = new Random().Next(0, 10);
    }
    return matrix;
}

