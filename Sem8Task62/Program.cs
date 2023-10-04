// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] SpiralFillMatrix(int n)
{
    int[,] array = new int[n,n]; //Квадратная матрица

    int rowStart =0;   // Номер первой строки
    int rowEnd = n-1;  // Номер последней строки
    int colStart = 0;  //Номер первого столбца
    int colEnd = n-1;  //Номер последнего столбца

    int val=1;         //Текущее значение числа

    while(val<=n*n)
    {
        for(int j=colStart; j<=colEnd;j++) //Движение влево
        {
            array[rowStart,j] =val++;
        }
        rowStart++;
        for(int i=rowStart;i<=rowEnd;i++) //Движение вниз
        {
            array[i,colEnd]=val++;
        }
        colEnd--;
        for(int j=colEnd;j>=colStart; j--) //Движение вправо
        {
            array[rowEnd,j]=val++;
        }
        rowEnd--;
        for(int i=rowEnd;i>=rowStart; i--) //Движение вверх
        {
            array[i, colStart]=val++;
        }
        colStart++;
      
    }
   
        return array;
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
//===============Программа==========
int[,] array = SpiralFillMatrix(4);
Print2DArray(array);
