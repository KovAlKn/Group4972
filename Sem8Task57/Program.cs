// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

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

int[] FreqDic(int[,] arr, int len)
{
    int[] dic = new int[len];
    for(int i=0; i<arr.GetLength(0); i++)
    {
        for(int j=0; j<arr.GetLength(1); j++)
        {
            dic[arr[i,j]]++;
        }
    }
    return dic;
}

void PrintArr(int[] arr)
{
    Console.Write("[");
    for(int i=0; i<arr.Length-1;i++)
    {
        Console.Write(arr[i]+"; ");
    }
    Console.Write(arr[arr.Length-1]+"]");
}
int[,] array = Fill2DArray(5,5,10,0);
Print2DArray(array);
int[] dic = FreqDic(array, 10);
for(int i=0; i<10; i++)
{
    Console.Write($"{i}, ");
}
Console.WriteLine();
PrintArr(dic);