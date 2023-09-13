Задача №22
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}

void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

string BuildLine (int num, int pow)
{
    string res = "";
    for(int i=1; i<=num; i++)
    {
    
        res = res + Math.Pow(i, pow)+" ";
    }
    
    return res;
}
int num = ReadData("Введите число");
string res = BuildLine(num, 2);
PrintResult("Таблица квадратов "+res);

// ====================================================
// Анастасия
// Вывод сообщения и вызов метода OutputSquares
// void Prompt(string message)
// {
//     Console.WriteLine(message);
//     string values = Console.ReadLine()??",";
//     int number = Convert.ToInt32(values);

//     OutputSquares(number);
// }

// // Расчёт квадратов и составление таблицы
// void OutputSquares(int number)
// {
//     Console.Clear();

//     int currentNumber = 0;
//     int currentNumberSquare;
//     int cursor = 0;

//     while (currentNumber <= number)
//     {
//         currentNumberSquare = (int)Math.Pow(currentNumber, 2);

//         Console.SetCursorPosition(cursor, 0);
//         Console.Write(currentNumber);

//         Console.SetCursorPosition(cursor, 1);
//         Console.Write(currentNumberSquare);

//         cursor = Console.CursorLeft + 3;

//         currentNumber++;
//     }
// }

// Prompt("Введите число: ");