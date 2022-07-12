// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120


Console.WriteLine("ВВедите число N:   ");
int num = int.Parse(Console.ReadLine());


int Sum (int number)
{
    int sum = 1;                                                  //начинается с 1, типа 1 * 2 * 3 * 4 
    for (int i = 1; i <= number; i++)
    {
        sum = sum * i;                                           //счетчик возведение в степень 
    }
    return sum;
}

int result = Sum(num);                                           //присваиваем переменную для вывода результата функции   вызов функции Sum 
Console.WriteLine($"Сумма чисел от 1 до {num}: {result}");

