/*Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5*/

int InputNamber(string mass) //запрос на ввод, ввод, и конвертация значения в "целое число"
{
    System.Console.WriteLine(mass);
    int num = Convert.ToInt32(Console.ReadLine()); //преобразование строк в целое число
    return num;
}

int SumDidgit(int num)
{
    int count = 1;
    num = Math.Abs(num);

    for (int i = 2; num > 10; i++)
    {
        num = num / 10;
        count = i;
    }
    return count;
}
int num = InputNamber("введите число");
System.Console.WriteLine(SumDidgit(num));