// №29 Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// (задание со *) Ввести с клавиатуры длину массива и диапазон значений элементов

// (задание со *) Дополнительно: Написать программу которая из имен через запятую выберет случайное имя и выведет в терминал
// Игорь, Антон, Сергей -> Антон
// Подсказка: Для разбора строки использовать метод string.split(). Для выбора случайного имени метод Random.Next(1,<длина массива имен>+1).

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

int[] GenArr(int len, int lowLimit, int upLimit)
{
    int[] arr = new int[len];
    Random rnd = new Random();
    for(int i = 0; i<len; i++)
    {
        arr[i] = rnd.Next(lowLimit, upLimit+1);
    }
    return arr;
}

void PrintArr(int[] arr)
{
    Console.Write("[");
    for(int i=0; i<arr.Length-1;i++)
    {
        Console.Write(arr[i]+"; ");
    }
    Console.Write(arr[arr.Length-1]+"]");
}

int len = ReadData("Введите длину массива");
int lowLimit = ReadData("Укажите нижную границу массива");
int upLimit = ReadData("Укажите верхную границу массива");
int[] array = GenArr(len, lowLimit, upLimit);
PrintArr(array);

// ==================================================================
// Выбор случайного имени
// получаем список имен с консоли в строку
string ReadDataString(string msg)
{
    Console.WriteLine(msg);
    Console.InputEncoding = System.Text.Encoding.GetEncoding("utf-16")//без указания кодировки работает только с английским
    string line = Console.ReadLine()??"0";
    return line;
}
// разбиваем строку на отдельные части, делаем массив
string RandomName(string line)
{
    string[] names = line.Split(',',' ');
    string randomName = names[new Random().Next(0,names.Length)];
    return randomName;
}
//Печатаем результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}
string line = ReadDataString("Введите список имен");
string name = RandomName(line);
Console.WriteLine("Случайное имя: ");
PrintResult(name);