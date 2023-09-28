// Задача №51
// Задайте двумерный массив.
//  Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

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

int MainDiagSum(int[,] mtrx)
{
    int res =0;
    int minSize=mtrx.GetLength(0);
    if (minSize>mtrx.GetLength(1)) {minSize=mtrx.GetLength(1);}

    for(int i=0; i<minSize;i++)
    {
        res= res+mtrx[i,i];
    }
    return res;
}
int row = ReadData("Введите количество строк");
int column = ReadData("Введите количество столбцов");

int[,] arr2D = Fill2DArray(row, column, 100, 10);
Print2DArray(arr2D);
int sum = MainDiagSum(arr2D);
Console.WriteLine($"Сумма по главной диагонали = {sum}");
