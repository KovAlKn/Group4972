// Задача №49
// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные,
// и замените эти элементы на их квадраты.

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
{
    System.Random rnd = new System.Random();
    int[,] array2D = new int[countRow,countColumn];
    for(int i=0;i<countRow;i++)
    {
        for(int j=0; j<countColumn;j++)
        {
            array2D[i,j] = rnd.Next(downBorder,topBorder);
        }
    }
        return array2D;
}

void Print2DArray(int[,] matrix)
{
   for(int i=0;i<matrix.GetLength(0);i++)
    {
        for(int j=0; j<matrix.GetLength(1);j++)
        {
            Console.Write(matrix[i,j]+" \t");
        }
        Console.WriteLine();
    }
}

void Update2DArray(int[,] mtrx)
{
    for(int i=0; i<mtrx.GetLength(0);i=i+2)
    {
        for(int j=0; j<mtrx.GetLength(1); j=j+2)
        {
            mtrx[i,j]*= mtrx[i,j];
        }
    }
}
int row = ReadData("Введите количество строк");
int column = ReadData("Введите количество столбцов");

int[,] arr2D = Fill2DArray(row, column, 100, 10);
Print2DArray(arr2D);
Console.WriteLine();
Update2DArray(arr2D);
Print2DArray(arr2D);