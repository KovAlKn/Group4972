// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов
// в промежутке от M до N.

//========Методы=============
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}

int RecSumNum(int m, int n)
{
    int sum = 0;
    if (m==n)
    {
        return n;
    }
    else
    {
        sum=m+RecSumNum(m+1,n);
    }
    return sum;
}
//==========Программа============
int m = ReadData("Введите число M: ");
int n = ReadData("Введите число N: ");
int sum =(m>n)?RecSumNum(n,m):RecSumNum(m,n);
Console.WriteLine($"Сумма чисел в промежутке от {m} до {n} равна {sum}");