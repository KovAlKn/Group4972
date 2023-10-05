// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

//============Методы=================
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}

int Ackerman(int m, int n)
{
    if (m==0)
    {
        return n+1;
    }
    else
    {
        if(m!=0 && n==0)
        {return Ackerman(m-1, 1);}
        
        else
        {return Ackerman(m-1,Ackerman(m,n-1));}
    }
}
//==========Программа===========
int m = ReadData("Укажите число m");
int n = ReadData("Укажите число n");
Console.WriteLine($"Функция Аккермана А({m},{n})= {Ackerman(m,n)}");