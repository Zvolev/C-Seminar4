/* Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0] */


int CreateRandomArray(int len) // создаем массив и наполняем его случайно 1 и 0 
{
    int[] arr = new int[len];
    Random rand = new Random();

    for (int i = 0; i <= arr.Length - 1; i++)
    {
        int r = rand.Next(0, 2);
        arr[i] = r;
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

PrintArray(CreateRandomArray(10));