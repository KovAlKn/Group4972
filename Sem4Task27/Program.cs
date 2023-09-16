// №27 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// (задание со *) Сделать оценку времени алгоритма через вещественные числа и строки

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine()??"0"); 
    return num;
}

// Печатаем результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}
// Суммирование через целые числа
int SumOfNum(int num)
{
    int sum = 0;
    int numShort = num;
    while(numShort>9)
    {
        sum = sum + numShort % 10;
        numShort = numShort/10;
    }
    sum = sum+numShort;
    return sum;
}

// Суммироввание через строки
int SumStringNum(string number)
{
    char[] digits = number.ToCharArray();
    int sum = 0;
    for(int i=0; i< number.Length;i++)
    {
       sum = sum + int.Parse(digits[i].ToString()); 
    }
    return sum;
}

int num = ReadData("Введите число");
DateTime d1 = DateTime.Now;
int result = SumOfNum(num);
PrintResult("Cумма цифр числа " + num +" составляет "+result);
Console.WriteLine(DateTime.Now-d1);

DateTime d2 = DateTime.Now;
int resultString = SumStringNum(num.ToString());
PrintResult("Cумма цифр числа " + num +" вторым методом составляет "+resultString);
Console.WriteLine(DateTime.Now-d1);

