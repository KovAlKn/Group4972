// №38 Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// (со звездочкой) Отсортируйте массив методом вставки и методом подсчета,
//  а затем найдите разницу между первым и последним элементом.
//  Для задачи со звездочкой использовать заполнение массива целыми числами



// Не доделана!!!!!!!!!!!!!!!!!!!!


//====================Методы==========================
double[] GenArray(int num, double lowBorder, double highBorder)
{
    double[] array = new double[num];
    
    for(int i = 0; i<num; i++)
    {
         array[i] = Math.Round(new Random().NextDouble()*(highBorder-lowBorder)+lowBorder,3);
    }
    return array;
}

int[] GenArrayInt(int num, int lowBorder, int highBorder)
{
    int[] array = new int[num];
    
    for(int i = 0; i<num; i++)
    {
         array[i] = new Random().Next(lowBorder, highBorder+1);
    }
    return array;
}

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}
// Напечатать массив
void PrintArray(double[] arr)
{
    Console.Write("[");
    for(int i=0; i<arr.Length-1;i++)
    {
        Console.Write(arr[i]+", ");
    }
    Console.WriteLine(arr[arr.Length-1]+"]");
}
void PrintArrayInt(int[] arr)
{
    Console.Write("[");
    for(int i=0; i<arr.Length-1;i++)
    {
        Console.Write(arr[i]+", ");
    }
    Console.WriteLine(arr[arr.Length-1]+"]");
}

//Поиск минимального значения
double MinNum(double[] array)
{
    double min = array[0];
    for(int i=1;i<array.Length; i++)
    {
        if(array[i]<min) {min=array[i];}
    }
    return min;
}
//Поиск максимального значения
double MaxNum(double[] array)
{
    double max = array[0];
    for(int i=1;i<array.Length; i++)
    {
        if(array[i]>max) {max=array[i];}
    }
    return max;
}

//Сортировка подсчетом
int[] CountSort(int[] array, int lowLimit, int upLimit)
{   
    int[] countArray = new int[upLimit-lowLimit+1];
    foreach (int num in countArray) { countArray[num]=0;}
    for(int i=0; i<array.Length; i++)
    {
        countArray[array[i]-lowLimit]+=1;
    }
   int index = 0;
   for(int i=0; i<countArray.Length; i++)
   {
    for(int j=0;j<countArray[i]; j++)
    {
        array[index]=i+lowLimit;
        index++;
    }
   }
   return array;
}

//===================Программа================
// int arrayLen = ReadData("Укажите длинну массива");
// double lowBorder =ReadData("Укажите нижнюю границу массива");
// double highBorder =ReadData("Укажите верхнюю границу массива");
// double[] array = GenArray(arrayLen, lowBorder, highBorder);
// PrintArray(array);
// double dif = MaxNum(array)-MinNum(array);
// Console.WriteLine($"Разница между максимальным и минимальным значения: {dif}");

Console.WriteLine("Task 38*");
int arrayLen = ReadData("Укажите длинну массива");
int lowBorderInt =ReadData("Укажите нижнюю границу массива");
int highBorderInt =ReadData("Укажите верхнюю границу массива");
int[] arrayInt = GenArrayInt(arrayLen, lowBorderInt, highBorderInt);
PrintArrayInt(arrayInt);
int[] sortedArray = CountSort(arrayInt, lowBorderInt, highBorderInt);
Console.WriteLine("Сортировка подсчетом");
PrintArrayInt(sortedArray);
