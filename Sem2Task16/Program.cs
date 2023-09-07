// Задача №16
// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

Console.WriteLine("Введите первое число");
int firstNum = int.Parse(Console.ReadLine()??"0");

Console.WriteLine("Введите второе число");
int secondNum = int.Parse(Console.ReadLine()??"0");

bool test1 = (firstNum == secondNum*secondNum);
bool test2 = (secondNum == firstNum * firstNum);

if(test1)
{
    Console.WriteLine("1-ое квадрат 2-ого");
}
if(test2)
{
    Console.WriteLine("2-ое квадрат 1-ого");
}
if(!(test1||test2))
{
    Console.WriteLine("числа не квадрат друг друга");
}