//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число ");
int firstNum = int.Parse(Console.ReadLine()??"0");

Console.WriteLine("Введите второе число ");
int secondNum = int.Parse(Console.ReadLine()??"0");

if(firstNum == secondNum)
{
    Console.WriteLine("Числа равны");
}
else
{
Console.Write("Большее ");
Console.WriteLine(firstNum>secondNum?"первое число "+firstNum:"второе число "+secondNum);
Console.Write("Меньшее ");
Console.Write(firstNum<secondNum?"первое число "+firstNum:"второе число "+secondNum);
}
