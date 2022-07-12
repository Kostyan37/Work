// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10




Console.Clear();

Console.WriteLine("Введите число: ");

int a = int.Parse(Console.ReadLine());

int TenToTwo(int n)                      //рекурсия из десятичной в двоичную
{
    if (n == 1) return 1;               // возвращаем единицу
    if (n == 0) return 0;               // возвращаем ноль
    return n %2 + 10*TenToTwo (n/2);      // разворот как реализация из десятичной в двоичную
}

Console.WriteLine(TenToTwo(a));
