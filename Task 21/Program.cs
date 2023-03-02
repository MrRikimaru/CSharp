// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки А");
Console.Write("X: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int zA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B");
Console.Write("X: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yB = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int zB = Convert.ToInt32(Console.ReadLine());
Console.Write($"A({xA},{yA}); B({xB}, {yB}) -> {Math.Round(Distance(xA, yA, zA, xB, yB, zB), 2, MidpointRounding.ToZero)}");

double Distance(int xA, int yA, int zA, int xB, int yB, int zB)
{
    return Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2) + Math.Pow(zB - zA, 2));
}