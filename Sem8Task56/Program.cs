// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить
// строку с наименьшей суммой элементов.

//======================Methods==========================
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine()??"0");
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

//Поиск строки с наименьшей суммой элементов
int MinSumRow(int[,] arr)
{
    int rowNum = 0; // Номер сроки с наименьшей суммой
    int sumRowMin= 0; //Наименьшая сумма элементов строки
    for(int i = 0; i<arr.GetLength(0);i++)
    {
        int sumRow = Int32.MaxValue;
        for(int j=0; j<arr.GetLength(1); j++)
        {
            sumRow+=arr[i,j];
        }
        if(sumRow<sumRowMin) 
        {
            sumRowMin=sumRow;
            rowNum=i;
        }
    }
        return rowNum;    
}

// ===========Тело программы======
//Создание массива
int n = ReadData("Количество строк массива:");
int m = ReadData("Количество столбцов массива:");
int upLimit = ReadData("Верхняя грацница массива:");
int downLimit = ReadData("Нижняя грацница массива:");
int[,] array = Fill2DArray(n, m, upLimit, downLimit);

Console.WriteLine("Исходный массив");
Print2DArray(array);
int rowNum = MinSumRow(array);
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {rowNum+1}");
