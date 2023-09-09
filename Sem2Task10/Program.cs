// №10 Напишите программу, которая принимает на вход трёхзначное число
//  и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число");
string line = Console.ReadLine()??"0";
if (line.Length == 3)
{
    char[] digits = line.ToCharArray();
    Console.WriteLine(digits[1]);
}
else
{
    Console.WriteLine("Введено не трехзначное число");
}