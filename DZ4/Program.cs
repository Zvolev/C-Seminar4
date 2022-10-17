/*Задача *: Напишите программу, которая из массива случайных чисел. 
Ищет второй максимум (число меньше максимального элемента, но больше всех остальных). 
Постарайтесь сделать одним циклом
[1, 3, 5, 6, 6, 4] -> 5*/

Console.Clear();

int InputArraySize(string message) // запрос, ввод  и проверка размера массива 
{
    Start:
    Console.Write(message);
    int length = Convert.ToInt32(Console.ReadLine());
    if (length <= 1)
    {
        Console.Write("Недопустимый размер массива ");
        goto Start;
    }
    return length;
}


int Prompt(string message) // запрос и ввод значений
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}


int[] CreateRandomArray(int argLength, int argMin, int argMax) // создаем массив и наполняем его случайными значениями по заданным параметрам и выводим на экран
{
    int[] array = new int[argLength];

    Random rand = new Random();
    for (int i = 0; i < argLength; i++)
    {
        array[i] = rand.Next(argMin, argMax);
        Console.Write($"{array[i]}, ");
        //System.Console.WriteLine();
    }
    return array;
}

int SecondMax(int[] arg)  //Ищем второй максимум (число меньше максимального элемента, но больше всех остальных).
{
    int length = arg.Length;
    int max = arg[0];
    int max2 = 0;
    for (int i = 0; i < length; i++)
    {
        if (arg[i] >= max)
        {
            max = arg[i];
        }
    }
    for (int i = 0; i < length; i++)
    {
        if (arg[i] > max2 && arg[i] < max)
        {
            max2 = arg[i];
        }
    }
    System.Console.WriteLine($" max -> {max}     max2 -> {max2}");  // контроль работы метода
    return max2;
}

int len = InputArraySize("Укажите размер массива -> ");
int min = Prompt("Укажите диапазон значений массива: от -> ");
int max = Prompt("до (включительно) -> ");

int[] array = CreateRandomArray(len, min, max - 1);
Console.WriteLine();
Console.WriteLine($"Второе максимальное число в массиве -> {SecondMax(array)}");