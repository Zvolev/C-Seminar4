/*Задача 1: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B (и в нулевую степень). 
Использовать свои функции, не использовать Math.Pow
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int Ext(int arg1, int arg2)
{
    int res = 0;
    if (arg2 == 0)
    {
        res = 1;
    }
    else
        res = arg1;
        for (int i = 2; i <= arg2; i++)
        {
            res = res * arg1;
        }
    return res;
}

int A = Prompt(" введите число A >- ");
int B = Prompt(" введите число B >- ");
int C = Ext(A, B);
System.Console.WriteLine(C);