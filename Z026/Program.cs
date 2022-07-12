// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());


int i = 0;
while (num > 0)
{

    i++;
    num/=10;

}

Console.WriteLine($"Количество цифр в числе {i}");


/*  num = Math.Abs(num);      //Этот метод возвращает абсолютное значение числа, то есть иными словами - если число неотрицательное, 
                            //то его и возвращает, а если отрицательное - отбрасывает знак "минус"
int Count(int number)
{
    int result = 0;
    {
        while (number > 0)
        {
            number = number / 10;
            result++;
        }
    }
    return result;
}
int countNum = Count(num);
Console.WriteLine($"Количество цифр в числе {num} = {countNum}");  */