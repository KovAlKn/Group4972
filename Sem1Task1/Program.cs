// Задача №1
// Напишите программу, которая на вход принимает два числа и проверяет,
//  является ли первое число квадратом второго.

Console.WriteLine("Напишите первое число");
int num1 = int.Parse(Console.ReadLine()??"0");

Console.WriteLine("Напишите второе число");
int num2 = int.Parse(Console.ReadLine()??"0");

Console.WriteLine(num2==Math.Pow(num1,2)?"да":"нет");