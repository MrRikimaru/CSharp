// Задача 19ю.Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число:");
int nmbr = Convert.ToInt32(Console.ReadLine());
if (nmbr < 0) nmbr = -nmbr;
if (nmbr < 10000) Console.Write("Некорректный ввод!");
else Console.Write(Palindrome(nmbr) ? $"{nmbr} -> да." : $"{nmbr} -> нет.");

bool Palindrome(int nmbr_value)
{
    int buffer = nmbr_value, mirorNmbr = 0;
    while (buffer > 0)
    {
        mirorNmbr = mirorNmbr * 10 + buffer % 10; 
        buffer /= 10;
    }
    if (nmbr == mirorNmbr) return true;
    else return false;
}