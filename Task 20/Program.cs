// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты точки А");
Console.Write("X: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B");
Console.Write("X: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yB = Convert.ToInt32(Console.ReadLine());
Console.Write($"A({xA},{yA}); B({xB}, {yB}) -> {Math.Round(Distance(xA, yA, xB, yB), 2, MidpointRounding.ToZero)}");

double Distance(int xA, int yA, int xB, int yB)
{
    double dist = Math.Sqrt(Math.Pow(xB - xA, 2)+Math.Pow(yB - yA,2));
    return dist;
}