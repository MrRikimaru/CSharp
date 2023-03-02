//Задача 17. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введите координаты точки.");
Console.Write("Введите X:");
int xCoordinates = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y:");
int yCoordinates = Convert.ToInt32(Console.ReadLine());
int quarter = Quarter(xCoordinates,yCoordinates);
string result = quarter > 0 
                        ? $"Указанные координаты соответсвуют четверти - {quarter}" 
                        : "Введены некорректрные координаты";
Console.Write(result);

int Quarter(int value_x, int value_y)
{
    if ((value_x > 0) && (value_y > 0)) return 1;
    if ((value_x < 0) && (value_y > 0)) return 2;
    if ((value_x < 0) && (value_y < 0)) return 3;
    if ((value_x > 0) && (value_y < 0)) return 4;
    return 0;
}