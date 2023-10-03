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

void Change2DArray(int[,] matrix)
{
    int temp =0;
    for(int i=0; i<matrix.GetLength(1); i++)
    {
        temp = matrix[0,i];
        matrix[0,i]= matrix[matrix.GetLength(0)-1,i];
        matrix[matrix.GetLength(0)-1, i]=temp;
    }

}
int[,] arr2D = Fill2DArray(10,10,10,1);
Print2DArray(arr2D);
Change2DArray(arr2D);
Console.WriteLine();
Print2DArray(arr2D);