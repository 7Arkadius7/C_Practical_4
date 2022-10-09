// // Напишите программу, которая задает массив из 8 элементов и выводит их на экран
Console.Clear();

System.Console.WriteLine("Пожалуйста, введите восемь чисел для заполнения массива: ");
System.Console.WriteLine();
System.Console.WriteLine("Первое число: ");
int i0 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Второе число: ");
int i1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Третье число: ");
int i2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Четвертое число: ");
int i3 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Пятое число: ");
int i4 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Шестое число: ");
int i5 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Седьмое число: ");
int i6 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Восьмое число: ");
int i7 = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[8];

arr[0] = i0;
arr[1] = i1;
arr[2] = i2;
arr[3] = i3;
arr[4] = i4;
arr[5] = i5;
arr[6] = i6;
arr[7] = i7;

 void PrintArray(int[] ar)
{
    int count = ar.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write ($"{ar[position]} ");
        position++;
    }
}

PrintArray(arr);