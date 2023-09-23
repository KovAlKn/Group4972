// Задача №44
// Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}

void FibonachiNum(int num)
{
    int firstNum = 0;
    int secondNum = 1;
    Console.Write("0, 1");
    for(int i =2; i<num; i++)
    {
        int buffer = firstNum+secondNum;
        Console.Write($", {buffer}");
        firstNum=secondNum;
        secondNum=buffer;
    }
}

int num = ReadData("Укажите номер числа Фибоначчи");
FibonachiNum(num);