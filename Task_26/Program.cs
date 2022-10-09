// Напишите программу, которая принимает на взод число и выдает количество цифр в числе

Console.Clear();

System.Console.WriteLine("Пожалуйста, введите число");
int number = Convert.ToInt32(Console.ReadLine());

int DigitCount(int num)
{
    num = Math.Abs(num);  //сделали модуль числа (num)
    int count = 0;
    while (num > 0)
    {
        num = num / 10;
        count++;
    }
    return count;
}
int res = DigitCount(number);

Console.WriteLine($"Количество цифр числа {number} = {res}");
