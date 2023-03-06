// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int arraySize = 8;
int[] array = new int[arraySize];
FillArray(array);
PrintArray(array);

void FillArray(int[] array_value)
{
    Random rndm = new Random();
    for (int i = 0; i < array_value.Length; i++) array_value[i] = rndm.Next(0, 2);
}

void PrintArray(int[] array_value)
{
    for (int i = 0; i < array_value.Length; i++) Console.Write($"{array_value[i]} ");
}