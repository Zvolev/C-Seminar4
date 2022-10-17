/* Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0] */


int[] CreateRandomArray(int len) // создаем массив и наполняем его случайно 1 и 0 
{
    Random rand = new Random();
    int[] arr = new int[len];
    for (int i = 0; i < len; i++)
    {
        arr[i] = rand.Next(0, 2);
    }
    return arr;
}

void PrintArray(int[] array)
{
    for (int i = 0; i <= array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}
int[] array = CreateRandomArray(10);
PrintArray(array);

