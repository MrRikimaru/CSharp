// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
Console.Write("Введите число:");
int nmbr = Convert.ToInt32(Console.ReadLine());
Console.Write($"Количество цифр в числе {nmbr} = {NumberLenght(nmbr)}.");

int NumberLenght(int number_value)
{
    int buffer = number_value, counter = 0;
    while (buffer > 0)
    {
        buffer /= 10;counter++;
    }
    return counter;
}