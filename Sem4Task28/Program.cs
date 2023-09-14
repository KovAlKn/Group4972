// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.

using System.Numerics;
//Вводим данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

//Печатаем результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

BigInteger Factorial(int num)
{
    BigInteger res=1;
    for(int i = 2;i<=num; i++)
{
       res = res*i;
}
    
    return res;
}

int num = ReadData("Введите число ");
BigInteger res = Factorial(num);
PrintResult("Факториал числа "+ num + " равен "+res);