// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.

int[] array = CreateArrayRndInt(12, -9, 9);
FillArray(array);
PrintArray(array);
Console.WriteLine($"Сумма положительных чисел равна: {GetSumPositiveElem(array)}.");
Console.WriteLine($"Сумма отрицательных чисел равна: {GetSumNegativeElem(array)}.");

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void FillArray(int[] array_value)
{
    Random rndm = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rndm.Next(-9, 10);
    }
}

void PrintArray(int[] array_value)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}\n");
    }
}

int GetSumNegativeElem(int[] array_value)
{
    int negativeSum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) negativeSum += array[i];
    }
    return negativeSum;
}

int GetSumPositiveElem(int[] array_value)
{
    int positiveSum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) positiveSum += array[i];
    }
    return positiveSum;
}