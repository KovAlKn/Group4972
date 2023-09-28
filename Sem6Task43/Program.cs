// №43 Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1,
// y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// (Задание со звездочкой) Найдите площадь треугольника образованного пересечением 3 прямых

//=================Методы======================
double ReadData(string msg)
{
    Console.Write(msg);
    double num = double.Parse(Console.ReadLine() ?? "0");
    return num;
}

//Определение точки пересечения прямых
double[] IntersectionPoint(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    double[] point = new double[2];
    point[0] = x;
    point[1] = y;
    return point;
}

void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

//Определение длины отрезка
double LengthOfStrait(double[] a, double[] b)
{
    double lineLen = Math.Sqrt(Math.Pow((a[0] - b[0]), 2) + Math.Pow((a[1] - b[1]), 2));
    return lineLen;
}

//Площадь треугольника по формуле Герона
double TriangleSquare(double a, double b, double c)
{
    double p = (a + b + c) / 2; //Полупериметр
    double square = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    return square;
}

//==============Тело программы==============
Console.WriteLine($"Укажие коефициенты 'k' и 'b' для уравнения 1 прямой");
double k1 = ReadData("k=");
double b1 = ReadData("b=");

Console.WriteLine($"Укажие коефициенты 'k' и 'b' для уравнения 2 прямой");
double k2 = ReadData("k=");
double b2 = ReadData("b=");

Console.WriteLine($"Укажие коефициенты 'k' и 'b' для уравнения 3 прямой");
double k3 = ReadData("k=");
double b3 = ReadData("b=");

Console.WriteLine($"Cистема уравнений:");
Console.WriteLine($"y={k1}*x + {b1}");
Console.WriteLine($"y={k2}*x + {b2}");
Console.WriteLine($"y={k3}*x + {b3}");

double[] pointA = IntersectionPoint(k1, b1, k2, b2);
double[] pointB = IntersectionPoint(k1, b1, k3, b3);
double[] pointC = IntersectionPoint(k3, b3, k2, b2);

PrintResult($"Координаты точки А: ({pointA[0]}; {pointA[1]})");
PrintResult($"Координаты точки B: ({pointB[0]}; {pointB[1]})");
PrintResult($"Координаты точки C: ({pointC[0]}; {pointC[1]})");

double ab = LengthOfStrait(pointA, pointB);
double bc = LengthOfStrait(pointB, pointC);
double ac = LengthOfStrait(pointC, pointA);

double square = TriangleSquare(ab, bc, ac);
PrintResult($"Площадь треугольника = {square}");
