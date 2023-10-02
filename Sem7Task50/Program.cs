// №50 Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
// * Заполнить числами Фиббоначи и выделить цветом найденную цифру


void PrintArray (int [,] matrix, int x, int y)
{
       for(int i=0; i<matrix.GetLength(0);i++)
      {
        for(int j=0;j<matrix.GetLength(1);j++)
        {
          if(i==x-1 && j==y-1)
          {
            Console.ForegroundColor=ConsoleColor.Red;}
          Console.Write(matrix[i,j]+" \t",Console.ForegroundColor);
          Console.ForegroundColor=ConsoleColor.White;
        }
        Console.WriteLine();
      }

}
  
int[,] CreateIncreasingMatrix(int n, int m)
{
      int[,]array = new int[n,m];
      int temp=0;
      int temp1=0;
      for(int i=0;i<n;i++)
      {
        for(int j=0;j<m;j++)
        {
          if(i==0 && j==1){temp=1;}
          array[i,j]=temp+temp1;
          temp=temp1;
          temp1=array[i,j];
          
        }
      }

      return array;
}
  
int[] FindNumberByPosition (int [,] matrix, int rowPosition, int columnPosition)
{  
      int[] res= new int[2];
      if(matrix.GetLength(0)+1>=rowPosition && matrix.GetLength(1)+1>=columnPosition)
      {
        res[0]=matrix[rowPosition-1,columnPosition-1];
        res[1]=0;
      }

      return res;
}

void PrintCheckIfError (int[] results, int X, int Y)
{
      if(results[0]!=0)
      {
        Console.WriteLine($"The number in [{X}, {Y}] is {results[0]}");
      }
      else
      {Console.WriteLine("There is no such index");}
}

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

int n = ReadData("n= ");
int m = ReadData("m= ");
int x= ReadData("Координат X искомого числа: ");
int y = ReadData("Координат Y искомого числа: ");
int[,] result = CreateIncreasingMatrix(n, m);

PrintArray(result, x, y);
PrintCheckIfError(FindNumberByPosition(result, x, y), x, y);
    
