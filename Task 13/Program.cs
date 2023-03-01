//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Write("Введите число:");
int number = Convert.ToInt32(Console.ReadLine()), result = number;
if (number < 100) Console.Write($"{number} -> третьей цифры нет");
else if (number >= 100) 
{
    while (result > 1000) result /= 10; 
    Console.Write($"{number} -> {result %= 10}");
}