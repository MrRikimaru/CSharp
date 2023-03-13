// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

Console.Write("Введите размер массива:");
int arraySize = Convert.ToInt32(Console.ReadLine());
int[] array = new int[arraySize];
FillArray(array);
PrintArrayInt(array);
ReverseArray(array);
PrintArrayInt(array);

void FillArray(int[] arrayValue)
{
    Random rnd = new Random();
    for (int i = 0; i < arrayValue.Length; i++)
    {
        arrayValue[i] = rnd.Next(1, 10);
    }
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

int[] ReverseArray(int[] arr)
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
        int buffer = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = buffer;
    }
    return arr;
}