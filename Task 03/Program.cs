//Задача 03. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//3 -> Среда
//5 -> Пятница

Console.Write("Введите число:");
string nmbr = Console.ReadLine();
switch(nmbr)
{
    case "1":
    {
        Console.Write("Понедельник");
        break;
    }
    case "2":
    {
        Console.Write("Вторник");
        break;
    }
    case "3":
    {
        Console.Write("Среда");
        break;
    }
    case "4":
    {
        Console.Write("Четверг");
        break;
    }
    case "5":
    {
        Console.Write("Пятница");
        break;
    }
    case "6":
    {
        Console.Write("Суббота");
        break;
    }
    case "7":
    {
        Console.Write("Воскресенье");
        break;
    }
    default:
    {
        Console.Write("Ошибка ввода.");
        break;
    }
}