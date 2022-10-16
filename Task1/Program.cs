/*Задача 1: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36*/
int InputNamber(string mass) //запрос на ввод, ввод, и конвертация значения в "целое число"
{
    System.Console.WriteLine(mass);
    string str = (Console.ReadLine() ?? "0");
    //int num = Convert.ToInt32(str); преобразование строк в целое число
    int num = int.Parse(str); // тоже преобразование строк в число
    return num;
}

bool ValidNam(int num) // проверка числа на соответствие параметрам, выводит true/false
{
    if (num < 1)
    {
        System.Console.WriteLine("Число меньше 1 - сумма не расчитается");
        return false;
    }
    return true;
}

int SumNumber(int num) // сумма чисел от 1 до num
{
    int sum = 0;
    for (int i = 0; i <= num; i++)
    {
        sum = sum + i;
    }
    return sum;
}

int number = InputNamber("Введите число -> ");
ValidNam(number);
int summa = SumNumber(number);
System.Console.WriteLine(summa);