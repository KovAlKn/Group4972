// №47 Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
// * При выводе матрицы показывать каждую цифру разного цвета(цветов всего 16)

double[, ] CreateRandomMatrix(int m, int n, int minLimitRandom, int maxLimitRandom)
{
      System.Random rnd = new System.Random(); 
      double[,] array = new double[m,n];
            
      for(int i =0;i<m;i++)
      {
        for(int j=0;j<n; j++)
        {
            array[i,j]=rnd.NextDouble()*(maxLimitRandom-minLimitRandom)+minLimitRandom;
        }
      }
    return array; 
}

void PrintArray(double[, ] matrix)
{
  ConsoleColor[] colors = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                         ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                         ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                         ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                         ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                         ConsoleColor.Yellow};
      int col = 0;                                  
      for(int i=0; i<matrix.GetLength(0);i++)
      {
        for(int j=0;j<matrix.GetLength(1);j++)

        {
          Console.ForegroundColor= colors[col];
            Console.Write(Math.Round(matrix[i,j],3)+" \t");
            col++;
            if(col>15){col=0;}
        }
        Console.WriteLine();
      } 
}

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

int m = ReadData("m = ");
int n= ReadData("n = ");
int minLimitRandom = -10;
int  maxLimitRandom = 10;

double[, ] result = CreateRandomMatrix(m, n, minLimitRandom, maxLimitRandom);
PrintArray(result);