// Напишите программу, которая принимает на взод число и выдает произведение чисел от 1 до N (факториал)

Console.Clear();

System.Console.WriteLine("Пожалуйста, введите число");
System.Console.WriteLine();
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    int result = Factorial2(number);
    System.Console.WriteLine($"Произведение чисел от 1 до {number} равно {result}");
}
else Console.WriteLine("Введите корректное число");


int Factorial2(int num2) // описываем метод поиска факториала
{
    int multiplic = 1;
    for (int i = 1; i <= num2; i++)
    {
        multiplic = multiplic * i;
    }
    return multiplic;
}

System.Console.WriteLine();
System.Console.WriteLine();


//_____________________________________________________________________________________________________


double Factorial(int num) // описываем метод поиска факториала
{

    if (num == 1) return 1;               // если n(число от которого ищем факториал) равен 1, то пишем на выходе 1
    else return num * Factorial(num - 1); // иначе делаем рекурсию метода, 
                                          // т.е. число n(число от которого ищем факториал) умножаем на (n-1) и повторяем
                                          // пока n == 1 (как указанно в первом условии if)
}

System.Console.WriteLine($"Произведение чисел от 1 до {number} равно {Factorial(number)}");  // выводим метод поиска факториала (5) на экран
System.Console.WriteLine();

for (int i = 1; i <= number; i++) // прописываем дополнительное условие задачи по поиску факториала (number) истользуя метод,
                                  // который описывали ранее начиная с (1). Данное действие делаем через цикл, чтобы перебирали каждое число
{
    Console.WriteLine($"{i}! = {Factorial(i)}"); // выводим каждое значение проходящее через цикл на экран
}

