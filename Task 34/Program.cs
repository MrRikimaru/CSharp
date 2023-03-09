// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Write("Введите размер массива:");
int arraySize = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArrayRndInt(arraySize, 100, 1000);
PrintArrayInt(array);
Console.Write($"Количесво четных чисел: {QuantityNumbers(array)}.");

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max);
    }
    return arr;
}

void PrintArrayInt(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int QuantityNumbers(int[] arrayValue)
{
    int counter = 0;
    for (int i = 0; i < arrayValue.Length; i++)
    {   
        if (arrayValue[i] % 2 == 0)  counter++;
    }
    return counter;
}