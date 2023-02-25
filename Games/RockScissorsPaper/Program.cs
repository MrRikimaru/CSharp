Console.WriteLine("0. Камень.");
Console.WriteLine("1. Ножницы.");
Console.WriteLine("2. Бумага");
int randNmbr = new Random().Next(0, 4);
Console.Write("Введите число:");
string nmbr = Console.ReadLine();
switch (nmbr)
{
    case "0":
        {
            if (randNmbr == 0) Console.Write("Вы: Камень.\nКомпьютер: Камень.\n Ничья!");
            else if (randNmbr == 1) Console.Write("Вы: Камень.\nКомпьютер: Ножницы.\nВы победили!");
            else Console.Write("Вы: Камень.\nКомпьютер: Бумага.\nВы проиграли!");
            break;
        }
    case "1":
        {
            if (randNmbr == 0) Console.Write("Вы: Ножницы.\nКомпьютер: Камень.\nВы проиграли!");
            else if (randNmbr == 1) Console.Write("Вы: Ножницы.\nКомпьютер: Ножницы.\nНичья!");
            else Console.Write("Вы: Ножницы.\nКомпьютер: Бумага.\nВы победили!");
            break;
        }
    case "2":
        {
            if (randNmbr == 1) Console.Write("Вы: Бумага.\nКомпьютер: Камень.\nВы победили!");
            else if (randNmbr == 2) Console.Write("Вы: Бумага.\nКомпьютер: Ножницы.\nВы проиграли!");
            else Console.Write("Вы: Бумага.\nКомпьютер: Бумага.\n Ничья!");
            break;
        }
    default:
        {
            Console.Write("Ошибка ввода!");
            break;
        }
}