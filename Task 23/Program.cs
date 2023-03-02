// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите натуральное число:");
int nmbr = Convert.ToInt32(Console.ReadLine());
CubeTable(nmbr);

void CubeTable(int nmbr)
{
    if (nmbr > 0)
    {
        Console.Write($"{nmbr} -> ");
        for (int i = 1; i <= nmbr; i++)
        {
            Console.Write($"{i*i*i} ");
        }
    }
    else Console.Write("Введено некорректное число!");
}