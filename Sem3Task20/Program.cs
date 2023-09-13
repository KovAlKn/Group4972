// Задача №20
// Напишите программу, которая принимает на вход координаты двух точек
//  и находит расстояние между ними в 2D пространстве.

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

double Calc2DDist(int x1, int y1, int x2, int y2)
{
    double res = Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2));
    return res;
}

int x1 = ReadData("Введите координату Х 1-ой точки ");
int y1 = ReadData("Введите координату Y 1-ой точки ");
int x2 = ReadData("Введите координату Х 2-ой точки ");
int y2 = ReadData("Введите координату Y 2-ой точки ");

double res = Calc2DDist(x1, y1, x2, y2);
PrintResult("расстояние между точками "+res);
