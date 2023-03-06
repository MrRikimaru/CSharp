// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] array = new int[8];
FillArray(array);
PrintArray(array);

void FillArray(int[] array_value)
{
    Random rnmd = new Random();
    for (int i = 0;i < array_value.Length;i++) 
    {
        array[i] = rnmd.Next(0,100);Console.Write($"{array[i]}");
        if (i != array_value.Length -1) Console.Write(", ");
    }
}

void PrintArray(int[] array_value)
{
    for (int i = 0; i < array_value.Length;i++) 
    {
        if (i == 0) Console.Write(" -> [");
        Console.Write($"{array[i]}");
        if (i != array_value.Length -1) Console.Write(", ");
        else Console.Write("]");
    }
}