// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы\
// каждой строки двумерного массива.

//============Methods===============
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

// Перестановка двух чисел
void Swap(ref int num1,ref int num2)
{
    int temp = num1;
    num1 = num2;
    num2 = temp;
}
// Сортировка пузырьком по возрастанию
int[] BubbleSort(int[] array)
{
    for(int i=0; i<array.Length; i++)
    {
        for(int j=0; j<array.Length-i-1; j++)
        {
            if(array[j]>array[j+1]) {Swap(ref array[j], ref array[j+1]);}
        }
    }
    return array;
}

void SortInRowArr(int[,] arr)
{
    int[] buf = new int[arr.GetLength(1)];
    for(int i=0; i<arr.GetLength(0); i++)
    {
        for(int j=0; j<arr.GetLength(1);j++)
        {
            buf[j]=arr[i,j];
        }
        BubbleSort(buf);
        for(int j=0; j<arr.GetLength(1);j++)
        {
            arr[i,j]=buf[j];
        }
    }
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
SortInRowArr(array);
Console.WriteLine("Массив после сортировки");
Print2DArray(array);
