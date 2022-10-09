
// // Напишите программу, которая принимает на взод число и выдает количество цифр в числе

Console.Clear();

System.Console.WriteLine("Пожалуйста, введите число");
int number = Convert.ToInt32(Console.ReadLine());

int DigitCount(int num)
{
    num = Math.Abs(num);  

    int arg2 = 0;
    int arg1 = 0;
    for (int i = 0; i < 10; i++)
    {
        arg2 = num % 10;
        num = num / 10;
        arg1 = arg1 + arg2;
    }
    return arg1;
}
int res = DigitCount(number);

if (number >= 0)
{
Console.WriteLine(res);
Console.WriteLine($"Сумма цифр числа {number} = {res}");
}
else Console.WriteLine("Пожалуйста введите положительное число");


// _________________________________________________________________________________
// ПОИСК ПЕРВОЙ ЦИФРЫ ЧИСЛА

// int FirstNumber(int num)
// {
//     int count = 0;
//     int first = 0;
//     while (num > 0)
//     {
//         first = num;
//         num = num / 10;
//         count++;
//     }
//     return first;
// }
