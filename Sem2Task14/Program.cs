// Задача №14
// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

Console.WriteLine("Введите число ");
int nam = int.Parse(Console.ReadLine());

if(nam%7==0)
{
    if(nam%23==0)
    {
        Console.WriteLine("Число кратно 7-и и 23-трем");
    }
}
else
{
    Console.WriteLine("Не кратно");
}