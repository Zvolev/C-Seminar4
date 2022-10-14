/*Задача 2: Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе. Функция должна на вход принимать число, 
а выдавать сумму его цифр
452 -> 11
82 -> 10
9012 -> 12*/

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int SumOfDigits (int arg)
{
    int res = arg % 10;
    while (10 < arg)
    {
        arg = arg / 10;
        res = res + arg % 10;
    }
    return res;
}   
int num = Prompt("Введите число >- ");
int sum = SumOfDigits(num);
System.Console.WriteLine(sum);