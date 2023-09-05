//Задача 8: Напишите программу, которая на вход принимает число (N),
//а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число, больше 1");
int n = int.Parse(Console.ReadLine()??"0");
if (n>1)
{
int startNum = 2; //начало интервала
while (startNum <=n)
{
    if(startNum%2 == 0)
    {
        Console.Write(startNum+"; ");
        startNum=startNum+2;
    }
}
}
else
{
    Console.WriteLine("Число задано неверно!!!");
}
