//Задача 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
//456 -> 46
//782 -> 72
//918 -> 98

int randNumber = new Random().Next(100, 1000);
int result = (randNumber / 100) * 10 + (randNumber % 10);
Console.Write($"{randNumber} -> {result}.");