
/*Задача 3: Напишите программу, которая задаёт массив 
из 8 (* из указанного размера массива) случайных элементов 
и выводит их на экран.
8 >- 1, 2, 5, 7, 19, 6, 7, 8 */

int InputArraySize(string message) // запрос, ввод  и проверка размера массива 
{
    Console.Write(message);
    int length = Convert.ToInt32(Console.ReadLine());
    if (length <= 0)
        Console.Write("Недопустимый размер массива");
    else
        Console.WriteLine();
    return length;
}


int Prompt(string message) // запрос и ввод значений
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}


void CreateRandomArray(int argLength, int argMin, int argMax) // создаем массив и наполняем его случайными значениями по заданным параметрам и выводим на экран
{  
    int[] array = new int[argLength];

    Random rand = new Random();
    for (int i = 0; i < argLength; i++)
    {
        array[i] = rand.Next(argMin, argMax);     
        Console.Write($"{array[i]}, ");
    }
}



int len = InputArraySize("Укажите размер массива >- ");
int min = Prompt("Укажите диапазон значений массива: от >- ");
int max = Prompt("до (включительно) >- ");
CreateRandomArray(len, min, max-1);
