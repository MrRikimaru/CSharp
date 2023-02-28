//Задача 16. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
//5, 25 -> да
//-4, 16 -> да
//25, 5 -> да
//8,9 -> нет

Console.Write("Введите первое число:");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber < secondNumber)
{
    if (firstNumber*firstNumber == secondNumber) Console.Write($"{firstNumber}, {secondNumber} -> да");
    else Console.Write($"{firstNumber}, {secondNumber} -> нет");
}
else if (firstNumber > secondNumber)
{
    if (secondNumber*secondNumber == firstNumber) Console.Write($"{firstNumber}, {secondNumber} -> да");
    else Console.Write($"{firstNumber}, {secondNumber} -> нет.");
}