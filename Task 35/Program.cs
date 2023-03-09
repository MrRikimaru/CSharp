// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] array = new int[5];
FillArray(array);
PrintArray(array);
Console.Write($"Количество элементов массива значения которых лежат в отрезке [10, 99]: {QuantityArrayElem(array)}.");

void FillArray(int[] arrayValue)
{
    Random rnd = new Random();
    for (int i = 0; i < arrayValue.Length; i++)
    {
        arrayValue[i] = rnd.Next(0,100);
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

int QuantityArrayElem(int[] arrayValue)
{
    int counter = 0;
    for (int i =0;i < arrayValue.Length;i++)
    {
        if ((arrayValue[i] >= 10)&&(arrayValue[i] <= 99))
            counter++;
    }
    return counter;
}

