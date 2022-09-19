//не получилось заполнить рандомными неповторяющимися числами, сделал по порядку

int[,,] CreateArrayThree(int layerCount, int rowCount, int columnCount)
{
    int count = 10;
    int[,,] array = new int[layerCount, rowCount, columnCount];
    for (int layer = 0; layer < layerCount; layer++)
    {
        for (int row = 0; row < rowCount; row++)
        {
            for (int column = 0; column < columnCount; column++)
            {
                array[layer, row, column] = count++;
            }
        }
    }
    return array;
}

void PrintArray(int[,,] array)
{
    for (int layer = 0; layer < array.GetLength(0); layer++)
    {
        Console.Write($"\t");
        for (int row = 0; row < array.GetLength(1); row++)
        {

            for (int column = 0; column < array.GetLength(2); column++)
            {
                Console.Write($"{array[layer, row, column]}({layer}, {row}, {column})\t");
            }
        }       
        Console.WriteLine(); 
    }
}

int[,,] array = CreateArrayThree(2, 2, 2);
PrintArray(array);