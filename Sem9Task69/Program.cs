// Задача 69
// Напишите программа, которая будет принимать 2 числа А и В.
//Возведите А в степень В с помощью рекурсии.

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}

long MyPow(int a, int b)
{
    if(b==2)
    {
        return a*a;
    }
    if(b==1) {return a;}
    if(b%2==0)
    {
        return MyPow(a, b/2)*MyPow(a, b/2);
    }
    else
    {
        return MyPow(a,b/2) * MyPow(a, b/2+1);
    }
}

int numA = ReadData("Введите число А");
int numB = ReadData("Введите число В");
Console.WriteLine($"{numA} в степени {numB} равно {MyPow(numA, numB)}");