//Задача 39: Напишите программу, которая перевернёт
//одномерный массив (последний элемент будет на первом
//месте, а первый - на последнем и т.д.)
//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]



// int[] array = new int[8];

// Arrya.Reverse(array);


int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];    //размер масива
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);   //задаем пределы массива

    }
    return arr;                      
}


void PrintArray(int[] arr)   //метод вывода масива
{
   for (int i = 0; i < arr.Length; i++) 
   {
      if(i == 0) Console.Write("[");                    
      if(i<arr.Length - 1) Console.Write(arr[i] + ",");
      else Console.Write(arr[i] + "]");

   }

}

// 0 1 2 3 4  - индекс
// [1 2 3 4 5] 
// [5 4 3 2 1]
void Reverse(int[] arr)
{
int size = arr.Length;
int index1 = 0;         //первое значение в элементе
int index2 = size - 1;  // последний знак

while (index1 < index2)
{

int temp = arr[index1];
arr[index1] = arr[index2];
arr[index2] =  temp;
index1++;
index2--;

}


}

int[] array = CreateArrayRndInt(5, 1, 9);
PrintArray(array);     //принт входной массив
Reverse(array);          // реверс
Console.WriteLine();
PrintArray(array);    //принт выходного массива
