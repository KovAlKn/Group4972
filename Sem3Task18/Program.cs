// Задача №18
// Напишите программу, которая по заданному номеру четверти,
//  показывает диапазон возможных координат точек в этой четверти (x и y).
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}

string QuterBorderAsk(int numQut)
{
    if(numQut == 1) return "х > 0; y > 0";
    if(numQut == 2) return "х < 0; y > 0";
    if(numQut == 3) return "х < 0; y < 0";
    if(numQut == 4) return "х > 0; y < 0";
    return "0";
}
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int quarterNum = ReadData("Введите номер четверти");
string res = QuterBorderAsk(quarterNum);
PrintResult("Возможные координаты "+ res);


// ======================================================================
// Анастасия
// Вывод сообщения и вызов метода CheckingCoordinates
// string Prompt(string message)
// {
//     Console.WriteLine(message);
//     string values = Console.ReadLine()??",";
//     int quarter = Convert.ToInt32(values);

//     return CheckingCoordinates(quarter);
// }

// // Проверка четверти
// string CheckingCoordinates(int quarter)
// {
//     switch(quarter)
//     {
//         case 1: return "(X > 0 ; Y > 0)";
//         case 2: return "(X < 0 ; Y > 0)";
//         case 3: return "(X < 0 ; Y < 0)";
//         case 4: return "(X > 0 ; Y < 0)";
//         default: return "0";
//     }
// }

// Console.WriteLine(Prompt("Введите номер четверти: "));
// ==========================================================================