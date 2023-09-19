// Решение в группах задач:
// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

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
        Console.Write(arr[i]+",");
    }
    Console.Write(arr[arr.Length-1]+"]");
}

void InversArr(int[] arr)
{
    for(int i=0; i < arr.Length; i++)
    {
         arr[i]*=-1;
    }
}
int[] array= GenArray(12, -9, 9);
PrintArray(array);
InversArr(array);
PrintArray(array);