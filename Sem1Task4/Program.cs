//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число");
int firstNum = int.Parse(Console.ReadLine()??"0");

Console.WriteLine("Введите второе число");
int secondNum = int.Parse(Console.ReadLine()??"0");

Console.WriteLine("Введите третье число");
int thirdNum = int.Parse(Console.ReadLine()??"0");

int max = firstNum;

if (secondNum > max)
{
    max=secondNum;
}

if (thirdNum > max)
{
    max = thirdNum;

}
Console.WriteLine( "Максимальным является число "+max);