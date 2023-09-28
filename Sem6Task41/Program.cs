// №41 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// (Задание со звездочкой) Пользователь вводит число нажатий, затем программа следит за нажатиями и
//  выдает сколько чисел больше 0 было введено.

using System.Text.RegularExpressions;

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}
int CountPositiveNum(int m)
{
    int count =0;
    int num = 0;
    for(int i=0;i<m; i++)
    {
        num = ReadData("Введи число: ");
        if(num>0) {count++;}
    }
    return count;
}

// Получение нажатий с клавиатуры.
string KeyPresses(string msg, int numOfKeyPresses)
{
     Console.Write(msg);
    string data = string.Empty;
    
    for (int i = 0; i < numOfKeyPresses; i++)
    {
        var keyInfo = Console.ReadKey();
        data += keyInfo.KeyChar;
    }


    return data;
}

int CountPositivChar(string input)
{
        string pattern = @"[-]?[0-9]+";
    MatchCollection matches = Regex.Matches(input, pattern);
    int count = 0;   
    foreach(Match match in matches)
    {
        
        if(int.Parse(match.Value)>0)
        {
            count++;
        }
    }
      return count;     
}

int m = ReadData("Укажите какое количество чисел М:");
Console.WriteLine($"Количество положительных чисел: {CountPositiveNum(m)}");

int numOfChar = ReadData("Укажите количество нажатий");
string line = KeyPresses("Введите строку: ", numOfChar);
Console.WriteLine($"Кол-во положительных чисел: {CountPositivChar(line)}");
