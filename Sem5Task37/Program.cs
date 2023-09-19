// Задача №37
// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент,
// второй и предпоследний и т.д. Результат запишите в новом массиве.

int[] GenArray(int num, int lowBorder, int highBorder)
{
    int[] array = new int[num];
    
    for(int i = 0; i<num; i++)
    {
         array[i] = new Random().Next(lowBorder, highBorder+1);
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.Write("[");c
    for(int i=0; i<arr.Length-1;i++)
    {
        Console.Write(arr[i]+", ");
    }
    Console.Write(arr[arr.Length-1]+"]");
}

int[] ConvertArr(int[] arr)
{
    int[] outArr = new int[arr.Length/2];
    for(int i =0; i<arr.Length/2; i++)
    {
        outArr[i]=arr[i]*arr[arr.Length-1-i];
    }
    return outArr;
}
int[] array = GenArray(10, 0, 10);
PrintArray(array);
Console.WriteLine();
PrintArray(ConvertArr(array));