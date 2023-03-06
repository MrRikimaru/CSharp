// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Write("Введите натуральное число:");
int nmbr = Convert.ToInt32(Console.ReadLine());
Console.Write($"Сумма чисел от 1 до {nmbr} = {SumNumbers(nmbr)}.");

int SumNumbers(int nmbr_value)
{
    int sum = 0;
    for (int i = 1; i <= nmbr_value; i++)
    {
        sum += i;
    }
    return sum;
}

