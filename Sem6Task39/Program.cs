// Задача 39: Напишите программу, которая перевернёт одномерный
// массив (последний элемент будет на первом месте, а первый - на
// последнем и т.д.)

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
    Console.Write("[");
    for(int i=0; i<arr.Length-1;i++)
    {
        Console.Write(arr[i]+", ");
    }
    Console.WriteLine(arr[arr.Length-1]+"]");
}


int[]SawpNewArray(int[] arr)
{
    int [] outArr= new int[arr.Length];
    for(int i=0; i<arr.Length; i++)
    {
        outArr[arr.Length-1-i]=arr[i];
    }
    return outArr;
}
void SwapArray(int[] arr)
{
    for(int i=0;i<arr.Length/2;i++)
    {
        (arr[arr.Length-1-i],arr[i])=(arr[i],arr[arr.Length-1-i]);
       
    }
}

int[] arr = GenArray(15, 1, 100);
PrintArray(arr);
int[] swapArr = SawpNewArray(arr);
Console.WriteLine("Исходный массив");
PrintArray(arr);
Console.WriteLine("Перевернутый массив");
PrintArray(swapArr);

SwapArray(arr);
PrintArray(swapArr);