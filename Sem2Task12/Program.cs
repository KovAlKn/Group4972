// Задача №12
// Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому. Если второе число некратно первому,
//  то программа выводит остаток от деления.


Console.WriteLine("Введите первое число ");
int firstNum = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Введите второе число ");
int secondNum = int.Parse(Console.ReadLine()??"0");
if (secondNum%firstNum ==0)
{
    Console.WriteLine("Второе число кратно первому");
}
else
{
    Console.WriteLine("Второе не кратно первому. Остаток от оделения "+secondNum%firstNum);
}