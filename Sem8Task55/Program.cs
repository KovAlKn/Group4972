//Задача 55
// Поменять местами строки и столбцы

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

bool TestArrRot(int[,] arr)
{
    if(arr.GetLength(0)==arr.GetLength(1))
    {
        return true;
    }
    else
    {
        return false;}
}

void Rotate2DArr(int[,] arr)
{
    int buff =0;
   for(int i=0; i<arr.GetLength(0);i++)
   {
    for(int j=1+i; j<arr.GetLength(1);j++)
    {
        buff = arr[i,j];
        arr[i,j]=arr[j,i];
        arr[j,i]=buff;

    }
   } 
}
Console.Clear();
int[,] arr2D = Fill2DArray(5,5,10,1);
Print2DArray(arr2D);
if(TestArrRot(arr2D)==false){Console.WriteLine("Матрицу перевернуть нельзя!");};
Rotate2DArr(arr2D);
Console.WriteLine("______________________");
Print2DArray(arr2D);