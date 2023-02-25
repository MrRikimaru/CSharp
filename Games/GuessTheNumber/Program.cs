int score = 1000, fivePrecent = 0;
Console.Write("Введите начало интервала случайных чисел:");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конец интервала случайных чисел:");
int max = Convert.ToInt32(Console.ReadLine());
int randNmbr = new Random().Next(min, max + 1);
Console.WriteLine($"{randNmbr}.");
while (true)
{
    fivePrecent = score / 100 * 5;
    Console.Write("Введите число:");
    int nmbr = Convert.ToInt32(Console.ReadLine());
    if (nmbr > randNmbr)
    {
        Console.WriteLine("Ваше число больше загаданного.");
        score = score - fivePrecent;
    } 
    else if (nmbr < randNmbr)
    {
        Console.WriteLine("Ваше число меньше загаданного.");
        score = score - fivePrecent;
    } 
    else 
    {
        Console.WriteLine("Поздравляю. Вы победили!");
        Console.Write($"Ваш счет: {score}.");
        break;
    }
}
