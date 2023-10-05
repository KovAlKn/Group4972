// Задача 67
// Программа принимает на вход число N и возвращает сумму цифр в числе

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}

int SumDigitRec(int num)
{
    if(num==0)
    {
        return 0;
    }
    else
    {
        return num%10+SumDigitRec(num/10);
    }
}
int n = ReadData("Укажите число N:");
int res = SumDigitRec(n);
Console.WriteLine($"Сумма цифр числа {n}: {res}");