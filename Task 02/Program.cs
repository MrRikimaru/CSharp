//Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Write("Введие первое число:");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введие второе число:");
int numberTwo = Convert.ToInt32(Console.ReadLine());
if (numberOne > numberTwo)
{
    Console.Write($"Число {numberOne} больше числа {numberTwo}.");
}
else
    Console.Write($"Число {numberTwo} больше числа {numberOne}.");