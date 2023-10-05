// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа
//  в промежутке от N до 1. Выполнить с помощью рекурсии.

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}

void GenLineRec(int num)
{
    Console.Write(num+", ");
    if(num<=1)
    {

    }
    else
    {
        GenLineRec(num-1);
    } 
}
int num = ReadData("Введите число N:");
GenLineRec(num);