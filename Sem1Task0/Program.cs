//Задача №0
//Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

Console.WriteLine ("Введите число: ");
//Считываем данные с консоли 
string? inputNum = Console.ReadLine();//??"0";
//Проверяем, чтобы данные были не пустыми
if(inputNum!=null)
{
    // Парсим введеное число
    // int num = int.Parse(inputNum);
    // Находим квадрат числа
    // int res = num * num;
    // Ввыводим данные в консоль
    // Console.WriteLine(res);
}

Console.WriteLine("Квадрат числа: "+Math.Pow(int.Parse(inputNum),2));