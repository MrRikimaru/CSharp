//Задача 18: Напишите программу, которая по
//заданному номеру четверти, показывает диапазон
//возможных координат точек в этой четверти (x и y).

Console.Write("Введите номер четверти:");
int quarter = Convert.ToInt32(Console.ReadLine());
Console.Write(Quarter(quarter));

string Quarter(int quarter_value)
{
    if (quarter_value == 1) return "X > 0, Y > 0";
    if (quarter_value == 2) return "X < 0, Y > 0";
    if (quarter_value == 3) return "X < 0, Y < 0";
    if (quarter_value == 4) return "X > 0, Y < 0";
    return "Некорректный ввод четверти!";
}