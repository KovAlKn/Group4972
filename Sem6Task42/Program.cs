// Задача №42
// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}

string DecToBin(int num)
{
    string line ="";
    while(num>0)
    {
        line = num%2+line;
        num=num/2;
    } 
    return line;
}
int num = ReadData("Введите число");
Console.WriteLine(DecToBin(num));
String bin = Convert.ToString(num, 2);
Console.WriteLine(bin);
