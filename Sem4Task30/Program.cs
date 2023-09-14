// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}


int[] GenArr(int len)
{
    int[] arr = new int[len];
    Random rnd = new Random();
    for(int i = 0; i<len; i++)
    {
        arr[i] = rnd.Next(0, 2);
    }
    return arr;
}

void PrintArr(int[] arr)
{
    Console.Write("[");
    for(int i=0; i<arr.Length-1;i++)
    {
        Console.Write(arr[i]+",");
    }
    Console.Write(arr[arr.Length-1]+"]");
}
int len = ReadData("Введите длину массива");
int[] array = GenArr(len);
PrintArr(array);
