//Задача 65
// Задайте значение М и N. Напишите программу, которая найдет все натуральные элементы
// в промежутке от M до N.

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

string RecMN(int n, int m)
{
    string res = "";
    if (n<=m)
    {
        res=n.ToString();
    }
    else
    {res=m+","+RecMN(n,m+1);}
    return res;
}
int n = ReadData("Введите число N: ");
int m = ReadData("Введите число M: ");
string line =(n>m)?RecMN(n,m):RecMN(m,n);
PrintResult(line);