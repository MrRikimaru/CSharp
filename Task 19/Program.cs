// Задача 19ю.Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число:");
int nmbr = Convert.ToInt32(Console.ReadLine());
int buffer = nmbr, counter = 1;
while (buffer > 10) 
{
    buffer /= 10; counter++;
}
if (counter < 5) Console.Write("Некорректный ввод!");
else Console.Write(Palindrome(nmbr, counter) == true ? $"{nmbr} -> да." : $"{nmbr} -> нет.");


bool Palindrome(int nmbr, int counter)
{
    int buffer = nmbr, dec = Convert.ToInt32(Math.Pow(10, counter-1)), mirorNmbr = 0;
    for (int i = 0; i < counter; i++)
    {
        mirorNmbr += buffer % 10 * dec;
        buffer /= 10; dec /= 10;
    }
    if (nmbr == mirorNmbr) return true;
    else return false;
}