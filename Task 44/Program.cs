// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Write("Введите количество N: ");
int size = Convert.ToInt32(Console.ReadLine());
if (size > 2)
{
    int[] arr = new int[size];
    PrintArray(Fibonacci(arr)); 
}

void PrintArray(int[] array_value)
{
    for (int i = 0; i < array_value.Length; i++)
    {
        if (i != array_value.Length - 1) Console.Write($"{array_value[i]}, ");
        else Console.Write($"{array_value[i]}\n");
    }
}

int[] Fibonacci(int[] array)
{
    array[1] = 1;
    for (int i = 2; i < size; i++)
    {
        arr[i] = arr[i - 1] + arr[i - 2];
    }
    return arr;
}
