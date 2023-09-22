// №36 Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// (со звездочкой) Найдите все пары в массиве и выведите пользователю


//============Методы===================================
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
int SumOnOddPos(int[] array)
{
    int sum = 0;
    for(int i=1; i<array.Length; i=i+2)
    {
        sum=sum+array[i];
    }
    return sum;
}

int[] BubbleSort(int[] array)
{
    for(int i=0; i<array.Length; i++)
    {
        for(int j=0; j<array.Length-i-1; j++)
        {
            if(array[j]>array[j+1])
             {
                int temp = array[j];
                array[j] = array[j+1];
                array[j+1] = temp;
                
            }
        }
    }
    return array;
}

void PrintPairsInArray(int[] array)
{
    for(int i=0; i<array.Length-1; i++)
    {      
        if(array[i]==array[i+1])
        {
            Console.WriteLine($"({array[i]}:{array[i+1]})");
            i++;
        }
    }
}
//===========Программа============
int arrayLen = ReadData("Укажите кол-во элементов массива");
int arrayDown = ReadData("Укажите нижнюю границу массива");
int arrayUp = ReadData("Укажите верхнюю границу массива");
int[] array = GenArray(arrayLen, arrayDown, arrayUp);
PrintArray(array);
int sum = SumOnOddPos(array);
PrintResult($"Сумма нечетных элементов массива: {sum}");
PrintPairsInArray(BubbleSort(array));