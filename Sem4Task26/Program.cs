// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.

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

int NumDigits(int num)
{
    int count = 0;
    while(num >0)
    {
        count++;
        num=num/10;
    }

    return count;
}
int num = ReadData("Введите число");
int res = NumDigits(num);
PrintResult("Кол-во цифр в числе "+num +": "+res);