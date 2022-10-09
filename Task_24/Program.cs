

// Напишите программму, которая принимает на вход число (А) и выдает сумму чисел от 1 до (А)

Console.Clear();


System.Console.WriteLine("Пожалуйста, введите число");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int num)
{
    int sum = default;  // default - исходное хначение (0)
    for (int i = 1; i <= num; i++)
    {
        sum = sum + i;
    }
    return sum;
}
int result = SumNumbers(number);
Console.WriteLine($"Сумма чисел от 1 до {number} равна {result}");
