//Задача 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
//78 -> 8
//12-> 2
//85 -> 8

int randNumber = new Random().Next(10, 100);
if (randNumber / 10 > randNumber % 10) Console.Write($"{randNumber} -> {randNumber / 10}");
else Console.Write($"{randNumber} -> {randNumber % 10}");