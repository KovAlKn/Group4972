// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}

int[,,] Fill3DArray(int index1, int index2, int index3,  int topBorder, int downBorder)
{
    System.Random rnd = new System.Random();
    int[,,] array3D = new int[index1, index2, index3];
    if(index1*index2*index3>topBorder-downBorder)
    {
        throw new Exception("Невозможно заполнить массив уникальными значениями!");
    }
    else
    {
        for(int i=0;i<index1;i++)
    {
        for(int j=0; j<index2;j++)
        {
            for(int k=0; k<index3;k++)
            {
                int num = rnd.Next(downBorder,topBorder);
                bool checkNum = SeachValue(array3D, num);
                if(checkNum==false) {array3D[i,j,k]=num;}
                else {k--;}
            }
            
        }
    }
        
    }
    return array3D;
}

bool SeachValue(int[,,] array, int num)
{
    bool res = false;
    foreach(int val in array)
    {
        if(val==num) { res=true;}
    }
    return res;
}

void Print3DArray(int[,,] array)
{
   for(int i=0;i<array.GetLength(0);i++)
    {
        for(int j=0; j<array.GetLength(1);j++)
        {
            for(int k=0; k<array.GetLength(2); k++)
            {
                Console.Write($"{array[i,j,k]} ({i},{j},{k})\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

//================Программа============
int ind1 = ReadData("Укажите первый размер матрицы");
int ind2 = ReadData("Укажите второй размер матрицы");
int ind3 = ReadData("Укажите третий размер матрицы");
int upLimit = 99;
int downLimit = 10;

int[,,] array = Fill3DArray(ind1, ind2, ind3, upLimit, downLimit);
Print3DArray(array);