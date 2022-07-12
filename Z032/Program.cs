//Задача 32: Напишите программу замена элементов
//массива: положительные элементы замените на
//соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]


// int[] array = new int[4];

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(-10, 10);
//     Console.Write(array[i] + " "); 
// }
// Console.WriteLine();
// for (int j = 0; j < array.Length; j++)
// {
//     array[j] = array[j] * -1;
//     Console.Write(array[j]+ " ");
// }


int[] array1 =  {-4, 3, -9, 2};

int[] Integer(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr[i] * -1;
        // arr[i] = -arr[i];
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i] + "]");
    }
}

int[] array2 = Integer(array1);
PrintArray(array2);

