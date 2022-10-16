/*Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120*/

int InputNamber(string mass) //запрос на ввод, ввод, и конвертация значения в "целое число"
{
    System.Console.WriteLine(mass);
    int num = Convert.ToInt32(Console.ReadLine()); //преобразование строк в целое число
    return num;
}

int FactorialNumber(int num)
{
    int factorial = 1;

    for (int i = 1; i <= num; i++)
    {
        factorial = factorial * i;
    }
    return factorial;
}
int num = InputNamber("введите число");
System.Console.WriteLine(FactorialNumber(num));