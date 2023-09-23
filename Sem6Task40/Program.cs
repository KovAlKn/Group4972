// Задача №40
// Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины

// Получение данных из консоли
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}

bool TriangleTest(int a, int b, int c)
{
    return !(a+b<c|| b+c<a ||a+c<b );
    
}
int a = ReadData("Первая сторона:");
int b = ReadData("Вторая сторона:");
int c = ReadData("Третья сторона:");
Console.WriteLine(TriangleTest(a,b,c)?"Треугольник существует":"Треугольник не существует");

