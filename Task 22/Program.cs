// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Write("Введите натуральное число:");
int nmbr = Convert.ToInt32(Console.ReadLine());
TableSquare(nmbr);

void TableSquare(int nmbr)
{
    if (nmbr > 0)
    {
        Console.Write($"{nmbr} -> ");
        for (int i = 1; i <= nmbr; i++)
        {
            Console.Write($"{i * i} ");
        }
    }
    else Console.Write("Введено некорректное число!");


}