// Задача №7
// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает последнюю цифру этого числа.

Console.WriteLine("Веедите трехзначное число");
int num = int.Parse(Console.ReadLine()??"0");
if (num > 100 && num < 1000)
{
    int lastNum = num % 10;
    Console.WriteLine("последеняя цифра числа " +num +" - это " +lastNum);
}
else
{
    Console.WriteLine("Число не трехзначное");
}