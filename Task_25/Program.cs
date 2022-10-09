//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


Console.Clear();

Console.WriteLine("Пожалуйста, введите число, которое будем возводить в степень: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Пожалуйста, введите число в которое будем возводить");
int b = Convert.ToInt32(Console.ReadLine());


int DiggeeDigital(int arg1, int arg2) // описываем метод поиска факториала
{
    int diggee = 1;
    for (int i = 0; i < arg2; i++)
    {
        diggee = diggee * arg1;
    }
    return diggee;
}

if (b > 0) Console.WriteLine(DiggeeDigital(a, b));
else Console.WriteLine("Введите корректное число");
  