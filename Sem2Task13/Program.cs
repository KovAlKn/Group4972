// №13 Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число");
double num = double.Parse(Console.ReadLine()??"0");
if (num>9999999999)
{
    Console.WriteLine("число содержит больше 10 цифр");
}
else if (num >=100)
{
    int step = 1;
    
    while (num / Math.Pow(10,step) > 9)
    {
            step++;
    }
    double thirdNum = (num - (num % Math.Pow(10, step-2))) / Math.Pow(10, step-2) % 10;
    Console.Write("Третья цифра: ");
    Console.Write(thirdNum);
}
else
{
    Console.WriteLine("Третьей цифры нет!");
}