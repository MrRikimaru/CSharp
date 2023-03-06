// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120
Console.Write("Введите натуральное число:");
int nmbr = Convert.ToInt32(Console.ReadLine());
if (nmbr < 0) nmbr *= -1;
if (nmbr > 12) Console.Write($"Факториал числа {nmbr} вычислить нет возможности.");
else
{
    Console.WriteLine($"Произведение чисел от 1 до {nmbr} = {Factorial(nmbr)}.");
    Console.Write($"Произведение чисел от 1 до {nmbr} = {FactorialRecursion(nmbr)}.");
}


int Factorial(int number_value)
{
    int multi = 1;
    for (int i = 1; i <= number_value; i++)
    {
        checked
        {
            multi *= i;
        }
    }
    return multi;
}

int FactorialRecursion(int number_value)
{
    if (number_value == 0) return 1;
    return number_value * FactorialRecursion(number_value - 1);
}