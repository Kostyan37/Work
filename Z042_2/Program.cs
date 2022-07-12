// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10



Console.Write("Введите целое число: ");
int number = int.Parse(Console.ReadLine());

Console.Write("Введите основание системы счисления: ");
int baseNum = int.Parse(Console.ReadLine());

int d10 = 1;
int result = 0;
while (number != 0)
{
    result = result + number % baseNum * d10;
    number = number / baseNum;
    d10 = d10 * 10;
}
Console.WriteLine(result);

