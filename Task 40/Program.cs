// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.Write("Введите первое число:");
int aSide = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int bSide = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число:");
int cSide = Convert.ToInt32(Console.ReadLine());
Console.Write(CheckTriangle(aSide, bSide, cSide) ? "Да" : "Нет");

bool CheckTriangle(int aSideValue, int bSideValue, int cSideValue)
{
    if ((aSideValue < bSideValue + cSideValue) && (bSideValue < aSideValue + cSideValue) && (cSideValue < aSideValue + bSideValue)) return true;
    else return false;
}