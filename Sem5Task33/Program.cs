// Задача №33
// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

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
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}

void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int FindElm(int[] arr, int elm)
{
    for(int i=0; i<arr.Length; i++)
    {
        if(arr[i]==elm) {return i;}
    }
    return -1;
}

int[] array = GenArray(12, 0, 50);
PrintArray(array);
int elm = ReadData("Введите искомый элемент");
int posOfElm = FindElm(array, elm);
PrintResult("Номер элемента в массиве:"+posOfElm);


// Решение от Анастасии
// Вывод сообщения и запись введённых данных
// int Prompt(string message)
// {
//     Console.WriteLine(message);
//     string value = Console.ReadLine()??",";
//     int number = Convert.ToInt32(value);

//     return number;
// }
// // Проверяет, есть ли число
// string Check(int[] array, int num)
// {
//     for (int i = 0; i < array.Length; i++)
//         if (array[i] == num)
//             return $"Есть, индекс {i}";
//     return "Нет";
// }
// // Выводит элементы массива в консоль
// void OutputArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length - 1; i++)
//         Console.Write(array[i] + ", ");
//     Console.WriteLine(array[array.Length - 1] + "]");
// }

// int[] array = {1, -2, 5, 6, 58, 7, -3, -42, 63, 15};
// OutputArray(array);

// int num = Prompt("Введите число для поиска: ");

// Console.WriteLine(Check(array, num));