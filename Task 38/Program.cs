// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.Write("Введие размер массива:");
int arraySize = Convert.ToInt32(Console.ReadLine());
double[] array = CreateArrayRndDouble(arraySize, 1, 100);
PrintArrayDouble(array);
Console.Write($"Разница между максимальным и минимальным элементом: {MaxArrayElem(array) - MinArrayElem(array)}.");

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, 1);
    }
    return arr;
}

void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

double MinArrayElem(double[] arrayValue)
{
    double min = arrayValue[0];
    for (int i = 0;i < arrayValue.Length;i++)
    {
        if (min > arrayValue[i]) min = arrayValue[i];
    }
    return min;
}

double MaxArrayElem(double[] arrayValue)
{
    double max = arrayValue[0];
    for (int i = 0;i < arrayValue.Length;i++)
    {
        if (max < arrayValue[i]) max = arrayValue[i];
    }
    return max;
}