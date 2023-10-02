// №52 Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом
// столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// * Дополнительно вывести среднее арифметическое по диагоналям и диагональ выделить разным
// цветом.

//Заготовка
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

void PrintArray (int [,] matrix)
{
  for(int i=0; i<matrix.GetLength(0);i++)
  {
    for(int j=0;j<matrix.GetLength(1);j++)
    {
        Console.Write(matrix[i,j]+"\t");
    }
    Console.WriteLine();
  }
}
  
int[,] CreateIncreasingMatrix(int n, int m, int k)
  {
    int[,]array = new int[n,m];
    int temp=1;
    for(int i=0;i<n;i++)
    {
      for(int j=0;j<m;j++)
      {
        array[i,j]=temp;
        temp+=k;
      }
    }
    return array;
   }
  
void PrintListAvr (double [] list)
  {
      Console.WriteLine("The averages in columns are:");
    for(int i=0;i<list.Length;i++)
    {
      Console.Write(list[i].ToString("0.00")+"\t");
    }


  }

double [] FindAverageInColumns (int [,] matrix)
  { 
    double[] array = new double[matrix.GetLength(1)];
    for(int j=0;j<matrix.GetLength(1);j++)
    {
      double sum=0;
      int count=0;
      for(int i=0;i<matrix.GetLength(0);i++)
      {
          sum+=matrix[i,j];
          count++;
      }
      array[j]=Math.Round(sum/count,2);
        
    }

      return array;
   }





int n = ReadData("Кол-во строк");
int m = ReadData("Кол-во столбцов");
int k = ReadData("Число увеличения");
int[,] result = CreateIncreasingMatrix(n, m, k);
PrintArray(result);
PrintListAvr(FindAverageInColumns(result));
