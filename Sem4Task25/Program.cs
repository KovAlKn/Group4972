// №25 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// Вводим данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

// Печатаем результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}
// Метод если выбрана операция:+,-, *,^. Деление вынесено отдельно.
long Calculator(int firstNum, int secondNum, string mathOperation)
{
    long result = 0;
    if(mathOperation == "+")    {result = mySum(firstNum, secondNum);}

    else if (mathOperation == "-")    {result = myMinus(firstNum, secondNum);}
    else if(mathOperation == "*")   {result = myMultiplication(firstNum, secondNum);}
    else if(mathOperation == "^")    {    result = MyPow(firstNum, secondNum);    }
    return result;
}

long MyPow(int numA, int numB)
{
    long res = 1;
    while(numB > 0)
    {
        res = res * numA;
        numB = numB - 1;
    }
    return res;
}

int mySum(int numA, int numB)
{
    int res = numA + numB;
    return res;
}

int myMinus(int numA, int numB)
{
    int res = numA-numB;
    return res;
}

long myMultiplication(int numA, int numB)
{
   long res = numA * numB;
    return res;
}
float myDivision(float numA, float numB)
{
    float res = numA / numB;
    return res;
}

// Получение первого числа
int firstNum =ReadData("Введите число первое число ");

// Выбор математической операции
Console.WriteLine("Выберете операцию: +|-|*|/|^|");
string mathOperation = Console.ReadLine()??"0";

// получение второго числа
int secondNum =ReadData("Введите второе число");

// Вычисление
if (mathOperation== "/")
{
    float result = myDivision(Convert.ToSingle(firstNum),Convert.ToSingle(secondNum));
    PrintResult(firstNum + mathOperation + secondNum +" = "+result);
}
else
{
long result = Calculator(firstNum, secondNum, mathOperation);
PrintResult(firstNum + mathOperation + secondNum +" = "+result);
}



