// №34 Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// (со звездочкой) Отсортировать массив методом пузырька

// =======================Методы================================
// Создание массива случайных чисел
int[] GenArray(int num, int lowBorder, int highBorder)
{
    int[] array = new int[num];
    
    for(int i = 0; i<num; i++)
    {
         array[i] = new Random().Next(lowBorder, highBorder+1);
    }
    return array;
}
//Посчет кол-ва четных чисел
int CountEvenNum(int[] array)
{
    int count = 0;
    for(int i=0; i<array.Length; i++)
    {
        if (array[i]%2==0) {count+=1;}
    }
    return count;
}   

//Печать результата
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}
// Получение данных (числа) из консоли
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}
// Напечатать массив
void PrintArray(int[] arr)
{
    Console.Write("[");
    for(int i=0; i<arr.Length-1;i++)
    {
        Console.Write(arr[i]+", ");
    }
    Console.WriteLine(arr[arr.Length-1]+"]");
}
// Перестановка двух чисел
void Swap(ref int num1,ref int num2)
{
    int temp = num1;
    num1 = num2;
    num2 = temp;
}
// Сортировка пузырьком по возрастанию
int[] BubbleSort(int[] array)
{
    for(int i=0; i<array.Length; i++)
    {
        for(int j=0; j<array.Length-i-1; j++)
        {
            if(array[j]>array[j+1]) {Swap(ref array[j], ref array[j+1]);}
        }
    }
    return array;
}

//============Вычисление============================
int arrayLen = ReadData("Укажите кол-во элементов массива");
int[] array = GenArray(arrayLen, 100, 999);
int countEven = CountEvenNum(array);
PrintArray(array);
int[] sortedArray = BubbleSort(array);
PrintArray(sortedArray);
PrintResult($"кол-во четных элементов массива: {countEven}");