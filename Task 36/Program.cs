// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Введие размер массива:");
int arraySize = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArrayRndDouble(arraySize, -10, 20);
PrintArrayInt(array);
Console.Write($"Сумма элементов нечетых позиций: {SummArrayElem(array)}.");

int[] CreateArrayRndDouble(int size, int min, int max)
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

int SummArrayElem(int[] arrayValue)
{
    int summ = 0;
    for (int i = 0; i < arrayValue.Length; i++)
    {
        if (i % 2 != 0) summ += arrayValue[i];
    }
    return summ;
}