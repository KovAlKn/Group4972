// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

 // метод для умножения матриц
    int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
    {       
        if (matrixA.GetLength(0) != matrixB.GetLength(1))
        {
            throw new Exception("Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
        }

        int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

        for (int i = 0; i < matrixA.GetLength(0); i++)
        {
            for (int j = 0; j < matrixB.GetLength(1); j++)
            {
                matrixC[i, j] = 0;

                for (int k = 0; k < matrixA.GetLength(1); k++)
                {
                    matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }

        return matrixC;
    }

//=======================Тело программы=============
// Создание первого массива
Console.WriteLine("Параметры первого массива");
int nA = ReadData("Количество строк массива:");
int mA = ReadData("Количество столбцов массива:");
int upLimitA = ReadData("Верхняя грацница массива:");
int downLimitA = ReadData("Нижняя грацница массива:");
int[,] arrayA = Fill2DArray(nA, mA, upLimitA, downLimitA);
Console.WriteLine();

// Создание второго массива
Console.WriteLine("Параметры второго массива");
int nB = ReadData("Количество строк массива:");
int mB = ReadData("Количество столбцов массива:");
int upLimitB = ReadData("Верхняя грацница массива:");
int downLimitB = ReadData("Нижняя грацница массива:");
int[,] arrayB = Fill2DArray(nB, mB, upLimitB, downLimitB);

Console.WriteLine("Массив А");
Print2DArray(arrayA);
Console.WriteLine("Массив B");
Print2DArray(arrayB);
Console.WriteLine();

int[,] arrayC = MatrixMultiplication(arrayA, arrayB);
Console.WriteLine("Результат перемножения");
Print2DArray(arrayC);

