//задача 01. Напишите программу, которая на вход принимает два 
//числа и проверяет, являеться ли первое число квадратом второго.
//a = 25, b = 5 -> Да
//a = 2, b = 10 -> Нет
//a = 9, b -3 -> Да
//a = -3, b = 9 -> Нет

Console.Write("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());
if (b*b == a)
{
    Console.WriteLine($"Число {a} являеться квадратом числа {b}.");
}
else
{
    Console.WriteLine($"Число {a} не являеться квадратом числа {b}.");
}