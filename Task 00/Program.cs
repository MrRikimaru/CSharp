//Задача 00. Ввод числа с клавиатуры и вывод его значения в квадрате.

Console.Write("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int square = number*number;
Console.Write($"Квадрат числа {number} = {square}");